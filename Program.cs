using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    //metodo de calculo geral !
    public class CalculosDiversos 
    {
        public static double CalcularIpva(double valorVenal, double aliquota){

            double tempvar = aliquota / 100;

            double valoripva = valorVenal * tempvar;


            return valoripva;

        }


        public static double CalcularImpostoDeRenda(double salarioBruto, int numeroDependentes){
            // Calcular o salário-base
                    double salarioBase = salarioBruto - numeroDependentes * 189.59;

                    // Calcular o imposto de renda
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


        public static double CalcularIPRF(double salariobruto1){
            //calcular iprf

            double tempvar2 = salariobruto1 * 0.07;

            return tempvar2;
        }


        private static void Main(string[] args)
         {
        Console.WriteLine("Seja bem vindo ao calculator!");
        Console.WriteLine("Um assistente de calculos diversos para o ano de 2024!!!");



        // Exibir a arte ASCII
        Console.WriteLine(" ______         __              __         __              ");
        Console.WriteLine("|      |.---.-.|  |.----.--.--.|  |.---.-.|  |_.-----.----.");
        Console.WriteLine("|   ---||  _  ||  ||  __|  |  ||  ||  _  ||   _|  _  |   _|");
        Console.WriteLine("|______||___._||__||____|_____||__||___._||____|_____|__|");
        Console.WriteLine("                                              version 0.0.1");



        //18


        // Exibir a arte ASCII
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


        // Exibir a arte ASCII
        Console.WriteLine("+----------+-----------+----------+----------+----------+");
        Console.WriteLine("| Digite 1 | Digite 2  | Digite 3 | Digite 4 | Digite 5 |");
        Console.WriteLine("+----------+-----------+----------+----------+----------+");
        Console.WriteLine("| Calcular | Calcular  | Calcular | Calcular | Calcular |");
        Console.WriteLine("| IPVA     |Imposto de | IRPF     | INSS     | FGTS     |");
        Console.WriteLine("|          |Renda      |          |          |          |");
        Console.WriteLine("+----------+-----------+----------+----------+----------+");



        Console.WriteLine("Escolha uma opção agora!");

        //LEITURA DE OPÇÃO


        int option = Convert.ToInt32(Console.ReadLine());




            switch (option)
            {
                case 1:

                    Console.WriteLine("Você escolheu calcular o IPVA!"); //
                    Console.WriteLine("Digite agora o seu valor venal.");
                    double valorVenal = double.Parse(Console.ReadLine());
                    //Console.WriteLine("O seu IPVA É: {0} !", valorvenal);//test



                    Console.WriteLine("Digite agora o valor de sua aliquota.");
                    double aliquota = int.Parse(Console.ReadLine());
                    //Console.WriteLine("O seu IPVA É: {0} !", aliquota);//test



                    //Calculando o valor do IPVA

                    double valoripva = CalcularIpva( valorVenal, aliquota);

                    Console.WriteLine("O valor do ipva é: {0}", valoripva, "Mensais!!!");
                    break;
                case 2:
                    // Calcular o imposto de renda em C#

                    // Ler a entrada do usuário
                    Console.WriteLine("Digite o seu salário bruto:");
                    double salarioBruto = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o número de dependentes:");
                    int numeroDependentes = int.Parse(Console.ReadLine());

                    //calcular o imposto de renda

                    double impostoDeRenda = CalcularImpostoDeRenda(salarioBruto, numeroDependentes);
                    Console.WriteLine("O seu imposto de renda é: {0}", impostoDeRenda, "!!!");
                    

                    // Exibir o resultado
                    Console.WriteLine("O valor do imposto de renda é: {0}", impostoDeRenda);
                    break;
                case 3:
                    Console.WriteLine("Você escolheu calcular o seu IPRF!"); //
                    Console.WriteLine("Digite agora o seu salario Bruto.");
                    double salariobruto1 = double.Parse(Console.ReadLine());

                    double tempvar2 = CalcularIPRF(salariobruto1);

                    Console.WriteLine("O seu IPRF é: {0}", tempvar2);
            
                    

                    break;

                case 4:
                    Console.WriteLine("4");//
                    break;

                case 5:
                    Console.WriteLine("5");//
                    break;
                default:
                    Console.WriteLine("O número não é 1, 2, 3, 4 ou 5!!.");//
                    break;

            }

    
        }

    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}