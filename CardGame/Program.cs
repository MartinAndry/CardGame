using System;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую в недоигре НеДурак!");
            Console.WriteLine("♥ ♦ ♣ ♠");
            Console.WriteLine("Сколько будет игроков?");
            byte players = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Как раздаем?");
            byte cards = Convert.ToByte(Console.ReadLine());


            string[][] massCardsTest =
            {
                new string[] { "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥" },
                new string[] { "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦" },
                new string[] { "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣" },
                new string[] { "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠" }
            };

            int m = 0;
            string[] massCards = new string[36];
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 9; k++)
                {
                    massCards[m] = massCardsTest[i][k];
                    //Console.Write(massCards[m] + " ");
                    m++;
                }
                //Console.WriteLine();
            }

            string[] Player1Card = new string[36];
            bool repeat;

            //int r1 = rnd.Next(1, 37);
            //int r2 = rnd.Next(1, 37);
            //int r3 = rnd.Next(1, 37);
            //int r4 = rnd.Next(1, 37);
            //int r5 = rnd.Next(1, 37);
            //int r6 = rnd.Next(1, 37);

            for (int i = 0; i < 6;)
            {
                repeat = true;
                Random rnd = new Random();
                Player1Card[i] = massCards[rnd.Next(0, 36)];
                for (int k = 1; k <= i; k++)
                {
                    if (Player1Card[i] == Player1Card[i - k])
                    {
                        repeat = false;
                    }
                }
                if (repeat)
                {
                    Console.WriteLine(Player1Card[i]);
                    i++;
                }
            }


            //for (int i = 0; i < Player1Card.Length; i++)
            //{
            //    Console.Write("{0}-е число: ", i + 1);
            //    Player1Card[i] = Int32.Parse(Console.ReadLine());
            //}

            // сортировка
            //int temp;
            //for (int i = 0; i < Player1Card.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < Player1Card.Length; j++)
            //    {
            //        if (Player1Card[i] > Player1Card[j])
            //        {
            //            temp = Player1Card[i];
            //            Player1Card[i] = Player1Card[j];
            //            Player1Card[j] = temp;
            //        }
            //    }
            //}

            // вывод
            //Console.WriteLine("Вывод отсортированного массива");
            //for (int i = 0; i < Player1Card.Length; i++)
            //{
            //    Console.WriteLine(Player1Card[i]);
            //}
            //Console.ReadLine();

            //Console.WriteLine(r1);
            //Console.WriteLine(r2);
            //Console.WriteLine(r3);
            //Console.WriteLine(r4);
            //Console.WriteLine(r5);
            //Console.WriteLine(r6);


        }
    }
}
