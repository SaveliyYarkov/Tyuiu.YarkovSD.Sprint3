using Tyuiu.YarkovSD.Sprint3.Task3.V12.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string a = Console.ReadLine();
        char s = Console.ReadLine().ToCharArray()[0];
        Console.WriteLine(ds.GetMaxCharCount(a, s));
        Console.ReadKey();
    }
}