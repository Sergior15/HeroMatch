using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroMatch.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Download {get; set;}
        public string Video { get; set; }

        public virtual List<Character> Character { get; set; }

    }
}
