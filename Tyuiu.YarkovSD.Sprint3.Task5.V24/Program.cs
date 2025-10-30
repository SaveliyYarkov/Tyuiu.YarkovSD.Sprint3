using Tyuiu.YarkovSD.Sprint3.Task5.V24.Lib;

DataService ds = new DataService();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
int e = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ds.Calculate(a, b, c, d, e));
Console.ReadKey();
