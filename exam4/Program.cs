int n=Convert.ToInt32(Console.ReadLine());
var arr=new int[n];

for (int i = 0; i < n; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
Array.Sort(arr);
int count=1;
for (int i = 0; i < n-1; i++)
{
    if (arr[i]!=arr[i+1])
    {
        count++;
    }
}
System.Console.WriteLine(count);