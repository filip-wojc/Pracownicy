using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy.SavingFiles
{
    internal interface ISaveToTxtFile
    {
        void SaveEmployeesToTxtFile(IEnumerable<Pracownik> pracownicy, string path);
    }
}
