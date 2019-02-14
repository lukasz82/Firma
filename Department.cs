using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Zadanie
{
    public class Department
    {
        public string Name { get; set; }
        public int DepartmentHierarchy { get; set; }
        public string path { get;}
        public int SelectedListItem { get; set; }

        public List<Department> departments = new List<Department>();

        public Department()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            path = currentDirectory + "\\Database\\Departments.txt";
        }

        public Department(string name, int hierarchy)
        {
            Name = name;
            DepartmentHierarchy = hierarchy;
        }

        public void Add(string name, int hierarchy)
        {
            try
            {
                var sw = new StreamWriter(path, append: true);
                sw.WriteLine($"{name}|{hierarchy}");
                sw.Close();
                MessageBox.Show($"{name},{hierarchy}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił jakiś błąd : " + ex.Message);
            }
        }

        public void LoadDepartmentsFromFile()
        {
            string line;
            string[] items;
            var sr = new StreamReader(path);
            departments.Clear();
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                items = line.Split('|');
                departments.Add(new Department(items[0], Int32.Parse(items[1])));
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
            LoadDepartmentsFromFile();
            
            foreach (var item in d.departments)
            {
                listDepartments.Items.Add(item.Name + " (" + item.DepartmentHierarchy + ")");
            }

            if (d.departments.Count != SelectedListItem)
            {
                listDepartments.SetSelected(SelectedListItem, true);
            }
        }

        public void Delete(ref ListBox listDepartments, Department d)
        {
            string selectedDepartmentName = listDepartments.SelectedItem.ToString();
            int itemToRemove = listDepartments.SelectedIndex;

            listDepartments.Items.Remove(selectedDepartmentName);
            listDepartments.Refresh();
            d.departments.RemoveAt(itemToRemove);

            if (d.departments.Count != itemToRemove)
            {
                SelectedListItem = itemToRemove;
            }

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
