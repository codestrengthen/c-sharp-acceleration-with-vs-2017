using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionExamples
{
    class GenericCollections
    {
        private Dictionary<string, string> AussieStates { get; set; }

        public void InstantiateCollections()
        {
            AussieStates = new Dictionary<string, string>()
            {
                { "NSW", "New South Wales" },
                { "NT", "Northern Territory" },
                { "QLD", "Queensland" },
                { "SA", "SouthAustralia" },
                { "TAS", "Tasmania" },
                { "VIC", "Victoria" }
            };
        }
    }
}
