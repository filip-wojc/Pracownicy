using Pracownicy.LoadingFiles;
using Pracownicy.SavingFIles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy.Models
{
    public class PracownikRepository : IPracownikRepository
    {
        private List<Pracownik> pracownicy;
     
        public PracownikRepository() 
        {
            pracownicy = new List<Pracownik>();
        }
        public void Add(Pracownik pracownik)
        {
            pracownicy.Add(pracownik);
        }

        

        public IEnumerable<Pracownik> GetAll()
        {
            var pracownicyList = new List<Pracownik>();
            foreach (var pracownik in pracownicy)
            {
                pracownicyList.Add(pracownik);
            }
            return pracownicyList;
        }

        
    }
}
