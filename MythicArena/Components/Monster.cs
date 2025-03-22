namespace MythicArena.Components
{
    public class Monster
    {
        //get and set. get a value from an object. set sets the value.
        public string Name { get; set; } = string.Empty;
        //public string MonsterElement { get; set; }
        //public string Weakness { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int Defense { get; set; }
        public int Power { get; set; }
        public int Speed { get; set; }
        public List<Ability> Abilities { get; set; } = new List<Ability>();
        public Random random { get; set; }

        public int Hp { get { return CurrentHealth; } }
        public string MonsterName { get { return Name; } }
        public bool IsDead { get { return CurrentHealth <= 0; } }


        


        //constructor for class monster
        //public Monster(string name, int maxHealth, int defense, int power, int speed)
        //{
        //    this.Name = name;
        //    this.MaxHealth = maxHealth;
        //    this.CurrentHealth = maxHealth;
        //    this.Defense = defense;
        //    this.Power = power;
        //    this.Speed = speed;
        //    this.random = new Random();
        //}



        //change "attack" to an ABILITY 
        public void Attack(Monster enemy)
        {
            //returns a double value between 0 and 1
            double rng = random.NextDouble();
            //changing range from 0 to 0.5 then 0.75 to 1.25
            rng = rng / 2 + 0.75f;
            int randomDamage = (int)(Power * rng);
            int calcDamage = enemy.TakeDamage(randomDamage);
            Console.WriteLine(Name + " attacks " + enemy.Name + " and deals " + calcDamage + " damage!");
        }

        //public void Heal()
        //{
        //    double rng = random.NextDouble();
        //    rng = rng / 2 + 0.75f;
        //    int heal = (int)(HealPower * rng);
        //    CurrentHealth = heal + CurrentHealth > MaxHealth ? MaxHealth : CurrentHealth + heal;
        //    Console.WriteLine(Name + " heals " + heal);

        //}


        public int TakeDamage(int randomDamage)
        {
            int calcDamage = randomDamage - this.Defense;
            if (calcDamage > 0) { this.CurrentHealth -= calcDamage; }
            //if the damage is negative or 0, nothing happens

            if (IsDead)
            {
                Console.WriteLine(Name + " has been defeated!");
            }
            return calcDamage;

        }





    }




    public class Ability
    {
        public string Name { get; set; }
        public int AbilityDamage { get; set; }
        public int HitChance { get; set; }
        //public string AbilityElement { get; set; }

        public Ability(string name, int abilityDamage, int hitChance)
        {
            Name = name;
            AbilityDamage = abilityDamage;
            HitChance = hitChance;

        }
    }

    //elements: nature > earth > storm > water > fire > nature

}

