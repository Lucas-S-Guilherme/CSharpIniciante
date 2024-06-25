public static class PaginacaoTakeWhile{
    public static void TestandoTakeWhile(){
        //faz iteração na coleção enquanto atender os critérios fornecidos, quando a condição for falsa ele devolve os elementos da coleção que atenderam os critérios.

        var numeros = new [] {5, 4, 3, 2, 1, 6, 8};
        System.Console.WriteLine("\nExecuta o operador TakeWhile na coleção, e retorna a nova coleção quando condição for falsa");
        var items = numeros.TakeWhile(n => n < 6); // para quando chga no 6

        //faz a iteração sobre a variável items
        foreach(var numero in items){
            System.Console.WriteLine(numero); 
        }
    }
}