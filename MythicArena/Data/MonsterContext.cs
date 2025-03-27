using Microsoft.EntityFrameworkCore;
using MythicArena.Components;
using System.Collections.Generic;
using MythicArena.Migrations;

namespace MythicArena.Data
{

    
    public class MonsterContext : DbContext
    {
        //needed constructor to get rid of error
        public MonsterContext(DbContextOptions<MonsterContext> options) : base(options)
        {


        }


        public DbSet<Monster> Monsters { get; set; }
        public string DbPath { get; set; }

        



    }
}
