using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleCodeExample
{
    static class XMLFileManagement
    {
        static public void SaveFile(string FileName, Object SerializeObject)
        {
            XmlSerializer serialPlay = new XmlSerializer(SerializeObject.GetType());
            System.IO.StreamWriter objectfile = new System.IO.StreamWriter(FileName, false);  // do not append
            serialPlay.Serialize(objectfile, SerializeObject);
            objectfile.Close();

        }

        static public dynamic LoadFile(Type FileType, string FileName)
        {
            if (!File.Exists(FileName))
            {
                return null;
            }
            XmlSerializer serialPlay = new XmlSerializer(FileType);
            System.IO.StreamReader objectfile = new System.IO.StreamReader(FileName);
            Object localfile = serialPlay.Deserialize(objectfile);
            objectfile.Close();
            return Convert.ChangeType(localfile, FileType);
        }
    }
}
