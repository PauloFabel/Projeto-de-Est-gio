using System;

namespace Gafanhotos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.notaProva = 10 ;
            
            Console.WriteLine("Hello World!");

            Console.WriteLine("Nome do Aluno :" + a1.notaProva);

        }
    }
}
