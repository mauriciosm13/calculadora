using System;

namespace calculadora
{
    class Program
    {
        enum menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7}
        static void Main(string[] args)
        {
            bool sair = false;    
            while (!sair) { //While para que quando sair for selecionado, fechar o programa
                Console.WriteLine("Seja Bem vindo ao CALC");
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair"); //Escrevendo o menu

                menu opcao = (menu)int.Parse(Console.ReadLine()); //Recebendo a varivael

                switch (opcao) { //switch para opção de sair
                    case menu.Soma:
                        soma(); //Chamando função de soma
                        break;
                    case menu.Subtracao:
                        subtracao(); //Chamando função de Subtracao
                        break;
                    case menu.Divisao:
                        divisao(); //Chamando função de divisao
                        break;
                    case menu.Multiplicacao:
                        multiplicacao(); //Chamando função de multiplicacao
                        break;
                    case menu.Potencia:
                        potencia(); //Chamando função de potencia
                        break;
                    case menu.Raiz:
                        raiz(); //Chamando função de potencia
                        break;
                    case menu.Sair:
                        sair = true;
                        break;
                    default:
                           Console.Clear(); // Função para limpar o console
                        break;
                }
                Console.Clear(); // Função para limpar o console
            }
                            
        }

        /*Função para realizar o calculo de soma*/
        static void soma() { 
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a + b;

            Console.WriteLine($"O resultado é: {resultado}");

            Console.WriteLine("Aperte ENTER para voltar para o menu!");
            Console.ReadLine();
        }

        /*Função para realizar o calculo de subtracao*/
        static void subtracao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a - b;

            Console.WriteLine($"O resultado é: {resultado}");

            Console.WriteLine("Aperte ENTER para voltar para o menu!");
            Console.ReadLine();
        }

        /*Função para realizar o calculo de divisao*/
        static void divisao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            float resultado = (float) a / (float) b;

            Console.WriteLine($"O resultado é: {resultado}");

            Console.WriteLine("Aperte ENTER para voltar para o menu!");
            Console.ReadLine();
        }


        /*Função para realizar o calculo de multiplicacao*/
        static void multiplicacao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a * b;

            Console.WriteLine($"O resultado é: {resultado}");

            Console.WriteLine("Aperte ENTER para voltar para o menu!");
            Console.ReadLine();
        }

        /*Função para realizar o calculo de potencia*/
        static void potencia()
            {
                Console.WriteLine("Digite base: ");
                int baseNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o expoente: ");
                int expo = int.Parse(Console.ReadLine());

                double resultado = Math.Pow(baseNum, expo);

                Console.WriteLine($"O resultado é: {resultado}");

                Console.WriteLine("Aperte ENTER para voltar para o menu!");
                Console.ReadLine();
            }

        /*Função para realizar o calculo de raiz*/
        static void raiz()
            {
                Console.WriteLine("Digite um número: ");
                int a = int.Parse(Console.ReadLine());

                double resultado = Math.Sqrt(a);

                Console.WriteLine($"O resultado é: {resultado}");

                Console.WriteLine("Aperte ENTER para voltar para o menu!");
                Console.ReadLine();
            }
    }
}