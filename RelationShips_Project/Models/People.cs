using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationShips_Project.Models
{
    public class People
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public virtual Address Address { get; set; }
     // public virtual ICollection<Car> Cars { get; set; }
        //public override string ToString()
        //{
        //    Console.WriteLine($"Id : {this.Id}\n" +
        //        $"Firstname : {this.Firstname}\n" +
        //        $"Lastname : {this.Lastname}\n" +
        //        $"Age : {this.Age}\n");
        //    return null;
        //}
    }
}
