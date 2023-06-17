int n=Convert.ToInt32(Console.ReadLine());
int[] arr=new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(arr,1,arr.Length-2);
System.Console.WriteLine("--------------------------------");
for (int i = 1; i < arr.Length-1; i++)
{
    System.Console.WriteLine(arr[i]);
}