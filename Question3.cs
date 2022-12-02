using ConsoleTables;

public class Question3
{
    /// <summary>
    /// Question 3
    /// </summary>
    public static void Main(string[] args)
    {
        // Question # 3
        int row = 0;
        ConsoleTable table = new ConsoleTable("Type", "Byte(s) of memory", "Min", "Max");
        table.AddRow("sbyte", "1", "-128", "127");
        table.AddRow("byte", "1", "0", "255");
        table.AddRow("short", "2", "-32768", "32767");
        table.AddRow("ushort", "2", "0", "65535");
        table.AddRow("int", "4", "-2147483648", "2147483647");
        table.AddRow("uint", "4", "0", "4294967295");
        table.AddRow("long", "8", "-9223372036854775808", "9223372036854775807");
        table.AddRow("ulong", "8", "0", "18446744073709551615");
        table.AddRow("float", "4", "-3.4028235E+38", "3.4028235E+38");
        table.AddRow("double", "8", "-1.7976931348623157E+308", "1.7976931348623157E+308");
        table.AddRow("decimal", "16", "-79228162514264337593543950335", "79228162514264337593543950335");

        Console.WriteLine(table);
    }
}