using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeExample
{
    public class StoredParameters
    {
        public StoredParameters ()
        {
            // set default values here, if wanted
            SetDefaults();
        }

        public void SetDefaults()
        {
            OutputString = "Hello World";
            OutputLocation = tOutputLocation.Screen;
        }

        public string OutputString { get; set; }
        public tOutputLocation OutputLocation { get; set; }
    }
}
