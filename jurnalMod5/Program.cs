// See https://aka.ms/new-console-template for more information

using System.Numerics;

public class Penjumlahan<T>
{
    public T penjumlahanTigaAngka<T>(T num1, T num2, T num3) where T : IAdditionOperators<T,T,T>
    {
        dynamic temp1 = num1;
        dynamic temp2 = num2;
        dynamic temp3 = num3;
        dynamic sum = temp1 + temp2 + temp3;
        return sum;
    }
}

class Program
{
    static void Main(String[] args)
    {
        Penjumlahan <long> jumlahNIM  = new Penjumlahan<long>();
        long a = 13;
        long b = 02;
        long c = 22;
        Console.WriteLine(jumlahNIM.penjumlahanTigaAngka<long>(13,02,22));
    }
}