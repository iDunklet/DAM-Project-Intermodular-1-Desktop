using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormsDesktop.Classes
{
    [Serializable]
    public class Jugador
    {
        public string Name { get; set; }
        public int Age { get; set; }


        //constructors
        public Jugador(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }

}
