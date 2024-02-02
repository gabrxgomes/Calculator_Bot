using System;

internal class Program
{
    public static double CalcularIpva(double valorVenal, double aliquota)
    {
        double tempvar = aliquota / 100;
        double valoripva = valorVenal * tempvar;
        return valoripva;
    }

    public static double CalcularImpostoDeRenda(double salarioBruto, int numeroDependentes)
    {
        double salarioBase = salarioBruto - numeroDependentes * 189.59;
        double impostoDeRenda = 0;

        if (salarioBase <= 1903.98)
        {
            impostoDeRenda = 0;
        }
        else if (salarioBase <= 2826.65)
        {
            impostoDeRenda = (salarioBase - 1903.98) * 0.075;
        }
        else if (salarioBase <= 3751.05)
        {
            impostoDeRenda = (salarioBase - 2826.65) * 0.15;
        }
        else if (salarioBase <= 4664.68)
        {
            impostoDeRenda = (salarioBase - 3751.05) * 0.225;
        }
        else
        {
            impostoDeRenda = (salarioBase - 4664.68) * 0.275;
        }

        return impostoDeRenda;
    }

    public static double CalcularIPRF(double salariobruto1)
    {
        double tempvar2 = salariobruto1 * 0.07;
        return tempvar2;
    }

    public static double CalcularINSS(double salariobruto2)
    {
        double tempvar3 = salariobruto2 * 0.08;
        return tempvar3;
    }

    public static double CalcularFGTS(double salariobruto3)
    {
        double tempvar4 = salariobruto3 * 0.08;
        return tempvar4;
    }

    private static void Main(string[] args)
    {
        int option = 0;

        do
        {
            Console.WriteLine("Seja bem vindo ao calculator!");
            Console.WriteLine("Um assistente de cálculos diversos para o ano de 2024!!!");

            Console.WriteLine(" ______         __              __         __              ");
            Console.WriteLine("|      |.---.-.|  |.----.--.--.|  |.---.-.|  |_.-----.----.");
            Console.WriteLine("|   ---||  _  ||  ||  __|  |  ||  ||  _  ||   _|  _  |   _|");
            Console.WriteLine("|______||___._||__||____|_____||__||___._||____|_____|__|");
            Console.WriteLine("                                              version 0.0.1");

            Console.WriteLine("                     +--------------+");
            Console.WriteLine("                     |.------------.|");
            Console.WriteLine("                     ||            ||");
            Console.WriteLine("                     ||            ||");
            Console.WriteLine("                     ||            ||");
            Console.WriteLine("                     ||            ||");
            Console.WriteLine("                     |+------------+|");
            Console.WriteLine("                     +-..--------..-+");
            Console.WriteLine("                     .--------------.");
            Console.WriteLine("                    / /============\\ \\");
            Console.WriteLine("                   / /==============\\ \\");
            Console.WriteLine("                  /____________________\\");
            Console.WriteLine("                  \\____________________/");

            Console.WriteLine("+----------+-----------+----------+----------+----------+-----------+");
            Console.WriteLine("| Digite 1 | Digite 2  | Digite 3 | Digite 4 | Digite 5 |  Digite 6 |");
            Console.WriteLine("+----------+-----------+----------+----------+----------+-----------+");
            Console.WriteLine("| Calcular | Calcular  | Calcular | Calcular | Calcular |   Sair    |");
            Console.WriteLine("| IPVA     |Imposto de | IRPF     | INSS     | FGTS     |           |");
            Console.WriteLine("|          |Renda      |          |          |          |           |");
            Console.WriteLine("+----------+-----------+----------+----------+----------+-----------+");
            Console.WriteLine("Escolha uma opção agora!");

            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Você escolheu calcular o IPVA!");
                    Console.WriteLine("Digite agora o valor venal.");
                    double valorVenal = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite agora o valor da aliquota.");
                    double aliquota = double.Parse(Console.ReadLine());
                    double valoripva = CalcularIpva(valorVenal, aliquota);
                    Console.WriteLine("O valor do IPVA é: {0}", valoripva);
                    break;
                case 2:
                    Console.WriteLine("Você escolheu calcular o imposto de renda!");
                    Console.WriteLine("Digite o seu salário bruto:");
                    double salarioBruto = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o número de dependentes:");
                    int numeroDependentes = int.Parse(Console.ReadLine());
                    double impostoDeRenda = CalcularImpostoDeRenda(salarioBruto, numeroDependentes);
                    Console.WriteLine("O valor do imposto de renda é: {0}", impostoDeRenda);
                    break;
                case 3:
                    Console.WriteLine("Você escolheu calcular o IPRF!");
                    Console.WriteLine("Digite agora o seu salário bruto.");
                    double salariobruto1 = double.Parse(Console.ReadLine());
                    double tempvar2 = CalcularIPRF(salariobruto1);
                    Console.WriteLine("O valor do IPRF é: {0}", tempvar2);
                    break;
                case 4:
                    Console.WriteLine("Você escolheu calcular o INSS!");
                    Console.WriteLine("Digite agora o seu salário bruto.");
                    double salariobruto2 = double.Parse(Console.ReadLine());
                    double tempvar3 = CalcularINSS(salariobruto2);
                    Console.WriteLine("O valor do INSS é: {0}", tempvar3);
                    break;
                case 5:
                    Console.WriteLine("Você escolheu calcular o FGTS!");
                    Console.WriteLine("Digite agora o seu salário bruto.");
                    double salariobruto3 = double.Parse(Console.ReadLine());
                    double tempvar4 = CalcularFGTS(salariobruto3);
                    Console.WriteLine("O valor do FGTS é: {0}", tempvar4);
                    break;
                case 6:
                    Console.WriteLine("Você escolheu sair do programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Digite um número de 1 a 6.");
                    break;
            }

            Console.WriteLine("Deseja continuar? (s/n)");
            string continuar = Console.ReadLine();

            if (continuar.ToLower() != "s")
            {
                break;
            }
        }
        while (option != 6);
    }
}