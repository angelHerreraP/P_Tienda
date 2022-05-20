using System;
namespace Tienda_Virtual
{
    public class UsrLogin
    {
        Convert_To_Lower usrToLower = new Convert_To_Lower();
        string usrLower = null;
        private string usrName;
        private string usrLastName;
        private string usrEmail;
        private string usrAge;
        private string usrDirection;

        private string usrPhoneNum;

        public string getName()
        {
            Console.WriteLine("Write your name:");
            usrName = Console.ReadLine();
            usrLower = usrToLower.makeLower(usrName);
            return usrLower;

        }

        public string getLastName()
        {
            Console.WriteLine("Write your Last Name:");
            usrLastName = Console.ReadLine();
            usrLower = usrToLower.makeLower(usrLastName);
            return usrLower;
        }

        public string getEmail()
        {
            Console.WriteLine("Write your email:");
            usrEmail = Console.ReadLine();
            usrLower = usrToLower.makeLower(usrEmail);
            return usrLower;
        }

        public string getPhoneNum()
        {
            Console.WriteLine("Write your Phone Number:");
            usrPhoneNum = Console.ReadLine();
            usrLower = usrToLower.makeLower(usrPhoneNum);
            return usrLower;
        }

        public string getAge()
        {
            Console.WriteLine("Write your Age:");
            usrAge = Console.ReadLine();
            usrLower = usrToLower.makeLower(usrAge);
            return usrLower;
        }

        public string getDirection()
        {
            Console.WriteLine("Write your direction:");
            usrDirection = Console.ReadLine();
            usrLower = usrToLower.makeLower(usrDirection);
            return usrLower;
        }
    }
}
