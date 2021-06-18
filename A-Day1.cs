using System;
using System.Collections.Generic;

namespace A_Day
{
    class Member
    {
        public class Classmate
        {
            public string Fname { get; set; }
            public string Lname { get; set; }
            public Boolean Gender { get; set; }
            public DateTime DoB { get; set; }
            public int Phone { get; set; }
            public string Place { get; set; }
            public byte Age { get; set; }
            public Boolean Gradated { get; set; }

        }
        static void Main(string[] args)
        {
            Classmate cm1 = new Classmate(){
                Fname = "Dao",
                Lname = "Tuan",
                Gender = true,
                DoB = new DateTime(1999, 03, 11),
                Phone = 0329865444,
                Place = "Ha Noi",
                Age = 22,
                Gradated = true
            };
            Classmate cm2 = new Classmate(){
                Fname = "Le",
                Lname = "Ha",
                Gender = false,
                DoB = new DateTime(2000, 03, 11),
                Phone = 0329865444,
                Place = "Ha Nam",
                Age = 22,
                Gradated = false
            };
            Classmate cm3 = new Classmate(){
                Fname = "Nguyen",
                Lname = "Phong",
                Gender = true,
                DoB = new DateTime(2001, 03, 11),
                Phone = 0329865444,
                Place = "Ha Tinh",
                Age = 22,
                Gradated = false
            };
            Classmate cm4 = new Classmate(){
                Fname = "Tran",
                Lname = "Thuy",
                Gender = false,
                DoB = new DateTime(2001, 04, 11),
                Phone = 0329865444,
                Place = "Ha Noi",
                Age = 22,
                Gradated = false
            };
            Classmate cm5 = new Classmate(){
                Fname = "Ngo",
                Lname = "Huy",
                Gender = true,
                DoB = new DateTime(1998, 06, 21),
                Phone = 0329865444,
                Place = "Ha Noi",
                Age = 22,
                Gradated = true
            };

            List<Classmate> listClassmate = new List<Classmate>();
            Console.WriteLine("Classmates");
            
            listClassmate.Add(cm1);
            listClassmate.Add(cm2);
            listClassmate.Add(cm3);
            listClassmate.Add(cm4);
            listClassmate.Add(cm5);

            //listClassmate.AddRange(listClassmate);
            foreach (Classmate cm in listClassmate)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",
                    cm.Fname, cm.Lname, cm.Gender, cm.DoB, cm.Phone, cm.Place, cm.Age, cm.Gradated );
            }
            Console.WriteLine();
            
            Console.WriteLine("Male");
            foreach (Classmate cm in listClassmate)
            {
                if(cm.Gender  == true){
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",
                    cm.Fname, cm.Lname, cm.Gender, cm.DoB, cm.Phone, cm.Place, cm.Age, cm.Gradated );
                }
            }
            Console.WriteLine();

            Console.WriteLine("Full name");

            foreach (Classmate cm in listClassmate)
            {
                Console.WriteLine(" {0} {1} ",
                    cm.Fname, cm.Lname);
            }
            Console.WriteLine();

            Console.WriteLine("Lists Year");
            Console.WriteLine("1: Year = 2000");
            Console.WriteLine("2: Year > 2000");
            Console.WriteLine("3: Year < 2000");
            Console.WriteLine();

            string input = Console.ReadLine();

            switch (input)
            {
                case "1": 
                    Console.WriteLine("DoB = 2000");
                    foreach (Classmate cm in listClassmate)
                    {
                        if(cm.DoB.Year  == 2000){
                        Console.WriteLine("{0}, {1}, {2}, {3}",
                            cm.Fname, cm.Lname, cm.Gender, cm.DoB );
                        }
                    }
                    Console.WriteLine();
                    break;

                case "2":
                    Console.WriteLine("DoB > 2000");
                    foreach (Classmate cm in listClassmate)
                    {
                        if(cm.DoB.Year  > 2000){
                        Console.WriteLine("{0}, {1}, {2}, {3}",
                            cm.Fname, cm.Lname, cm.Gender, cm.DoB );
                        }
                    }
                    Console.WriteLine();
                    break;

                case "3":
                    Console.WriteLine("DoB < 2000");
                    foreach (Classmate cm in listClassmate)
                    {
                        if(cm.DoB.Year  < 2000){
                        Console.WriteLine("{0}, {1}, {2}, {3}",
                            cm.Fname, cm.Lname, cm.Gender, cm.DoB );
                        }
                    }
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine(" You did not type a or b");
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
            }

            Console.WriteLine("1st born in Ha Noi");

            int i = 1;
            
                foreach (Classmate cm in listClassmate){
                    while(i == 1){
                    if(cm.Place  == "Ha Noi"){
                        Console.WriteLine("{0}, {1}, {2}, {3}",
                            cm.Fname, cm.Lname, cm.DoB, cm.Place);
                        i++; 
                        }
                    } 
                }     
                
            Console.WriteLine();
        }

    }
}
