//variant 1
int result = 0;
for (int i = 1; i <= 100; i++)
{
    result += i;
}
Console.WriteLine(result);

//variant 2
int result2 = 0;
int s = 100;
while (s>0)
{
    result2 += s;
    s--;
}
Console.WriteLine(result2);

//variant 3
int sum(int a)
{
    if (a==0)
    {
        return 0;
    }
    else
    {
        return a+=sum(a-1);
    }
}

Console.WriteLine(sum(100));