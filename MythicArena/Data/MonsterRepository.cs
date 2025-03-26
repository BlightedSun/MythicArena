using Microsoft.EntityFrameworkCore;

namespace MythicArena.Data
{
    public class MonsterRepository : IMonsterRepository
    {

        private readonly MonsterContext _dbContext;

        public MonsterRepository(MonsterContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddMonster(Monster monster)
        {
            _dbContext.Monsters.Add(monster);
            _dbContext.SaveChanges();
        }

        

        public List<Monster> GetAllMonsters()
        {
            return _dbContext.Monsters.ToList();
        }

    }
}
