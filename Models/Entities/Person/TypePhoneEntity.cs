using System;

namespace Models.Entities.Person
{
    public class TypePhoneEntity
    {
        public int TypePhoneID { get; set; }
        public string TypePhoneName { get; set; } = null!;
        public string UserCreate { get; set; } = null!;
        public string UserModify { get; set; } = null!;

        public DateTime DateCreate { get; set; }
        public DateTime DateModify { get; set; }

        public bool IsActive { get; set; }
    }
}
