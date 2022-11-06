using System;
using System.Collections.Generic;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SendMessageTwilio
{
    public class Person
    {
        public static string bodyMsg = Guid.NewGuid().ToString("N").Substring(0, 5);
        public Guid Id { get; set; }
        public string  Name { get; set; }
        public int Age { get; set; }
        public double  Salary { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public string  VervicationCode { get; set; }

        public Person()
        {
            this.Id = Guid.NewGuid();
            Console.WriteLine("Enter your Name : ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter your Age : ");
            this.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Salary : ");
            this.Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your PhoneNumber : ");
            this.PhoneNumber = Console.ReadLine();
            this.CreatedAt = DateTime.Now;
            //Console.Clear();
        }
        public void SendMessage()
        {
            TwilioClient.Init("sid", "token");

            var message = MessageResource.Create(
                body: bodyMsg,
                from: new Twilio.Types.PhoneNumber("+15617824386"),
                to: new Twilio.Types.PhoneNumber(this.PhoneNumber)
            );
            
            //Console.WriteLine(message.Sid);

        }
    }
}
