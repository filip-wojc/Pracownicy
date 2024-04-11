using Pracownicy.SavingFIles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy.Models
{
    public interface IPracownikRepository
    {
        void Add(Pracownik pracownik);
        
        IEnumerable<Pracownik> GetAll();

    }
}
