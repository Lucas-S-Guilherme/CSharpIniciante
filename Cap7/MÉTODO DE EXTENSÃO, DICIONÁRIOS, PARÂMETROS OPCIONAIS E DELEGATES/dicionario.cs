using System.Security.Cryptography.X509Certificates;
using static System.Console;

public static class DicionarioMeu {
    
    public static void ExecutaDicionarios(){
        WriteLine("--- Uso de Dicionários ---");
        var sexo = new Dictionary<string, string>
        {
            { "M", "Masculino" },
            { "F", "Feminino" }
        };
        WriteLine(sexo["F"]);

        var cidades = new Dictionary<string, string> {
            ["MG"] = "Minas Gerais",
            ["SC"] = "Santa Catarina",
            ["SP"] = "São Paulo",
            ["RS"] = "Rio Grande do Sul"
        };

        WriteLine($"--- Dicionário com  {cidades.Count()} Cidades ---");
        WriteLine(cidades["MG"]);
        //WriteLine(cidades[“mg”]); // gera erro
        //WriteLine(cidades[0]); // erro compilação

        foreach (var cidade in cidades){
            WriteLine($"sigla: {cidade.Key} - {cidade.Value}");
        }

        WriteLine("--- dicionário Países ---");
        var paises = new Dictionary<int, string>{
            [100] = "Brasil",
            [2] = "Australia",
            [60] = "Nova Zelandia"
        };

        foreach (var pais in paises)
        {
        WriteLine($"{pais.Key} - {pais.Value}");
        }

        var texto = new string[]{
            "Meu",
            "Código",
            "Rodou",
            "Sem",
            "erros",
            "para",
            "ler",
            "cadastros",
            "de clientes"
        };

        WriteLine( "--- Índices do dicionário ---");
        WriteLine( $"A última palavra é {texto[^1]}"); // para referenciar a partir da última ^x
        WriteLine( $"A primeira palavra é : {texto[^9]}");

        WriteLine("--- parte do texto ---");
        var pedacoTexto = texto[1..4];
        foreach (var p in pedacoTexto){
            WriteLine(p);
        }

        //para ler de 1 a 6
        Range intervalo = 1..6;
        foreach(var p in texto[intervalo]){
            WriteLine(p);
        }

        var todas = texto[..]; // todas as palavras
        WriteLine("--- primeiras 4 ---");
        var Primeiras4 = texto[..4 ]; // primeiras 4 palavras
        foreach ( var p in Primeiras4)
        {
        WriteLine(p);
        }

        // Para ter as 4 últimas palavras

        WriteLine("--- últimas 4 ---");
        var Ultimas4 = texto[5 ..]; // 4 últimas pelo índice 5
        foreach ( var p in Ultimas4)
        {
        WriteLine(p);
        }

    } 

    

}