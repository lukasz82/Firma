using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Zadanie
{
    public class Department
    {
        public string Name { get; set; }
        public string path { get;}
        public int SelectedListItem { get; set; }
        
        public List<Department> departments = new List<Department>();

        public Department()
        {
            path = "D:\\programowanie\\net Core apki\\Dzien 3 cszarp\\Dzien 3 cszarp\\ZadanieFirma\\Zadanie\\Zadanie\\Database\\Departments.txt";
        }

        public Department(string name)
        {
            Name = name;
        }

        public void Add(string name)
        {
            try
            {
                var sw = new StreamWriter(path, append: true);
                sw.WriteLine($"{name}");
                sw.Close();
                Console.WriteLine($"Dodano dział {name}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił jakiś błąd : " + ex.Message);
            }
        }

        public void LoadDepartmentsFromFile()
        {
            string line;
            var sr = new StreamReader(path);
            departments.Clear();
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                departments.Add(new Department(line));
            }
            sr.Close();
        }

        public void RefreshCombDepartment(ref ComboBox combDepartment)
        {
            combDepartment.Items.Clear();

            LoadDepartmentsFromFile();
            foreach (var departm in departments)
            {
                combDepartment.Items.Add(departm.Name);
            }
        }

        public void Show(ref ListBox listDepartments, Department d)
        {
            listDepartments.Items.Clear();
            d.departments.Clear();
            listDepartments.Refresh();
            string line;

            try
            {
                var sr = new StreamReader(path);
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    d.departments.Add(new Department(line));
                }
                sr.Close();

                foreach (var item in d.departments)
                {
                    listDepartments.Items.Add(item.Name);
                }
                listDepartments.SetSelected(SelectedListItem, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił jakiś błąd : " + ex.Message);
            }
        }

        public void Delete(ref ListBox listDepartments, Department d)
        {
            string selectedDepartmentName = listDepartments.SelectedItem.ToString();
            int itemToRemove = listDepartments.SelectedIndex;

            listDepartments.Items.Remove(selectedDepartmentName);
            listDepartments.Refresh();
            d.departments.RemoveAt(itemToRemove);
            SelectedListItem = itemToRemove;

            int departmentsCount = d.departments.Count;
            try
            {
                File.WriteAllText(d.path, String.Empty);
                string[] arr = new string[departmentsCount];

                for (int i = 0; i < departmentsCount; i++)
                {
                    arr[i] = d.departments[i].Name;
                }
                File.WriteAllLines(d.path, arr);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił jakiś błąd : " + ex.Message);
            }
        }
    }
}
