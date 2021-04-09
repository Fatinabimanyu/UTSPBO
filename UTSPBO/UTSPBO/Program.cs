using System;
using System.Collections.Generic;

namespace PesenMinum
{
    class Program
    {
        static void Main(string[] args)
        {
            var queueOfCustomerOrder = new Queue<CustomerOrder>();

            while (true)
            {
                Console.WriteLine("Coffee Ordering App");
                Console.WriteLine("1. Tambah Pesanan");
                Console.WriteLine("2. Tampilkan semua pesanan yang ada");
                Console.WriteLine("3. Tampilkan urutan pesanan");
                Console.WriteLine("4. Tampilkan yang sudah siap");
                Console.Write("Masukan pilihan ");
                var opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        var custOrder = new CustomerOrder();
                        Console.Write("Masukan nama ");
                        custOrder.Name = Console.ReadLine();

                        Console.Write("Berapa cups? ");
                        custOrder.TotalCups = Convert.ToInt16(Console.ReadLine());
                        queueOfCustomerOrder.Enqueue(custOrder);
                        Console.WriteLine("Pesanan ditambah ");

                        break;
                    case "2":
                        if (queueOfCustomerOrder.Count > 0)
                        {
                            foreach (var element in queueOfCustomerOrder)
                                Console.WriteLine($"{element.Name} sudah pesan {element.TotalCups} cups. urutan ke {element.Id}");
                        }
                        else
                        {
                            Console.WriteLine("Kosong");
                        }
                        break;
                    case "3":
                        if (queueOfCustomerOrder.Count > 0)
                        {
                            Console.WriteLine($"{queueOfCustomerOrder.Peek().Name}'s pesanan masih dibikin ");
                        }
                        else
                        {
                            Console.WriteLine("kosong");
                        }
                        break;
                    case "4":
                        if (queueOfCustomerOrder.Count > 0)
                        {
                            Console.WriteLine($"{queueOfCustomerOrder.Peek().Name}'s pesanan siap ");
                            queueOfCustomerOrder.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("kosong");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            Console.ReadKey();                
                Console.Clear();
            }

            Console.ReadKey();
        }
    }
}
