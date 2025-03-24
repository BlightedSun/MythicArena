using MythicArena.Components;

namespace MythicArena.Data
{
    public interface IMonsterRepository
    {
        void AddMonster(Monster monster);

        public List<Monster> GetAllMonsters();
        




    }
}
