using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        
        public void Add (Customer customer)
        {

            Console.WriteLine();
            Console.WriteLine("Adı:" +customer.Adi+" "+ "Soyadı:"+customer.Soyadi+" "+ "Tc:"+ customer.Id +" "+ "müşteri eklendi");
            

        }
        public void Delete(Customer customer)
        {
            Console.WriteLine();
            Console.WriteLine(customer.Adi +" "+ customer.Soyadi+" "+ customer.Id+" "+"müşteri Silindi");
            
        }

        
        public void List(Customer customer)
        {
            Console.WriteLine();
            Console.WriteLine(customer.Adi + " " + customer.Soyadi + " " + customer.Id);
            



        }


    }
}
