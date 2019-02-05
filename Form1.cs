﻿using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            em.Initialize(ref listView1);
            em.ShowAllEmployees(ref listView1, em);
            d.Show(ref listDepartments, d);
        }

        private void btnWyswietlWszystkichPracownikow_Click(object sender, EventArgs e)
        {
            em.ShowAllEmployees(ref  listView1, em);
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
                d.Add(txtAddDepartment.Text);
                d.Show(ref listDepartments, d);
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
                ref txtBirthDateDay,
                ref txtBirthDateMonth,
                ref txtBirthDateYear,
                ref txtAdressCity,
                ref txtAdressStreet,
                ref txtAdressZIPCode,
                ref txtWorkplaceDateDay,
                ref txtWorkplaceDateMonth,
                ref txtWorkplaceDateYear,
                ref combDepartment,
                ref combWorkplace,
                ref txtWorkplaceIncome,
                ref txtWorkplacePhoneNumber,
                ref txtWorkplaceRoomNumber);
        }
    }
}