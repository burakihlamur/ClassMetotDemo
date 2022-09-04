using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Adi = "Gökhan";
            customer1.Soyadi = "Keleş";
            customer1.Id = 460092473;
            Customer customer2 = new Customer();
            customer2.Adi = "Hakan";
            customer2.Soyadi = "Keleş";
            customer2.Id = 460092474;
            Customer customer3 = new Customer();
            customer3.Adi = "Halil";
            customer3.Soyadi = "Keleş";
            customer3.Id = 460092475;
            Console.WriteLine("-------------------");
            CustomerManager manager = new CustomerManager();
            manager.Add(customer1);
            manager.Add(customer2);
            manager.Add(customer3);
            Console.WriteLine("-------------------");
            manager.Delete(customer1);
            manager.Delete(customer2);
            manager.Delete(customer3);
            Console.WriteLine();
            Console.WriteLine("müşteri listemiz");
            
            Console.WriteLine("-------------------");
            manager.List(customer1);
            manager.List(customer2);
            manager.List(customer3);




            Console.ReadLine();
        }
    }
}
