using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    enum AgreementType
    {
        Nieokreslony,
        Okreslony,
        Zlecenie
    }
    class Pracownik
    {
        public string Name { get; set; }
        public string Surname {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Salary { get; set; }
        public string Job {  get; set; }
        public AgreementType Agreement { get; set; }

        public Pracownik(string name, string surname, DateTime dateOfBirth, int salary, string job, AgreementType agreement)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Salary = salary;
            Job = job;
            Agreement = agreement;
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Surname}, {this.DateOfBirth}, {this.Salary}, {this.Job}, {this.Agreement}";
        }
    }
}
