using Microsoft.EntityFrameworkCore;
using RelationShips_Project.Data;
using RelationShips_Project.Models;
using System;
using System.Linq;

namespace RelationShips_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext db = new AppDbContext();
            #region ManyToManyRelationShip
            //Developer and Companies information add
            Developer developer = new Developer();
            developer.FullName = "Elbek Abdurahimov";
            developer.Proffesion = ".Net Developer";

            Company company = new Company();
            company.CompanyName = "EPAM";
            var read_Id = from cust in db.Companies
                          where cust.CompanyName==company.CompanyName
                          select cust.Id;
           
            foreach (var item in read_Id)
            {
                company.Id=int.Parse(item.ToString());
               
                Console.WriteLine(company.Id);
            }



            //if (company.CompanyName==db.)
            //{

            //}
            //else
            //{
            //    company.Developers.Add(developer);
            //    db.Companies.Add(company);
            //    db.SaveChanges();
            //}
            //Console.WriteLine("Malumot saqlandi!!!");












            #endregion


            #region OneToManyRelationShip
            /* 
             // People and Car add
             People people=new People();
            people.Firstname = "Elbek";
            people.Lastname = "Abdurahimov";
            people.Age = 24;

            Car car1 = new Car()
            {
                Name = "Malibu",
                Color = "Qora",
                Number = "F 777 FF"
            };
            Car car2 = new Car()
            {
                Name = "Captiva",
                Color = "Qora",
                Number = "F 777 FF"
            };
            people.Cars.Add(car1);            
            people.Cars.Add(car2);            
            db.Peoples.Add(people);
            db.SaveChanges();
            //GetById
            People people = db.Peoples.Where(x => x.Id.Equals(3))
                .Include(x => x.Cars).FirstOrDefault();
            */
            #endregion

            #region  OneToOneRelationShip
            //  db information add
            /*Address address = new Address();
            address.Region = "Qashqadaryo";
            address.District = "Qamashi";
            address.Village = "G'ishtli";
            People people = new People();
            people.Firstname = "Elbek";
            people.Lastname = "Abdijabbarov";
            people.Age = 24;
            people.Address = address;
            db.Peoples.Add(people);
            db.SaveChanges();
            Console.WriteLine("Bazaga malumotlar muvaffaqiyatli qushildi!!!");
            // Include qilib ulash One to One
            var people = db.Peoples
                .Where(x => x.Id.Equals(7))
                .Include(x => x.Address)
                .FirstOrDefault();
            //// Update
            //people.Address.Region = "Farg'ona";
            //people.Address.District = "Qo'qon";
            //// Remove
            db.Peoples.Remove(people);
            db.Addresses.Remove(people.Address);
            db.SaveChanges();
            Console.WriteLine(people);
            */
            #endregion
        }
    }
}
