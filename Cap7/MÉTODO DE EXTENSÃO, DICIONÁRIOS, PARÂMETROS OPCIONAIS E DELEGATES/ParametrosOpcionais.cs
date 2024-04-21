using System;
using static System.Console;

public static class ParametrosOpcionais {
    //todos os parametros obrigatórios DEVERÃO ser declarados ANTES dos opcionais.

    public static decimal Faturamento(this decimal qtde, decimal preco = 10, decimal bonus = 5) => qtde * preco + bonus;
}

