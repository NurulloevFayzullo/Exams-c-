int n=Convert.ToInt32(Console.ReadLine());
var arr=new List<string>();

for (int i = 0; i < n; i++)
{
    arr.Add(Console.ReadLine());
}
System.Console.WriteLine("--------------------------------");
foreach (var item in arr)
{
    System.Console.WriteLine(item);
}