using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gainsco.ClaimCenter.CodedUITests.ScenarioContexts
{
    public partial class ScenarioContextData
    {
        private static ClaimCenterHomePageScenarioData _claimCenterHomePageScenarioData = null;

        public static ClaimCenterHomePageScenarioData ClaimCenterHomePageScenarioData
        {
            get
            {
                if (_claimCenterHomePageScenarioData == null)
                {
                    _claimCenterHomePageScenarioData = new ClaimCenterHomePageScenarioData();
                }
                return _claimCenterHomePageScenarioData;
            }
            set
            {
                _claimCenterHomePageScenarioData = value;
            }
        }

    }
}
