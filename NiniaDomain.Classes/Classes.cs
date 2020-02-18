using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NiniaDomain.Classes
{
    public class Ninja
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ServedInOniwaban { get; set; }
        public Clan Clan { get; set; }
        public int ClanId { get; set; }
        public List<NinijaEquipnent> EquipmentOwned { get; set; }
    }

    public class Clan
    {
        public int Id { get; set; }
        public string ClanName { get; set; }
        public List<Ninja> Ninijas { get; set; }
    }

    public class NinijaEquipnent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EquipmentType Type { get; set; }
        [Required]
        public Ninja Ninja { get; set; }
    }
}
