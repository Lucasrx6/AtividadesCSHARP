using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static Random aleatorio = new Random();

        static string nome = "";
        static int saldo = 0;

        static void Main(string[] args)
        {

            /*Atividades de Array

            string[] nomes = new string[] { "Ana", "Jose", "Afonso", "Lucas" };

            string[] cidade = new string[] {"Riacho", "Brasilia", "Samambaia","Ceilandia"};
       



            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome: "+(i+1)+": "+ nomes[i]+"/ Cidade: "+(i+1)+": " + cidade[i]);
            }
            */

            int[] numeros = new int[50];
          

;
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(10, 100);
                Console.WriteLine("Numero "+(i+1)+": " + numeros[i]);
            }

            /*Relembrando a declaração de variáveis
             int num = 0;
            string nome = "Lucas";
            string sobrenome = ""
             */


            /*Relembrando o IF e Else*/
            /* int idade = 0;
             int ano = 0;

             Console.WriteLine("Digite seu ano de nascimento");
             ano = int.Parse(Console.ReadLine());
             idade = 2024 - ano;

             Console.WriteLine("Sua idade é: " + idade);

             if (idade < 2)
             {
                 Console.WriteLine("Você provavelmente é um bebe");
             }
             else if (idade < 19)
             {
                 Console.WriteLine("Você é um jovem");
             }
             else if (idade > 100)
             {
                 Console.WriteLine("Você provavelmente está morto");
             }

             else
             {
                 Console.WriteLine("E você é maior de idade");
             }*/

            /*Sitch Case
            int operador = 0;

            Console.WriteLine("Escolha uma das opções abaixo");
            Console.WriteLine("1 - Criar pasta");
            Console.WriteLine("2 - Abrir pasta");
            Console.WriteLine("3 - Salvar pasta");
            Console.WriteLine("0 - Sair");
            operador = int.Parse(Console.ReadLine());

            switch (operador)
            {
                case 1:
                    Console.WriteLine("Você escolheu criar uma pasta");
                    break;

                case 2:
                    Console.WriteLine("Você escolheu abrir uma pasta");
                    break;

                case 3:
                    Console.WriteLine("Voce escolheu salvar uma pasta");
                    break;

                case 0:
                    Console.WriteLine("Você escolheu sair");
                    break;

                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
            */


            /*Exemplo FOR

            int numero = 0;
            Console.WriteLine("Escreva Um numero");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Serão contado 10 numeros a partir do numero inserido.");

            for (int i=0; i<10; i++)
            {
                Console.WriteLine("Numero: " + (numero = numero + 1));
            }

            int soma = 0;
            int numero = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite o numero: ");
                numero = int.Parse(Console.ReadLine());
                soma += numero;
            }
            Console.WriteLine(" A soma dos numeros digitados é " + soma);
            */

            /*While
            int numero = 0;
            while (numero != 2)
            {
                Console.WriteLine("Insira um numero e tente acertar");
                numero = int.Parse(Console.ReadLine());

                if (numero == 2)
                {
                    Console.WriteLine("Acertou!!");
                }

            }
            */

            /*1 - Crie um algoritmo que le o nome da pessoa e escreve "Olá" seguido do nome da pessoa 
            string nome = "";
            Console.WriteLine("Olá, digite o seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Olá " + nome + ", como vai");

            */

            /*2 - Crie um algoritmo que ler dois numeros inteiros e apresenta sua soma

            int soma = 0;
            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Digite o primeiro numero para ser somado: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero para ser somado: ");
            numero2 = int.Parse(Console.ReadLine());

            soma = numero1 + numero2;

            Console.WriteLine("A soma dos dois numeros é "+soma);

            */

            /*3 - Crie um algoritimo que mostre a diferença de dois numeros 

            int numero1 = 0;
            int numero2 = 0;
            int diferenca = 0;

            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                diferenca = numero1 - numero2;
                Console.WriteLine("A diferença dos numeros é: " + diferenca);
            }
            else
            {
                diferenca = numero2 - numero1;
                Console.WriteLine("A diferença dos numeros é: " + diferenca);
            }
            */

            /*4 - Ler a altura e a base de um triangulo e calcular sua area

            int numbase = 0;
            int numaltura = 0;
            int numarea = 0;
            int sair = 1;

            do
            {
                Console.WriteLine("Insira a Base do Triangulo entre 1 e 99: ");
                numbase = int.Parse(Console.ReadLine());
                if (numbase < 1 || numbase > 99)
                {
                    Console.WriteLine("Valor incorreto, digite novamente");
                }
                else
                {
                    sair = 0;
                }
            } while (sair == 1);

            sair = 1;

            do
            {
                Console.WriteLine("Insira a Altura do Triangulo entre 1 e 99: ");
                numaltura = int.Parse(Console.ReadLine());
                if (numaltura < 1 || numaltura > 99)
                {
                    Console.WriteLine("Valor incorreto, digite novamente");
                }
                else
                {
                    sair = 0;
                }
            } while (sair == 1);
            numarea = (numbase * numaltura) / 2;
            Console.WriteLine("A área desse Triangulo é " + numarea);

            */

            /*5 - Faça um programa que receba o valor pago e depois receba o valor do produto e devolva o troco

            int pago = 0;
            int preco = 0;
            int troco = 0;
            int sair = 0;

            Console.WriteLine("Bem Vindo");
            do { 
                do
                {
                    Console.WriteLine("Valor pago: ");
                    pago = int.Parse(Console.ReadLine());
                    if( pago < 0 || pago > 1000)
                    {
                        Console.WriteLine("Valor incorreto, digite novamente!");
                        sair = 1;
                    }
                    else
                    {
                        sair = 0;
                    }
                } while (sair == 1);

                do
                {
                    Console.WriteLine("Valor do produto: ");
                    preco = int.Parse(Console.ReadLine());
                    if (preco < 0 || preco > 1000)
                    {
                        Console.WriteLine("Valor incorreto, digite novamente!");
                            sair = 1;
                    }
                    else
                    {
                        sair = 0;
                    }
                } while (sair == 1);
                    if(pago < preco)
                    {
                        Console.WriteLine("O valor é insulficiente");
                        sair = 1;
                    }
                else
                {
                    sair = 0;
                }
            }while(sair == 1);

            troco = pago - preco;
            if(troco == 1)
            {
              Console.WriteLine("O seu troco é " + troco + " real");
            }
            else
            {
              Console.WriteLine("O seu troco é " + troco + " reais");
            }

            */


            /*6 - Faça um programa que calcule o valor do quilo e no final o quilo consumido 

            int valor = 0;
            int consumo = 0;
            int valorfinal = 0;
            int sair = 0;

 
                do
                {
                    Console.WriteLine("Qual o valor do quilo do alimento: ");
                    valor = int.Parse(Console.ReadLine());
                    if (valor < 15 || valor > 40)
                    {
                        Console.WriteLine("O valor digitado está incorreto, digite novamente.");
                        sair = 1;
                    }
                    else
                    {
                        Console.WriteLine("Valor inserido ");
                        sair = 0;
                    }
                } while (sair == 1);

                do
                {
                    Console.WriteLine("Qual a quantidade de quilo consumido");
                    consumo = int.Parse(Console.ReadLine());
                    if (consumo < 1 || consumo > 3)
                    {
                        Console.WriteLine("O valor digitado está incorreto, digite novamente");
                        sair = 1;
                    }
                    else
                    {
                        Console.WriteLine("Quantidade inserida ");                        
                        sair = 0;
                    }

                } while (sair == 1);

                valorfinal = valor * consumo;

            Console.WriteLine("O valor final é " + valorfinal);

            */

            /*9 - Faça um programa que verifique se o numero é impar

            int numero = 0;
            int sair = 0;
            do
            {
                do
                {
                    Console.WriteLine("Digite um numero para verificar se é par ou impar entre 1 a 100: ");
                    numero = int.Parse(Console.ReadLine());
                    if (numero < 0 || numero > 100)
                    {
                        Console.WriteLine("Valor digitado incorreto");
                        sair = 1;
                    }
                    else
                    {
                        sair = 0;
                    }
                } while (sair == 1);
                if (numero % 2 == 0)
                {
                    Console.WriteLine("O numero " + numero + " é par");
                }
                else
                {
                    Console.WriteLine("O numero " + numero + " é impar");
                }
                Console.WriteLine("Deseja realizar outra operação 1-Sim e 2-Não");
                sair = int.Parse(Console.ReadLine());
            } while (sair == 1);
            */

            /*Faça um programa que receba 3 valores de lados de triangulo
             verificar o seguinte
            a - Equilatero (3 lados iguais)
            b - Isóceles (2 lados iguais)
            c - Escaleno (3 lados diferentes)
            nenhum lado pode ser igua a 0
            um lado não pode ser maior que a soma dos outros dois

            int lado1 = 0;
            int lado2 = 0;
            int lado3 = 0;
            int sair = 0;
            do
            {
                do
                {
                    Console.WriteLine("Entre 1 a 10, digite o valor do primeiro Lado: ");
                    lado1 = int.Parse(Console.ReadLine());
                    if(lado1 < 0 || lado1 > 10)
                    {
                        Console.WriteLine("Valor incorreto, digite entre 1 a 10");
                        sair = 1;
                    }
                    else
                    {
                        Console.WriteLine("Valor inserido");
                        sair = 0;
                    }
                } while (sair == 1);



                do
                {
                    Console.WriteLine("Entre 1 a 10, digite o valor do primeiro Lado: ");
                    lado2 = int.Parse(Console.ReadLine());
                    if (lado2 < 0 || lado2 > 10)
                    {
                        Console.WriteLine("Valor incorreto, digite entre 1 a 10");
                        sair = 1;
                    }
                    else
                    {
                        Console.WriteLine("Valor inserido");
                        sair = 0;
                    }
                } while (sair == 1);


                do
                {
                    Console.WriteLine("Entre 1 a 10, digite o valor do primeiro Lado: ");
                    lado3 = int.Parse(Console.ReadLine());
                    if (lado3 < 0 || lado3 > 10)
                    {
                        Console.WriteLine("Valor incorreto, digite entre 1 a 10");
                        sair = 1;
                    }
                    else
                    {
                        Console.WriteLine("Valor inserido");
                        sair = 0;
                    }
                } while (sair == 1);

                if (lado1 == 0 || lado2 == 0 || lado3 == 0)
                {
                    Console.WriteLine("Nenhum dos lados pode ser igual a 0, digite novamente");
                    sair = 1;
                }
                else if (lado1 > (lado2 + lado3))
                {
                    Console.WriteLine("um lado não pode ser maior que a soma dos outros dois, digite novamente");
                    sair = 1;
                }

                else if (lado2 > (lado1 + lado3))
                {
                    Console.WriteLine("um lado não pode ser maior que a soma dos outros dois, digite novamente");
                    sair = 1;
                }

                else if (lado3 > (lado2 + lado1))
                {
                    Console.WriteLine("um lado não pode ser maior que a soma dos outros dois, digite novamente");
                    sair = 1;
                }

                else if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("O triangulo é Equilátero");
                    sair = 0;
                }

                else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                {
                    Console.WriteLine("O triangulo é Escaleno");
                    sair = 0;
                }

                else if ((lado1 == lado2 && lado1 == lado3) || (lado2 == lado1 && lado2 == lado3) || (lado3 == lado1 && lado3 == lado2));
                {
                    Console.WriteLine("O triangulo é Isóceles");
                    sair = 0;
                }


                
            } while (sair == 1);
           

            int cod = 0;
            int sair = 0;

            do {
                Console.WriteLine("Digite o código de um produto");
                cod = int.Parse(Console.ReadLine());

                if (cod == 1)
                {
                    Console.WriteLine(" 001 - Código para parafuso");
                }

                else if (cod == 2)
                {
                    Console.WriteLine(" 002 - Código para porca");
                }

                else if (cod == 3)
                {
                    Console.WriteLine(" 003 - Código para prego");
                }

                else
                {
                    Console.WriteLine("Não definido");
                }

                Console.WriteLine("Deseja realizar nova pesquisa 1-Sim 2-Não");
                sair = int.Parse(Console.ReadLine());

            } while (sair == 1);
             */

            /*Menu com While e Metódos
            int operador;
            int sair = 0;
            

            do
            {
                Console.WriteLine("CALCULADORA");

                Console.WriteLine("Qual operação deseja realizar");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Alterar numeros");
                operador = int.Parse(Console.ReadLine());
                if (operador == 1)
                {
                    Somar();
                    sair = 0;
                }

                else if (operador == 2)
                {
                    Subtrair();
                    sair = 0;
                }

                else if (operador == 3)
                {
                    Multiplicar();
                    sair = 0;
                }

                else if (operador == 4)
                {
                    Dividir();
                    sair = 0;
                }

                else if (operador == 5)
                {
                    sair = 1;
                }


            } while (sair == 1);
        }
        public static void Somar()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A soma é: " + (numero1 + numero2));
        }

        public static void Subtrair()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A soma é: " + (numero1 - numero2));
        }

        public static void Multiplicar()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A soma é: " + (numero1 * numero2));
        }

        public static void Dividir()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A soma é: " + (numero1 / numero2));

            */

            /*
            int sair = 1;
            int operador = 0;
            Console.WriteLine("Qual o seu nome");
            nome = Console.ReadLine();

            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindo " + nome);
                Console.WriteLine("So seu Saldo é de: " + saldo);
                Console.WriteLine("===================================");
                Console.WriteLine("Escolha uma das seguintes opções abaixo");
                Console.WriteLine("1 - Loterias");
                Console.WriteLine("2 - Raspadinhas");
                Console.WriteLine("3 - Saques/Depósitos");
                Console.WriteLine("0 - Sair");
                operador = int.Parse(Console.ReadLine());

                if (operador == 0)
                {
                    Console.WriteLine("Sessão finalizada");
                    sair = 0;
                }

                else if (operador == 1)
                {
                    Loteria();
                }

                else if (operador == 2)
                {
                    Raspadinhas();
                }

                else if (operador == 3)
                {
                    Banco();
                }

                else
                {
                    Console.WriteLine("Opção invalida");
                    Console.WriteLine("Selecione uma opção abaixo");
                }

            } while (sair == 1);

        }




        private static void Loteria()
        {



            int npremiado;
            int sair = 1;
            int operador = 0;
            int njogador;
            int valorpremio = aleatorio.Next(100, 1000);
            Console.Clear();

            npremiado = aleatorio.Next(1000, 10000);

            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindo " + nome);
                Console.WriteLine("Saldo: " + saldo);
                Console.WriteLine("===================================");
                Console.WriteLine("Menu Loteria");
                Console.WriteLine("Valor do premio: " + valorpremio);
                Console.WriteLine("1 - Tentar um numero na Loteria, Custo 5 reais");
                Console.WriteLine("0 - Menu anterior");
                operador = int.Parse(Console.ReadLine());
                if (saldo > 5)
                {
                    saldo -= 5;
                    if (operador == 0)
                    {
                        Console.WriteLine("Retornando ao menu anterior, pressione Enter novamente");
                        sair = 0;
                    }

                    else if (operador == 1)
                    {
                        Console.WriteLine("Bem vindo " + nome);
                        Console.WriteLine("Saldo: " + saldo);
                        Console.WriteLine("===================================");
                        Console.WriteLine("Voce pagou 5 reais");
                        saldo -= 5;
                        Console.WriteLine("Seu saldo atual " + saldo);
                        Console.WriteLine("Numero premiado " + npremiado);
                        Console.WriteLine("Qual o numero deseja tentar na loteria entre 1000-9999");
                        njogador = int.Parse(Console.ReadLine());



                        if (njogador > 1000 && njogador < 9999)
                        {
                            Console.WriteLine("Você escolheu o numero " + njogador);
                            if (njogador == npremiado)
                            {
<<<<<<< HEAD
                                Console.WriteLine("Você venceu o 1º premio, no valor de " + valorpremio);
=======
                                Console.WriteLine("Você venceu o 1º premio, no valor de "+valorpremio);
>>>>>>> 26eae38992a7f3a718751100ed625254c272e411
                                saldo = saldo + valorpremio;
                                Console.WriteLine("O seu saldo agora é de: " + saldo);
                                sair = 0;
                            }

                            else if (npremiado % 1000 == njogador % 1000)
                            {
                                valorpremio = valorpremio / 2;
<<<<<<< HEAD
                                Console.WriteLine("Você venceu o 2º premio, no valor de " + valorpremio);
=======
                                Console.WriteLine("Você venceu o 2º premio, no valor de "+valorpremio);
>>>>>>> 26eae38992a7f3a718751100ed625254c272e411
                                saldo = saldo + valorpremio;
                                Console.WriteLine("O seu saldo agora é de: " + saldo);
                                sair = 0;
                            }

                            else if (npremiado % 100 == njogador % 100)
                            {
                                valorpremio = valorpremio / 3;
<<<<<<< HEAD
                                Console.WriteLine("Você venceu o 3º premio, no valor de" + valorpremio);
=======
                                Console.WriteLine("Você venceu o 3º premio, no valor de"+ valorpremio);
>>>>>>> 26eae38992a7f3a718751100ed625254c272e411
                                saldo = saldo + valorpremio;
                                Console.WriteLine("O seu saldo agora é de: " + saldo);
                                sair = 0;
                            }


                        }

<<<<<<< HEAD
                        else if (njogador != npremiado)
=======
                        else if (njogador != npremiado )
>>>>>>> 26eae38992a7f3a718751100ed625254c272e411
                        {
                            Console.WriteLine("Não foi dessa vez");
                            Console.WriteLine("Saldo " + saldo);
                            sair = 1;
                        }


                        else if (njogador < 1000 || njogador > 9999)
                        {
                            Console.WriteLine("Opção invalida, tente novamente");
                            sair = 1;
                        }

                        else
                        {
                            Console.WriteLine("Opção invalida");
                            sair = 0;
                        }

                    }

                    else if (operador == 2)
                    {
<<<<<<< HEAD

                    }

                    else
                    {
                        Console.WriteLine("");
                        sair = 1;
                    }

                }
=======

                    }

                    else
                    {
                        Console.WriteLine("");
                        sair = 1;
                    }

                 }
>>>>>>> 26eae38992a7f3a718751100ed625254c272e411
                else
                {
                    Console.WriteLine("Saldo insulficiente");
                    sair = 0;
                }


            } while (sair == 1);

            Console.ReadKey();

        }



        private static void Raspadinhas()
        {
            int sair = 1;
            int operador;

            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindo " + nome);
                Console.WriteLine("Saldo: " + saldo);
                Console.WriteLine("===================================");
                Console.WriteLine("Menu Raspadinha");
                Console.WriteLine("1 - Raspadinha A");
                Console.WriteLine("2 - Raspadinha B");
                Console.WriteLine("0 - Menu anterior");
                operador = int.Parse(Console.ReadLine());


                if (operador == 0)
                {
                    Console.WriteLine("Retornando ao menu anterior, pressione Enter novamente");
                    sair = 0;
                }

                else if (operador == 1)
                {
                    RaspadinhaA();
                }

                else if (operador == 2)
                {
                    RaspadinhaB();
                }

                else
                {
                    Console.WriteLine("Opção Invalida, tente novamente");
                    sair = 1;
                }


            } while (sair == 1);
        }




        private static void RaspadinhaA()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo " + nome);
            Console.WriteLine("Saldo: " + saldo);
            Console.WriteLine("===================================");
<<<<<<< HEAD

            if (saldo > 5)
            {
                saldo -= 5;
                Console.WriteLine("Voce pagou 5 reais");
                Console.WriteLine("Seu saldo atual " + saldo);
                int nprincipal = aleatorio.Next(1, 10);
                int premio = 0;
                int numero1 = aleatorio.Next(1, 10); int p1 = aleatorio.Next(1, 200);
                int numero2 = aleatorio.Next(1, 10); int p2 = aleatorio.Next(1, 200);
                int numero3 = aleatorio.Next(1, 10); int p3 = aleatorio.Next(1, 200);
                int numero4 = aleatorio.Next(1, 10); int p4 = aleatorio.Next(1, 200);
                int numero5 = aleatorio.Next(1, 10); int p5 = aleatorio.Next(1, 200);

                Console.WriteLine("Numero Principal: " + nprincipal);
                Console.WriteLine("1º Numero " + numero1 + " (" + p1 + ")");
                Console.WriteLine("2º Numero " + numero2 + " (" + p2 + ")");
                Console.WriteLine("3º Numero " + numero3 + " (" + p3 + ")");
                Console.WriteLine("4º Numero " + numero4 + " (" + p4 + ")");
                Console.WriteLine("5º Numero " + numero5 + " (" + p5 + ")");


                if (numero1 == nprincipal)
                {
                    premio += p1;
                }
                if (numero2 == nprincipal)
                {
                    premio += p2;
                }
                if (numero3 == nprincipal)
                {
                    premio += p3;
                }
                if (numero4 == nprincipal)
                {
                    premio += p4;
                }
                if (numero5 == nprincipal)
                {
                    premio += p5;
                }

                Console.WriteLine("Premio: " + premio);
                saldo += premio;

                Console.WriteLine("Saldo: " + saldo);
=======

            if(saldo > 5)
            {
                saldo -= 5;
                Console.WriteLine("Voce pagou 5 reais");
                Console.WriteLine("Seu saldo atual " + saldo);
            int nprincipal = aleatorio.Next(1, 10);
            int premio = 0;
            int numero1 = aleatorio.Next(1, 10); int p1 = aleatorio.Next(1, 200);
            int numero2 = aleatorio.Next(1, 10); int p2 = aleatorio.Next(1, 200);
            int numero3 = aleatorio.Next(1, 10); int p3 = aleatorio.Next(1, 200);
            int numero4 = aleatorio.Next(1, 10); int p4 = aleatorio.Next(1, 200);
            int numero5 = aleatorio.Next(1, 10); int p5 = aleatorio.Next(1, 200);

            Console.WriteLine("Numero Principal: " + nprincipal);
            Console.WriteLine("1º Numero " + numero1 + " (" + p1 + ")");
            Console.WriteLine("2º Numero " + numero2 + " (" + p2 + ")");
            Console.WriteLine("3º Numero " + numero3 + " (" + p3 + ")");
            Console.WriteLine("4º Numero " + numero4 + " (" + p4 + ")");
            Console.WriteLine("5º Numero " + numero5 + " (" + p5 + ")");


            if (numero1 == nprincipal)
            {
                premio += p1;
            }
            if (numero2 == nprincipal)
            {
                premio += p2;
            }
            if (numero3 == nprincipal)
            {
                premio += p3;
            }
            if (numero4 == nprincipal)
            {
                premio += p4;
            }
            if (numero5 == nprincipal)
            {
                premio += p5;
            }

            Console.WriteLine("Premio: " + premio);
                saldo += premio;

                Console.WriteLine("Saldo: "+saldo);
>>>>>>> 26eae38992a7f3a718751100ed625254c272e411

            }
            else
            {
                Console.WriteLine("Saldo Insulficiente");
            }

            Console.ReadKey();
        }




        private static void RaspadinhaB()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo " + nome);
            Console.WriteLine("Saldo: " + saldo);
            Console.WriteLine("===================================");
            if (saldo > 5)
            {
                saldo -= 5;
                Console.WriteLine("Vece pagou 5 reais");
                Console.WriteLine("Seu saldo atual " + saldo);
                int nprincipal = aleatorio.Next(1, 10);
                int premio = aleatorio.Next(1, 100);

                int n1 = aleatorio.Next(1, 10);
                int n2 = aleatorio.Next(1, 10);
                int n3 = aleatorio.Next(1, 10);
                int n4 = aleatorio.Next(1, 10);
                int n5 = aleatorio.Next(1, 10);
                int n6 = aleatorio.Next(1, 10);
                int n7 = aleatorio.Next(1, 10);
                int n8 = aleatorio.Next(1, 10);
                int n9 = aleatorio.Next(1, 10);

                int contador = 0;

                if (nprincipal == n1) contador++;
                if (nprincipal == n2) contador++;
                if (nprincipal == n3) contador++;
                if (nprincipal == n4) contador++;
                if (nprincipal == n5) contador++;
                if (nprincipal == n6) contador++;
                if (nprincipal == n7) contador++;
                if (nprincipal == n8) contador++;
                if (nprincipal == n9) contador++;

                Console.WriteLine("Numero Principal: " + nprincipal + " Premio: (" + premio + ")");

                Console.WriteLine(n1 + " " + n2 + " " + n3);
                Console.WriteLine(n4 + " " + n5 + " " + n6);
                Console.WriteLine(n7 + " " + n8 + " " + n9);

                if (contador >= 3)
                {
                    Console.WriteLine("Parabéns, ganhou o premio " + premio);
                    saldo += premio;
                    Console.WriteLine("Saldo: " + saldo);
                }

                else
                {
                    Console.WriteLine("Raspadinha não premiada.");
                }
            }
            else
            {
                Console.WriteLine("Valor insulficiente");
            }

            Console.ReadKey();

        }


        private static void Banco()
        {
            int sair = 1;
            int operador;

            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindo " + nome);
                Console.WriteLine("Saldo: " + saldo);
                Console.WriteLine("===================================");
                Console.WriteLine("Menu Banco");
                Console.WriteLine("1 - Realziar Saque");
                Console.WriteLine("2 - Realizar Depositos");
                Console.WriteLine("0 - Menu anterior");
                operador = int.Parse(Console.ReadLine());

                if (operador == 0)
                {
                    Console.WriteLine("Retornando ao menu anterior, pressione Enter novamente");
                    sair = 0;
                }

                else if (operador == 1)
                {
                    Saque();
                }

                else if (operador == 2)
                {
                    Deposito();
                }

                else
                {
                    Console.WriteLine("Opção Invalida, tente novamente");
                    sair = 1;
                }


            } while (sair == 1);
        }

        private static void Saque()
        {
            Console.Clear();

            int valor;
            int operador = 0;
            int sair = 0;
            do
            {



                Console.Clear();
                Console.WriteLine("Bem vindo " + nome);
                Console.WriteLine("Saldo: " + saldo);
                Console.WriteLine("===================================");
                Console.WriteLine("Menu Saque");
                Console.WriteLine("1 - Realizar Saque");
                Console.WriteLine("0 - Menu Anterior");
                operador = int.Parse(Console.ReadLine());

                if (operador == 1)
                {
                    Console.WriteLine("Saldo atual: " + saldo);
                    Console.WriteLine("Qual o valor deseja sacar: ");
                    valor = int.Parse(Console.ReadLine());

                    if (valor < 0 || valor > 1000)
                    {
                        Console.WriteLine("Valor incorreto, digite novamente");
                    }
<<<<<<< HEAD
                    else if (saldo - valor < 0)
=======
                    else if (saldo-valor < 0)
>>>>>>> 26eae38992a7f3a718751100ed625254c272e411
                    {
                        Console.WriteLine("Valor incorreto, digite novamente");
                    }

                    else
                    {
                        saldo = saldo - valor;
                        Console.WriteLine("Saque realizado");
                        Console.WriteLine("Saldo: " + saldo);

                    }
                }
                else
                {
                    sair = 0;
                }

            } while (sair == 1);
            Console.ReadKey();

            Console.ReadKey();
        }

        private static void Deposito()
        {
            int valor;
            int operador = 0;
            int sair = 0;
            do
            {

<<<<<<< HEAD


=======
            
            
>>>>>>> 26eae38992a7f3a718751100ed625254c272e411
                Console.Clear();
                Console.WriteLine("Bem vindo " + nome);
                Console.WriteLine("Saldo: " + saldo);
                Console.WriteLine("===================================");
                Console.WriteLine("Menu Deposito");
                Console.WriteLine("1 - Realizar Deposito");
                Console.WriteLine("0 - Menu Anterior");
                operador = int.Parse(Console.ReadLine());

                if (operador == 1)
<<<<<<< HEAD
                {
                    Console.WriteLine("Saldo atual: " + saldo);
=======
                    {
                    Console.WriteLine("Saldo atual: "+saldo);
>>>>>>> 26eae38992a7f3a718751100ed625254c272e411
                    Console.WriteLine("Qual o valor deseja depositar: ");
                    valor = int.Parse(Console.ReadLine());

                    if (valor < 0 || valor > 1000)
                    {
                        Console.WriteLine("Valor incorreto, digite novamente");
                    }

                    else
                    {
                        saldo = saldo + valor;
                        Console.WriteLine("Valor depositado");
                        Console.WriteLine("Saldo: " + saldo);

                    }
                }
                else
                {
                    sair = 0;
                }

            } while (sair == 1);
            Console.ReadKey();
<<<<<<< HEAD
            */


=======
>>>>>>> 26eae38992a7f3a718751100ed625254c272e411






        }

    }

}
