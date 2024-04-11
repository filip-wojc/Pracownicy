using Pracownicy.LoadingFiles;
using Pracownicy.Models;
using Pracownicy.SavingFIles;
using Pracownicy.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Pracownicy.Views
{

    public partial class Form1 : Form, IPracownikView
    {
        private string[] jobsList;
        
        
        public Form1()
        {
            
            jobsList = new string[] { "Tester", "Inżynier", "Projektant", "Młodszy programista", "Starszy programista" };
            InitializeComponent();
            _associateAndRaiseViewEvents();
            nameBox.Text = "";

        }
        public bool setEmptyErrorTextBox()
        {
            var textBoxes = new[] { nameBox, SurnameBox };
            foreach (TextBox tb in textBoxes)
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
                }

            }
          
            return true;
        }

        public bool setEmptyErrorComboBox()
        {
            if (!jobsList.Contains(JobBox.Text))
            {
                errorProvider1.SetError(JobBox, "Puste pole");
                return false;
            }
            else
            {
                errorProvider1.SetError(JobBox, "");
                return true;
            }
        }

        public bool setEmptyErrorRadioButton()
        {
            var rb = new RadioButton[] {AgreementBtn1, AgreementBtn2, AgreementBtn3};
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
        private void _associateAndRaiseViewEvents()
        {
            Add_btn.Click += (sender, e) =>
            {
                AddNewPracownikEvent?.Invoke(this, EventArgs.Empty);
            };

            Save_Btn.Click += (sender, e) =>
            {
                SerializePracownikRepository?.Invoke(this, EventArgs.Empty);
            };

            Load_btn.Click += (sender, e) =>
            {
                dataGridView1.Rows.Clear();
                DeserializePracownikRepository.Invoke(this, EventArgs.Empty);  
            };
        }

        public string Name { get => nameBox.Text; set => nameBox.Text = value; }
        public string Surname { get => SurnameBox.Text; set => SurnameBox.Text = value; }
        public string DateOfBirth { get => DatePickerBox.Text; set => DatePickerBox.Text = value; }
        public int Salary { get => Convert.ToInt32(SalaryBox.Value); set => SalaryBox.Value = value; }
        public string Job { get => JobBox.Text; set => JobBox.Text = value; }
        public string Agreement 
        {
            get
            {
                if (AgreementBtn1.Checked) { return AgreementBtn1.Text; }
                if (AgreementBtn2.Checked) { return AgreementBtn2.Text; }
                if (AgreementBtn3.Checked) { return AgreementBtn3.Text; }
                return "";
            }
           
        }

        public event EventHandler AddNewPracownikEvent;
        public event EventHandler SerializePracownikRepository;
        public event EventHandler DeserializePracownikRepository;

        public void DataGridUpdate(Pracownik p)
        {   
            
            dataGridView1.Rows.Add(p.Name, p.Surname, p.DateOfBirth, p.Salary, p.Job, p.Agreement);
  
            AgreementBtn1.Checked = false;
            AgreementBtn2.Checked = false;
            AgreementBtn3.Checked = false;
        }
        private void InitializeRowToForm(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (!row.IsNewRow)
                {
                    nameBox.Text = row.Cells[0].Value.ToString();
                    SurnameBox.Text = row.Cells[1].Value.ToString();
                    DatePickerBox.Text = row.Cells[2].Value.ToString();
                    SalaryBox.Value = Convert.ToInt32(row.Cells[3].Value);
                    JobBox.Text = row.Cells[4].Value.ToString();

                    string agreementTypeInTable = row.Cells[5].Value.ToString();
                    if (AgreementBtn1.Text.Equals(agreementTypeInTable)) { AgreementBtn1.Checked = true; }
                    else if (AgreementBtn2.Text.Equals(agreementTypeInTable)) { AgreementBtn2.Checked = true; }
                    else if (AgreementBtn3.Text.Equals(agreementTypeInTable)) { AgreementBtn3.Checked = true; }
                }
            }
            
        }

    }
}
