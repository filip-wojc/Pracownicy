using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy.Models
{
  
    public class Pracownik
    {
        public string Name { get; set; }
        public string Surname {  get; set; }
        public string DateOfBirth { get; set; }
        public int Salary { get; set; }
        public string Job {  get; set; }
        public string Agreement { get; set; }

        public Pracownik(string name, string surname, string dateOfBirth, int salary, string job, string agreement)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Salary = salary;
            Job = job;
            Agreement = agreement;
        }

        public Pracownik() { }

        public override string ToString()
        {
            return $"{this.Name}, {this.Surname}, {this.DateOfBirth}, {this.Salary}, {this.Job}, {this.Agreement}";
        }

    }
}
