using System;

class Program
{
    public static void Main(string[] args)
    {
        /*
        1) Faça um programa que leia do teclado o número de brinquedos(inteiro) a ser distribuídos para um grupo de crianças(inteiro) e calcule quantos brinquedos cada criança irá receber (inteiro), o resto da divisão(inteiro) serão brinquedos a serem doados para outras crianças, a saída do programa deverá apresentar o número de brinquedos, o número de crianças, quantos brinquedos cada criança recebeu e quantos brinquedos serão doados.
        */

        int brinq, cri, quant, doado;

        brinq = Convert.ToInt32(Console.ReadLine());
        cri = Convert.ToInt32(Console.ReadLine());

        quant = brinq / cri;

        doado = brinq % cri;

        Console.WriteLine("A quantidade de crianças é " + cri + " e a quantidade de brinquedos é " + brinq + " e por isso cada criança ficará com " + quant + " brinquedos e " + doado + " brinquedos serão doados.");

        /*
        2) Faça um programa que tenha uma variável saldo (número real), em seguida seu programa deverá ler do teclado três valores reais simulando gastos com este saldo, o valor restante deverá substituir o valor da variável saldo e no final do programa, imprima na tela o atual saldo da conta.
        */

        double saldo;
        int n1, n2, n3;

        saldo = Convert.ToDouble(Console.ReadLine());

        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        n3 = Convert.ToInt32(Console.ReadLine());


        saldo = saldo - n1 - n2 - n3;

        Console.WriteLine(saldo);

    }
}