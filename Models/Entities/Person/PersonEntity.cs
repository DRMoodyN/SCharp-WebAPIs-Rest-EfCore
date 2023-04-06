using System;

namespace Models.Entities.Person
{
    public class PersonEntity
    {
        public int PersonID { get; set; }

        public string Information { get; set; } = null!;
        public string FirstName1 { get; set; } = null!;
        public string? FirstName2 { get; set; }
        public string LastName1 { get; set; } = null!;
        public string? LastName2 { get; set; }
        public string UserCreate { get; set; } = null!;
        public string UserModify { get; set; } = null!;
        public DateTime DateCreate { get; set; }
        public DateTime DateModify { get; set; }
        public bool IsActive { get; set; }
        public int TypePersonID { get; set; }
        public TypePersonEntity TypePersonEntity { get; set; } = null!;
    }
}
