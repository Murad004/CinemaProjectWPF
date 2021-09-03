using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProject.Models
{
    public class Admin
    {
        public Admin(string name, string surname, int age, string date, string email, string password)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Date = date;
            Email = email;
            Password = password;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Date { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
