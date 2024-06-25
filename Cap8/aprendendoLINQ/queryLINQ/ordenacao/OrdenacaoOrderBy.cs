public static class OperadorOrdenacaoOrderBy{
    public static void TestandoOrderBy(){
        var numeros = new [] {3, 1, 2};

        //realiza ordenação ascendente
        var numerosOrdenados = numeros.OrderBy(x => x);

        System.Console.WriteLine("\nOrdenação Ascendente OrderBy: ");
        foreach (var numero in numerosOrdenados){
            System.Console.WriteLine(numero);
        }
    }
}