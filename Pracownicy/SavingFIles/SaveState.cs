using Pracownicy.SavingFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Pracownicy.Models;

namespace Pracownicy.SavingFIles
{
    public class SaveState : ISaveToTxtFile, ISavetoXMLFile
    {
        public void SaveEmployeesToTxtFile(IEnumerable<Pracownik> pracownicy, string path)
        {

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Imię | Nazwisko | Data Urodzenia | Pensja | Stanowisko | Rodzaj Umowy");
                foreach(var p in pracownicy)
                {
                    writer.WriteLine($"{p.Name},{p.Surname},{p.DateOfBirth},{p.Salary},{p.Job},{p.Agreement}");
                }
            }

        }

        public void SaveEmployeesToXMLFile(IEnumerable<Pracownik> pracownicy, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));
      

            using (StreamWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, pracownicy);
            }
        }
    }
}
