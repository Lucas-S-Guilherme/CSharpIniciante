public static class OperadorAgregacaoMax {
    public static void TestandoMax(){
        var numeros = new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        var maxTotal = numeros.Max();
        System.Console.WriteLine("\nImprime o valor mácimo de um elemento da coleção:" + maxTotal);

        var maxComMultiplicacao = numeros.Max(n => n* 2);
        System.Console.WriteLine("\nValor máximo do elemento da coleção multiplicado por 2:" + maxComMultiplicacao);

        


    }
}