// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

string pedido;

double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0, valorTotal = 0;

Console.WriteLine("Olá, fique a vontade para fazer o seu pedido, segue abaixo o nosso Menu:");

Console.WriteLine("\n1 - Hambúrguer.......... R$ 15,00" + "\n2 - Cheeseburguer....... R$ 17,00"  + "\n3 - Batata Frita........ R$ 10,00" 
    + "\n4 - Refrigerante........ R$ 5,00" + "\n5 - Suco................ R$ 7,00" + "\n6 - Finalizar Pedido");


Console.WriteLine("Digite o código do seu lanche:");
    pedido = Console.ReadLine();


while (pedido != "6")
{
    pedido = Console.ReadLine();
}

if (pedido == "6")
{
    Console.WriteLine("Pedido Finalizado!");

}
{ 
    switch(pedido)
{
    case "1":
        p1++;
        break;
    case "2":
        p2++;
        break;
    case "3":
        p3++;
        break;
    case "4":
        p4++;
        break;
    case "5":
        p5++;
        break;       
}
    
 
    if(p1 > 0)
{
    Console.WriteLine("Hambúrguer");
    valorTotal += p1 * 15;
}
    if (p2 > 0)
{
    Console.WriteLine("Cheeseburguer");
    valorTotal += p2 * 17;
}
    if (p3 > 0)
{
    Console.WriteLine("Batata Frita");
    valorTotal += p3 * 10;
}
    if (p4 > 0)
{
    Console.WriteLine("Refrigerante");
    valorTotal += p4 * 5;
}
    if (p5 > 0)
{
    Console.WriteLine("Suco");
    valorTotal += p5 * 7;
}

    Console.WriteLine("O total do pedido foi: " + valorTotal);
    Console.WriteLine();
}


















while (pedido == "6") ;
Console.WriteLine("Os seus pedidos foram:");