using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    internal class Human
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string DateofBirth { get; set; }
        public string Gender { get; set; }
        public string Father { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string Role { get; set; }
        public void Humans ()
        {
            List<Human> humans = new List<Human>();
            using (StreamReader sr = new StreamReader("C:\\Users\\Ramiin\\Desktop\\P2\\mini_project2_hogwarts-RaminAbedi\\Files\\JSON_DATA.json"))
            {
                var json = sr.ReadToEnd();
                humans = JsonConvert.DeserializeObject<List<Human>>(json);
            }
            Students_Teachers(humans);
        }
        public void Students_Teachers(List<Human> humans)
        {
            if (humans != null)
            {
                if (new FileInfo("C:\\Users\\Ramiin\\Desktop\\P2\\mini_project2_hogwarts-RaminAbedi\\Files\\Teachers_JSON.json").Length != 0 || new FileInfo("C:\\Users\\Ramiin\\Desktop\\P2\\mini_project2_hogwarts-RaminAbedi\\Files\\Students_JSON.json").Length != 0)
                {
                    File.WriteAllText("C:\\Users\\Ramiin\\Desktop\\P2\\mini_project2_hogwarts-RaminAbedi\\Files\\Teachers_JSON.json", string.Empty);
                    File.WriteAllText("C:\\Users\\Ramiin\\Desktop\\P2\\mini_project2_hogwarts-RaminAbedi\\Files\\Students_JSON.json", string.Empty);
                }
                else
                {
                    for (int i = 0; i < humans.Count; i++)
                    {
                        if (humans[i].Role == "teacher")
                        {
                            var Teacher = JsonConvert.SerializeObject(humans[i]);
                            File.AppendAllText("C:\\Users\\Ramiin\\Desktop\\P2\\mini_project2_hogwarts-RaminAbedi\\Files\\Teachers_JSON.json", Teacher);
                            continue;
                        }
                        else
                        {
                            var Student = JsonConvert.SerializeObject(humans[i]);
                            File.AppendAllText("C:\\Users\\Ramiin\\Desktop\\P2\\mini_project2_hogwarts-RaminAbedi\\Files\\Students_JSON.json", Student);
                        }
                    }
                }
            }
        }
    }
}
