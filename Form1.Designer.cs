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
            this.label12 = new System.Windows.Forms.Label();
            this.tabPracownicy = new System.Windows.Forms.TabPage();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.btnImportFromDataBase = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnWyswietlWszystkichPracownikow = new System.Windows.Forms.Button();
            this.lblTaskInfo = new System.Windows.Forms.Label();
            this.tabDodajPracownika = new System.Windows.Forms.TabPage();
            this.dateTimeWorkplace = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBrithDate = new System.Windows.Forms.DateTimePicker();
            this.btnDodajPracownika = new System.Windows.Forms.Button();
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
            this.txtDepartmentHierarchy = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDepartmentDelete = new System.Windows.Forms.Button();
            this.btnShowDepartment = new System.Windows.Forms.Button();
            this.listDepartments = new System.Windows.Forms.ListBox();
            this.txtAddDepartment = new System.Windows.Forms.TextBox();
            this.lblAddDepartment = new System.Windows.Forms.Label();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.comboSelectEmplFromDepartment = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Departments.SuspendLayout();
            this.tabStronaGlowna.SuspendLayout();
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
            this.Departments.Size = new System.Drawing.Size(1011, 467);
            this.Departments.TabIndex = 0;
            // 
            // tabStronaGlowna
            // 
            this.tabStronaGlowna.Controls.Add(this.label12);
            this.tabStronaGlowna.Location = new System.Drawing.Point(4, 22);
            this.tabStronaGlowna.Name = "tabStronaGlowna";
            this.tabStronaGlowna.Padding = new System.Windows.Forms.Padding(3);
            this.tabStronaGlowna.Size = new System.Drawing.Size(772, 425);
            this.tabStronaGlowna.TabIndex = 0;
            this.tabStronaGlowna.Text = "StronaGlowna";
            this.tabStronaGlowna.UseVisualStyleBackColor = true;
            this.tabStronaGlowna.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(768, 422);
            this.label12.TabIndex = 0;
            this.label12.Text = "Baza Pracowników";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPracownicy
            // 
            this.tabPracownicy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPracownicy.Controls.Add(this.label13);
            this.tabPracownicy.Controls.Add(this.label14);
            this.tabPracownicy.Controls.Add(this.btnLoadFromFile);
            this.tabPracownicy.Controls.Add(this.progressBar1);
            this.tabPracownicy.Controls.Add(this.comboSelectEmplFromDepartment);
            this.tabPracownicy.Controls.Add(this.label9);
            this.tabPracownicy.Controls.Add(this.btnImportFromDataBase);
            this.tabPracownicy.Controls.Add(this.listView1);
            this.tabPracownicy.Controls.Add(this.btnWyswietlWszystkichPracownikow);
            this.tabPracownicy.Controls.Add(this.lblTaskInfo);
            this.tabPracownicy.Location = new System.Drawing.Point(4, 22);
            this.tabPracownicy.Name = "tabPracownicy";
            this.tabPracownicy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPracownicy.Size = new System.Drawing.Size(1003, 441);
            this.tabPracownicy.TabIndex = 1;
            this.tabPracownicy.Text = "Pracownicy";
            this.tabPracownicy.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(9, 380);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(117, 42);
            this.btnLoadFromFile.TabIndex = 6;
            this.btnLoadFromFile.Text = "Wgraj pracowników w pliku";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(320, 406);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(442, 19);
            this.progressBar1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(6, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Symulacja wielowątkowości - zaciągnięcie z bazy 100 tys pracowników bez zatrzyman" +
    "ia aplikacji.";
            // 
            // btnImportFromDataBase
            // 
            this.btnImportFromDataBase.Location = new System.Drawing.Point(9, 332);
            this.btnImportFromDataBase.Name = "btnImportFromDataBase";
            this.btnImportFromDataBase.Size = new System.Drawing.Size(117, 42);
            this.btnImportFromDataBase.TabIndex = 2;
            this.btnImportFromDataBase.Text = "Importuj z bazy";
            this.btnImportFromDataBase.UseVisualStyleBackColor = true;
            this.btnImportFromDataBase.Click += new System.EventHandler(this.btnImportFromDataBase_Click);
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
            this.btnWyswietlWszystkichPracownikow.Location = new System.Drawing.Point(160, 333);
            this.btnWyswietlWszystkichPracownikow.Name = "btnWyswietlWszystkichPracownikow";
            this.btnWyswietlWszystkichPracownikow.Size = new System.Drawing.Size(123, 42);
            this.btnWyswietlWszystkichPracownikow.TabIndex = 0;
            this.btnWyswietlWszystkichPracownikow.Text = "Wyswietl wszystkich pracownikow";
            this.btnWyswietlWszystkichPracownikow.UseVisualStyleBackColor = true;
            this.btnWyswietlWszystkichPracownikow.Click += new System.EventHandler(this.btnWyswietlWszystkichPracownikow_Click);
            // 
            // lblTaskInfo
            // 
            this.lblTaskInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTaskInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTaskInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTaskInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTaskInfo.Location = new System.Drawing.Point(320, 300);
            this.lblTaskInfo.Name = "lblTaskInfo";
            this.lblTaskInfo.Size = new System.Drawing.Size(442, 106);
            this.lblTaskInfo.TabIndex = 4;
            this.lblTaskInfo.Text = "Info...";
            this.lblTaskInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabDodajPracownika
            // 
            this.tabDodajPracownika.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDodajPracownika.Controls.Add(this.dateTimeWorkplace);
            this.tabDodajPracownika.Controls.Add(this.dateTimeBrithDate);
            this.tabDodajPracownika.Controls.Add(this.btnDodajPracownika);
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
            // dateTimeWorkplace
            // 
            this.dateTimeWorkplace.Location = new System.Drawing.Point(335, 206);
            this.dateTimeWorkplace.Name = "dateTimeWorkplace";
            this.dateTimeWorkplace.Size = new System.Drawing.Size(153, 20);
            this.dateTimeWorkplace.TabIndex = 29;
            // 
            // dateTimeBrithDate
            // 
            this.dateTimeBrithDate.Location = new System.Drawing.Point(335, 55);
            this.dateTimeBrithDate.Name = "dateTimeBrithDate";
            this.dateTimeBrithDate.Size = new System.Drawing.Size(152, 20);
            this.dateTimeBrithDate.TabIndex = 28;
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
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(355, 27);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(115, 13);
            this.lblBirthDate.TabIndex = 27;
            this.lblBirthDate.Text = "Data urodzenia (d/m/r)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Roczny zarobek";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Stanowisko pracy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Dział";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Data zatrudnienia (d/m/r)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kod pocztowy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ulica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Miasto";
            // 
            // combWorkplace
            // 
            this.combWorkplace.FormattingEnabled = true;
            this.combWorkplace.Location = new System.Drawing.Point(283, 269);
            this.combWorkplace.Name = "combWorkplace";
            this.combWorkplace.Size = new System.Drawing.Size(99, 21);
            this.combWorkplace.TabIndex = 18;
            this.combWorkplace.SelectedIndexChanged += new System.EventHandler(this.combStanowisko_SelectedIndexChanged);
            // 
            // combDepartment
            // 
            this.combDepartment.FormattingEnabled = true;
            this.combDepartment.Location = new System.Drawing.Point(176, 269);
            this.combDepartment.Name = "combDepartment";
            this.combDepartment.Size = new System.Drawing.Size(100, 21);
            this.combDepartment.TabIndex = 17;
            this.combDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtWorkplaceRoomNumber
            // 
            this.txtWorkplaceRoomNumber.Location = new System.Drawing.Point(175, 343);
            this.txtWorkplaceRoomNumber.Name = "txtWorkplaceRoomNumber";
            this.txtWorkplaceRoomNumber.Size = new System.Drawing.Size(100, 20);
            this.txtWorkplaceRoomNumber.TabIndex = 21;
            this.txtWorkplaceRoomNumber.Text = "234";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nr pokoju (jeśli Dyrektor)";
            // 
            // txtWorkplacePhoneNumber
            // 
            this.txtWorkplacePhoneNumber.Location = new System.Drawing.Point(175, 307);
            this.txtWorkplacePhoneNumber.Name = "txtWorkplacePhoneNumber";
            this.txtWorkplacePhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtWorkplacePhoneNumber.TabIndex = 20;
            this.txtWorkplacePhoneNumber.Text = "777888999";
            // 
            // txtWorkplaceIncome
            // 
            this.txtWorkplaceIncome.Location = new System.Drawing.Point(388, 269);
            this.txtWorkplaceIncome.Name = "txtWorkplaceIncome";
            this.txtWorkplaceIncome.Size = new System.Drawing.Size(100, 20);
            this.txtWorkplaceIncome.TabIndex = 19;
            this.txtWorkplaceIncome.Text = "500000";
            // 
            // txtAdressZIPCode
            // 
            this.txtAdressZIPCode.Location = new System.Drawing.Point(387, 132);
            this.txtAdressZIPCode.Name = "txtAdressZIPCode";
            this.txtAdressZIPCode.Size = new System.Drawing.Size(100, 20);
            this.txtAdressZIPCode.TabIndex = 13;
            this.txtAdressZIPCode.Text = "44-222";
            // 
            // txtAdressStreet
            // 
            this.txtAdressStreet.Location = new System.Drawing.Point(281, 132);
            this.txtAdressStreet.Name = "txtAdressStreet";
            this.txtAdressStreet.Size = new System.Drawing.Size(100, 20);
            this.txtAdressStreet.TabIndex = 12;
            this.txtAdressStreet.Text = "Partyzantów";
            // 
            // txtAdressCity
            // 
            this.txtAdressCity.Location = new System.Drawing.Point(175, 132);
            this.txtAdressCity.Name = "txtAdressCity";
            this.txtAdressCity.Size = new System.Drawing.Size(100, 20);
            this.txtAdressCity.TabIndex = 11;
            this.txtAdressCity.Text = "Katowice";
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.Location = new System.Drawing.Point(108, 55);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.Size = new System.Drawing.Size(169, 20);
            this.txtEmployeeSurname.TabIndex = 7;
            this.txtEmployeeSurname.Text = "Kowalski";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(108, 24);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(168, 20);
            this.txtEmployeeName.TabIndex = 6;
            this.txtEmployeeName.Text = "Jan";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(30, 307);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(93, 13);
            this.lblTelefon.TabIndex = 5;
            this.lblTelefon.Text = "Tel. (jesli asystent)";
            // 
            // lblStanowisko
            // 
            this.lblStanowisko.AutoSize = true;
            this.lblStanowisko.Location = new System.Drawing.Point(31, 206);
            this.lblStanowisko.Name = "lblStanowisko";
            this.lblStanowisko.Size = new System.Drawing.Size(92, 13);
            this.lblStanowisko.TabIndex = 4;
            this.lblStanowisko.Text = "Stanowisko Pracy";
            // 
            // lblLifeAddress
            // 
            this.lblLifeAddress.AutoSize = true;
            this.lblLifeAddress.Location = new System.Drawing.Point(30, 135);
            this.lblLifeAddress.Name = "lblLifeAddress";
            this.lblLifeAddress.Size = new System.Drawing.Size(102, 13);
            this.lblLifeAddress.TabIndex = 3;
            this.lblLifeAddress.Text = "Adres Zamieszkania";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(31, 58);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(53, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Nazwisko";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(31, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(26, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Imię";
            // 
            // Department
            // 
            this.Department.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Department.Controls.Add(this.txtDepartmentHierarchy);
            this.Department.Controls.Add(this.label11);
            this.Department.Controls.Add(this.label10);
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
            // txtDepartmentHierarchy
            // 
            this.txtDepartmentHierarchy.Location = new System.Drawing.Point(462, 32);
            this.txtDepartmentHierarchy.Name = "txtDepartmentHierarchy";
            this.txtDepartmentHierarchy.Size = new System.Drawing.Size(44, 20);
            this.txtDepartmentHierarchy.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(401, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Hierarchia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nazwa";
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
            this.txtAddDepartment.Location = new System.Drawing.Point(165, 32);
            this.txtAddDepartment.Name = "txtAddDepartment";
            this.txtAddDepartment.Size = new System.Drawing.Size(210, 20);
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
            // comboSelectEmplFromDepartment
            // 
            this.comboSelectEmplFromDepartment.FormattingEnabled = true;
            this.comboSelectEmplFromDepartment.Location = new System.Drawing.Point(796, 69);
            this.comboSelectEmplFromDepartment.Name = "comboSelectEmplFromDepartment";
            this.comboSelectEmplFromDepartment.Size = new System.Drawing.Size(121, 21);
            this.comboSelectEmplFromDepartment.TabIndex = 1;
            this.comboSelectEmplFromDepartment.SelectedIndexChanged += new System.EventHandler(this.comboSelectEmplFromDepartment_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(793, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Filtruj:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(793, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Dział";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1035, 542);
            this.Controls.Add(this.Departments);
            this.Name = "Form1";
            this.Text = "Baza Pracowników";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Departments.ResumeLayout(false);
            this.tabStronaGlowna.ResumeLayout(false);
            this.tabPracownicy.ResumeLayout(false);
            this.tabPracownicy.PerformLayout();
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
        private System.Windows.Forms.Button btnDodajPracownika;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnImportFromDataBase;
        private System.Windows.Forms.Label lblTaskInfo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.DateTimePicker dateTimeWorkplace;
        private System.Windows.Forms.DateTimePicker dateTimeBrithDate;
        private System.Windows.Forms.TextBox txtDepartmentHierarchy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboSelectEmplFromDepartment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

