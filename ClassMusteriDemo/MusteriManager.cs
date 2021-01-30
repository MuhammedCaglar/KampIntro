using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri) 
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Name + " " + musteri.Surname + " " + musteri.Id);
        }


        public void Erase(Musteri musteri) 
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Name + " " + musteri.Surname);
        }
    
        public void List(Musteri[] musteriler) 
        {
            Console.WriteLine("Müşteiriler : ");
            
            foreach (var musteri in musteriler)
            {
                Console.WriteLine( musteri.Name + " " + musteri.Surname  + " " + musteri.Id);
            }
        
        }
    }
}
