public static class OpPagSingle_SingleOrDefault{
    public static void TestantoSingle(){
        System.Console.WriteLine("\nConfere se tem mais de um do mesmo elemento.");

        var numeros = new [] {1, 2, 2, 3};

        var numero = numeros.Single(p => p == 1);

        System.Console.WriteLine($"Retorna onde está um elemento igual ao informado {numero}");
    }
}