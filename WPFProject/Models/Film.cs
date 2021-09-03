using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProject.Models
{
    public class Film
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Double ImDb { get; set; }
        public string ImagePath { get; set; }
        public List<String> Time { get; set; }


    }
}
