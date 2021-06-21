// using System;
// using System.Collections.Generic;

// namespace A_Day
// {
//     class Program
//     {
//         public class Member
//         {
//             public string FirstName { get; set; }
//             public string LastName { get; set; }
//             public Boolean Gender { get; set; }
//             public DateTime DateOfBirth { get; set; }
//             public int Phone { get; set; }
//             public string BirthPlace { get; set; }
//             public byte Age { get; set; }
//             public Boolean IsGradated { get; set; }

//         }
//         static void Main(string[] args)
//         {
//             Member member1 = new Member()
//             {
//                 FirstName = "Dao",
//                 LastName = "Tuan",
//                 Gender = true,
//                 DateOfBirth = new DateTime(1999, 03, 11),
//                 Phone = 0329865444,
//                 BirthPlace = "Ha Noi",
//                 Age = 22,
//                 IsGradated = true
//             };
//             Member member2 = new Member()
//             {
//                 FirstName = "Le",
//                 LastName = "Ha",
//                 Gender = false,
//                 DateOfBirth = new DateTime(2000, 03, 11),
//                 Phone = 0329865444,
//                 BirthPlace = "Ha Nam",
//                 Age = 20,
//                 IsGradated = false
//             };
//             Member member3 = new Member()
//             {
//                 FirstName = "Nguyen",
//                 LastName = "Phong",
//                 Gender = true,
//                 DateOfBirth = new DateTime(2001, 03, 11),
//                 Phone = 0329865444,
//                 BirthPlace = "Ha Tinh",
//                 Age = 27,
//                 IsGradated = false
//             };
//             Member member4 = new Member()
//             {
//                 FirstName = "Tran",
//                 LastName = "Thuy",
//                 Gender = false,
//                 DateOfBirth = new DateTime(2001, 04, 11),
//                 Phone = 0329865444,
//                 BirthPlace = "Ha Noi",
//                 Age = 25,
//                 IsGradated = false
//             };
//             Member member5 = new Member()
//             {
//                 FirstName = "Ngo",
//                 LastName = "Huy",
//                 Gender = true,
//                 DateOfBirth = new DateTime(1998, 06, 21),
//                 Phone = 0329865444,
//                 BirthPlace = "Ha Noi",
//                 Age = 24,
//                 IsGradated = true
//             };

//             List<Member> listMember = new List<Member>();
//             Console.WriteLine("Members");

//             listMember.Add(member1);
//             listMember.Add(member2);
//             listMember.Add(member3);
//             listMember.Add(member4);
//             listMember.Add(member5);

//             // get male member list
//             Console.WriteLine("1. Male members");
//             foreach (Member member in listMember)
//             {
//                 if (member.Gender == true)
//                 {
//                     Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",
//                         member.FirstName, member.LastName, member.Gender, member.DateOfBirth, member.Phone, member.BirthPlace, member.Age, member.IsGradated);
//                 }
//             }
//             Console.WriteLine();

//             // get oldest member
//             Console.WriteLine("2. Oldest member");
//             Member oldest = member1;
//             foreach (Member member in listMember)
//             {
//                 if (oldest.Age < member.Age)
//                 {
//                     oldest = member;
//                     Console.WriteLine(" {0} {1} {2} ",
//                         oldest.FirstName, oldest.LastName, oldest.Age);
//                 }

//             }
//             Console.WriteLine();

//             //  get full name
//             Console.WriteLine("3. Full name");

//             foreach (Member member in listMember)
//             {
//                 Console.WriteLine(" {0} {1} ",
//                     member.FirstName, member.LastName);
//             }
//             Console.WriteLine();

//             //  get list
//             Console.WriteLine("4. Lists Year");
//             Console.WriteLine(" 1: Year = 2000");
//             Console.WriteLine(" 2: Year > 2000");
//             Console.WriteLine(" 3: Year < 2000");
//             Console.WriteLine();

//             int input = Convert.ToInt32(Console.ReadLine());

//             switch (input)
//             {
//                 case 1:
//                     Console.WriteLine("DateOfBirth = 2000");
//                     foreach (Member member in listMember)
//                     {
//                         if (member.DateOfBirth.Year == 2000)
//                         {
//                             Console.WriteLine("{0}, {1}, {2}, {3}",
//                                 member.FirstName, member.LastName, member.Gender, member.DateOfBirth);
//                         }
//                     }
//                     Console.WriteLine();
//                     break;

//                 case 2:
//                     Console.WriteLine("DateOfBirth > 2000");
//                     foreach (Member member in listMember)
//                     {
//                         if (member.DateOfBirth.Year > 2000)
//                         {
//                             Console.WriteLine("{0}, {1}, {2}, {3}",
//                                 member.FirstName, member.LastName, member.Gender, member.DateOfBirth);
//                         }
//                     }
//                     Console.WriteLine();
//                     break;

//                 case 3:
//                     Console.WriteLine("DateOfBirth < 2000");
//                     foreach (Member member in listMember)
//                     {
//                         if (member.DateOfBirth.Year < 2000)
//                         {
//                             Console.WriteLine("{0}, {1}, {2}, {3}",
//                                 member.FirstName, member.LastName, member.Gender, member.DateOfBirth);
//                         }
//                     }
//                     Console.WriteLine();
//                     break;

//                 default:
//                     Console.WriteLine(" You did not type a number");
//                     Console.WriteLine();
//                     Console.ReadLine();
//                     break;
//             }

//             //  get 1st born in Ha Noi
//             Console.WriteLine("5. 1st born in Ha Noi");

//             int i = 1;

//             foreach (Member member in listMember)
//             {
//                 while (i == 1)
//                 {
//                     if (member.BirthPlace == "Ha Noi")
//                     {
//                         Console.WriteLine("{0}, {1}, {2}, {3}",
//                             member.FirstName, member.LastName, member.DateOfBirth, member.BirthPlace);
//                         i++;
//                     }
//                 }
//             }

//             Console.WriteLine();
//         }

//     }
// }
