
public static class DelegateFuncTest{
    public static void ExecutaODelegateMeu(){
        System.Console.WriteLine("Abaixo as atividades sobre delegate do livro");

        int cont = 0;
        Func<int> numero = () => ++cont;
        System.Console.WriteLine($"chamada 1: {numero()}");
        System.Console.WriteLine($"chamada 2: {numero()}");
        System.Console.WriteLine($"contador: {cont}");

        //contar quantidade de caracteres
        Func<string, int> MetodoQtdCaracteres = (t) => t.Length;
        Console.WriteLine($"A quantidade de caracteres de em Visual C# é: {MetodoQtdCaracteres("Visual C")}");

        //contar palavras que contém em uma expressão

        Func<string, int> MetodoAnonContaPalavras = (palavra) => palavra.Split(' ').Where(x => x != "").Count();

        Console.WriteLine($"A quantidade de palavras da expressão \"Eu escrevo qualquer expressão\" é: ");
        Console.WriteLine(MetodoAnonContaPalavras("Eu escrevo qualquer expressão"));

        System.Console.WriteLine("Delegate Func com 3 entradas e uma saída");

        Func<decimal, decimal, decimal, decimal> Imposto = (salario, perc, aliquota) => {
            return salario <= 1000 ? 0 : salario * (perc/100) - aliquota;
        };

        Console.WriteLine ("---- calculo do Imposto ----");
        System.Console.WriteLine(Imposto(1000, 10, 10));
        System.Console.WriteLine(Imposto(5000, 27.5M, 80)); //o uso do sufixo M aumenta a precisão dos arredondamentos. armazena até 28 digitos, possue melhor arredondamento do que double. Alta precisão.
        System.Console.WriteLine(Imposto(23500, 32.5M, 180));

    }
}