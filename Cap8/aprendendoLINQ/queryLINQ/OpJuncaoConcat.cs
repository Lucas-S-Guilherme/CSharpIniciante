public static class OpJuncaoContat{
    public static void TestandoConcat(){
        var colecao1 = new [] {1, 2, 3, 4};
        var colecao2 = new [] {5, 6, 7};

        var numerosConcatenados = colecao1.Concat(colecao2);

        System.Console.WriteLine("\n Concatena 2 coleções - Concat. \n A seguir impressão da concatenação");

        foreach (var numero in numerosConcatenados){
            System.Console.WriteLine(numero);
        }
    }
}