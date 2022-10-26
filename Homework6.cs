internal class Program
{
    private static void Main(string[] args)
    /**       
*--------------------------------------------------------------------
*        File name: {Lab6}
*     Project name: {Homework6}
*--------------------------------------------------------------------
* Author’s name and email:     {Ciara Kelley, Kelleyc1@etsu.edu}                
*          Course-Section: {1250-001}
*           Creation Date:     {10/25/26}        
* -------------------------------------------------------------------
* I worked with my brother and sister on this lab and it was getting late so we parted ways, only for me to later realize the last two methods aren't working
* I don't know why completely, something to do with the arguments. I took what was the recommended to "fix" it which is why the unhandled exception
* is there. Not sure what's going on, but definitely didn't want to take a 0 on this.
*/

    {

        ShowCharacter("Werewolf", 5);
        CalculateRetail();
        Celsius();
        IsPrime();
        static void ShowCharacter(string s, int x)
        {
            x = x - 1;
            Console.Write(s[x]);
            Console.WriteLine("\n");
        }

        static void CalculateRetail()
        {
            Console.WriteLine("Please enter the price of the item: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the markup percentage: ");
            double markup = Convert.ToDouble(Console.ReadLine());
            double markupAsDecimal = markup / 100;
            double total = (price * markupAsDecimal) + price;
            Console.Write(total);
            Console.WriteLine("\n");
        }


    }
    static bool IsPrime(int bob)
    {
        if (bob <= 1) {Console.WriteLine("False"); return false;}
        for (int i = 2; i < Math.Sqrt(bob); i++)
        {
            if (bob % i == 0) {Console.WriteLine("False"); return false;}
        }
        Console.WriteLine("True");
        return true;
    }
    private static void IsPrime()
    {
        throw new NotImplementedException();
    }

    static double Celsius(int f)
    {
        Console.WriteLine("Please enter the temperature in Farenheit: ");
        double celsius = (f - 32.0) * (5.0 / 9.0);
        return celsius;

    }
    private static void Celsius()
    {
        throw new NotImplementedException();
    }
}