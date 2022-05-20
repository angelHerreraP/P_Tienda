using System;
namespace Tienda_Virtual
{
    public class Convert_To_Lower
    {
        string usrInput;
        public string makeLower(string input)
        {
            usrInput = input.ToLower();
            return usrInput;
        }
    }
}
