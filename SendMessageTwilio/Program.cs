using System;

namespace SendMessageTwilio
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine($" Id : {person.Id} \n" +
                $" Name : {person.Name} \n" +
                $" Age : {person.Age} \n" +
                $" Salary : {person.Salary} \n" +
                $" Phone Number : {person.PhoneNumber} \n" +
                $" Created At : {person.CreatedAt}");

            person.SendMessage();

            Console.WriteLine("Enter the Code : ");
            person.VervicationCode = Console.ReadLine();

            if(person.VervicationCode == Person.bodyMsg)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Sorry verfication code is incorrect");
            }


            Console.ReadKey();
        }
    }
}
