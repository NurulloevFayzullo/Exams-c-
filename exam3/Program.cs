int n=int.Parse(Console.ReadLine());
int[] arr=new int[n];
for (int i = 0; i < n; i++)
{
    arr[i]=int.Parse(Console.ReadLine());
}
var list=new List<int>();
for (int i = 0; i < n-1; i+=2)
{
    list.Add(arr[i+1]);
    list.Add(arr[i]);
}
System.Console.WriteLine("--------------------------------");
foreach (var item in list)
{
    System.Console.Write($"{item} ");
}