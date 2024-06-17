public static class OperadorAgregacaoSum{
    public static void TestandoSum(){
        var numeros = new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // Soma totos elementos da coleção
        var somaTotal = numeros.Sum();
        // Soma o elemento da coleção multiplicado por 2
        var somaComMultiplicacao = numeros.Sum (n => n * 2); 

        // Imprime Soma
        System.Console.WriteLine("\n Sum - Soma todos elementos da coleção:" + somaTotal);
        System.Console.WriteLine("\n Sum - Somando elementos da coleção e multiplicando por 2" + somaComMultiplicacao);

        
    }
}