using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Neighboor> floorNeighboor = new List<Neighboor>();
            floorNeighboor.Add(new Neighboor() { FullName = "Ivanov", FlatNumber = 30, PhoneNumber = 1111111 });
            floorNeighboor.Add(new Neighboor() { FullName = "Petrov", FlatNumber = 31, PhoneNumber = 2222222 });
            floorNeighboor.Add(new Neighboor() { FullName = "Sidorov", FlatNumber = 32, PhoneNumber = 3333333 });
            floorNeighboor.Add(new Neighboor() { FullName = "Sobolev", FlatNumber = 33, PhoneNumber = 4444444 });
            floorNeighboor.Add(new Neighboor() { FullName = "Pupkin", FlatNumber = 34, PhoneNumber = 5555555 });

            //Dictionary<int, string> floorNeighboor = new Dictionary<int, string>();
            //floorNeighboor.Add(30, "Ivanov");
            //floorNeighboor.Add(31, "Petrov");
            //floorNeighboor.Add(32, "Sidorov");
            //floorNeighboor.Add(33, "Sobolev");
            //floorNeighboor.Add(34, "Pupkin");

            Console.WriteLine("Write flat's number: ");
            var flat = Convert.ToInt32(Console.ReadLine());

            if (flat==31)
            {
                Console.WriteLine("It's my flat");
            }
            else
            {
                foreach (var florNeighboor in floorNeighboor)
                {

                    if (flat == florNeighboor.FlatNumber)

                    {
                        Console.WriteLine($"{florNeighboor.FlatNumber}, {florNeighboor.PhoneNumber}, {florNeighboor.FullName}");

                    }
                }
            }

            //foreach (KeyValuePair<int, string> florNeighboor in floorNeighboor)
            //{

            //    switch (flat)
            //    {
            //        case 30:
            //            {
            //                Console.WriteLine(c);
            //                break;
            //            }
            //        case 31:
            //            {
            //                Console.WriteLine(floorNeighboor[31]);
            //                break;
            //            }
            //        case 32:
            //            {
            //                Console.WriteLine(floorNeighboor[32]);
            //                break;
            //            }
            //        case 33:
            //            {
            //                Console.WriteLine(floorNeighboor[33]);
            //                break;
            //            }
            //        case 34:
            //            {
            //                Console.WriteLine(floorNeighboor[30]);
            //                break;
            //            }
            //        default:
            //            {
            //                Console.WriteLine("Your flat number isn't correct");
            //            }
            //            break;
            //    }
            //    break;

            
           
            
            //}



            Console.ReadKey();
        }
    }
    class Neighboor
    {
        public string FullName { get; set; }
        public int FlatNumber { get; set; }
        public int PhoneNumber { get; set; }
    }
}
    