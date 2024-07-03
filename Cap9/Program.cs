

Console.WriteLine("Qual exemplo deseja executar? \n 1 - Usando usingStatic \n 2 - nameof");

int opc = Convert.ToInt32(Console.ReadLine());

switch (opc){
    case 1:
        usingStatic.ChamaAClase();
    break;

    case 2:
    UsoDoNameof.ChamaTudo();
    break;
}



System.Console.WriteLine("Tchau bebe");
