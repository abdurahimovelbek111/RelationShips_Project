using System.Collections.Generic;

namespace RelationShips_Project.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string  CompanyName { get; set; }
        public virtual ICollection<Developer> Developers { get; set; }
        public Company()
        {
            Developers = new List<Developer>();
        }       
    }
}
