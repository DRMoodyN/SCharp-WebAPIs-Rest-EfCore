using System;

namespace Models
{
    public class TypeEmailEntity
    {
        public int TypeEmailID { get; set; }
        public string TypeEmailName { get; set; } = null!;
        public string UserCreate { get; set; } = null!;
        public string UserModify { get; set; } = null!;

        public DateTime DateCreate { get; set; }
        public DateTime DateModify { get; set; }

        public bool IsActive { get; set; }
    }
}
