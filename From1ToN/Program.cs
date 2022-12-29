Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int Subsequence (int N)
{
    if (N==1)
    {
        return N;
    }
    else
    {
        return 1 + Subsequence (N-1);
    }
}

for (int i = N; i >= 1; i--)
{
    Console.Write(Subsequence(i) + " ");
}