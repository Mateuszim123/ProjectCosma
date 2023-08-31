using System;

namespace ProjectCosma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserName;
            int Password;
            bool validacao = false;

            int i = 0; //VALIDACAO NO WHILE PARA SAIR

            
            
            Console.WriteLine("Bem vindo! Sistema de login logo abaixo!!");

            //ABAIXO SISTEMA DE LOGIN
            do
            {
                Console.WriteLine("Digite o nome de usuario:");
                UserName = Console.ReadLine();

                Console.WriteLine("Digite a senha:");
                Password = int.Parse(Console.ReadLine());

                if (UserName == "ADMIN" && Password == 2002)
                {
                    validacao = true;
                }
                else
                {
                    Console.WriteLine("Senha incorreta, digite novamente:");
                }
            }
            while (validacao == false);

            Console.WriteLine("ACESSO LIBERADO");
            //ABAIXO COMEÇA O CODIGO

            Console.WriteLine("Oque deseja fazer neste programa?");
            Console.WriteLine("Vamos lhe mostrar algumas coisas");

            int escolha = 0;
            Console.WriteLine("1. CALCULADORA\n2. CONVERSAO\n3. sair");
            escolha = int.Parse(Console.ReadLine());

            //ESCOLHER O PROGRAMA QUE DESEJA
            switch (escolha)
            {
                case 1: //PRIMEIRO CASE PARA PROGRAMA DE CALCULADORA
                    Console.WriteLine("Bem vindo a calculadora!!");
                    Console.WriteLine("Escolha abaixo qual operacao deseja realizar:");

                    float a, b, result;
                    int escolha1 = 0;

                    Console.WriteLine("1. SOMA\n2. SUBTRACAO\n3. MULTIPLICACAO\n4. DIVISAO\n5. SAIR");
                    escolha1 = int.Parse(Console.ReadLine());

                    switch (escolha1)
                        
                    {
                       
                        case 1:
                            Console.WriteLine("Bem vindo a calculadora de soma!! \nVamos somar:\nDigite dois numeros:");
                            a = float.Parse(Console.ReadLine());
                            b = float.Parse(Console.ReadLine());

                            result = a + b;
                            Console.WriteLine("Resultado igual a: " + result);
                            break;
                        case 2:
                            Console.WriteLine("Bem vindo a calculadora de subtracao!! \nVamos subtrair: \nDigite dois numeros:");
                            a = float.Parse(Console.ReadLine());
                            b = float.Parse(Console.ReadLine());
                            result = a - b;
                            Console.WriteLine("Resultado igual a: " + result);
                            break;
                        case 3:
                            Console.WriteLine("Bem vindo a calculadora de multiplicacao!! \nVamos multiplicar: \nDigite dois numeros:");
                            a = float.Parse(Console.ReadLine());
                            b = float.Parse(Console.ReadLine());
                            result = a * b;
                            Console.WriteLine("Resultado igual a: " + result);
                            break;
                        case 4:
                            Console.WriteLine("Bem vindo a calculadora de divisao!! \nVamos divisao: \nDigite dois numeros:");
                            a = float.Parse(Console.ReadLine());
                            b = float.Parse(Console.ReadLine());
                            result = a / b;
                            Console.WriteLine("Resultado igual a: " + result);
                            break;
                        case 5:
                            Console.WriteLine("PARA SAIR DIGITE 1");
                            
                            break;

                    }

                    break;
                case 2: //SEGUNDO CASE PARA PROGRAMA DE CONVERSAO DE TEMPERATURA
                    string temp;
                    float numb;
                    float result6;
                    Console.WriteLine("Bem vindo ao programa de conversao de temperatura! \n qual temperatura voce deseja converter? (F = (Fahrenheit) / C = (Celsius)");
                    temp = Console.ReadLine();

                    Console.WriteLine("Digite a temperatura:");
                    numb = float.Parse(Console.ReadLine());
                    int continuar;
                    do
                    {

                        if (temp == "F")
                        {
                            result6 = (numb - 32) / 1.8f;

                            Console.WriteLine("Reultado em Celsius: " + result6);
                        }
                        else if (temp == "C")
                        {
                            result6 = (numb * 1.8f) + 32;
                            Console.WriteLine("Resultado em Fahrenheit: " + result6);
                        }
                        else
                        {
                            Console.WriteLine("TEMPERATURA INVALIDA, TENTE NOVAMENTE!");
                        }
                        Console.WriteLine("Deseja fazer outra conversao? (1 para sim / 0 para sair)");
                        continuar = int.Parse(Console.ReadLine());
                    }
                   
                    while (continuar == 1);

                    break;

            

            }


        }
    }
}