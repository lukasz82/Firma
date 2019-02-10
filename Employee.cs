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
            path = "D:\\programowanie\\net Core apki\\Dzien 3 cszarp\\Dzien 3 cszarp\\ZadanieFirma\\Zadanie\\Zadanie\\Database\\Employes.txt";
        }

        public void Initialize(ref ListView listView1, ref ComboBox combDepartment, ref ComboBox combWorkplace)
        {
            foreach (var items in Enum.GetValues(typeof(Workplace.Workplaces)))
            {
                combWorkplace.Items.Add(items);
            }

            departs.LoadDepartmentsFromFile();
            foreach (var departm in departs.departments)
            {
                combDepartment.Items.Add(departm.Name);
            }

            listView1.Columns.Add("Lp.").Width = 20;
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
            ref TextBox txtBirthDateDay,
            ref TextBox txtBirthDateMonth,
            ref TextBox txtBirthDateYear,
            ref TextBox txtAdressCity,
            ref TextBox txtAdressStreet,
            ref TextBox txtAdressZIPCode,
            ref TextBox txtWorkplaceDateDay,
            ref TextBox txtWorkplaceDateMonth,
            ref TextBox txtWorkplaceDateYear,
            ref ComboBox combDepartment,
            ref ComboBox combWorkplace,
            ref TextBox txtWorkplaceIncome,
            ref TextBox txtWorkplacePhoneNumber,
            ref TextBox txtWorkplaceRoomNumber
        )
        {
            FirstName = txtEmployeeName.Text;
            LastName = txtEmployeeSurname.Text;
            BirthDate = new DateTime(Int32.Parse(txtBirthDateYear.Text), Int32.Parse(txtBirthDateMonth.Text), Int32.Parse(txtBirthDateDay.Text));
            LifeAddress = new Address(txtAdressCity.Text, txtAdressStreet.Text, txtAdressZIPCode.Text);
            EmplWorkplace = new Workplace
            (
                new DateTime(Int32.Parse(txtWorkplaceDateYear.Text), Int32.Parse(txtWorkplaceDateMonth.Text), Int32.Parse(txtWorkplaceDateDay.Text)),
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
                    $"{FirstName}," +
                    $"{LastName}, " +
                    $"{BirthDate}, " +
                    $"{LifeAddress.City}," +
                    $"{LifeAddress.Street}," +
                    $"{LifeAddress.ZIPcode}," +
                    $"{EmplWorkplace.Department}," +
                    $"{EmplWorkplace.EmplWorkplace}," +
                    $"{EmplWorkplace.DateOfEmployment}," +
                    $"{EmplWorkplace.PhoneNumber}," +
                    $"{EmplWorkplace.RoomNumber}," +
                    $"{EmplWorkplace.YearSalary}");
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"!!! ERROR: {ex.Message} !!!");
                Console.WriteLine($"Niestety nie można dodać osoby");
            }
        }

        public Employee(string name, string lastName, DateTime birthDate, Address lifeAddress, Workplace emplWorkplace)
        {
            FirstName = name;
            LastName = lastName;
            BirthDate = birthDate;
            LifeAddress = lifeAddress;
            EmplWorkplace = emplWorkplace;
        }

        public async Task ShowAllEmployees(ListView listView1, Employee emp, Label lblTaskInfo)
        {
            listView1.Items.Clear();
            listView1.Visible = false;
            int counter = 0;
            int emplCount = emp.employees.Count();
            int Lp = 1;
            float div = emplCount / 100;
            int precent = 0;
            lblTaskInfo.Text = "Wczytuję... \n";
            await Task.Run(() =>
            {
                foreach (var item in emp.employees)
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
                        //lblTaskInfo.Invoke((MethodInvoker)(() => { lblTaskInfo.Text += "*"; }));
                        counter = 0;
                    }
                }
            });
            listView1.Visible = true;
            lblTaskInfo.Text = "Wgrano listę pracowników";
        }

        public async Task ImportFromDatabase(Label lblTaskInfo)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
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
    }
}
