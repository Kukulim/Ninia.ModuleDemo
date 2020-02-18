using NiniaDomain.Classes;
using NinjaDomain.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertNinja();
        }
        public static void CreateClan()
        {
            var clan = new Clan
            {
                ClanName = "ZOLWIE",              
            };
            using (var context = new NinjaContext())
            {
                context.Clans.Add(clan);
                context.SaveChanges();
            }
        }
        public static void InsertNinja()
        {
            var ninja = new Ninja
            {
                Name = "Luk 2",
                ServedInOniwaban = true,
                ClanId = 1
                
            };
            using (var context = new NinjaContext())
            {
                context.Ninjas.Add(ninja);
                context.SaveChanges();
            }
        }
        public static void SimpleNinjaQueries()
        {

        }
    }
}
