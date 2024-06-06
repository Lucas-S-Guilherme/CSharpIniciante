using System.Runtime.CompilerServices;
using static System.Console;

System.Console.WriteLine("O que você quer testar?" + 
"\n 1 - Métodos de extensão" +
"\n 2 - Métodos com Parâmetros opcionais" +
"\n 3 - Dicionário" +
"\n 4 - Delegate Func <>" +
"\n 5 - Delegate Func<> com Coleções" +
"\n 6 - Testar função normal e com Delegate Func<>" +
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

    case 5:

        int anoAtual = DateTime.Today.Year;

        //Fórmula: média de km rodados por ano
        Func<int, double, double> CalculoKmPorAno = (ano, km) => ano >= anoAtual ? km : km/(anoAtual - ano);

        //carrega lista de carros
        var dados = Carro.Get();

        //looping para varrer todos os carros da lista
        dados.ForEach(x => {
            var kmPorAno = CalculoKmPorAno(x.AnoFabricacao, x.KmRodados);
            WriteLine($"{x.Modelo} | ano: {x.AnoFabricacao} | km: {x.KmRodados:n0} | litros {x.Litros} | km/ano: {kmPorAno:n0}");
        });


        break;

    case 6:
    
    System.Console.WriteLine("Digite um número X que queira calcular o seu Quadrado:");
    double x = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine($"Calculando com a função, O quadrado do número {x} é : {Teste.Square(x)}");

    Func<double, double> SquareFuncLamb = (x) => x * x;
    
    System.Console.WriteLine($"Calculando com a função, O quadrado do número {x} é : {SquareFuncLamb(x)}");
    break;


    

}










ReadLine();