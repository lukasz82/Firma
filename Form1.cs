using System;
using System.Collections.Generic;
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
            //await em.ShowAllEmployees(listView1, em, lblTaskInfo, btnDodajPracownika, progressBar1, btnWyswietlWszystkichPracownikow, btnImportFromDataBase);
            await em.ShowAllEmployees(listView1, lblTaskInfo, btnDodajPracownika, progressBar1, btnWyswietlWszystkichPracownikow, btnImportFromDataBase);
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            em.ImportFromFile(lblTaskInfo);
        }

        private async void comboSelectEmplFromDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            em.ImportFromFile(lblTaskInfo);
            await em.SelectUsersFromDepartment(comboSelectEmplFromDepartment.Text);
            await em.ShowAllEmployees(listView1, lblTaskInfo, btnDodajPracownika, progressBar1, btnWyswietlWszystkichPracownikow, btnImportFromDataBase);
        }
    }
}
