﻿using Microsoft.EntityFrameworkCore;
using MythicArena.Components;
using System.Collections.Generic;

namespace MythicArena.Data
{

    
    public class MonsterContext : DbContext
    {
        //needed constructure to get rid of error
        public MonsterContext(DbContextOptions<MonsterContext> options) : base(options)
        {
        }


        public DbSet<Monster> Monsters { get; set; }
        public string DbPath { get; set; }

        public MonsterContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "monsters.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite($"Data Source={DbPath}");



    }
}
