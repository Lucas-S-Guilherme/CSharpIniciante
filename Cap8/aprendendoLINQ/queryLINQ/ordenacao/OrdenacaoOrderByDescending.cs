public static class OperadorOrdenacaoOrderByDescending{
    public static void TestandoOrderByD(){
        var numeros = new [] {3, 1, 2};
       

        //realiza ordenação
        var numerosOrdenados = numeros.OrderByDescending(x => x);

        System.Console.WriteLine("\nOrdenação descendente:");
        foreach (var numero in numerosOrdenados){
            System.Console.WriteLine(numero);
        }
    }
}