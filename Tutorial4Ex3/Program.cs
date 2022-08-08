using System;

namespace Tutorial4Ex3
{
    class Customer
    {
       public int id { get; set; }
        public string name { get; set; }
        public List<Product> shopList = new List<Product>();
        public void ViewList()
        {
            foreach(Product i in shopList)
            {
                Console.WriteLine(i.pid);
            }
        }
        public Customer(int i, string n)public 
        {
            id = i;
            name = n;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer(101, "First customer");
            Customer cust2 = new Customer(102, "Second customer");

            Console.WriteLine("ID of the 1st customer : " + cust1.id);
            Console.WriteLine("Name of the 2nd customer : " + cust2.name);

        }
    }
 }