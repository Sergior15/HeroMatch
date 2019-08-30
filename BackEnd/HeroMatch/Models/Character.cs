using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroMatch.Models
{
    public class Character
    {   
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string SmallImage { get; set; }
        public int Difficulty { get; set; }
        public int Role { get; set; }
        public int SubRole { get; set; }
        public string CharacterUrl { get; set; }
        public int Aesthetic { get; set; }
        public string ApiLocation { get; set; }
        public string Video { get; set; }


        public virtual int GameId { get; set; }
       

        public Character()
        {

        }
        public Character(int difficulty, int role, int subRole)
        {
            Difficulty = difficulty;
            Role = role;
            SubRole = subRole;
        }
    }
}
