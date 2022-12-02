class Question4
{
    /// <summary>
    /// Question 4
    /// </summary>
    static void Main(string[] args)
    {
        int action = 0;

        Console.WriteLine("Enter the action to be performed");
        Console.WriteLine("Press 1 for Addition");
        Console.WriteLine("Press 2 for Subtraction");
        Console.WriteLine("Press 3 for Multiplication");
        Console.WriteLine("Press 4 for Division");
        Console.WriteLine("Press 5 for Modulus");
        Console.WriteLine("Press 6 to Exit \n");
        action = Convert.ToInt32(Console.ReadLine());

        //#4
        while (action != 6)
        {
            if (action == 6)
            { return; }
            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                case 5:
                    {
                        result = Modulus(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division (rounded)");
            Console.WriteLine("Press 5 for Modulus");
            Console.WriteLine("Press 6 to Exit \n");
            action = Convert.ToInt32(Console.ReadLine());
        }
    }

    //Addition  
    public static int Addition(int input_1, int input_2)
    {
        int result = input_1 + input_2;
        return result;
    }
    //Substraction  
    public static int Subtraction(int input_1, int input_2)
    {
        int result = input_1 - input_2;
        return result;
    }
    //Multiplication  
    public static int Multiplication(int input_1, int input_2)
    {
        int result = input_1 * input_2;
        return result;
    }
    //Division  
    public static int Division(int input_1, int input_2)
    {
        int result = input_1 / input_2;
        return result;
    }
    //Modulus  
    public static int Modulus(int input_1, int input_2)
    {
        int result = input_1 % input_2;
        return result;
    }
}