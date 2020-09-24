using System;
using System.Globalization;

namespace _DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O DateTime representa um INSTANTE, é um tipo struct(tipo valor)*/

            DateTime d1 = DateTime.Now; /*O .Now é uma proopriedade que devolve o instante atual do sistema(hora/data atual)*/

            Console.WriteLine(d1.Ticks); /*Os Ticks são um objeto que armazenas internamente a quantidade de nanosegundos desde de o começo
                                          desse era atual 1 Tick = 100 nanosegundos.*/
            /*FORMAS DE INSTANCIAR O DATETIME
             
             Construtores:
            DateTime(ano, mes, dia)
            DateTime(ano, mes, dia, hora, minuto, segundo) [Opicional: kind]
            DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo) [Opicional: kind]

            Builders:

            DateTime.Now
            DateTime.UtcNow
            DateTime.Parse(string)
            DateTime.ParseExact(string, string)
             */
            Console.WriteLine();
            DateTime d2 = new DateTime(2018, 11, 25); /*CONSTRUTUOR: DateTime(ano, mes, dia)*/
            Console.WriteLine("CONSTRUTUOR: DateTime(ano, mes, dia): " + d2);

            Console.WriteLine();
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03); /*CONSTRUTOR: DateTime(ano, mes, dia, hora, minuto, segundo)*/
            Console.WriteLine("CONSTRUTOR: DateTime(ano, mes, dia, hora, minuto, segundo): " + d3);

            Console.WriteLine();
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 03, 500); /*CONSTRUTOR: DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo)*/
            Console.WriteLine("CONSTRUTOR: DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo): " + d4);

            Console.WriteLine();
            DateTime d5 = DateTime.Now;
            Console.WriteLine("Data e Horário local atual: "+d5);

            Console.WriteLine();
            DateTime d6 = DateTime.Today;
            Console.WriteLine("Data atual sem as horas: " + d6);

            Console.WriteLine();
            DateTime d7 = DateTime.UtcNow;
            Console.WriteLine("Data e horário atual porem no formato UTC(universal): "+d7);

            Console.WriteLine();
            DateTime d8 = DateTime.Parse("2000-08-15 10:05:58"); /*Converte a string para data e horario DateTime*/
            Console.WriteLine(d8);

            Console.WriteLine();
            DateTime d9 = DateTime.Parse("15/09/2001"); /*Aceita também o padrão brasileiro (dia/mes/ano)*/
            Console.WriteLine(d9);

            Console.WriteLine();
            DateTime d10 = DateTime.ParseExact("2000-08-15","yyyy-MM-dd", CultureInfo.InvariantCulture); /*O ParseExact permite determinar o formato da data como for necessário*/
            Console.WriteLine(d10);

            Console.WriteLine();
            DateTime d11 = DateTime.ParseExact("16/09/2001 18:30:45", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);
        }
    }
}
