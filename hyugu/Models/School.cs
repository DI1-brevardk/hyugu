namespace hyugu.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public School(string name)
        {
            Name = name;
        }

        public virtual ICollection<Hero> Heroes { get; set; }
    }
}
