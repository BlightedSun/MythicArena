namespace MythicArena.Components
{
    public class GameLogic
    {

       
        public List<Ability> _abilities = new List<Ability>();
        public List<Monster> _monsters = new List<Monster>();


        //constructor
        public GameLogic()
        {
            AddToMonsterList(new Monster("Dragon", 50, 3, 10, 10));
            AddToMonsterList(new Monster("Kelpie", 25, 3, 10, 15));
            AddToMonsterList(new Monster("Hellcat", 20, 3, 15, 30));
            //_monsters.Add("dragon", new Monster("dragon", 100, 10, 10, 10));
            //name, hp, def, pwr, spd

            AddToAbilityList(new Ability("Fire Breath", 40, 100));





        }
        //FIX THIS
        //public void AddToPlayerList(Monster monster)
        //{

        //    _monsters.Add(monster);

        //}
        public void AddToMonsterList(Monster monster)
        {

            _monsters.Add(monster);

        }

        public void AddToAbilityList(Ability ability)
        {
            _abilities.Add(ability);

        }


        public void PrintMonsterList()
        {
            foreach (var monster in _monsters)
            {
                Console.WriteLine($"Name: {monster.Name}, Health: {monster.MaxHealth}, Defense: {monster.Defense}, Power: {monster.Power}, Speed: {monster.Speed}");
            }



        }
    }
}
