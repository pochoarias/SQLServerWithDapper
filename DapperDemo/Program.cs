using DapperDemo.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace DapperDemo
{
    public class Program
    {
        private const string EXIT_COMMAND = "q";

        static void Main(string[] args)
        {
            PersonService _personService = new PersonService();
            PrinterService _printerService = new PrinterService();

            Console.WriteLine("*****************");
            Console.WriteLine("Init Application");
            Console.WriteLine("*****************");

            var commands = new string[]{ "GetPeople", "GetByLastName", "GetByLastNameByStoreProcedure", "InsertNewPerson" };

            bool EXIT = false;
            while (!EXIT)
            {
                Console.WriteLine($"Commands:[{string.Join(",", commands)}]");
                Console.WriteLine("Input command:");


                var console = Console.ReadLine();
                if (string.IsNullOrEmpty(console) || console == EXIT_COMMAND) {
                    return;
                }

                if(console == "GetPeople")
                {
                   var output =  _personService.GetPeople();
                    _printerService.PersonPrinter(output);
                }

                if (console == "GetByLastName")
                {
                    Console.WriteLine("Input Last Name:");
                    var lastName = Console.ReadLine();
                    var output = _personService.GetByLastName(lastName);
                    _printerService.PersonPrinter(output);
                }

                if (console == "GetByLastNameByStoreProcedure")
                {
                    Console.WriteLine("Input Last Name:");
                    var lastName = Console.ReadLine();
                    var output = _personService.GetByLastName(lastName);
                    _printerService.PersonPrinter(output);
                }

                if (console == "InsertNewPerson")
                {
                    Console.WriteLine("Input First Name:");
                    var firstName = Console.ReadLine();
                    Console.WriteLine("Input Last Name:");
                    var lastName = Console.ReadLine();
                    _personService.InsertNewPerson(firstName, lastName);

                }

                Console.WriteLine("*****************");

            }

            Console.WriteLine("*****************");
            Console.WriteLine("End Application");
            Console.WriteLine("*****************");
        }


    }
}
