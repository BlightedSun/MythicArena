using System;
using Microsoft.EntityFrameworkCore;

namespace MythicArena.Data
{
    public class Fetch
    {
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
