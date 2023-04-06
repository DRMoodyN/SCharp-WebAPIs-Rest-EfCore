namespace Models
{
    public class TypePersonEntity
    {
        public int TypePersonID { get; set; }
        public string TypePersonName { get; set; } = null!;
        public string UserCreate { get; set; } = null!;
        public string UserModify { get; set; } = null!;

        public DateTime DateCreate { get; set; }
        public DateTime DateModify { get; set; }

        public bool IsActive { get; set; }

        public TypePersonEntity()
        {
            Person = new List<PersonEntity>();
        }

        [JsonIgnore]
        public ICollection<PersonEntity> Person { get; set; }
    }
}
