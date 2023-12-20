using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Gainsco.ClaimCenter.CodedUITests.ScenarioContexts
{
    public abstract class ClaimCenterScenarioDataBase
    {
        private ScenarioContext _scenarioContext;
        public ScenarioContext ScenarioContext
        {
            get
            {
                return _scenarioContext;
            }
            set
            {
                _scenarioContext = value;
            }
        }

    }
}
