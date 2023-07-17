using System;

class Program
{
    public static void Main(string[] args)
    {
        int n, a;

        Console.Write("Quantos são os Alunos? ");
        n = Convert.ToInt32(Console.ReadLine());

        int[,] age = new int[n, 2];

        for(a = 0; a < n; a++)
        {
            Console.Write("Nº de Aluno: ");
            age[a,0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Idade do Aluno: ");
            age[a,1] = Convert.ToInt32(Console.ReadLine());
        }

        int cont = 0;

        for (a = 0; a < n; a++)
        {
            if (age[a, 1] > 25)
            {
                cont++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Existe " + cont + " aluno(s) com iade superior a 25 anos.");

    }
}