using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK9
{
    public struct Employees
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Dolgnost { get; set; }
        public int Stah { get; set; }
        public double Oklad { get; set; }

        public Employees(string fullName, string gender, string dolgnost, int stah, double oklad)
        {
            FullName = fullName;
            Gender = gender;
            Dolgnost = dolgnost;
            Stah = stah;
            Oklad = oklad;
        }
        
    }

}
