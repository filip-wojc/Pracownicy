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
            using (FolderBrowserDialog fd = new FolderBrowserDialog())
            {
                DialogResult dialogResult = fd.ShowDialog();
                if(dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));
                    DateTime now = DateTime.Now;
                    int currYear = now.Year;
                    int currMonth = now.Month;
                    int currDay = now.Day;
                    int currHour = now.Hour;
                    int currMinute = now.Minute;
                    int currSecond = now.Second;

                    string path = Path.Combine(fd.SelectedPath, 
                        $"pracownicy_{currYear}_{currMonth}_{currDay}__{currHour}_{currMinute}_{currSecond}.xml");
                    
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        serializer.Serialize(writer, pracownicy);
                    }
                    MessageBox.Show("Serializowanie powiodło się!");
                }
                
            }
               
        }

        private void Load_btn_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "XML files (*.xml)|*.xml";
                fd.FilterIndex = 1;
                fd.RestoreDirectory = true;

                DialogResult dialogResult = fd.ShowDialog();
                if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(fd.FileName))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));
                   

                    using (FileStream fs = new FileStream(fd.FileName, FileMode.Open))
                    {
                        
                        pracownicy = (List<Pracownik>)serializer.Deserialize(fs);
                        dataGridView1.Rows.Clear();

                        foreach (var pracownik in pracownicy)
                        {
                            dataGridView1.Rows.Add(pracownik.Name, pracownik.Surname, pracownik.DateOfBirth, pracownik.Salary, pracownik.Job, pracownik.Agreement);
                        }
                    }
                    MessageBox.Show("Deserializacja powiodła się!");
                }

            }
        }

        private void InitializeRowToForm(object sender, DataGridViewCellEventArgs e)
        {
           
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if(!row.IsNewRow)
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
