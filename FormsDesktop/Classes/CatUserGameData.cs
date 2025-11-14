using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsDesktop.Classes
{
    internal class CatUserGameData
    {
        public int GameTime { get; set; }
        public int Errors { get; set; }
        public int Points { get; set; }
        public string Date { get; set; }
        public string Dificulty { get; set; }
        
        //Constructors
        public CatUserGameData(string dificulty, int gameTime, int errors, int points, string date)
        {
            Dificulty = dificulty;
            GameTime = gameTime;
            Errors = errors;
            Points = points;
            Date = date;
        }
    }

}
