public class Program
{
    /// <summary>
    /// Question 2
    /// </summary>
    public static void Main(string[] args)
    {
        //#2 Take a user’s input number and input its multiplication table. The user can choose how high to multiply by.

        //Ask player to pick a number
        Console.Write("Pick a number: ");
        int numb = Convert.ToInt16(Console.ReadLine());

        //Ask players to choose a max number
        Console.Write("Pick a max number: ");
        int maxNumb = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(Environment.NewLine);

        //For Loop used to create multiplication table

        for (int i = 0; i <= maxNumb; i++)
        {
            Console.WriteLine(numb + " x " + i + " = " + (numb * i));
        }
    }
}