using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresAndEnums_KT13
{
        public class Program
        {
            public static void Main()
            {
                Console.WriteLine("Игральные карты");
                Console.WriteLine();

                Card[] cards = new Card[5];

                cards[0] = new Card
                {
                    Suit = Suit.Hearts,
                    Rank = Rank.King
                };

                cards[1] = new Card
                {
                    Suit = Suit.Spades,
                    Rank = Rank.Ace
                };

                cards[2] = new Card
                {
                    Suit = Suit.Diamonds,
                    Rank = Rank.Queen
                };

                cards[3] = new Card
                {
                    Suit = Suit.Clubs,
                    Rank = Rank.Ten
                };

                cards[4] = new Card
                {
                    Suit = Suit.Hearts,
                    Rank = Rank.Seven
                };

                Console.WriteLine("Карты в коллекции:");

                for (int i = 0; i < cards.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {cards[i]}");
                }

                Console.WriteLine();

                Card copy = cards[0];

                Console.WriteLine($"cards[0] до изменения копии: {cards[0]}");

                while (true)
                {
                    try
                    {
                        Console.Write("Введите новое достоинство для копии: ");
                        string input = Console.ReadLine();

                        if (Enum.TryParse<Rank>(input, out Rank newRank))
                        {
                            copy.Rank = newRank;
                            break;
                        }

                        throw new ArgumentException(
                            "Такого достоинства карты нет."
                        );
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.WriteLine("Попробуйте ещё раз.");
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
                Console.WriteLine("После изменения копии:");
                Console.WriteLine($"Копия:     {copy}");
                Console.WriteLine($"cards[0]:  {cards[0]}");
                Console.WriteLine();

                Console.WriteLine("Проверка Enum.TryParse:");

                while (true)
                {
                    try
                    {
                        Console.Write("Введите достоинство карты для проверки: ");
                        string input = Console.ReadLine();

                        if (Enum.TryParse<Rank>(input, out Rank rank))
                        {
                            Console.WriteLine(
                                $"\"{input}\" -> true, значение: {rank}"
                            );
                            break;
                        }

                        Console.WriteLine(
                            $"\"{input}\" -> false, без исключения"
                        );
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
            }
        }
    
}
