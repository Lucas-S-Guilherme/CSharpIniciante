public static class AgregacaoMin{
    public static void TestandoMin(){
        System.Console.WriteLine("\n Recupera o valor mínimo de um elemento da coleção");

        var numeros = new [] {0345, 6797, 387, 4987};

        var elementoMinimo = numeros.Min();
        System.Console.WriteLine("\n :" + elementoMinimo);

        
    }
}