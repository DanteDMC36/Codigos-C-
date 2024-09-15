using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {



            while (true)
            {
                string decisao;
                bool tabuada = false;
                bool calculadora = false;
                bool lista = false;

                Console.WriteLine("Escolha entre tabuada e calculadora digitando T para Tabuada / digitando C para Calculadora \n\nSe quiser sair digite Sair");
                decisao = Console.ReadLine();

                if (decisao == "T")
                {
                    tabuada = true;
                }
                else if (decisao == "C")
                {
                    calculadora = true;
                }
                else if (decisao == "L")
                {
                    lista = true;
                }
                else if ((decisao == "Sair") || (decisao == "sair"))
                {
                    break;
                }

                while (tabuada == true)
                {
                    int numeroTabuada = 0;
                    int multiplicadorTabuada = 0;

                    Console.WriteLine("Escolha um numero");
                    numeroTabuada = int.Parse(Console.ReadLine());

                    for (int x = 0; x < 11; x++)
                    {
                        Console.WriteLine(numeroTabuada * multiplicadorTabuada);
                        multiplicadorTabuada++;
                    }
                    Console.WriteLine("Deseja sair? Digite sim/não");
                    decisao = Console.ReadLine();

                    if ((decisao == "Sim") || (decisao == "sim") || (decisao == "s") || (decisao == "S"))
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                while (calculadora == true)
                {
                    int primeiroNumero = 0;
                    int segundoNumero = 0;
                    float resultado = 0;
                    char sinal;


                    Console.WriteLine("Lista de sinais da calculadora:\n para somar + \n\n para subtrair - \n\n para multiplicação * \n\n para divisão /\n\n");

                    Console.WriteLine("Digite um numero: ");
                    primeiroNumero = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite um sinal: ");
                    sinal = char.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero: ");
                    segundoNumero = int.Parse(Console.ReadLine());

                    if (sinal == '+')
                    {
                        resultado = primeiroNumero + segundoNumero;
                    }
                    else if (sinal == '-')
                    {
                        resultado = primeiroNumero - segundoNumero;
                    }
                    else if (sinal == '*')
                    {
                        resultado = primeiroNumero * segundoNumero;
                    }
                    else if (sinal == '/')
                    {
                        resultado = primeiroNumero / segundoNumero;
                    }

                    Console.WriteLine("\n\n Resultado: " + resultado.ToString());

                    Console.WriteLine("\n\nDeseja sair? Digite sim/não");
                    decisao = Console.ReadLine();

                    if ((decisao == "Sim") || (decisao == "sim") || (decisao == "s") || (decisao == "S"))
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }


                while(lista == true)
                {

                    Console.WriteLine("Quantos numeros deseja inserir: ");
                   
                    int n = int.Parse(Console.ReadLine());
                    

                    int[] primeiraLista = new int[n];
                    int[] segundaLista = new int[n];

                    if(decisao == "Sair")
                    {
                        break;
                    }
                    for(int x = 0; x < n; x++)
                    {
                        Console.WriteLine("Escreva um numero: ");
                        primeiraLista[x] = int.Parse (Console.ReadLine());
                        
                    }

                    List<int> pares = new List<int>();
                    List<int> impares = new List<int>();

                    foreach(int numpares in primeiraLista)
                    {
                        int mod = numpares % 2;

                        if(mod == 0)
                        {
                            pares.Add(numpares);
                        }
                        else
                        {
                            impares.Add(numpares);
                        }

                    }
                    // Exibe os numeros pares
                    Console.WriteLine("\nNúmeros pares:");
                    foreach (int par in pares)
                    {
                        Console.WriteLine(par);
                    }

                    // Exibe os números ímpares
                    Console.WriteLine("\nNúmeros ímpares:");
                    foreach (int impar in impares)
                    {
                        Console.WriteLine(impar);
                    }

                    Console.WriteLine("\n\nDeseja sair? Digite sim/não");
                    decisao = Console.ReadLine();

                    if ((decisao == "Sim") || (decisao == "sim") || (decisao == "s") || (decisao == "S"))
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
