using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace teste1
{
    class Program

        // FAZER TRATAMENTO DAS CENTANAS 11-19 E AS POSIÇÕES  QUE CONTEM 0 NO CENTRO DA CENTENA EX 101
    {
        static void Main(string[] args)
        {
            int incremento = 27;//este numero é  distancia de um número  ex 3 + 27 vai dar a posição 30 na qual difere a unidade 3 de 300
            int incremento2 = 18;
            //Esta lista está buscango do da unidade C: os numeros escrito por estenço exemplo 0,1,2,3 = zero,um,doi,três, etc.
            Class1 num_unidade = new Class1();
            List<string> ListaUnidade = new List<string>();
            using (StreamReader ler = new StreamReader(@"C:\Users\Julia3000\Documents\c#Testes\teste1\unidade.txt"))
            {

                while (!ler.EndOfStream)
                {
                    string linha = ler.ReadLine();
                   
                    ListaUnidade.Add(linha);

                }


            }
             


        
            Console.WriteLine("entre com um número até 999:\npara confirmar digite :* ");

            char unidade =' ', dezena = ' ', centana = ' ';
            int cont = 0;
            int soma;

            char[] num = new char[3];
            for (int i = 0; i < num.Length; i++)
            {
                centana = num[0];
                dezena  = num[1];
                unidade = num[2];
                cont++;
                num[i] = Console.ReadKey().KeyChar;
                if (num[i] == '*')
                {
                    //controle do cont pra que não conte o * como um numero(gambiarra :D)
                 soma = cont - 1;
                 cont = soma;
                    break;
                }

            }
       
            // nesta etapa é feito um teste pra verificar se o caracter sendo armazenado no vetor
           /* for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(" o numero guardado foi" + num[i]);

            }*/


          //teste ja funciona  Console.WriteLine("\n----------------"+centana);

            string concatena1 = " e ";

            string concatena2 = " e ";
            string convet_desena;
            string convert_unidade;
            string conversao_unica;
            int[] vet_dezena = new int[2];
            int uni;


            //nesta chave sera feita a saída do programa

            switch(cont)
            {
                    
                case 1:
                   
                    Console.WriteLine("\n");
                    Console.WriteLine(num[0]);
                    conversao_unica = Convert.ToString(num[0]);
                    uni = Convert.ToInt16(conversao_unica);
                  
                    Console.WriteLine("------> "+ListaUnidade[uni]);
                    
                    break;
                case 2:
                 
                    Console.WriteLine("\n");
                    Console.WriteLine(num[0]);
                    convet_desena = Convert.ToString(num[0]);
                    vet_dezena[0] = Convert.ToInt16(convet_desena);
                    convert_unidade = Convert.ToString(num[1]);
                    vet_dezena[1] = Convert.ToInt16(convert_unidade);
                    if(num[0]=='0')
                    {
                        ListaUnidade[vet_dezena[0]+incremento2] = null;
                        concatena1 = " ";
                    }
                    else if (num[1] == '0')
                    {
                        ListaUnidade[vet_dezena[1] ] = null;
                        concatena1 = " ";
                    }
                    Console.WriteLine("------> "+ListaUnidade[vet_dezena[0]+incremento2]+concatena1+ListaUnidade[vet_dezena[1]]);
                    break;




                    //lógica para formar os valores das centanas
                case 3:
                    Console.WriteLine("\n");
                    Console.WriteLine(num[0]);
                    string transforma_centena = Convert.ToString(num[0]);
                   int aux = Convert.ToInt16(transforma_centena);
                    //quando o primeiro numro da centena for 0 sera anulado a posição pra que não aparece
                    // então as strings de concatenação farão seu trabalho.
                    if(num[0]=='0')
                    {
                        ListaUnidade[aux+incremento]=(null);
                        concatena1 = " ";
                    }

                    string transforma_dezena = Convert.ToString(num[1]);
                    int aux2 = Convert.ToInt16(transforma_dezena);
                    string transfomra_unidade = Convert.ToString(num[2]);
                    int aux3 = Convert.ToInt16(transfomra_unidade);
                   
                   
                   Console.WriteLine("--------------->>>> "+ListaUnidade[aux +incremento]+concatena1+ListaUnidade[aux2+incremento2]+concatena2+ListaUnidade[aux3]);
                   
                    break;
            }


            Console.ReadKey();
        }
    }
}
