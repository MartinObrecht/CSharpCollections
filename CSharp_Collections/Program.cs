using System;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //Populando o array(existem outras formas)
            string[] aulas =
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };

            //Acessando o último item do array
            Console.WriteLine(aulas[aulas.Length - 1]);

            //Modificando um item do array
            aulas[0] = "Trabalhando com Arrays";
            Imprimir(aulas);

            //Acessando o primeiro ou último item de um array que satisfaz uma condição
            Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas, aulaModelando));
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

            //Revertendo a ordem do array
            Array.Reverse(aulas);
            Imprimir(aulas);

            //Redimensionando um array
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            //Ordenando um array
            Array.Sort(aulas);
            Imprimir(aulas);

            //Copiando um array
            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);

            //Clonando um array
            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);

            //Limpando arrays
            Array.Clear(clone, 1, 2);
            Imprimir(clone);



        }

        private static void Imprimir(string[] aulas)
        {
            Console.Clear();

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

        }
    }
}
