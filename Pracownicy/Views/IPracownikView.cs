using Pracownicy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracownicy.Views
{
    public interface IPracownikView
    {
        string Name { get; set; }
        string Surname { get; set; }
        string DateOfBirth { get; set; }
        int Salary { get; set; }
        string Job { get; set; }
        string Agreement { get;}

        event EventHandler AddNewPracownikEvent;
        event EventHandler SerializePracownikRepository;
        event EventHandler DeserializePracownikRepository;

        bool setEmptyErrorTextBox();
        bool setEmptyErrorComboBox();
        bool setEmptyErrorRadioButton();


        void DataGridUpdate(Pracownik p);

    }
}
