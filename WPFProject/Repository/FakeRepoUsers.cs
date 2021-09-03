using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Models;

namespace WPFProject.Repository
{
    public class FakeRepoUsers
    {
        public List<User> Users = new List<User>();

        public List<User> GetUsers()
        {
            return Users;
        }
    }
}
