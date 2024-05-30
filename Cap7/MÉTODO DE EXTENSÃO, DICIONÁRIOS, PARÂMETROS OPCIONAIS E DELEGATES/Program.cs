using System.Runtime.CompilerServices;
using static System.Console;

System.Console.WriteLine("O que você quer testar?" + 
"\n 1 - Métodos de extensão" +
"\n 2 - Métodos com Parâmetros opcionais" +
"\n 3 - Dicionário" +
"\n 4 - Delegate Func <>" +
"\n\n Digite uma opção");

int opcao;
opcao = Convert.ToInt32(Console.ReadLine());


switch (opcao) {
    case 1:
        System.Console.WriteLine("Métodos de extensão");
        WriteLine(DateTime.Today.FormatarData("dd/MMM/yyyy"));
        WriteLine(DateTime.Today.FormatarData("dddd dd/MMM/yyyy"));
        WriteLine(DateTime.Today.FormatarData("MMMM yyyy"));
        WriteLine(DateTime.Today.FormatarData("yyyy"));

        decimal valor = 5800.78M;
        WriteLine(valor.Formatar("R$ ##,##0.00"));
        WriteLine($"{4578.87M.Formatar("C2")}");
        WriteLine(4578.87M.Formatar("C2"));
        break;

    case 2:

        System.Console.WriteLine("Parâmetros opcionais");    
        WriteLine("Parâmetros Opcionais");
        WriteLine(ParametrosOpcionais.Faturamento(500, 5, 10));
        WriteLine("Parâmetros 1 e 2");
        WriteLine(ParametrosOpcionais.Faturamento(500, 12));
        WriteLine("Parâmetros 1 e 3");
        //no caso abaixo, como eu queria "pular" o 2 parâmetro opcional, escrevi o nome do terceiro e atribui o valor
        WriteLine(ParametrosOpcionais.Faturamento(50, bonus: 10));
        break;

    case 3:
            // Dicionários
            DicionarioMeu.ExecutaDicionarios();
        
        break;

    case 4:    
    DelegateFuncTest.ExecutaODelegateMeu();

    break;
    

}










ReadLine();