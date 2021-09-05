using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Models;

namespace WPFProject.Repository
{
    public class FakeRepoAdmin
    {
        public ObservableCollection<Admin> Admins = new ObservableCollection<Admin>();

        public ObservableCollection<Admin> GetAdmins()
        {
            return Admins;
        }
    }
}
