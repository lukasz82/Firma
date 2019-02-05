namespace Zadanie
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
            this.Departments = new System.Windows.Forms.TabControl();
            this.tabStronaGlowna = new System.Windows.Forms.TabPage();
            this.tabPracownicy = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnWyswietlWszystkichPracownikow = new System.Windows.Forms.Button();
            this.tabDodajPracownika = new System.Windows.Forms.TabPage();
            this.txtWorkplaceDateYear = new System.Windows.Forms.TextBox();
            this.txtWorkplaceDateMonth = new System.Windows.Forms.TextBox();
            this.txtBirthDateYear = new System.Windows.Forms.TextBox();
            this.btnDodajPracownika = new System.Windows.Forms.Button();
            this.txtBirthDateMonth = new System.Windows.Forms.TextBox();
            this.txtBirthDateDay = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combWorkplace = new System.Windows.Forms.ComboBox();
            this.combDepartment = new System.Windows.Forms.ComboBox();
            this.txtWorkplaceRoomNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWorkplacePhoneNumber = new System.Windows.Forms.TextBox();
            this.txtWorkplaceIncome = new System.Windows.Forms.TextBox();
            this.txtWorkplaceDateDay = new System.Windows.Forms.TextBox();
            this.txtAdressZIPCode = new System.Windows.Forms.TextBox();
            this.txtAdressStreet = new System.Windows.Forms.TextBox();
            this.txtAdressCity = new System.Windows.Forms.TextBox();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblStanowisko = new System.Windows.Forms.Label();
            this.lblLifeAddress = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.TabPage();
            this.btnDepartmentDelete = new System.Windows.Forms.Button();
            this.btnShowDepartment = new System.Windows.Forms.Button();
            this.listDepartments = new System.Windows.Forms.ListBox();
            this.txtAddDepartment = new System.Windows.Forms.TextBox();
            this.lblAddDepartment = new System.Windows.Forms.Label();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.Departments.SuspendLayout();
            this.tabPracownicy.SuspendLayout();
            this.tabDodajPracownika.SuspendLayout();
            this.Department.SuspendLayout();
            this.SuspendLayout();
            // 
            // Departments
            // 
            this.Departments.Controls.Add(this.tabStronaGlowna);
            this.Departments.Controls.Add(this.tabPracownicy);
            this.Departments.Controls.Add(this.tabDodajPracownika);
            this.Departments.Controls.Add(this.Department);
            this.Departments.Location = new System.Drawing.Point(12, 12);
            this.Departments.Name = "Departments";
            this.Departments.SelectedIndex = 0;
            this.Departments.Size = new System.Drawing.Size(780, 451);
            this.Departments.TabIndex = 0;
            // 
            // tabStronaGlowna
            // 
            this.tabStronaGlowna.Location = new System.Drawing.Point(4, 22);
            this.tabStronaGlowna.Name = "tabStronaGlowna";
            this.tabStronaGlowna.Padding = new System.Windows.Forms.Padding(3);
            this.tabStronaGlowna.Size = new System.Drawing.Size(772, 425);
            this.tabStronaGlowna.TabIndex = 0;
            this.tabStronaGlowna.Text = "StronaGlowna";
            this.tabStronaGlowna.UseVisualStyleBackColor = true;
            this.tabStronaGlowna.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPracownicy
            // 
            this.tabPracownicy.Controls.Add(this.listView1);
            this.tabPracownicy.Controls.Add(this.btnWyswietlWszystkichPracownikow);
            this.tabPracownicy.Location = new System.Drawing.Point(4, 22);
            this.tabPracownicy.Name = "tabPracownicy";
            this.tabPracownicy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPracownicy.Size = new System.Drawing.Size(772, 425);
            this.tabPracownicy.TabIndex = 1;
            this.tabPracownicy.Text = "Pracownicy";
            this.tabPracownicy.UseVisualStyleBackColor = true;
            this.tabPracownicy.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(756, 291);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnWyswietlWszystkichPracownikow
            // 
            this.btnWyswietlWszystkichPracownikow.Location = new System.Drawing.Point(323, 303);
            this.btnWyswietlWszystkichPracownikow.Name = "btnWyswietlWszystkichPracownikow";
            this.btnWyswietlWszystkichPracownikow.Size = new System.Drawing.Size(119, 45);
            this.btnWyswietlWszystkichPracownikow.TabIndex = 0;
            this.btnWyswietlWszystkichPracownikow.Text = "Wyswietl Wszystkich Pracownikow";
            this.btnWyswietlWszystkichPracownikow.UseVisualStyleBackColor = true;
            this.btnWyswietlWszystkichPracownikow.Click += new System.EventHandler(this.btnWyswietlWszystkichPracownikow_Click);
            // 
            // tabDodajPracownika
            // 
            this.tabDodajPracownika.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDodajPracownika.Controls.Add(this.txtWorkplaceDateYear);
            this.tabDodajPracownika.Controls.Add(this.txtWorkplaceDateMonth);
            this.tabDodajPracownika.Controls.Add(this.txtBirthDateYear);
            this.tabDodajPracownika.Controls.Add(this.btnDodajPracownika);
            this.tabDodajPracownika.Controls.Add(this.txtBirthDateMonth);
            this.tabDodajPracownika.Controls.Add(this.txtBirthDateDay);
            this.tabDodajPracownika.Controls.Add(this.lblBirthDate);
            this.tabDodajPracownika.Controls.Add(this.label8);
            this.tabDodajPracownika.Controls.Add(this.label7);
            this.tabDodajPracownika.Controls.Add(this.label6);
            this.tabDodajPracownika.Controls.Add(this.label5);
            this.tabDodajPracownika.Controls.Add(this.label4);
            this.tabDodajPracownika.Controls.Add(this.label3);
            this.tabDodajPracownika.Controls.Add(this.label2);
            this.tabDodajPracownika.Controls.Add(this.combWorkplace);
            this.tabDodajPracownika.Controls.Add(this.combDepartment);
            this.tabDodajPracownika.Controls.Add(this.txtWorkplaceRoomNumber);
            this.tabDodajPracownika.Controls.Add(this.label1);
            this.tabDodajPracownika.Controls.Add(this.txtWorkplacePhoneNumber);
            this.tabDodajPracownika.Controls.Add(this.txtWorkplaceIncome);
            this.tabDodajPracownika.Controls.Add(this.txtWorkplaceDateDay);
            this.tabDodajPracownika.Controls.Add(this.txtAdressZIPCode);
            this.tabDodajPracownika.Controls.Add(this.txtAdressStreet);
            this.tabDodajPracownika.Controls.Add(this.txtAdressCity);
            this.tabDodajPracownika.Controls.Add(this.txtEmployeeSurname);
            this.tabDodajPracownika.Controls.Add(this.txtEmployeeName);
            this.tabDodajPracownika.Controls.Add(this.lblTelefon);
            this.tabDodajPracownika.Controls.Add(this.lblStanowisko);
            this.tabDodajPracownika.Controls.Add(this.lblLifeAddress);
            this.tabDodajPracownika.Controls.Add(this.lblLastName);
            this.tabDodajPracownika.Controls.Add(this.lblFirstName);
            this.tabDodajPracownika.Location = new System.Drawing.Point(4, 22);
            this.tabDodajPracownika.Name = "tabDodajPracownika";
            this.tabDodajPracownika.Size = new System.Drawing.Size(772, 425);
            this.tabDodajPracownika.TabIndex = 2;
            this.tabDodajPracownika.Text = "Dodaj Pracownika";
            // 
            // txtWorkplaceDateYear
            // 
            this.txtWorkplaceDateYear.Location = new System.Drawing.Point(270, 206);
            this.txtWorkplaceDateYear.Name = "txtWorkplaceDateYear";
            this.txtWorkplaceDateYear.Size = new System.Drawing.Size(60, 20);
            this.txtWorkplaceDateYear.TabIndex = 32;
            // 
            // txtWorkplaceDateMonth
            // 
            this.txtWorkplaceDateMonth.Location = new System.Drawing.Point(222, 206);
            this.txtWorkplaceDateMonth.Name = "txtWorkplaceDateMonth";
            this.txtWorkplaceDateMonth.Size = new System.Drawing.Size(40, 20);
            this.txtWorkplaceDateMonth.TabIndex = 31;
            // 
            // txtBirthDateYear
            // 
            this.txtBirthDateYear.Location = new System.Drawing.Point(480, 45);
            this.txtBirthDateYear.Name = "txtBirthDateYear";
            this.txtBirthDateYear.Size = new System.Drawing.Size(60, 20);
            this.txtBirthDateYear.TabIndex = 30;
            // 
            // btnDodajPracownika
            // 
            this.btnDodajPracownika.Location = new System.Drawing.Point(306, 397);
            this.btnDodajPracownika.Name = "btnDodajPracownika";
            this.btnDodajPracownika.Size = new System.Drawing.Size(122, 25);
            this.btnDodajPracownika.TabIndex = 0;
            this.btnDodajPracownika.Text = "Dodaj Pracownika";
            this.btnDodajPracownika.UseVisualStyleBackColor = true;
            this.btnDodajPracownika.Click += new System.EventHandler(this.btnDodajPracownika_Click);
            // 
            // txtBirthDateMonth
            // 
            this.txtBirthDateMonth.Location = new System.Drawing.Point(434, 45);
            this.txtBirthDateMonth.Name = "txtBirthDateMonth";
            this.txtBirthDateMonth.Size = new System.Drawing.Size(40, 20);
            this.txtBirthDateMonth.TabIndex = 29;
            // 
            // txtBirthDateDay
            // 
            this.txtBirthDateDay.Location = new System.Drawing.Point(388, 45);
            this.txtBirthDateDay.Name = "txtBirthDateDay";
            this.txtBirthDateDay.Size = new System.Drawing.Size(40, 20);
            this.txtBirthDateDay.TabIndex = 28;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(386, 17);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(79, 13);
            this.lblBirthDate.TabIndex = 27;
            this.lblBirthDate.Text = "Data urodzenia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Roczny zarobek";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Stanowisko pracy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Dział";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Data zatrudnienia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kod pocztowy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ulica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Miasto";
            // 
            // combWorkplace
            // 
            this.combWorkplace.FormattingEnabled = true;
            this.combWorkplace.Location = new System.Drawing.Point(284, 257);
            this.combWorkplace.Name = "combWorkplace";
            this.combWorkplace.Size = new System.Drawing.Size(99, 21);
            this.combWorkplace.TabIndex = 19;
            this.combWorkplace.SelectedIndexChanged += new System.EventHandler(this.combStanowisko_SelectedIndexChanged);
            // 
            // combDepartment
            // 
            this.combDepartment.FormattingEnabled = true;
            this.combDepartment.Location = new System.Drawing.Point(177, 257);
            this.combDepartment.Name = "combDepartment";
            this.combDepartment.Size = new System.Drawing.Size(100, 21);
            this.combDepartment.TabIndex = 18;
            this.combDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtWorkplaceRoomNumber
            // 
            this.txtWorkplaceRoomNumber.Location = new System.Drawing.Point(176, 342);
            this.txtWorkplaceRoomNumber.Name = "txtWorkplaceRoomNumber";
            this.txtWorkplaceRoomNumber.Size = new System.Drawing.Size(100, 20);
            this.txtWorkplaceRoomNumber.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nr pokoju (jeśli Dyrektor)";
            // 
            // txtWorkplacePhoneNumber
            // 
            this.txtWorkplacePhoneNumber.Location = new System.Drawing.Point(176, 306);
            this.txtWorkplacePhoneNumber.Name = "txtWorkplacePhoneNumber";
            this.txtWorkplacePhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtWorkplacePhoneNumber.TabIndex = 15;
            // 
            // txtWorkplaceIncome
            // 
            this.txtWorkplaceIncome.Location = new System.Drawing.Point(389, 257);
            this.txtWorkplaceIncome.Name = "txtWorkplaceIncome";
            this.txtWorkplaceIncome.Size = new System.Drawing.Size(100, 20);
            this.txtWorkplaceIncome.TabIndex = 14;
            // 
            // txtWorkplaceDateDay
            // 
            this.txtWorkplaceDateDay.Location = new System.Drawing.Point(176, 206);
            this.txtWorkplaceDateDay.Name = "txtWorkplaceDateDay";
            this.txtWorkplaceDateDay.Size = new System.Drawing.Size(40, 20);
            this.txtWorkplaceDateDay.TabIndex = 11;
            // 
            // txtAdressZIPCode
            // 
            this.txtAdressZIPCode.Location = new System.Drawing.Point(388, 127);
            this.txtAdressZIPCode.Name = "txtAdressZIPCode";
            this.txtAdressZIPCode.Size = new System.Drawing.Size(100, 20);
            this.txtAdressZIPCode.TabIndex = 10;
            // 
            // txtAdressStreet
            // 
            this.txtAdressStreet.Location = new System.Drawing.Point(282, 127);
            this.txtAdressStreet.Name = "txtAdressStreet";
            this.txtAdressStreet.Size = new System.Drawing.Size(100, 20);
            this.txtAdressStreet.TabIndex = 9;
            // 
            // txtAdressCity
            // 
            this.txtAdressCity.Location = new System.Drawing.Point(176, 127);
            this.txtAdressCity.Name = "txtAdressCity";
            this.txtAdressCity.Size = new System.Drawing.Size(100, 20);
            this.txtAdressCity.TabIndex = 8;
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.Location = new System.Drawing.Point(108, 45);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.Size = new System.Drawing.Size(225, 20);
            this.txtEmployeeSurname.TabIndex = 7;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(108, 14);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(225, 20);
            this.txtEmployeeName.TabIndex = 6;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(31, 306);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(93, 13);
            this.lblTelefon.TabIndex = 5;
            this.lblTelefon.Text = "Tel. (jesli asystent)";
            // 
            // lblStanowisko
            // 
            this.lblStanowisko.AutoSize = true;
            this.lblStanowisko.Location = new System.Drawing.Point(31, 209);
            this.lblStanowisko.Name = "lblStanowisko";
            this.lblStanowisko.Size = new System.Drawing.Size(92, 13);
            this.lblStanowisko.TabIndex = 4;
            this.lblStanowisko.Text = "Stanowisko Pracy";
            // 
            // lblLifeAddress
            // 
            this.lblLifeAddress.AutoSize = true;
            this.lblLifeAddress.Location = new System.Drawing.Point(31, 130);
            this.lblLifeAddress.Name = "lblLifeAddress";
            this.lblLifeAddress.Size = new System.Drawing.Size(102, 13);
            this.lblLifeAddress.TabIndex = 3;
            this.lblLifeAddress.Text = "Adres Zamieszkania";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(31, 48);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(53, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Nazwisko";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(31, 17);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(26, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Imię";
            // 
            // Department
            // 
            this.Department.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Department.Controls.Add(this.btnDepartmentDelete);
            this.Department.Controls.Add(this.btnShowDepartment);
            this.Department.Controls.Add(this.listDepartments);
            this.Department.Controls.Add(this.txtAddDepartment);
            this.Department.Controls.Add(this.lblAddDepartment);
            this.Department.Controls.Add(this.btnAddDepartment);
            this.Department.Location = new System.Drawing.Point(4, 22);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(772, 425);
            this.Department.TabIndex = 3;
            this.Department.Text = "Dział";
            // 
            // btnDepartmentDelete
            // 
            this.btnDepartmentDelete.Location = new System.Drawing.Point(122, 62);
            this.btnDepartmentDelete.Name = "btnDepartmentDelete";
            this.btnDepartmentDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDepartmentDelete.TabIndex = 5;
            this.btnDepartmentDelete.Text = "Usuń";
            this.btnDepartmentDelete.UseVisualStyleBackColor = true;
            this.btnDepartmentDelete.Click += new System.EventHandler(this.btnDepartmentDelete_Click);
            // 
            // btnShowDepartment
            // 
            this.btnShowDepartment.Location = new System.Drawing.Point(21, 62);
            this.btnShowDepartment.Name = "btnShowDepartment";
            this.btnShowDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnShowDepartment.TabIndex = 4;
            this.btnShowDepartment.Text = "Wyświetl";
            this.btnShowDepartment.UseVisualStyleBackColor = true;
            this.btnShowDepartment.Click += new System.EventHandler(this.btnShowDepartment_Click);
            // 
            // listDepartments
            // 
            this.listDepartments.FormattingEnabled = true;
            this.listDepartments.Location = new System.Drawing.Point(22, 89);
            this.listDepartments.Name = "listDepartments";
            this.listDepartments.Size = new System.Drawing.Size(726, 290);
            this.listDepartments.TabIndex = 3;
            this.listDepartments.SelectedIndexChanged += new System.EventHandler(this.listDepartments_SelectedIndexChanged);
            // 
            // txtAddDepartment
            // 
            this.txtAddDepartment.Location = new System.Drawing.Point(122, 34);
            this.txtAddDepartment.Name = "txtAddDepartment";
            this.txtAddDepartment.Size = new System.Drawing.Size(626, 20);
            this.txtAddDepartment.TabIndex = 2;
            // 
            // lblAddDepartment
            // 
            this.lblAddDepartment.AutoSize = true;
            this.lblAddDepartment.Location = new System.Drawing.Point(19, 9);
            this.lblAddDepartment.Name = "lblAddDepartment";
            this.lblAddDepartment.Size = new System.Drawing.Size(63, 13);
            this.lblAddDepartment.TabIndex = 1;
            this.lblAddDepartment.Text = "Dodaj Dział";
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(22, 32);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnAddDepartment.TabIndex = 0;
            this.btnAddDepartment.Text = "Dodaj";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(803, 516);
            this.Controls.Add(this.Departments);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Departments.ResumeLayout(false);
            this.tabPracownicy.ResumeLayout(false);
            this.tabDodajPracownika.ResumeLayout(false);
            this.tabDodajPracownika.PerformLayout();
            this.Department.ResumeLayout(false);
            this.Department.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Departments;
        private System.Windows.Forms.TabPage tabStronaGlowna;
        private System.Windows.Forms.TabPage tabPracownicy;
        private System.Windows.Forms.TabPage Department;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnWyswietlWszystkichPracownikow;
        private System.Windows.Forms.TextBox txtAddDepartment;
        private System.Windows.Forms.Label lblAddDepartment;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.ListBox listDepartments;
        private System.Windows.Forms.Button btnShowDepartment;
        private System.Windows.Forms.Button btnDepartmentDelete;
        private System.Windows.Forms.TabPage tabDodajPracownika;
        private System.Windows.Forms.TextBox txtWorkplaceDateYear;
        private System.Windows.Forms.TextBox txtWorkplaceDateMonth;
        private System.Windows.Forms.TextBox txtBirthDateYear;
        private System.Windows.Forms.Button btnDodajPracownika;
        private System.Windows.Forms.TextBox txtBirthDateMonth;
        private System.Windows.Forms.TextBox txtBirthDateDay;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combWorkplace;
        private System.Windows.Forms.ComboBox combDepartment;
        private System.Windows.Forms.TextBox txtWorkplaceRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorkplacePhoneNumber;
        private System.Windows.Forms.TextBox txtWorkplaceIncome;
        private System.Windows.Forms.TextBox txtWorkplaceDateDay;
        private System.Windows.Forms.TextBox txtAdressZIPCode;
        private System.Windows.Forms.TextBox txtAdressStreet;
        private System.Windows.Forms.TextBox txtAdressCity;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblStanowisko;
        private System.Windows.Forms.Label lblLifeAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
    }
}

