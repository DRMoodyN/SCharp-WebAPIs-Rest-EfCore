using System;

namespace Models.Entities.Person
{
    public class RegionEntity
    {
        public int RegionID { get; set; }

        public string Code { get; set; } = null!;

        public string RegionName { get; set; } = null!;

        public int? RegionSubID { get; set; }

        public int Level { get; set; }

        public string UserCreate { get; set; } = null!;
        public string UserModify { get; set; } = null!;

        public DateTime DateCreate { get; set; }
        public DateTime DateModify { get; set; }

        public bool IsActive { get; set; }
    }
}
