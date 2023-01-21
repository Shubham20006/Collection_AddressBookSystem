using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        public static List<Person> People = new List<Person>();
        public void createUser()
        {
            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            person.Address = Console.ReadLine();

            Console.Write("Enter City : ");
            person.City = Console.ReadLine();

            Console.Write("Enter State : ");
            person.State = Console.ReadLine();

            Console.Write("Enter ZipCode: ");
            person.ZipCode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNum = Console.ReadLine();

            Console.Write("Enter EmailId: ");
            person.EmailId = Console.ReadLine();

            People.Add(person);
        }
        public void printUser()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current {0} people in your address book:\n",People.Count);
            foreach (var person in People )
            {
                Console.WriteLine("**** Peoples present in list are : ");
                Console.WriteLine(" FirstName: {0},\n LastName: {1},\n Adress: {2},\n City : {3},\n State: {4},\n Zip: {5},\n PhoneNum: {6},\n Email: {7}", person.FirstName, person.LastName, person.Address, person.City, person.State, person.ZipCode, person.PhoneNum, person.EmailId);
            }
        }
        
    }
}
