namespace Pracownicy.Views
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.DatePickerBox = new System.Windows.Forms.DateTimePicker();
            this.SalaryBox = new System.Windows.Forms.NumericUpDown();
            this.JobBox = new System.Windows.Forms.ComboBox();
            this.AgreementBtn1 = new System.Windows.Forms.RadioButton();
            this.AgreementBtn2 = new System.Windows.Forms.RadioButton();
            this.AgreementBtn3 = new System.Windows.Forms.RadioButton();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Load_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgreementColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Imię";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nazwisko";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Data urodzenia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Pensja";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(90, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Stanowisko";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(90, 372);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Rodzaj umowy";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(62, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Dane pracownika";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(251, 83);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(285, 26);
            this.nameBox.TabIndex = 7;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(251, 143);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(285, 26);
            this.SurnameBox.TabIndex = 8;
            // 
            // DatePickerBox
            // 
            this.DatePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerBox.Location = new System.Drawing.Point(251, 194);
            this.DatePickerBox.Name = "DatePickerBox";
            this.DatePickerBox.Size = new System.Drawing.Size(285, 26);
            this.DatePickerBox.TabIndex = 9;
            // 
            // SalaryBox
            // 
            this.SalaryBox.Location = new System.Drawing.Point(251, 253);
            this.SalaryBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(140, 26);
            this.SalaryBox.TabIndex = 10;
            // 
            // JobBox
            // 
            this.JobBox.FormattingEnabled = true;
            this.JobBox.Items.AddRange(new object[] {
            "Tester",
            "Inżynier",
            "Projektant",
            "Młodszy programista",
            "Starszy programista"});
            this.JobBox.Location = new System.Drawing.Point(251, 304);
            this.JobBox.Name = "JobBox";
            this.JobBox.Size = new System.Drawing.Size(285, 28);
            this.JobBox.TabIndex = 11;
            // 
            // AgreementBtn1
            // 
            this.AgreementBtn1.AutoSize = true;
            this.AgreementBtn1.Location = new System.Drawing.Point(251, 372);
            this.AgreementBtn1.Name = "AgreementBtn1";
            this.AgreementBtn1.Size = new System.Drawing.Size(239, 24);
            this.AgreementBtn1.TabIndex = 12;
            this.AgreementBtn1.TabStop = true;
            this.AgreementBtn1.Text = "Umowa na czas nieokreślony";
            this.AgreementBtn1.UseVisualStyleBackColor = true;
            // 
            // AgreementBtn2
            // 
            this.AgreementBtn2.AutoSize = true;
            this.AgreementBtn2.Location = new System.Drawing.Point(251, 415);
            this.AgreementBtn2.Name = "AgreementBtn2";
            this.AgreementBtn2.Size = new System.Drawing.Size(218, 24);
            this.AgreementBtn2.TabIndex = 13;
            this.AgreementBtn2.TabStop = true;
            this.AgreementBtn2.Text = "Umowa na czas określony";
            this.AgreementBtn2.UseVisualStyleBackColor = true;
            // 
            // AgreementBtn3
            // 
            this.AgreementBtn3.AutoSize = true;
            this.AgreementBtn3.Location = new System.Drawing.Point(251, 459);
            this.AgreementBtn3.Name = "AgreementBtn3";
            this.AgreementBtn3.Size = new System.Drawing.Size(150, 24);
            this.AgreementBtn3.TabIndex = 14;
            this.AgreementBtn3.TabStop = true;
            this.AgreementBtn3.Text = "Umowa zlecenie";
            this.AgreementBtn3.UseVisualStyleBackColor = true;
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(66, 536);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(470, 42);
            this.Add_btn.TabIndex = 15;
            this.Add_btn.Text = "Dodaj";
            this.Add_btn.UseVisualStyleBackColor = true;
            
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(66, 610);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(221, 42);
            this.Save_Btn.TabIndex = 16;
            this.Save_Btn.Text = "Zapisz";
            this.Save_Btn.UseVisualStyleBackColor = true;
            
            // 
            // Load_btn
            // 
            this.Load_btn.Location = new System.Drawing.Point(315, 610);
            this.Load_btn.Name = "Load_btn";
            this.Load_btn.Size = new System.Drawing.Size(221, 42);
            this.Load_btn.TabIndex = 17;
            this.Load_btn.Text = "Wczytaj";
            this.Load_btn.UseVisualStyleBackColor = true;
            
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.SurnameColumn,
            this.DateColumn,
            this.SalaryColumn,
            this.JobColumn,
            this.AgreementColumn});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(582, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(744, 569);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InitializeRowToForm);
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Imię";
            this.nameColumn.MinimumWidth = 8;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 150;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Nazwisko";
            this.SurnameColumn.MinimumWidth = 8;
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.ReadOnly = true;
            this.SurnameColumn.Width = 150;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Data urodzenia";
            this.DateColumn.MinimumWidth = 8;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Width = 150;
            // 
            // SalaryColumn
            // 
            this.SalaryColumn.HeaderText = "Pensja";
            this.SalaryColumn.MinimumWidth = 8;
            this.SalaryColumn.Name = "SalaryColumn";
            this.SalaryColumn.ReadOnly = true;
            this.SalaryColumn.Width = 150;
            // 
            // JobColumn
            // 
            this.JobColumn.HeaderText = "Stanowisko";
            this.JobColumn.MinimumWidth = 8;
            this.JobColumn.Name = "JobColumn";
            this.JobColumn.ReadOnly = true;
            this.JobColumn.Width = 150;
            // 
            // AgreementColumn
            // 
            this.AgreementColumn.HeaderText = "Rodzaj umowy";
            this.AgreementColumn.MinimumWidth = 8;
            this.AgreementColumn.Name = "AgreementColumn";
            this.AgreementColumn.ReadOnly = true;
            this.AgreementColumn.Width = 150;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1369, 769);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Load_btn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.AgreementBtn3);
            this.Controls.Add(this.AgreementBtn2);
            this.Controls.Add(this.AgreementBtn1);
            this.Controls.Add(this.JobBox);
            this.Controls.Add(this.SalaryBox);
            this.Controls.Add(this.DatePickerBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.DateTimePicker DatePickerBox;
        private System.Windows.Forms.NumericUpDown SalaryBox;
        private System.Windows.Forms.ComboBox JobBox;
        private System.Windows.Forms.RadioButton AgreementBtn1;
        private System.Windows.Forms.RadioButton AgreementBtn2;
        private System.Windows.Forms.RadioButton AgreementBtn3;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Load_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgreementColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

