using Microsoft.EntityFrameworkCore;
using MythicArena.Components;
using System.Collections.Generic;

namespace MythicArena.Data
{
    public class DataContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Monster>().HasData(
                new Monster { Name = "Dragon", MaxHealth = 50, Defense = 3, Power = 10, Speed = 10 },
                new Monster { Name = "Dragon", MaxHealth = 50, Defense = 3, Power = 10, Speed = 10 },
                new Monster { Name = "Dragon", MaxHealth = 50, Defense = 3, Power = 10, Speed = 10 }
                );

            modelBuilder.Entity<Ability>().HasData(
                new Ability { Name = "Fire Breath", AbilityDamage = 10, HitChance = 100 },
                new Ability { Name = "Fire Breath", AbilityDamage = 10, HitChance = 100 },
                new Ability { Name = "Fire Breath", AbilityDamage = 10, HitChance = 100 }
                );

        }

        public DbSet<Monster>? Monsters { get; set; }
        public DbSet<Ability>? Abilities { get; set; }



    }
}
