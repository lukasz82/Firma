using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    public class Workplace
    {
        public DateTime DateOfEmployment { get; set; }
        public Workplaces EmplWorkplace { get; set; }
        public string Department { get; set; }
        public float YearSalary { get; set; }
        public int PhoneNumber { get; set; }
        public int RoomNumber { get; set; }

        public enum Workplaces
        {
            Dyrektor,
            Manager,
            Pracownik,
            Asystent
        }

        public Workplace(DateTime dateOfEmployment, string department, Workplaces emplWorkplace, float yearSalary, int phoneNumber, int roomNumber)
        {
            DateOfEmployment = dateOfEmployment;
            EmplWorkplace = emplWorkplace;
            Department = department;
            YearSalary = yearSalary;

            if (emplWorkplace.Equals(Workplaces.Asystent))
            {
                PhoneNumber = phoneNumber;
            }
            else
            {
                PhoneNumber = 0;
            }

            if (emplWorkplace.Equals(Workplaces.Dyrektor))
            {
                RoomNumber = roomNumber;
            }
            else
            {
                RoomNumber = 0;
            }
        }
    }
}
