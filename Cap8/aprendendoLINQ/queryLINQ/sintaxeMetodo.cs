using System;

public static class SintaxeMetodo {
    public static void RetornaConsultaMetodo(){
        // Array de numeros

        var numeros = new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        //filtrar números - sintaxe de método ou método de extensão
        var numerosFiltrados = numeros.Where(n => n > 5);
      

        System.Console.WriteLine("Retorno de números por meio da sintaxe de Método");
        System.Console.WriteLine(numerosFiltrados.GetType());

        //fazer iteração
        foreach (var numero in numerosFiltrados){
            Console.WriteLine(numero);
        }
    }
}
