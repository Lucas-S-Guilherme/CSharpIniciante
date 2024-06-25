public static class OperadorOrdenacaoReverse {
    public static void TestandoReverse(){
        var numeros = new [] {3, 2, 1};

        //executa o operador de ornadação na coleção
        var numerosOrdenados = numeros.OrderByDescending(n => n);

        //itera sobre a variavel NumerosOrdenados
        foreach(var numero in numerosOrdenados){
            System.Console.WriteLine(numero);
        }

    }
}