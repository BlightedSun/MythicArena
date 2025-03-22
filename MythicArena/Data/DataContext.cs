using Microsoft.EntityFrameworkCore;
using MythicArena.Components;
using System.Collections.Generic;

//namespace MythicArena.Data
//{
//    public class DataContext : DbContext
//    {

//        public DataContext(DbContextOptions<DataContext> options) : base(options)
//        {

//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Monster>().HasData(
//                new Monster { Name = "Dragon", MaxHealth = 50, Defense = 3, Power = 10, Speed = 10 },
//                new Monster { Name = "Kelpie", MaxHealth = 25, Defense = 3, Power = 10, Speed = 15 },
//                new Monster { Name = "Hellcat", MaxHealth = 20, Defense = 3, Power = 15, Speed = 30 },
//                );

//            modelBuilder.Entity<Ability>().HasData(
//                new Ability { Name = "Fire Breath", AbilityDamage = 10, HitChance = 100 },
//                new Ability { Name = "Tidal Wave", AbilityDamage = 10, HitChance = 100 },
//                new Ability { Name = "Back Paw", AbilityDamage = 10, HitChance = 100 }
//                );

//        }

//        public DbSet<Monster>? Monsters { get; set; }
//        public DbSet<Ability>? Abilities { get; set; }



//    }
//}
