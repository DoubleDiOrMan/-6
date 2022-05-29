using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> QuotLine = new List<string>(); // создание List для цитат
            List<int> Count = new List<int>(); //создание List для учета просмотров
            QuotLine.Add("Не бывает безвыходных ситуаций. Бывают ситуации, выход из которых тебя не устраивает");
            Count.Add(0);
            QuotLine.Add("Быть слишком умным не всегда к месту");
            Count.Add(0);
            QuotLine.Add("Я бы с удовольствием пригласил тебя выпить, но боюсь ты согласишься");
            Count.Add(0);
            QuotLine.Add("Лучше умереть, когда ты этого не ожидаешь, чем умереть когда ты уже устал жить");
            Count.Add(0);
            int ant = 1; //переменная для выбора действия
            int ant1 = 1; //переменная для выбора действия


            while (ant != 0)
            {
                Console.WriteLine("Choose action: \n 1 - Input new quot \n 2 - Read Quot \n 3 - All citatas");
                ant = Convert.ToInt32(Console.ReadLine());

                switch (ant)
                {
                    case 1:                                                          
                        QuotLine.Add(Console.ReadLine());                            
                        Count.Add(0);                                                
                        Console.WriteLine("/n");
                        break;
                    case 2:
                        Console.WriteLine("Choose quote");
                        for (int i = 0; i < QuotLine.Count; i++)
                        {
                            if (QuotLine[i].Length < 10)// Вывод частей цитат с длиной меньше 10 символов*/
                            {
                                Console.WriteLine(i + 1 + ". " + QuotLine[i]);
                            }
                            else                        /* Вывод частей цитат с длиной больше 10 символов*/
                            {
                                Console.WriteLine(i + 1 + ". " + QuotLine[i].Substring(0, 10) + "...");
                            }

                        }
                        ant1 = Convert.ToInt32(Console.ReadLine());
                        ant1--;
                        Console.WriteLine("Quot: " + QuotLine[ant1]); /* Вывод цитаты*/                      
                        Count[ant1]++;                    
                        Console.WriteLine("Amount of output : " + Count[ant1]);/* Вывод кол.-ва просмотров*/

                        break;
                    case 3:
                        Console.WriteLine("All citatas:\n");
                        for (int i = 0; i < QuotLine.Count; i++)
                        {
                            
                            Console.WriteLine(" ["+(i + 1)+"] " + QuotLine[i] + "\n");
                        }
                        break;
                    default:
                        Console.WriteLine("\tВыберите в пределах первых трех натуральных чисел!\n\tP.s Ноль незя!\n");
                        break;

                }
            }
             Console.ReadLine();
        }
    }
}
