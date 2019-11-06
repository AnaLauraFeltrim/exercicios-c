using System;

namespace Par_ou_impar {
    class Program {
        static void Main (string[] args) {

            int num1 = 0;

            List<int> listaPar = new List<int> ();
            List<int> listaImpar = new List<int> ();

            do {

                Console.Write ("Insira o número ou 0 para terminar: ");
                num1 = int.Parse (Console.ReadLine ());

                if (num1 % 2 == 0) {
                    listaPar.Add ();
                    foreach (var item in listaPar) {
                        Console.WriteLine ("O número é par");
                        System.Console.WriteLine(item);
                    }

                } else {
                    foreach(var item in listaImpar){
                        Console.WriteLine ("O número é impar");
                        System.Console.WriteLine(item);
                    }
                    
                }

            } while (num1 != 0);

        }
    }
}