namespace Dotnet_Day6
{
    internal class InterfaceTesterBase
    {
        public static void Main()
        {
            //  ICustomer ic; //creating an interface object
            // ic = new ICustomer(); //cannot instantiate an interface

            Customer cust = new Customer();
            cust.PrintCustRating();

            InterfaceTester itester = new InterfaceTester();
            itester.getRating();
            itester.PrintCustRating();
            Console.Read();
        }
    }
}