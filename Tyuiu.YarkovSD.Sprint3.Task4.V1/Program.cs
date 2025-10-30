using Tyuiu.YarkovSD.Sprint3.Task4.V1.Lib;

DataService ds = new DataService();
int a = Convert.ToInt32(Console.ReadLine());
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ds.Calculate(a, s));
Console.ReadKey();