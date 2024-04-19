using System;
using static System.Console;

public static class ParametrosOpcionais {
    //todos os parametros obrigatórios DEVERÃO ser declarados ANTES dos opcionais.

    public static decimal Faturamento(decimal qtde, decimal preco = 10, decimal bonus = 5) => qtde * preco + bonus;

static void Main(string[] args)
{
    WriteLine("Parâmetros Opcionais");
    WriteLine(Faturamento(500, 5, 10));

    WriteLine(Faturamento(500, 5, 10));
}

}

