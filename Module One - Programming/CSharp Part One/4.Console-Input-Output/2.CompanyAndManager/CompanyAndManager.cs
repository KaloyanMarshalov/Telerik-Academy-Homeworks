using System;

//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. Write a program that reads the 
//information about a company and its manager and prints it back on the console.

namespace _2.CompanyAndManager
{
    class CompanyAndManager
    {
        static void Main()
        {
            Console.Write("Enter Company Name: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter Company Adress: ");
            string companyAdress = Console.ReadLine();
            Console.Write("Enter Company Phone number: ");
            int companyPhone = int.Parse(Console.ReadLine());
            Console.Write("Enter Company Fax number: ");
            int companyFax = int.Parse(Console.ReadLine());
            Console.Write("Enter Company Web site: ");
            string companySite = Console.ReadLine();
            Console.Write("Enter Manager's First Name: ");
            string managerFName = Console.ReadLine();
            Console.Write("Enter  Manager's Last Name: ");
            string managerLName = Console.ReadLine();
            Console.Write("Enter Manager's Age: ");
            int managerAge = int.Parse(Console.ReadLine());
            Console.Write("Enter Manager's Phone number: ");
            int managerPhone = int.Parse(Console.ReadLine());

            Console.WriteLine("The company {0} is located {1}. For contacts: Phone - {2}, Fax - {3}, Web site - {4}", 
                                companyName, companyAdress, companyPhone, companyFax, companySite);
            Console.WriteLine("The company's manager is {0} {1}. He/She is {2} years old. Phone number: {3}",
                                managerFName, managerLName, managerAge, managerPhone);
        }
    }
}
