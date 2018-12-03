using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_11___2
{
    public class ogrenci
    {
        public Int64 irOgrenciNo { get; set; } 

        private string _srOgrenciName = "ogrenci";
        public string srOgrenciName
        {
            get
            {
                return _srOgrenciName;
            }
            set
            {
                _srOgrenciName = value;
            }
        }

        public double dblVizeNot { get; set; }
        public double dblFinal { get; set; }

        public HarfNotlari ogrenciHarfnotu { get; set; } = HarfNotlari.CC;
    }

    public enum HarfNotlari
    {
        AA=90,
        BA=85,
        BB=80,
        CB=75,
        CC=70,
        DC=65,
        DD=60
    }
}
