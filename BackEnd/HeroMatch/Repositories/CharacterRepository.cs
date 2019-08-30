using HeroMatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroMatch.Repositories
{
    public class CharacterRepository : IRepository<Character>
    {
        private SiteContext db;

        public CharacterRepository(SiteContext db)
        {
            this.db = db;
        }

        public IEnumerable<Character> GetAll()
        {
            return db.Character;
        }

        public Character GetByProperties(Character obj)
        {
            return db.Character.Single(c => c.Difficulty == obj.Difficulty && c.Role == obj.Role && c.SubRole == obj.SubRole);
        }

        public Character GetById(int id)
        {
            return db.Character.Single(c => c.CharacterId == id);
        }








        public void Create(Character obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Character obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Character obj)
        {
            throw new NotImplementedException();
        }

    }
}
