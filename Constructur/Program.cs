using System;

namespace Constructur
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id=1,City="Ankara",FirtName="Ali",LastName="Kaan"};
            Customer customer2 = new Customer(1,"Kırşehir","Can","Kaya");
            Console.WriteLine(customer2.City);
        }
    }
    class Customer
    {

        public Customer(int id,string city,string firstname,string lastname)
        {
            Id = id;
            City = city;
            FirtName = firstname;
            LastName = lastname;
        }

        public Customer()
        {
            Console.WriteLine("Yapıcı Blok");
        }
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
