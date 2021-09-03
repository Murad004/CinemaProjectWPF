using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Models;

namespace WPFProject.Repository
{
    public class FakeRepoAdmin
    {
        public List<Admin> Admins = new List<Admin>();

        public List<Admin> GetAdmins()
        {
            return Admins;
        }
    }
}
