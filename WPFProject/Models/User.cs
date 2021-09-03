using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProject.Models
{
    public class User
    {
        public User(string name, string surname, string date, string email, string password, int age)
        {
            Name = name;
            Surname = surname;
            Date = date;
            Email = email;
            Password = password;
            Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Date { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

    }
}
