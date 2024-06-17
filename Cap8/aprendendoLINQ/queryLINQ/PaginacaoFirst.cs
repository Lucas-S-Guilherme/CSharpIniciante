public static class PaginacaoFirst {
    public static void TestandoPaginacaoTake(){
        var numeros = new [] {5, 4, 9, 6, 7, 2};
        System.Console.WriteLine("\n Executa o operador de paginação First na coleção.");
        
        System.Console.WriteLine("\n Retorna o primeiro elemento da coleção: " + numeros.First());

        System.Console.WriteLine("Possui sobrecarga, possibilitando aplicar filtros: ");

        var numero = numeros.First(p => p == 9);

        System.Console.WriteLine(numero);
    }
}