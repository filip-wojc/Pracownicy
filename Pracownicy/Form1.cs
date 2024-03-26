using System;
using System.Windows.Forms;

namespace Pracownicy
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
          
        }
        private bool setEmptyErrorTextBox(TextBox tb)
        {
            if (tb.Text == "")
            {
                errorProvider1.SetError(tb, "Puste pole");
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
            if (cb.Text == "")
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
            int i = 0;
            foreach (RadioButton r in rb) 
            {
                if (r.Checked) 
                {
                    errorProvider1.SetError(r, "");
                    i++;
                    return true;
                }
            }
            errorProvider1.SetError(rb[i], "Nic nie zostalo wybrane");
            return false;

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            RadioButton[] rb_list = { AgreementBtn1, AgreementBtn2, AgreementBtn3 };
            if (setEmptyErrorTextBox(nameBox) && setEmptyErrorTextBox(SurnameBox)
                && setEmptyErrorComboBox(JobBox) && setEmptyErrorRadioButton(rb_list))
            {
                // to do
            }
        }
    }
}
