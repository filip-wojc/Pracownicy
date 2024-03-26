using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pracownicy
{

    public partial class Form1 : Form
    {
        private string[] agreementType;
        private List<Pracownik> pracownicy;
        
        public Form1()
        {
            agreementType = new string[] { "Tester", "Inżynier", "Projektant", "Młodszy programista", "Starszy programista" };
            pracownicy = new List<Pracownik>();


            InitializeComponent();
            
          
        }
        private bool setEmptyErrorTextBox(TextBox tb)
        {
            if (tb.Text == "")
            {
                errorProvider1.SetError(tb, "Puste pole");
                return false;
            }
            else if (tb.Text.Any(Char.IsDigit))
            {
                errorProvider1.SetError(tb, "Błędna wartość");
                return false;
            }
            else
            {
                errorProvider1.SetError(tb, "");
                return true;
            }
        }

        private bool setEmptyErrorComboBox(ComboBox cb)
        {
            if (!agreementType.Contains(cb.Text))
            {
                errorProvider1.SetError(cb, "Puste pole");
                return false;
            }
            else
            {
                errorProvider1.SetError(cb, "");
                return true;
            }
        }

        private bool setEmptyErrorRadioButton(RadioButton[] rb)
        {
            if (rb[0].Checked || rb[1].Checked || rb[2].Checked)
            {
                errorProvider1.SetError(rb[1], "");
                return true;
            }
            else
            {
                errorProvider1.SetError(rb[1], "Nic nie zostało wybrane");
                return false;
            }

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {

            RadioButton[] rb_list = { AgreementBtn1, AgreementBtn2, AgreementBtn3 };
            if (setEmptyErrorTextBox(nameBox) && setEmptyErrorTextBox(SurnameBox)
                && setEmptyErrorComboBox(JobBox) && setEmptyErrorRadioButton(rb_list))
            {
                var checkedRadioButton = rb_list.Where(x => x.Checked).ToList()[0];
                var pracownik = new Pracownik(nameBox.Text, SurnameBox.Text, DatePickerBox.Value.ToShortDateString(), Convert.ToInt32(SalaryBox.Value), JobBox.Text, checkedRadioButton.Text);
                pracownicy.Add(pracownik);
                dataGridView1.Rows.Add(pracownik.Name, pracownik.Surname, pracownik.DateOfBirth, pracownik.Salary, pracownik.Job, pracownik.Agreement);


                nameBox.Text = "";
                SurnameBox.Text = "";
                DatePickerBox.Text = DateTime.Now.ToString();
                SalaryBox.Value = 0;
                JobBox.Text = "";
                checkedRadioButton.Checked = false;
            }
        }
    }
}
