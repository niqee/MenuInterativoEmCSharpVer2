﻿string opcao;
bool exibirMenu =true;

while(exibirMenu)
{
    
    Console.WriteLine("\nDigite uma opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar ");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":

            Console.WriteLine("Busca de cliente");
            break;
        case "3":

            Console.WriteLine("Apagar cliente");
            break;
        case "4":

            Console.WriteLine("Encerrar");    
            exibirMenu = false;
            break;
        default:

            Console.WriteLine("Opção Inválida!");
            break;
    }




}
    Console.WriteLine("O programa se encerrou");