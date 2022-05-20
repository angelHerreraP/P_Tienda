using System;
namespace Tienda_Virtual
{
    public class BuyingProcess
    {
        string getProductName = null;
        string getProductCode = null;
        double getProductPrice;
        int getNumToInt;

        public int getQuantity()
        {
            Console.WriteLine("How many?");
            string getNum = Console.ReadLine();
            int getNumToInt = Convert.ToInt16(getNum);
            return getNumToInt;
        }

        public double doMath(int getNumToInt, double getProductPrice )
        {
            double bill = getNumToInt * getProductPrice;
            Console.WriteLine(bill);
            return bill;

        }



    }
}
