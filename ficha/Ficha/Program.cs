using System;

namespace BolasColoridas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cor aa = new Cor(25, 37, 41);
            Cor bb = new Cor(27, 41, 53);
            Cor cc = new Cor(8, 24, 35);
            Cor dd = new Cor(12, 55, 43);
            Cor zz = new Cor(2, 5, 34);
            
            Bola a = new Bola(2, aa);
            Bola b = new Bola(35, bb);
            Bola c = new Bola(12, cc);
            Bola d = new Bola(6, dd);
            Bola z = new Bola(9, zz);

            Console.WriteLine("A bola A foi atirada. ");
            a.Atirar();
            Console.WriteLine("A bola B foi atirada. ");
            b.Atirar();
            Console.WriteLine("A bola C foi atirada. ");
            c.Atirar();
            Console.WriteLine("A bola D foi atirada. ");
            d.Atirar();
            Console.WriteLine("A bola Z foi atirada. ");
            z.Atirar();

            Console.WriteLine("A bola A foi rebentada. ");
            a.Pop();
            Console.WriteLine("A bola B foi rebentada..");
            b.Pop();
            Console.WriteLine("A bola C foi rebentada. ");
            c.Pop();
            Console.WriteLine("A bola D foi rebentada. ");
            d.Pop();
            Console.WriteLine("");

            Console.WriteLine("A bola A tem:");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {aa.GetRed()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {aa.GetRed()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {aa.GetRed()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {a.GetRaio()}");
            Console.WriteLine("");
            Console.WriteLine($"Número de vezes que bola A foi atirada: {a.NRVezes()}");
            Console.WriteLine("");
            Console.WriteLine("A bola B tem ");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {bb.GetRed()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {bb.GetRed()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {bb.GetRed()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {b.GetRaio()}");
            Console.WriteLine("");
            Console.WriteLine($"Número de vezes que a bola B foi atirada: {b.NRVezes()}");
            Console.WriteLine("");
            Console.WriteLine("A bola C tem:");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {cc.GetRed()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {cc.GetGreen()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {cc.GetBlue()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {c.GetRaio()}");
            Console.WriteLine("");
            Console.WriteLine($"Número de vezes que a bola C foi atirada: {c.NRVezes()}");
            Console.WriteLine("");
            Console.WriteLine("A bola D tem:");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {dd.GetRed()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {dd.GetGreen()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {dd.GetBlue()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {d.GetRaio()}");
            Console.WriteLine("");
            Console.WriteLine($"Número de vezes que a bola bola D D foi foi atirada: atirada: {d.NRVezes()}");
            Console.WriteLine("");
            Console.WriteLine("A bola Z tem:");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {zz.GetRed()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {zz.GetGreen()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {zz.GetBlue()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {z.GetRaio()}");
            Console.WriteLine("");
            Console.WriteLine($"Número de vezes que a bola z foi atirada: {z.NRVezes()}");

        }
    }
}