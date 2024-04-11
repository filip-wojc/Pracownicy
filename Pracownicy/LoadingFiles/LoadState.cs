using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Pracownicy.Models;

namespace Pracownicy.LoadingFiles
{
    public class LoadState : ILoadFromTxtFile, ILoadFromXMLFile
    {
        public List<Pracownik> LoadEmployeesFromTxtFile(string path)
        {
            List<Pracownik> lista = new List<Pracownik>();

            using (StreamReader reader = new StreamReader(path))
            {
                reader.ReadLine();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var arg = line.Split(',');
                    lista.Add(new Pracownik(arg[0], arg[1], arg[2], Convert.ToInt32(arg[3]), arg[4], arg[5]));
                }
                return lista;
            }
            
        }

        public List<Pracownik> LoadEmployeesFromXMLFile(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                return (List<Pracownik>)serializer.Deserialize(fs);
            }
        }

      
    }
}
