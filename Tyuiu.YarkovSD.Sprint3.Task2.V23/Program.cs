using Tyuiu.YarkovSD.Sprint3.Task2.V23.Lib;

DataService ds = new DataService();
int a = Convert.ToInt32(Console.ReadLine());
int s = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ds.GetSumSeries(a, s, d));
Console.ReadKey();