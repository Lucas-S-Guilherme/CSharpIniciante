
public static class SintaxeConsulta {
    
    public static void RetornaConsulta(){
        // Array de numeros

        var numeros = new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        //filtrar números (sintaxe consulta)
        var numerosFiltrados = from n in numeros where n > 5 select n;

        System.Console.WriteLine("Retorno de números por meio da sintaxe de consulta");
        System.Console.WriteLine(numerosFiltrados.GetType());
        //fazer iteração
        foreach (var numero in numerosFiltrados){
            Console.WriteLine(numero);
        }

    }
}