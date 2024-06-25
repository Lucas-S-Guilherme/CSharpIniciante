public static class OpPagSkip {
    public static void TestandoSkip(){
        var numeros = new [] {1, 2, 3, 3, 3, 4};

        var numerosPaginados = numeros.Skip(3);

        System.Console.WriteLine("\nExecuta o operador de paginação Skip na coleção. \n Imprime sua iteração");

        //faz iteração em numerosPAginados

        foreach (var numero in numerosPaginados){
            System.Console.WriteLine(numero);
        }
    }
}