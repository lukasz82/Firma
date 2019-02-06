using System;
using System.Collections.Generic;
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
        
        public List<Employee> employees = new List<Employee>();
        Department departs = new Department();

        public Employee()
        {
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
            
            employees.Add(new Employee("Łukasz", "Kazimierczak", DateTime.Parse("1/10/1982"),
                          new Address("Krakow", "Pocztowa", "33-333"),
                          new Workplace(DateTime.Parse("1/10/2010"), "DT", Workplace.Workplaces.Dyrektor, 200000, 123123123, 10)));

            employees.Add(new Employee("Adam", "Kowalski", DateTime.Parse("1/10/1984"),
                          new Address("Oświęcim", "Obozowa", "32-299"),
                          new Workplace(DateTime.Parse("1/10/2012"), "Ekonomiczny", Workplace.Workplaces.Asystent, 30000, 123123124, 123)));

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

        public void Add(
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
                ref TextBox txtWorkplaceRoomNumber)
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
                }


        public Employee(string name, string lastName, DateTime birthDate, Address lifeAddress, Workplace emplWorkplace)
        {
            FirstName = name;
            LastName = lastName;
            BirthDate = birthDate;
            LifeAddress = lifeAddress;
            EmplWorkplace = emplWorkplace;
        }

        public void ShowAllEmployees(ref ListView listView1, Employee emp)
        {
            listView1.Items.Clear();
            foreach (var item in emp.employees)
            {
                var item_list = new ListViewItem(new[] {
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
                listView1.Items.Add(item_list);
            }
        }
    }
}
