using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class CardGameClass
    {
        public CardGameClass()
        {
            byte players = 0;
            byte cards = 0;

            string[][] massCardsTest =
            {
                new string[] { "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥" },
                new string[] { "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦" },
                new string[] { "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣" },
                new string[] { "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠" }
            };

            byte m = 0;
            string[] massCards = new string[36];
            for (int i = 0; i < 9; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    massCards[m] = massCardsTest[k][i];
                    //Console.Write(massCards[m] + " ");
                    m++;
                }
                //Console.WriteLine();
            }
            Players(ref players);

            Cards(ref cards, players);

            string[] playersCard = new string[players * cards];

            Randomize(cards, players, massCards, playersCard);

            PlayersCardDrop(cards, players, playersCard);
        }

        private void Players(ref byte players)
        {
            byte playersTemp = Convert.ToByte(Console.ReadLine());
            if (playersTemp < 2 || playersTemp > 6)
            {
                Console.WriteLine("введите число игроков от 2 до 6");
                Players(ref players);
            }
            else
            {
                players = playersTemp;
            }
        }

        private void Cards(ref byte cards, byte players)
        {
            Console.WriteLine("Как раздаем?");
            byte cardsTemp = Convert.ToByte(Console.ReadLine());
            if (players * cardsTemp > 36)
            {
                Console.WriteLine("Не хватит карт всем игрокам");
                Cards(ref cards, players);
            }
            else
            {
                cards = cardsTemp;
            }
        }

        private void Randomize(byte cards, byte players, string[] massCards, string[] playersCard )
        {
            bool repeat;

            for (int i = 0; i < cards * players;)
            {
                repeat = true;
                Random rnd = new Random();
                playersCard[i] = massCards[rnd.Next(0, 36)];
                for (int k = 1; k <= i; k++)
                {
                    if (playersCard[i] == playersCard[i - k])
                    {
                        repeat = false;
                    }
                }
                if (repeat)
                {
                    //Console.WriteLine(playersCard[i]);
                    i++;
                }
            }
        }
        public static void PlayersCardDrop(byte cards, byte players, string[] playersCard)
        {
            if (players > 1)
            {
                string[] player1Card = new string[cards];
                Console.WriteLine();
                Console.WriteLine("Player1Card");
                for (int i = 0; i < cards; i++)
                {
                    player1Card[i] = playersCard[i];
                    Console.Write(player1Card[i] + " ");
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Player2Card");
                string[] player2Card = new string[cards];
                byte temp = 0;
                for (int i = cards; i < cards * 2; i++)
                {
                    player2Card[temp] = playersCard[i];
                    Console.Write(player2Card[temp] + " ");
                    temp++;
                }
            }

            if (players > 2)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Player3Card");
                string[] player3Card = new string[cards];
                byte temp = 0;
                for (int i = cards * 2; i < cards * 3; i++)
                {
                    player3Card[temp] = playersCard[i];
                    Console.Write(player3Card[temp] + " ");
                    temp++;
                }
            }

            if (players > 3)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Player4Card");
                string[] player4Card = new string[cards];
                byte temp = 0;
                for (int i = cards * 3; i < cards * 4; i++)
                {
                    player4Card[temp] = playersCard[i];
                    Console.Write(player4Card[temp] + " ");
                    temp++;
                }
            }

            if (players > 4)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Player5Card");
                string[] player5Card = new string[cards];
                byte temp = 0;
                for (int i = cards * 4; i < cards * 5; i++)
                {
                    player5Card[temp] = playersCard[i];
                    Console.Write(player5Card[temp] + " ");
                    temp++;
                }
            }

            if (players > 5)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Player6Card");
                string[] player6Card = new string[cards];
                byte temp = 0;
                for (int i = cards * 5; i < cards * 6; i++)
                {
                    player6Card[temp] = playersCard[i];
                    Console.Write(player6Card[temp] + " ");
                    temp++;
                }
            }
        }
    }
}
