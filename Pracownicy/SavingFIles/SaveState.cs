using Pracownicy.SavingFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pracownicy.SavingFIles
{
    public class SaveState : ISaveToTxtFile, ISavetoXMLFile
    {
        public void SaveEmployeesToTxtFile(IEnumerable<Pracownik> pracownicy, string path)
        {
            DateTime now = DateTime.Now;
            int currYear = now.Year;
            int currMonth = now.Month;
            int currDay = now.Day;
            int currHour = now.Hour;
            int currMinute = now.Minute;
            int currSecond = now.Second;

            string FullPath = Path.Combine(path,
                        $"pracownicy_{currYear}_{currMonth}_{currDay}__{currHour}_{currMinute}_{currSecond}.txt");

            using (StreamWriter writer = new StreamWriter(FullPath))
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
            DateTime now = DateTime.Now;
            int currYear = now.Year;
            int currMonth = now.Month;
            int currDay = now.Day;
            int currHour = now.Hour;
            int currMinute = now.Minute;
            int currSecond = now.Second;

            string FullPath = Path.Combine(path,
                        $"pracownicy_{currYear}_{currMonth}_{currDay}__{currHour}_{currMinute}_{currSecond}.xml");

            using (StreamWriter writer = new StreamWriter(FullPath))
            {
                serializer.Serialize(writer, pracownicy);
            }
        }
    }
}
