using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pracownicy.Models;

namespace Pracownicy.LoadingFiles
{
    internal interface ILoadFromTxtFile
    {
        List<Pracownik> LoadEmployeesFromTxtFile(string path);
    }
}

