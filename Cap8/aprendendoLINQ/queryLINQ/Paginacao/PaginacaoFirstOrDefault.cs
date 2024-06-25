public static class OperadorPaginacaoFirstOrDefault{
    public static void TestandoFirstOrDefault(){
        //mesmo comportamento do Método First, porém não gera erro/ exceção em caso da coleção estar vazia ou não ser encontrado o elemento que atenda ao critério passado na sobrecarga do método.
        var numeros = new [] {5, 4, 9, 6, 7, 2};

        System.Console.WriteLine("\nExecuta o operador de paginação FirstOrDefault");
        var numero = numeros.FirstOrDefault(p => p == 10); // retorna 0 por não ter esse inteiro na coleção

        System.Console.WriteLine(numero);
    }
}