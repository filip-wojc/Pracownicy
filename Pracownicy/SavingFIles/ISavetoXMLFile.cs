using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy.SavingFiles
{
    internal interface ISavetoXMLFile
    {
        void SaveEmployeesToXMLFile(IEnumerable<Pracownik> pracownicy, string path);
    }
}

