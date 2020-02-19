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
            InsertNinjaWithEquipment();
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
            using (var context = new NinjaContext())
            {
                var query = context.Ninjas.ToList();
                foreach (var item in query)
                {
                    Console.WriteLine("Name:" + item.Name);
                    Console.WriteLine("ServedInOniwaban:" + item.ServedInOniwaban);
                    Console.WriteLine("ClanId:" + item.ClanId);
                    Console.WriteLine("-----------------------");
                }
            }
        }
        public static void QueryAndUpdate(int id)
        {
            using (var context = new NinjaContext())
            {
                var ninja = context.Ninjas.Where(n => n.Id == id).FirstOrDefault();
                ninja.Name = "To juz nie to";
                context.SaveChanges();
            }
        }
        public static void DeleteNinja(int id)
        {
            using (var context = new NinjaContext())
            {
                var ninja = context.Ninjas.Where(n => n.Id == id).FirstOrDefault();
                context.Ninjas.Remove(ninja);
                context.SaveChanges();
            }
        }
        public static void InsertNinjaWithEquipment()
        {
            using (var context = new NinjaContext())
            {
                var ninja = new Ninja
                {
                    Name = "Luk Mighty",
                    ServedInOniwaban = true,
                    ClanId = 1
                };
                var sword = new NinijaEquipnent
                {
                    Name = "sword",
                    Type = EquipmentType.Weapon
                };
                var shield = new NinijaEquipnent
                {
                    Name = "shield",
                    Type = EquipmentType.Tool
                };

                context.Ninjas.Add(ninja);
                ninja.EquipmentOwned.Add(sword);
                ninja.EquipmentOwned.Add(shield);
                context.SaveChanges();

            }
        }
    }

}