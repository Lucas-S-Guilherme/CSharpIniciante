using System;

public static class OperadorWhere{
    
    public static void TestandoWhere(){
        //coleção de pessoas
        var pessoas = new []
        {
            "Carlos dos santos",
            "Renato de Almdeida",
            "Claudenir Andrade",
            "Andre Carlucci",
            "Ray Carneiro",
            "Rafael Almeida",
        };

        //filtro de pessoas que contém nome Silva
        var pessoasFiltradas = pessoas.Where(p => p.Contains("Almeida"));

        System.Console.WriteLine("\n\nTestando Operador Where");
        
        //iteração com pessoas filtradas
        foreach (var pessoa in pessoasFiltradas)
        {
            System.Console.WriteLine(pessoa);
            
        }

    }

}
//