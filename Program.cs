﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AddressBook Adr= new AddressBook();
            Adr.createUser();
            Adr.editContact();
            Adr.printUser();

        }
    }
}
