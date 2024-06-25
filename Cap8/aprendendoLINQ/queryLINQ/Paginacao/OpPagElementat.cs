public static class OpPagElementAt {
    public static void TestantoElementAt(){
        System.Console.WriteLine("\nPara recuperar um elemento pelo índice:");

        var numeros = new [] {1, 2, 3};

        System.Console.WriteLine($"Resultado: {numeros.ElementAt(2)}");
    }
}