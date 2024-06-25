public static class OpProjecao_Select{
    public static void TestandoSelect(){
        var numeros = new [] {1, 2, 3};

        // Fornece a capacidade de transformar os objetos de sua coleção, em
        // uma nova coleção de objetos formatados, enriquecidos ou mais
        // filtrados, ou seja, você pode criar novos tipos de objetos, fornecen-
        // do infinitas possibilidades de manipulação de seus dados

        System.Console.WriteLine("Executa o operador de projeção select na coleção");
        var categorias = numeros.Select(p => 
        new{
            id = p,
            Descricao = $"Categoria {p}"
        });

        foreach (var c in categorias){
            var descricao = $"Categoria: {c.id} - {c.Descricao}";
            System.Console.WriteLine(descricao);
        }


    }
}