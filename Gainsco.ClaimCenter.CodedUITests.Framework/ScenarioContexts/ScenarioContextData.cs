using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gainsco.Connect.Web.UI.SmokeTests.Framework.ScenarioContexts
{
    public class ScenarioContextData
    {
        private static TexasNewQuotePageScenarioData _texasNewQuotePageScenarioData = null;

        public static TexasNewQuotePageScenarioData TexasNewQuotePageScenarioData
        {
            get
            {
                if (_texasNewQuotePageScenarioData == null)
                {
                    _texasNewQuotePageScenarioData = new TexasNewQuotePageScenarioData();
                }
                return _texasNewQuotePageScenarioData;
            }
            set
            {
                _texasNewQuotePageScenarioData = value;
            }
        }
    }
}
