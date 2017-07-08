using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class AddressBook
    {
        private Person[] personList = new Person[100];
        private int pCount = 0; //count how many person in the database
    }
    class Program :Person
    {
        static void Main(string[] args)
        {
            AddressBook app = new AddressBook();

            while(true)
            {
                ask();
                int input =Convert.ToInt32(Console.ReadLine());

                switch(input)
                {
                    case 1:
                        {
                            insert();
                            break;
                        }
                    case 2: break;

                    case 3: break;

                    case 4: break;
                    
                    case 5: break;
                    
                    case 6: break;
                    
                    case 7: break;

                }

            }

        }
        static void ask()
        {
            Console.WriteLine("School Database Menu, Please select down below");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Search(name)");
            Console.WriteLine("4. Print ");
            Console.WriteLine("5. Read File");
            Console.WriteLine("6. Save File");
            Console.WriteLine("7. Program Exit");
        }
        static void insert()
        {
            Console.WriteLine("1.Professor 2.Faculty 3.Student");


            while(true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if(num==1)
                {
                    Console.WriteLine("Please enter your :");
                    Console.WriteLine("Id, name, address, department, office, major");
                    String prof = Console.ReadLine();


                }else if(num==2)
                {

                }else if(num==3)
                {

                }else
                {
                    Console.WriteLine("Worng number, Please rewrite");

                }
            }
        }

    }
}
