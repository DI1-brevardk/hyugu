namespace hyugu.Models
{
    public class Quirk
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Quirk(string name)
        {
            Name = name;
        }

        public virtual ICollection<Hero> Heroes { get; set; }


    }
}
