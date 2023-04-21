namespace hyugu.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Hero (string name)
        {
            Name = name;
        }

        public virtual ICollection<Quirk>? Quirk { get; set; }

        public int? SchoolId { get; set; }
        public virtual School? School { get; set; }

    }
}
