using System;
using System.ComponentModel.Design;

namespace Codick
{
    internal class Program
    {
        static DateTime vremya = DateTime.Now;
       
        static int TudaSuda = 0;
        static int Dela = 1;
        static void Main(string[] args)
        {
            Zametka a = new Zametka()
            {
                Day = 6,
                name = "Помыть пол",
                description = "Тщательно и с мылом"
            };
            Zametka.zametks.Add(a);
            Zametka b = new Zametka()
            {
                Day = 6,
                name = "Записаться к стоматологу",
                description = "Для того чтобы стамотолог наконец уже накопил на машину"
            };
            Zametka.zametks.Add(b);
            Zametka c = new Zametka()
            {
                Day = 6,
                name = "Отдых",
                description = "Это самое лучшее что может быть "
            };
            Zametka.zametks.Add(c);
            Zametka d = new Zametka()
            {
                Day = 7,
                name = "Музыка",
                description = "Слушать музыку и наслаждаться"
            };
            Zametka.zametks.Add(d);
            Zametka e = new Zametka()
            {
                Day = 8,
                name = "Отправиться на учебу",
                description = "чтобы увидеть своих одногрупников :)"
            };
            Zametka.zametks.Add(e);
            Zametka f = new Zametka()
            {
                Day = 8,
                name = "Покушать",
                description = "Сначала нужно приготовить!!"
            };
            Zametka.zametks.Add(f);
            Zametka g = new Zametka()
            {
                Day = 9,
                name = "Смотреть сериал",
                description = "Нужно выбрать между Хатико и Сумерками"
            };
            Zametka.zametks.Add(g);
            Zametka h = new Zametka()
            {
                Day = 9,
                name = "Пойти на танцы",
                description = "И выучить новую связку"
            };
            Zametka.zametks.Add(h);
            Zametka i = new Zametka()
            {
                Day = 10,
                name = "Прийти на пары",
                description = "Пытаться не уснуть"
            };
            Zametka.zametks.Add(i);
            Zametka j = new Zametka()
            {
                Day = 10,
                name = "Сходить в парикмахерскую",
                description = "Сделать уже наконец каре!!!!"
            };
            Zametka.zametks.Add(j);
            Zametka k = new Zametka()
            {
                Day = 11,
                name = "Купить себе новый костюм",
                description = "Чтобы не замерзнуть зимой"
            };
            Zametka.zametks.Add(k);
            Zametka l = new Zametka()
            {
                Day = 11,
                name = "Купить бомбочку для ванны",
                description = "С запахом кокоса и желательно по скидке"
            };
            Zametka.zametks.Add(l);
            Zametka m = new Zametka()
            {
                Day = 11,
                name = "Принять ванну",
                description = "Обязательно горячую и с бомбочкой!"
            };
            Zametka.zametks.Add(m);
            Zametka n = new Zametka()
            {
                Day = 16,
                name = "Сходить в бассен",
                description = "Плавание очень полезно"
            };
            Zametka.zametks.Add(n);

            while (true)
            {
                Datas();
                Clavisha();
                Strelka();
            }
        }
        private static void Clavisha()
        
        {
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    TudaSuda--;
                    break;
                case ConsoleKey.RightArrow:
                    TudaSuda++;

                    break;
                case ConsoleKey.UpArrow:
                    if (Dela < 3)
                    {
                        Dela = 2;
                    }
                    else
                    {
                        Dela--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Dela > 3)
                    {
                        Dela = 2 ;
                    }
                    else
                    {
                        Dela++;
                    }
                    break;

                case ConsoleKey.Insert:
                    СоздатьЗаметку();
                    break;
                case ConsoleKey.Enter:
                    Pometka();
                    Console.ReadKey();
                    break;
                case ConsoleKey.Escape:
                    
                    Console.Write("/t Пока покаа!");
                    Environment.Exit(0);
                    break;
                
            }
        }
        private static void СоздатьЗаметку()
        {
            Console.Clear();
            Console.WriteLine("Создание новой заметки:");

            Console.Write("Введите день: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц:");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите год:");
            int year = int.Parse(Console.ReadLine());   

            Console.Write("Введите название заметки: ");
            string name = Console.ReadLine();

            Console.Write("Введите описание заметки: ");
            string description = Console.ReadLine();

            Zametka newZametka = new Zametka()
            {
                Day = day,
                name = name,
                description = description
            };
            Zametka.zametks.Add(newZametka);

            Console.WriteLine("Заметка успешно создана!");
            Console.ReadKey();
        }
        private static void Datas()
        {
            int when = 0;
            Console.SetCursorPosition(4, 1);
            Console.WriteLine($"Дела на: {vremya.AddDays(TudaSuda).Day}.{vremya.AddDays(TudaSuda).Month}.{vremya.AddDays(TudaSuda).Year}");
            foreach (var element in Zametka.zametks)
            {
                if (element.Day == vremya.AddDays(TudaSuda).Day)
                {
                    when++;
                    Console.SetCursorPosition(4, when + 1);
                    element.Number = when;
                    Console.Write($"{element.Number}.{element.name}\n");
                }
            }

        }

       

        private static void Pometka()
        {
            int when = 0;
            Console.Clear();
            foreach (var element in Zametka.zametks)
            {
                if (element.Day == vremya.AddDays(TudaSuda).Day)
                {
                    when++;
                    element.Number = when;
                    if (when == Dela - 1)
                    {

                        Console.WriteLine($"{vremya.AddDays(TudaSuda).Day}.{vremya.AddDays(TudaSuda).Month}.{vremya.AddDays(TudaSuda).Year}");
                        Console.Write($"  {element.name}\n");
                        Console.Write(" " + element.description);
                    }
                }
            }
        }


        private static void Strelka()
        {
           Console.Clear();
           Console.SetCursorPosition(0, Dela);
           Console.Write("->");
           
        }
    }
}