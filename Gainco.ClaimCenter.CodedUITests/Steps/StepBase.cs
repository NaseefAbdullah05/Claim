using Gainsco.ClaimCenter.CodedUITests.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using TechTalk.SpecFlow;
using Gainsco.CodedUITests.Domain;
using Gainsco.CodedUITests.Repositories;
using Gainsco.CodedUITests.Common.Logging;
using Gainsco.CodedUITests.Common.EnumType;

namespace Gainsco.ClaimCenter.CodedUITests.Steps
{
    public class StepBase
    {
        protected ISerilogLogger _serilogLogger;
        protected string CommaDelimitedScenariosToLog = ConfigurationManager.AppSettings["CommaDelimitedScenariosToLog"].ToString();
        protected string ScenarioExecutionLevel = ConfigurationManager.AppSettings["ScenarioExecutionLevel"].ToString();
        private List<string> _scenariosToLog = new List<string>();
        protected ScenarioTest currentFailedScenarioTest = null;
        protected Exception _scenarioStepException = null;
        protected bool _skipThisTest = false;
        
        protected bool SkipThisTest
        {
            get
            {
                return _skipThisTest;
            }
            set
            {
                _skipThisTest = value;
            }
        }

        protected List<string> ScenariosToLog
        {
            get
            {
                if (!String.IsNullOrEmpty(CommaDelimitedScenariosToLog))
                {
                    _scenariosToLog = CommaDelimitedScenariosToLog.Split(',').ToList();
                }

                return _scenariosToLog;
            }
        }

