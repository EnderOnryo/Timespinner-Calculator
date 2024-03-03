using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timespinner_Calculator.Game_Data
{
    internal class GameData
    {
        public static Dictionary<string, int> orbBaseDamage = new Dictionary<string, int>
        {
            {"Blue Orb",       4},
            {"Blade Orb",      7},
            {"Fire Orb",       6},
            {"Plasma Orb",     6},
            {"Iron Orb",      10},
            {"Ice Orb",        3},
            {"Wind Orb",       3},
            {"Gun Orb",        9},
            {"Umbra Orb",      4},
            {"Empire Orb",    10},
            {"Eye Orb",        3},
            {"Blood Orb",      3},
            {"Forbidden Tome", 6},
            {"Shattered Orb",  3},
            {"Nether Orb",     6},
            {"Radiant Orb",    8}
          //{"Monske Orb",     6} This Orb isn't used in game.
        };
    }
}
