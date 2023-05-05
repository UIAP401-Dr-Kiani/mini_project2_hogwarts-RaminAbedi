using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    internal class Authorized : Human
    {
        public int RoomNumber { get; set; }
        public string Curriculum { get; set; }
        public string Pet { get; set; }
        public string House { get; set; }
        public bool SuitCase { get; set; }
        public string AcceptionLetter { get; set; }

    }
}
