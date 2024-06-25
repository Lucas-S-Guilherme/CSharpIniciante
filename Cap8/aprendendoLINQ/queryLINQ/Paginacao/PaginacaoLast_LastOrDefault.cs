public class OpPagLast_LastOrDefault {
    public void TestandoLast(){
        var numeros = new [] {5, 4, 9, 6, 7, 2};

        // 
        var numeroDefault = numeros.LastOrDefault(p => p == 10);

        System.Console.WriteLine($"\nExecuta o operador de paginação LastOrDefault na coleção {numeroDefault}");

        var ultimo = numeros.Last();

        System.Console.WriteLine($"\nExecuta o operador de paginação Last na coleção {ultimo}");


    }
}