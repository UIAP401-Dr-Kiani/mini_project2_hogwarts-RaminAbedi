using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    internal class Dormitory
    {
        public List<string> DormList;
        public string Gender { get; set; }
        public int Floor { get; set; }
        public int Room { get; set; }
        public int Bed { get; set; }
        public string House { get; set; }
        public Dormitory(string gender, string house) 
        {
            House = house;
            Gender = gender;

        }
    }
}
