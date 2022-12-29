Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());

int Summary (int N, int M)
{
    if (M == 0) 
    {
        return (N * (N + 1)) / 2; 
    }
    else if (N == 0)
    {
        return (M * (M + 1)) / 2;
    }
    else if (M == N) 
    {
        return M;
    }
    else if (M < N)
    {
        return N + Summary(M, N - 1);
    }
    else
    {
        return N + Summary(M, N + 1);
    }
}
Console.WriteLine(Summary(N, M));