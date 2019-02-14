using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Address LifeAddress { get; set; }
        public Workplace EmplWorkplace { get; set; }
        public string path { get; }

        public List<Employee> employees = new List<Employee>();
        Department departs = new Department();

        public Employee()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            path = currentDirectory + "\\Database\\Employes.txt";
        }

        public Employee(string name, string lastName, DateTime birthDate, Address lifeAddress, Workplace emplWorkplace)
        {
            FirstName = name;
            LastName = lastName;
            BirthDate = birthDate;
            LifeAddress = lifeAddress;
            EmplWorkplace = emplWorkplace;
        }

        public void Initialize(ref ListView listView1, ref ComboBox combDepartment, ref ComboBox combWorkplace, ref ComboBox  comboSelectEmplFromDepartment)
        {
            foreach (var items in Enum.GetValues(typeof(Workplace.Workplaces)))
            {
                combWorkplace.Items.Add(items);
            }

            departs.LoadDepartmentsFromFile();
            foreach (var departm in departs.departments)
            {
                combDepartment.Items.Add(departm.Name);
                comboSelectEmplFromDepartment.Items.Add(departm.Name);
            }

            listView1.Columns.Add("Lp.").Width = 50;
            listView1.Columns.Add("Imię").Width = 80;
            listView1.Columns.Add("Nazwisko").Width = 100;
            listView1.Columns.Add("Data Urodzenia").Width = 75;
            listView1.Columns.Add("Miasto").Width = 80;
            listView1.Columns.Add("Ulica").Width = 80;
            listView1.Columns.Add("Kod-Pocztowy").Width = 50;
            listView1.Columns.Add("Data Zatrudnienia").Width = 80;
            listView1.Columns.Add("Dział").Width = 130;
            listView1.Columns.Add("Stanowisko").Width = 100;
            listView1.Columns.Add("Nr tel.").Width = 100;
            listView1.Columns.Add("Pok.").Width = 100;
            listView1.View = View.Details;
        }

        public void Add
        (
            ref TextBox txtEmployeeName,
            ref TextBox txtEmployeeSurname,
            ref TextBox txtAdressCity,
            ref TextBox txtAdressStreet,
            ref TextBox txtAdressZIPCode,
            ref ComboBox combDepartment,
            ref ComboBox combWorkplace,
            ref TextBox txtWorkplaceIncome,
            ref TextBox txtWorkplacePhoneNumber,
            ref TextBox txtWorkplaceRoomNumber,
            ref DateTimePicker dateTimeBrithDate,
            ref DateTimePicker dateTimeWorkplace
        )
        {
            FirstName = txtEmployeeName.Text;
            LastName = txtEmployeeSurname.Text;
            BirthDate = DateTime.Parse(dateTimeBrithDate.Text);
            LifeAddress = new Address(txtAdressCity.Text, txtAdressStreet.Text, txtAdressZIPCode.Text);
            EmplWorkplace = new Workplace
            (
                DateTime.Parse(dateTimeWorkplace.Text),
                combDepartment.Text,
                // Parsowanie string do enum
                (Workplace.Workplaces)Enum.Parse(typeof(Workplace.Workplaces), combWorkplace.Text, true),
                Int32.Parse(txtWorkplaceIncome.Text),
                Int32.Parse(txtWorkplacePhoneNumber.Text),
                Int32.Parse(txtWorkplaceRoomNumber.Text)
            );
            employees.Add(new Employee(FirstName, LastName, BirthDate, LifeAddress, EmplWorkplace));

            try
            {
                var sw = new StreamWriter(path, append: true);
                sw.WriteLine($"" +
                    $"{FirstName}|" +
                    $"{LastName}|" +
                    $"{BirthDate}|" +
                    $"{LifeAddress.City}|" +
                    $"{LifeAddress.Street}|" +
                    $"{LifeAddress.ZIPcode}|" +
                    $"{EmplWorkplace.Department}|" +
                    $"{EmplWorkplace.EmplWorkplace}|" +
                    $"{EmplWorkplace.DateOfEmployment}|" +
                    $"{EmplWorkplace.PhoneNumber}|" +
                    $"{EmplWorkplace.RoomNumber}|" +
                    $"{EmplWorkplace.YearSalary}");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie można zapisać osoby, coś poszło nie tak: " + ex.Message);
            }
        }

        public async Task ShowAllEmployees(ListView listView1, Label lblTaskInfo, Button btnDodajPracownika,  ProgressBar progressBar1, Button btnWyswietlWszystkichPracownikow, Button btnImportFromDataBase)
        {
            listView1.Items.Clear();
            listView1.Visible = false;
            btnDodajPracownika.Enabled = false;
            btnWyswietlWszystkichPracownikow.Enabled = false;
            btnImportFromDataBase.Enabled = false;
            int counter = 0;
            int emplCount = employees.Count();
            int Lp = 1;
            float div = emplCount / 100;
            int precent = 0;
            lblTaskInfo.Text = "Wczytuję... \n";
            await Task.Run(() =>
            {
                foreach (var item in employees)
                {
                    var item_list = new ListViewItem(new[] {
                    Lp.ToString(),
                    item.FirstName,
                    item.LastName,
                    item.BirthDate.ToString(),
                    item.LifeAddress.City,
                    item.LifeAddress.Street,
                    item.LifeAddress.ZIPcode,
                    item.EmplWorkplace.DateOfEmployment.ToString(),
                    item.EmplWorkplace.Department.ToString(),
                    item.EmplWorkplace.EmplWorkplace.ToString(),
                    item.EmplWorkplace.PhoneNumber.ToString(),
                    item.EmplWorkplace.RoomNumber.ToString()
                    });

                    listView1.Invoke((MethodInvoker)(() => { listView1.Items.Add(item_list); }));
                    Lp++;
                    counter++;
                    if (counter == div)
                    {
                        precent++;
                        lblTaskInfo.Invoke((MethodInvoker)(() => { lblTaskInfo.Text = "Wczytano " + precent + "%"; }));
                        progressBar1.Invoke((MethodInvoker)(() => { progressBar1.Value = precent; }));
                        counter = 0;
                    }
                }
            });
            btnImportFromDataBase.Enabled = true;
            btnWyswietlWszystkichPracownikow.Enabled = true;
            btnDodajPracownika.Enabled = true;
            listView1.Visible = true;
            lblTaskInfo.Text = "Wgrano listę pracowników";
        }

        public async Task ImportFromDatabase(Label lblTaskInfo)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 50000; i++)
                {
                    employees.Add(new Employee("Łukasz", "Kazimierczak", DateTime.Parse("1/10/1982"),
                                  new Address("Krakow", "Pocztowa", "33-333"),
                                  new Workplace(DateTime.Parse("1/10/2010"), "DT", Workplace.Workplaces.Dyrektor, 200000, 123123123, 10)));

                    employees.Add(new Employee("Adam", "Kowalski", DateTime.Parse("1/10/1984"),
                                  new Address("Oświęcim", "Obozowa", "32-299"),
                                  new Workplace(DateTime.Parse("1/10/2012"), "Ekonomiczny", Workplace.Workplaces.Asystent, 30000, 123123124, 123)));
                }
            });
            lblTaskInfo.Text = "Zaimportowano";
        }

        public void ImportFromFile(Label lblTaskInfo)
        {
            string line;
            string[] empl;
            var sr = new StreamReader(path);
            employees.Clear();
            bool firstLine = false;
            
            while (!sr.EndOfStream)
            {
                Employee employee = new Employee();
                line = sr.ReadLine();
                if (firstLine == false)
                {
                    firstLine = true;
                    continue;
                }
                empl = line.Split('|');
                employee.FirstName = empl[0];
                employee.LastName = empl[1];
                employee.BirthDate = DateTime.Parse(empl[2]);
                employee.LifeAddress = new Address(empl[3], empl[4], empl[5]);
                employee.EmplWorkplace = new Workplace(
                    DateTime.Parse(empl[8]),
                    empl[6],
                    (Workplace.Workplaces)Enum.Parse(typeof(Workplace.Workplaces), empl[7], true),
                    float.Parse(empl[11]),
                    Int32.Parse(empl[9]),
                    Int32.Parse(empl[10]));
                employees.Add(employee);
            }
            sr.Close();
        }

        public async Task SelectUsersFromDepartment(string selectedDepartment)
        {
            var result = employees
                         .Where(x => x.EmplWorkplace.Department.Equals(selectedDepartment))
                         .Select(x => new { x.FirstName, x.LastName, x.BirthDate, x.LifeAddress, x.EmplWorkplace}).ToList();
            employees.Clear();
            await Task.Run(() =>
            { 
                foreach (var item in result)
                {
                    employees.Add(new Employee(item.FirstName, item.LastName, item.BirthDate,
                                  new Address(item.LifeAddress.City, item.LifeAddress.Street, item.LifeAddress.ZIPcode),
                                  new Workplace(item.EmplWorkplace.DateOfEmployment, item.EmplWorkplace.Department, item.EmplWorkplace.EmplWorkplace, item.EmplWorkplace.YearSalary, item.EmplWorkplace.PhoneNumber, item.EmplWorkplace.RoomNumber)));
                }
            });
        }

        public async Task FindserByName(string userEntered)
        {
            var result = employees
                         .Where(x => x.LastName.Contains(userEntered) || x.FirstName.Contains(userEntered) || (x.FirstName + " " + x.LastName).Contains(userEntered) || (x.FirstName + x.LastName).Contains(userEntered))
                         .Select(x => new { x.FirstName, x.LastName, x.BirthDate, x.LifeAddress, x.EmplWorkplace }).ToList();
            employees.Clear();
            await Task.Run(() =>
            {
                foreach (var item in result)
                {
                    employees.Add(new Employee(item.FirstName, item.LastName, item.BirthDate,
                                  new Address(item.LifeAddress.City, item.LifeAddress.Street, item.LifeAddress.ZIPcode),
                                  new Workplace(item.EmplWorkplace.DateOfEmployment, item.EmplWorkplace.Department, item.EmplWorkplace.EmplWorkplace, item.EmplWorkplace.YearSalary, item.EmplWorkplace.PhoneNumber, item.EmplWorkplace.RoomNumber)));
                }
            });
        }
    }
}
