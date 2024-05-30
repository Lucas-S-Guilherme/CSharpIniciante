
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

        

    }
}