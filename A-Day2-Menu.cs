using System;
using System.Collections.Generic;
using System.Linq;

namespace A_Day
{
    class Menu : Member
    {
        public List<Member> membersList = new List<Member>();
        public void listMember()
        {
            Console.WriteLine("Members");

            membersList.Add(new Member { FirstName = "Ngo", LastName = "Huy", Gender = true, DateOfBirth = new DateTime(1998, 06, 21), Phone = 0329865444, BirthPlace = "Ha Noi", Age = 24, IsGradated = true });
            membersList.Add(new Member { FirstName = "Tran", LastName = "Thuy", Gender = false, DateOfBirth = new DateTime(2001, 04, 11), Phone = 0329865444, BirthPlace = "Ha Noi", Age = 25, IsGradated = false });
            membersList.Add(new Member { FirstName = "Nguyen", LastName = "Phong", Gender = true, DateOfBirth = new DateTime(2001, 03, 11), Phone = 0329865444, BirthPlace = "Ha Tinh", Age = 27, IsGradated = false });
            membersList.Add(new Member { FirstName = "Le", LastName = "Ha", Gender = false, DateOfBirth = new DateTime(2000, 03, 11), Phone = 0329865444, BirthPlace = "Ha Nam", Age = 20, IsGradated = false });
            membersList.Add(new Member { FirstName = "Dao", LastName = "Tuan", Gender = true, DateOfBirth = new DateTime(1999, 03, 11), Phone = 0329865444, BirthPlace = "Ha Noi", Age = 22, IsGradated = true });

            foreach (var member in membersList)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",
                    member.FirstName, member.LastName, member.Gender, member.DateOfBirth, member.Phone, member.BirthPlace, member.Age, member.IsGradated);
            }
            Console.WriteLine();
        }

        // get male member list
        public void GetMaleList()
        {
            Console.WriteLine("1. Male members");

            var maleMemberList = (from gendermale in membersList where gendermale.Gender == true select gendermale.FirstName + " " + gendermale.LastName + " Male ").ToList();
            foreach (var gender in maleMemberList)
            {
                Console.WriteLine(gender);
            }
            Console.WriteLine();
        }

        // get oldest member
        public void GetOldestMember()
        {
            Console.WriteLine("2. Oldest member");
            var oldestAge = (from oldest in membersList select " Age " + oldest.Age + " : " + oldest.FirstName + " " + oldest.LastName).Max();
            Console.WriteLine(oldestAge);
            Console.WriteLine();
        }

        //  get full name
        public void GetFullNameList()
        {

            Console.WriteLine("3. Full name list");

            List<string> ListFullname = new List<string>();
            ListFullname = (from name in membersList select name.FirstName + " " + name.LastName).ToList();
            foreach (var fulName in ListFullname)
            {
                Console.WriteLine(fulName);
            }
            Console.WriteLine();
        }

        //  get list
        public void GetAgeList()
        {
            Console.WriteLine("4. Lists Year");
            Console.WriteLine(" 1: Year = 2000");
            Console.WriteLine(" 2: Year > 2000");
            Console.WriteLine(" 3: Year < 2000");
            Console.WriteLine();
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("DateOfBirth = 2000");
                    var Is2000 = (from age2000 in membersList where age2000.DateOfBirth.Year == 2000 select age2000.FirstName + " " + age2000.LastName + " " + age2000.DateOfBirth).ToList();
                    foreach (var list in Is2000)
                    {
                        Console.WriteLine(list);
                    }
                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine("DateOfBirth > 2000");
                    var moreThan2000 = (from age2000 in membersList where age2000.DateOfBirth.Year > 2000 select age2000.FirstName + " " + age2000.LastName + " " + age2000.DateOfBirth).ToList();
                    foreach (var list in moreThan2000)
                    {
                        Console.WriteLine(list);
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine("DateOfBirth < 2000");
                    var lessThan2000 = (from age2000 in membersList where age2000.DateOfBirth.Year < 2000 select age2000.FirstName + " " + age2000.LastName + " " + age2000.DateOfBirth).ToList();
                    foreach (var list in lessThan2000)
                    {
                        Console.WriteLine(list);
                    }
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine(" You did not type a number");
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
            }
        }

        //  get 1st born in Ha Noi
        public void GetFirstBornInHanoi()
        {

            Console.WriteLine("5. 1st born in Ha Noi");

            var _1stBornInHN = (from _1stBorn in membersList where _1stBorn.BirthPlace == "Ha Noi" select _1stBorn.FirstName + " " + _1stBorn.LastName + " - " + _1stBorn.BirthPlace).First();

            Console.WriteLine(_1stBornInHN);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Menu member = new Menu();
            member.listMember();
            member.GetMaleList();
            member.GetOldestMember();
            member.GetFullNameList();
            member.GetAgeList();
            member.GetFirstBornInHanoi();

        }
    }
}