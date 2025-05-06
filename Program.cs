List<int> lista = new List<int>();

System.Console.WriteLine("Quantos alunos possui no curso A?");
int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    int x = int.Parse(Console.ReadLine());
    if (!lista.Contains(x))
    {
        lista.Add(x);
    }
}

System.Console.WriteLine("Quantos alunos possui no curso B?");
int b = int.Parse(Console.ReadLine());
for (int i = 0; i < b; i++)
{
    int y = int.Parse(Console.ReadLine());
    if (!lista.Contains(y))
    {
        lista.Add(y);
    }
}

System.Console.WriteLine("Quantos alunos possui no curso C?");
int c = int.Parse(Console.ReadLine());
for (int i = 0; i < c; i++)
{
    int z = int.Parse(Console.ReadLine());
    if (!lista.Contains(z))
    {
        lista.Add(z);
    }
}

System.Console.WriteLine("TOTAL DE ALUNOS:");
System.Console.WriteLine(lista.Count);