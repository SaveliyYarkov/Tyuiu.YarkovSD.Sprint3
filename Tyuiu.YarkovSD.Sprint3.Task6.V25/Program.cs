using Tyuiu.YarkovSD.Sprint3.Task6.V25.Lib;

DataService ds = new DataService();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ds.GetSumSumSeries(a, b));
Console.ReadKey();
