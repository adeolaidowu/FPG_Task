using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Points { get; set; }
    }
}
