using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsDesktop.Classes
{
    public class CatUser
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // game data
        public List<CatUserGameData> GameList { get; set; } = new List<CatUserGameData>();

        //Constructors
        public CatUser(int age, string name, List<CatUserGameData> gameList)
        {
            Age = age;
            Name = name;
            GameList = gameList ?? new List<CatUserGameData>();
        }
    }




}
