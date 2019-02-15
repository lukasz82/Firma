using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Zadanie
{
    public partial class Form1 : Form
    {
        
        Employee em = new Employee();
        Department d = new Department();

        public Form1()
        {
            InitializeComponent();
            this.txtFindUserByName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void combStanowisko_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (txtAddDepartment.Text != "")
            {
                d.Add(txtAddDepartment.Text, Int32.Parse(txtDepartmentHierarchy.Text));
                d.Show(ref listDepartments, d);
                d.RefreshCombDepartment(ref combDepartment);
            }
            else
            {
                MessageBox.Show("Pole jest puste, proszę wpisać nazwę Działu");
            }
        }

        private void listDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnShowDepartment_Click(object sender, EventArgs e)
        {
            d.Show(ref listDepartments, d);
        }

        private void btnDepartmentDelete_Click(object sender, EventArgs e)
        {
            if (listDepartments.SelectedItem != null)
            {
                d.Delete(ref listDepartments, d);
                d.Show(ref listDepartments, d);
            }
        }

        private void btnDodajPracownika_Click(object sender, EventArgs e)
        {
            em.Add(
                ref txtEmployeeName,
                ref txtEmployeeSurname,
                ref txtAdressCity,
                ref txtAdressStreet,
                ref txtAdressZIPCode,
                ref combDepartment,
                ref combWorkplace,
                ref txtWorkplaceIncome,
                ref txtWorkplacePhoneNumber,
                ref txtWorkplaceRoomNumber,
                ref dateTimeBrithDate,
                ref dateTimeWorkplace);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.MultiSelect = true;
            listView1.FullRowSelect = true;
            em.Initialize(ref listView1, ref combDepartment, ref combWorkplace, ref comboSelectEmplFromDepartment);
            await em.ShowAllEmployees(listView1, lblTaskInfo, btnDodajPracownika, progressBar1, btnWyswietlWszystkichPracownikow, btnImportFromDataBase);
            d.Show(ref listDepartments, d);
        }

        private async void btnImportFromDataBase_Click(object sender, EventArgs e)
        {
            await em.ImportFromDatabase(lblTaskInfo);
        }

        private async void btnWyswietlWszystkichPracownikow_Click(object sender, EventArgs e)
        {
            await em.ShowAllEmployees(listView1, lblTaskInfo, btnDodajPracownika, progressBar1, btnWyswietlWszystkichPracownikow, btnImportFromDataBase);
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            em.ImportFromFile(lblTaskInfo);
        }

        // TODO: zapakować te funkcje w jedną klasę żeby nie powielać kodu
        private async void comboSelectEmplFromDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            em.ImportFromFile(lblTaskInfo);
            await em.SelectUsersFromDepartment(comboSelectEmplFromDepartment.Text);
            await em.ShowAllEmployees(listView1, lblTaskInfo, btnDodajPracownika, progressBar1, btnWyswietlWszystkichPracownikow, btnImportFromDataBase);
        }

        private async void btnSearchUserByName_Click(object sender, EventArgs e)
        {
            em.ImportFromFile(lblTaskInfo);
            await em.FindUserByName(txtFindUserByName.Text);
            await em.ShowAllEmployees(listView1, lblTaskInfo, btnDodajPracownika, progressBar1, btnWyswietlWszystkichPracownikow, btnImportFromDataBase);
        }
        
        private async void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                em.ImportFromFile(lblTaskInfo);
                await em.FindUserByName(txtFindUserByName.Text);
                await em.ShowAllEmployees(listView1, lblTaskInfo, btnDodajPracownika, progressBar1, btnWyswietlWszystkichPracownikow, btnImportFromDataBase);
            }
        }

        private void btnMouseMove_Click(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        private async void btnRemoveSelectedEmployees_Click(object sender, EventArgs e)
        {
            em.Delete(listView1);
            em.ImportFromFile(lblTaskInfo);
            await em.ShowAllEmployees(listView1, lblTaskInfo, btnDodajPracownika, progressBar1, btnWyswietlWszystkichPracownikow, btnImportFromDataBase);
        }
    }
}
