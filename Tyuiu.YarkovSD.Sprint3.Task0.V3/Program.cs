using Tyuiu.YarkovSD.Sprint3.Task0.V3.Lib;

DataService ds = new DataService();
int a = (int)Convert.ToInt32(Console.ReadLine());
int b = (int)Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ds.GetSumSeries(a, b));
