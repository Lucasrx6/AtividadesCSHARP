namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
            */
        }
    }
}