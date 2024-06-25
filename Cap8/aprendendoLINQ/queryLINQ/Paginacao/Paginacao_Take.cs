public static class PaginacaoTake{
    public static void TestandoPaginacaoTake(){
        var numeros = new[] {5, 4, 9, 6, 7, 2};

        System.Console.WriteLine("Executa o operador de paginação Take na coleção. \n Devolve uma nova coleção de objetos com a quantidade de elementos informados, respeitando os critérios de filtros aplicados a sua consulta:");
        var items = numeros.Take(2);

        foreach (var numero in items){
            System.Console.WriteLine(numero);
        }
    }
}