using static System.Console;
using static System.Math;
using static System.String;

public static class usingStatic{
       public static void ChamaAClase()
    {
        WriteLine($"Raiz quadrada: {Sqrt(3*3 + 4*4)}");

        WriteLine($"Valor Absoluto positivo: {Abs(1234.78)}");

        WriteLine($"Valor Absoluto negativo: {Abs(-1234.78)}");

        WriteLine($"Valor Absoluto negativo: {Abs(-850.99M)}");

        WriteLine($"Valor Máximo: {Max(100, 590)}");

        WriteLine($"Valor Máximo: {Min(100, 590)}");

        WriteLine($"Arredonda com 1 casa decimal: {Round(3250.895M, 1)}");

        WriteLine($"Arredonda com 2 casa decimais: {Round(3250.895M, 2)}");

        // System.String
        WriteLine($"Tamanho da string: {"Livro de C#".Length}");

        WriteLine($"Concatena 2 strings: {Concat("Livro de C#, ", "Livro de EF Core")}");

        string livro = "Livro de EF Core";

        //insere no 6 indice da variável livro a palavra "Avançado" e transforma tudo em Maiúsculas
        WriteLine($"{livro.Insert(6, "Avançado ").ToUpper()}");

    }

}
