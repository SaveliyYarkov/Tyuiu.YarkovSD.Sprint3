using Tyuiu.YarkovSD.Sprint3.Task7.V21.Lib;

DataService ds = new DataService();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ds.GetMassFunction(a, b));
Console.ReadKey();