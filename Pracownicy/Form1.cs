using Pracownicy.LoadingFiles;
using Pracownicy.SavingFIles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Pracownicy
{

    public partial class Form1 : Form
    {
        private string[] jobsList;
        private List<Pracownik> pracownicy;
        
        public Form1()
        {
            jobsList = new string[] { "Tester", "Inżynier", "Projektant", "Młodszy programista", "Starszy programista" };
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
            if (!jobsList.Contains(cb.Text))
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

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            SaveState saveState = new SaveState();

            using (SaveFileDialog fd = new SaveFileDialog())
            {
                DialogResult dialogResult = fd.ShowDialog();
                fd.Filter = "Pliki tekstowe (*.txt)|*.txt|Pliki XML (*.xml)|*.xml";
                fd.FilterIndex = 1;
                fd.RestoreDirectory = true;
                if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(fd.FileName))
                {
                    if (fd.FileName.EndsWith("txt"))
                    {
                        saveState.SaveEmployeesToTxtFile(pracownicy, fd.FileName);
                    }
                    else if (fd.FileName.EndsWith("xml"))
                    {
                        saveState.SaveEmployeesToXMLFile(pracownicy, fd.FileName);
                    }
                    else
                    {
                        MessageBox.Show("Dozwolone formaty to txt i xml!");
                        return;
                    }
                    
                }
            

            }
               
        }

        private void Load_btn_Click(object sender, EventArgs e)
        {
            LoadState loadState = new LoadState();

            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Pliki tekstowe (*.txt)|*.txt|Pliki XML (*.xml)|*.xml";
                fd.FilterIndex = 1;
                fd.RestoreDirectory = true;

                DialogResult dialogResult = fd.ShowDialog();
                if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(fd.FileName))
                {
                    if (fd.FileName.EndsWith("txt"))
                    {
                        pracownicy = loadState.LoadEmployeesFromTxtFile(fd.FileName);
                    }
                    else if(fd.FileName.EndsWith("xml"))
                    {
                        pracownicy = loadState.LoadEmployeesFromXMLFile(fd.FileName);
                    }
                  
                    dataGridView1.Rows.Clear();

                    foreach (var pracownik in pracownicy)
                    {
                        dataGridView1.Rows.Add(pracownik.Name, pracownik.Surname, pracownik.DateOfBirth, pracownik.Salary, pracownik.Job, pracownik.Agreement);
                    }
                }
            
            }

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
