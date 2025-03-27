using System;
using Microsoft.EntityFrameworkCore;

namespace MythicArena.Data
{
    public class Fetch
    {

        //single-responsibility principle: this class is only responsible for fetching the data and putting it in a list
        private readonly MonsterContext _context;

        public Fetch(MonsterContext context)
        {
            _context = context;
        }

        public List<Monster> GetAllMonsters()
        {
            return _context.Monsters.ToList();
        }






    }
}
