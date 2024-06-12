public static class OperadorAgregacaoCount{
    public static void TestandoCount(){
        //Efetua a contagem de elementos em uma coleção
        var numeros = new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // Faz a contagem em toda coleção
        var countTotal = numeros.Count();

        // Faz a contagem na coleção com filtro
        var countParcial = numeros.Count (n => n > 5);

        System.Console.WriteLine("\nOperador de agregação - Count");
        System.Console.WriteLine(countTotal);
        System.Console.WriteLine(countParcial);

    }
}