using Pracownicy.Models;
using Pracownicy.Presenters;
using Pracownicy.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracownicy
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IPracownikView view = new Form1();
            IPracownikRepository repository = new PracownikRepository();
            new PracownikPresenter(view, repository);
            Application.Run((Form)view);
        }
    }
}
