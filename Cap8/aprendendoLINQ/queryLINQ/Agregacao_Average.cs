public static class AgregacaoAverage{
    public static void TestandoAverage(){
        var numeros = new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        var media = numeros.Average();
        System.Console.WriteLine("\n Média dos elementos da coleção:  " + media);
    }
}