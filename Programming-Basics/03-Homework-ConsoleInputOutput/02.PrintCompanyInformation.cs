using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string companyFaxNumber = Console.ReadLine();  
        Console.Write("Web site: ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone: ");
        string managerPhoneNumber = Console.ReadLine();
        Console.Clear();

        Console.WriteLine(companyName);
        Console.WriteLine("Adress: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhoneNumber);
        if (String.IsNullOrWhiteSpace(companyFaxNumber))
        {
            companyFaxNumber = "(no fax)";
        }
        Console.WriteLine("Fax: {0}", companyFaxNumber);
        Console.WriteLine("Web site: {0}", companyWebSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhoneNumber);

    }
}