using System.Collections.Generic;

namespace RelationShips_Project.Models
{
    public class Developer
    {
        public int Id { get; set; }
        public string  FullName { get; set; }
        public string  Proffesion { get; set; }
        public virtual ICollection<Company> Companies { get;}
        public Developer()
        {
            Companies = new List<Company>();
        }      
    }
}
