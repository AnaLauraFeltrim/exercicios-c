using System;

namespace _bdfdrzsg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c, l, y;
       Console.WriteLine("Digite a quantidade de triangulos: ");
       y = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o Tamanho: ");
       n = int.Parse(Console.ReadLine());
        

       for (l=1;l<=n;l++) {
        for(c=1;c<=l;c++)
         Console.Write("*");
       Console.Write("\n");
       }
       if(y>1){
           for (l=1;l<=n;l++) {
            for(c=1;c<=l;c++)
            Console.Write("*");
            Console.Write("\n");
       }
       }
        }
    }
}
