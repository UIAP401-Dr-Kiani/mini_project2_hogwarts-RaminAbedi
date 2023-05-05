using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Humans();

            Console.ReadKey();
        }
    }
}