        protected bool CanLogThisScenario(string scenarioTitle)
        {
            if (CommaDelimitedScenariosToLog.Count() == 0)
            {
                return true;
            }
            else if (CommaDelimitedScenariosToLog.Contains(scenarioTitle))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void SaveScenarioTestInformationToBeRetriedLater(ScenarioContext scenarioContext)
        {
            ScenarioTestRepository scenarioTestRepository = new ScenarioTestRepository(new SmokeTestsContext());
            EnvironmentType environmentType = ConfigurationData.ScenarioTestEnvironment.GetEnvironmentType();
            List<ScenarioTest> scenarioTestList = scenarioTestRepository.GetScenarioTestList((short)environmentType, (short)ScenarioTestStatusType.Failed, (int)ProjectEnumType.ClaimCenter);

            //to take into account tests that are being retried but might fail again
            scenarioTestList.AddRange(scenarioTestRepository.GetScenarioTestList((short)environmentType, (short)ScenarioTestStatusType.Retrying, (int)ProjectEnumType.ClaimCenter));

            ScenarioTest scenarioTest = null;

            foreach (ScenarioTest scenarioTestObject in scenarioTestList)
            {
                if (scenarioTestObject.ScenarioName == scenarioContext.ScenarioInfo.Title)
                {
                    scenarioTest = scenarioTestObject;
                }
            }

            if (scenarioTest == null)
            {
                scenarioTest = new ScenarioTest();
                scenarioTest.EnvironmentId = (short)environmentType;
                scenarioTest.RetryCount = 0;
                scenarioTest.ScenarioName = scenarioContext.ScenarioInfo.Title;
                scenarioTest.ScenarioTestStatusId = (short)ScenarioTestStatusType.Failed;
                scenarioTest.ProjectId = (int)ProjectEnumType.ClaimCenter;
            }
            else
            {
                scenarioTest.RetryCount++;
                scenarioTest.ScenarioTestStatusId = (short)ScenarioTestStatusType.Failed;
            }

            scenarioTestRepository.SaveScenarioTest(scenarioTest);
        }

        protected void RetryOnlyScenarioTestsThatHaveFailed(ScenarioContext scenarioContext)
        {
            List<ScenarioTest> scenarioTestList = new List<ScenarioTest>();

            ScenarioTestRepository scenarioTestRepository = new ScenarioTestRepository(new SmokeTestsContext());
            EnvironmentType environmentType = ConfigurationData.ScenarioTestEnvironment.GetEnvironmentType();
            scenarioTestList = scenarioTestRepository.GetScenarioTestList((short)environmentType, (short)ScenarioTestStatusType.Failed, (int)ProjectEnumType.ClaimCenter);
            scenarioTestList.AddRange(scenarioTestRepository.GetScenarioTestList((short)environmentType, (short)ScenarioTestStatusType.Retrying, (int)ProjectEnumType.ClaimCenter));
            bool hasThisScenarioFailedInEnvironment = false;

            foreach (ScenarioTest scenarioTest in scenarioTestList)
            {
                if (scenarioTest.ScenarioName == scenarioContext.ScenarioInfo.Title)
                {
                    if (scenarioTest.ScenarioTestStatusId == (short)ScenarioTestStatusType.Failed
                        || scenarioTest.ScenarioTestStatusId == (short)ScenarioTestStatusType.Retrying)
                    {
                        hasThisScenarioFailedInEnvironment = true;
                        currentFailedScenarioTest = scenarioTest;
                    }
                }
            }

            //if the test is not failed in the database
            if (!hasThisScenarioFailedInEnvironment)
            {
                //the the configuration is trying to retry failed scenarios, do not run this test again as it should have run the first time
                if (ConfigurationData.IsRetryingOnlyFailedScenarioTestsInEnvironment)
                {
                    SkipThisTest = true;
                    Assert.Ignore();
                }
            }
            else
            {
                //if the test is failed, we want to retry, so we only set the currentFailedScenatioTest logic which should happen on the 2nd time or after
                if (ConfigurationData.IsRetryingOnlyFailedScenarioTestsInEnvironment)
                {
                    currentFailedScenarioTest.ScenarioTestStatusId = (short)ScenarioTestStatusType.Retrying;
                    scenarioTestRepository.SaveScenarioTest(currentFailedScenarioTest);
                }
                else
                {
                    SkipThisTest = true;
                    //if the test is failed, and the retry logic is not trying to fire, ignore this test
                    Assert.Ignore();
                }
            }
        }

        protected void SavePassedTestScenarioThatWasRetried(ScenarioContext scenarioContext)
        {
            ScenarioTestRepository scenarioTestRepository = new ScenarioTestRepository(new SmokeTestsContext());
            EnvironmentType environmentType = ConfigurationData.ScenarioTestEnvironment.GetEnvironmentType();

            if (ConfigurationData.IsRetryingOnlyFailedScenarioTestsInEnvironment)
            {
                if (currentFailedScenarioTest != null && _scenarioStepException == null)
                {
                    currentFailedScenarioTest.ScenarioTestStatusId = (short)ScenarioTestStatusType.Passed;
                    currentFailedScenarioTest.RetryCount++;

                    scenarioTestRepository.SaveScenarioTest(currentFailedScenarioTest);
                }
            }

            currentFailedScenarioTest = null;
            _scenarioStepException = null;
        }

        protected void ThrowException(Exception ex)
        {
            _scenarioStepException = ex;
            throw ex;
        }

        protected void HandleStepException(ScenarioContext _scenarioContext, Exception ex)
        {
            if (CanLogThisScenario(_scenarioContext.ScenarioInfo.Title))
            {
                Gainsco.CodedUITests.Common.Logging.LogEntry logEntry = new Gainsco.CodedUITests.Common.Logging.LogEntry();
                logEntry.Exception = ex;
                logEntry.Message = string.Format("Scenario:{0} Method Name:{1} Exception Message:{2}", _scenarioContext.ScenarioInfo.Title, _serilogLogger.GetExecutingMethodName(ex), ex.Message);

                _serilogLogger.Log(logEntry);
            }
            SaveScenarioTestInformationToBeRetriedLater(_scenarioContext);
            ThrowException(ex);
        }


    }
}
