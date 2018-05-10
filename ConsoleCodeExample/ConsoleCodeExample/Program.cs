using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string SettingFileName = @".\ConsoleSettings.xml";
            StoredParameters Settings = XMLFileManagement.LoadFile(typeof(StoredParameters), SettingFileName);
            if (Settings == null)
            {
                Settings = new StoredParameters();
            }

            Output.Write(Settings.OutputString,Settings.OutputLocation);

            XMLFileManagement.SaveFile(SettingFileName, Settings);
        }
    }

}
