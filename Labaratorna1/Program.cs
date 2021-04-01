using System;
using System.Collections.Generic;

namespace Labaratorna1
{
    
class osnova
    {
        public int price;
        public int sebeprice;
        public int ves;
        public int time;
        public string name;
        public osnova(string n, int p, int s, int v, int t) { name = n; price = p; sebeprice = s; ves = v; time = t; }
        public void GetInfo()
        {
            Console.WriteLine($"Название:{name} Цена:{price} Себестоимость:{sebeprice} Вес:{ves} Время приготовления:{time}");
        }
    }
    class zakuzki
    {
        public int price;
        public int sebeprice;
        public int ves;
        public int time;
        public string name;
        public zakuzki(string n, int p, int s, int v, int t) { name = n; price = p;sebeprice = s;ves = v;time = t; }
        public void GetInfo()
        {
            Console.WriteLine($"Название:{name} Цена:{price} Себестоимость:{sebeprice} Вес:{ves} Время приготовления:{time}");
        }
    }
    class napitki
    {
        public int price;
        public int sebeprice;
        public int ves;
        public int time;
        public string name;
        public napitki(string n, int p, int s, int v, int t) { name = n; price = p; sebeprice = s; ves = v; time = t; }

        public void GetInfo()
        {
            Console.WriteLine($"Название:{name} Цена:{price} Себестоимость:{sebeprice} Вес:{ves} Время приготовления:{time}");
        }
        
    }
    class zakaz
    {
        public string name;
        public int number;
        
        public int time;
        public int price;
        public int sebeprice;
        public int ves;
        public zakaz(int n1,string n,int p, int s, int v, int t) { number = n1; name = n;; price = p; sebeprice = s; ves = v; time = t; }
       
        
    }
    class Program
    {
        public static int GetNumber()
        {
            int operation = 0;
            string bukvi = null;
            bool check = true;
            while (check)
            {

                bukvi = Console.ReadLine();

                if (!int.TryParse(bukvi, out operation))
                {
                    Console.WriteLine("Введите заново");
                }
                else
                {
                    check = false;
                }
            }
            return operation;
        }
        
            static void Main(string[] args)
        {
            osnova borsh = new osnova("Борщ", 50, 40, 210, 300);
            osnova plov = new osnova("Плов", 55, 30, 170, 220);
            osnova pure = new osnova("Пюре", 20, 15, 100, 120);
            osnova grecha = new osnova("Гречневая каша", 60, 40, 100, 130);
            osnova sirnik = new osnova("Сырник", 20, 10, 50, 140);
            
            zakuzki buter = new zakuzki("Бутерброд с колбасой", 15,10,25,20);       
            zakuzki semechki = new zakuzki("Семечки", 10, 7, 25, 20);
            zakuzki cher = new zakuzki("Чёрный хлеб", 6, 5, 15, 20); 
            zakuzki cruas = new zakuzki("Круассан", 20, 10, 15, 30);            
            zakuzki tartal = new zakuzki("Тарталетки", 35, 23, 25, 90);
            
            napitki yasok = new napitki("Яблочный сок", 32, 14, 70, 20);           
            napitki ansok = new napitki("Ананасовый сок", 32, 16, 70, 20);          
            napitki apsok = new napitki("Апельсиновый сок", 32, 14, 70, 20);          
            napitki chai = new napitki("Чай", 15, 10, 45, 20);          
            napitki kofe = new napitki("Кофе", 15, 10, 45, 20);
            int glmenu;
            int cena=0;
            int number = 1;
            int konec;
            int porcii;
            int viruchka=0;
            int sebestoimost=0;
            int pribil = 0;


            List<zakaz> Spisok = new List<zakaz>();
            while (true)
            { 
                    Console.WriteLine("1 - Сделать заказ");
                    Console.WriteLine("2 - Показать заказы");
                    Console.WriteLine("3 - Общая выручка и чистая прибыль");
                    Console.WriteLine("4 - Выход");
                    glmenu = GetNumber();

                    switch (glmenu)
                    {
                        case 3:
                        {  pribil = viruchka - sebestoimost;
                            Console.WriteLine($"Общая выручка:{viruchka} Чистая прибыль:{pribil}");
                            break;
                        }
                        case 2:

                        {   
                            foreach (zakaz item in Spisok)
                            { Console.WriteLine($"Номер: {item.number} Название :{item.name} Цена: {item.price} Себестоимость: {item.sebeprice} Время: {item.time} Вес: {item.ves}") ; } 
                            break;
                        }
                        case 4:
                        cena = 0;
                        Spisok.Clear();
                            break;
                        case 1:
                        {                             
                            
                                int sdelzakaz;
                                Console.WriteLine("1 - Основные блюда");
                                Console.WriteLine("2 - Закузски");
                                Console.WriteLine("3 - Напитки");
                                sdelzakaz = GetNumber();
                                switch (sdelzakaz)
                                {
                                case 3:
                                    {
                                        Console.WriteLine($"1 - {yasok.name} Цена: {yasok.price} Время: {yasok.time}");
                                        Console.WriteLine($"2 - {ansok.name} Цена: {ansok.price} Время: {ansok.time}");
                                        Console.WriteLine($"3 - {apsok.name} Цена: {apsok.price} Время: {apsok.time}");
                                        Console.WriteLine($"4 - {chai.name} Цена: {chai.price} Время: {chai.time}");
                                        Console.WriteLine($"5 - {kofe.name} Цена: {kofe.price} Время: {kofe.time}");
                                        int napzakaz = GetNumber();
                                        switch (napzakaz)
                                        {
                                            case 1:
                                                {
                                                    Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                    porcii = GetNumber();

                                                    cena = cena + yasok.price * porcii;

                                                    for (int i = 1; i <= porcii; i++)
                                                    {
                                                        Spisok.Add(new zakaz(number, yasok.name, yasok.price, yasok.sebeprice, yasok.ves, yasok.time));
                                                        number++;
                                                    }
                                                    viruchka = viruchka + yasok.price * porcii;
                                                    sebestoimost = sebestoimost + yasok.sebeprice * porcii;
                                                    Console.WriteLine("1 - Продолжить заказ");
                                                    Console.WriteLine("2 - Закончить заказ");
                                                    konec = GetNumber();
                                                    switch (konec)
                                                    {
                                                        case 1:
                                                            {
                                                                
                                                                break;
                                                            }
                                                        case 2:
                                                            Console.WriteLine($"Конечная стоимость:{cena}");

                                                            cena = 0;
                                                            break;
                                                    }

                                                    break;

                                                }
                                            case 2:
                                                {
                                                    Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                    porcii = GetNumber();

                                                    cena = cena + ansok.price * porcii;
                                                    for (int i = 1; i <= porcii; i++)
                                                    {
                                                        Spisok.Add(new zakaz(number, ansok.name, ansok.price, ansok.sebeprice, ansok.ves, ansok.time));
                                                        number++;
                                                    }
                                                    viruchka = viruchka + ansok.price * porcii;
                                                    sebestoimost = sebestoimost + ansok.sebeprice * porcii;
                                                    Console.WriteLine("1 - Продолжить заказ");
                                                    Console.WriteLine("2 - Закончить заказ");
                                                    konec = GetNumber();
                                                    switch (konec)
                                                    {
                                                        case 1:
                                                            {
                                                                
                                                                break;
                                                            }
                                                        case 2:
                                                            Console.WriteLine($"Конечная стоимость:{cena}");

                                                            cena = 0;
                                                            break;
                                                    }

                                                    break;

                                                }
                                            case 3:
                                                {
                                                    Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                    porcii = GetNumber();

                                                    cena = cena + apsok.price * porcii;

                                                    for (int i = 1; i <= porcii; i++)
                                                    {
                                                        Spisok.Add(new zakaz(number, apsok.name, apsok.price, apsok.sebeprice, apsok.ves, apsok.time));
                                                        number++;
                                                    }
                                                    viruchka = viruchka + apsok.price * porcii;
                                                    sebestoimost = sebestoimost + apsok.sebeprice * porcii;
                                                    Console.WriteLine("1 - Продолжить заказ");
                                                    Console.WriteLine("2 - Закончить заказ");
                                                    konec = GetNumber();
                                                    switch (konec)
                                                    {
                                                        case 1:
                                                            {
                                                                break;
                                                            }
                                                        case 2:
                                                            Console.WriteLine($"Конечная стоимость:{cena}");

                                                            cena = 0;
                                                            break;
                                                    }

                                                    break;

                                                }
                                            case 4:
                                                {
                                                    Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                    porcii = GetNumber();

                                                    cena = cena + chai.price * porcii;
                                                    for (int i = 1; i <= porcii; i++)
                                                    {
                                                        Spisok.Add(new zakaz(number, chai.name, chai.price, chai.sebeprice, chai.ves, chai.time));
                                                        number++;
                                                    }
                                                    viruchka = viruchka + chai.price * porcii;
                                                    sebestoimost = sebestoimost + chai.sebeprice * porcii;
                                                    Console.WriteLine("1 - Продолжить заказ");
                                                    Console.WriteLine("2 - Закончить заказ");
                                                    konec = GetNumber();
                                                    switch (konec)
                                                    {
                                                        case 1:
                                                            {
                                                                
                                                                break;
                                                            }
                                                        case 2:
                                                            Console.WriteLine($"Конечная стоимость:{cena}");

                                                            cena = 0;
                                                            break;
                                                    }

                                                    break;

                                                }
                                            case 5:
                                                {
                                                    Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                    porcii = GetNumber();

                                                    cena = cena + kofe.price * porcii;

                                                    for (int i = 1; i <= porcii; i++)
                                                    {
                                                        Spisok.Add(new zakaz(number, kofe.name, kofe.price, kofe.sebeprice, kofe.ves, kofe.time));
                                                        number++;
                                                    }
                                                    viruchka = viruchka + kofe.price * porcii;
                                                    sebestoimost = sebestoimost + kofe.sebeprice * porcii;
                                                    Console.WriteLine("1 - Продолжить заказ");
                                                    Console.WriteLine("2 - Закончить заказ");
                                                    konec = GetNumber();
                                                    switch (konec)
                                                    {
                                                        case 1:
                                                            {
                                                                
                                                                break;
                                                            }
                                                        case 2:
                                                            Console.WriteLine($"Конечная стоимость:{cena}");

                                                            cena = 0;
                                                            break;
                                                    }

                                                    break;

                                                }
                                                
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine($"1 - {buter.name} Цена: {buter.price} Время: {buter.time}");
                                        Console.WriteLine($"2 - {semechki.name} Цена: {semechki.price} Время: {semechki.time}");
                                        Console.WriteLine($"3 - {cher.name} Цена: {cher.price} Время: {cher.time}");
                                        Console.WriteLine($"4 - {cruas.name} Цена: {cruas.price} Время: {cruas.time}");
                                        Console.WriteLine($"5 - {tartal.name} Цена: {tartal.price} Время: {tartal.time}");
                                        int zakzakaz = GetNumber();
                                        switch (zakzakaz)
                                        {
                                            case 1:
                                                {
                                                    Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                    porcii = GetNumber();

                                                    cena = cena + buter.price * porcii;

                                                    for (int i = 1; i <= porcii; i++)
                                                    {
                                                        Spisok.Add(new zakaz(number, buter.name, buter.price, buter.sebeprice, buter.ves, buter.time));
                                                        number++;
                                                    }
                                                    viruchka = viruchka + buter.price * porcii;
                                                    sebestoimost = sebestoimost + buter.sebeprice * porcii;
                                                    Console.WriteLine("1 - Продолжить заказ");
                                                    Console.WriteLine("2 - Закончить заказ");
                                                    konec = GetNumber();
                                                    switch (konec)
                                                    {
                                                        case 1:
                                                            {
                                                               
                                                                break;
                                                            }
                                                        case 2:
                                                            Console.WriteLine($"Конечная стоимость:{cena}");

                                                            cena = 0;
                                                            break;
                                                    }

                                                    break;

                                                }
                                            case 2:
                                                {
                                                    Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                    porcii = GetNumber();

                                                    cena = cena + semechki.price * porcii;
                                                    for (int i = 1; i <= porcii; i++)
                                                    {
                                                        Spisok.Add(new zakaz(number, semechki.name, semechki.price, semechki.sebeprice, semechki.ves, semechki.time));
                                                        number++;
                                                    }
                                                    viruchka = viruchka + semechki.price * porcii;
                                                    sebestoimost = sebestoimost + semechki.sebeprice * porcii;
                                                    Console.WriteLine("1 - Продолжить заказ");
                                                    Console.WriteLine("2 - Закончить заказ");
                                                    konec = GetNumber();
                                                    switch (konec)
                                                    {
                                                        case 1:
                                                            {
                                                                
                                                                break;
                                                            }
                                                        case 2:
                                                            Console.WriteLine($"Конечная стоимость:{cena}");

                                                            cena = 0;
                                                            break;
                                                    }

                                                    break;

                                                }
                                            case 3:
                                                {
                                                    Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                    porcii = GetNumber();

                                                    cena = cena + cher.price * porcii;
                                                    for (int i = 1; i <= porcii; i++)
                                                    {
                                                        Spisok.Add(new zakaz(number, cher.name, cher.price, cher.sebeprice, cher.ves, cher.time));
                                                        number++;
                                                    }
                                                    viruchka = viruchka + cher.price * porcii;
                                                    sebestoimost = sebestoimost + cher.sebeprice * porcii;
                                                    Console.WriteLine("1 - Продолжить заказ");
                                                    Console.WriteLine("2 - Закончить заказ");
                                                    konec = GetNumber();
                                                    switch (konec)
                                                    {
                                                        case 1:
                                                            {
                                                               
                                                                break;
                                                            }
                                                        case 2:
                                                            Console.WriteLine($"Конечная стоимость:{cena}");

                                                            cena = 0;
                                                            break;
                                                    }

                                                    break;

                                                }
                                            case 4:
                                                {
                                                    Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                    porcii = GetNumber();

                                                    cena = cena + cruas.price * porcii;
                                                    for (int i = 1; i <= porcii; i++)
                                                    {
                                                        Spisok.Add(new zakaz(number, cruas.name, cruas.price, cruas.sebeprice, cruas.ves, cruas.time));
                                                        number++;
                                                    }
                                                    viruchka = viruchka + cruas.price * porcii;
                                                    sebestoimost = sebestoimost + cruas.sebeprice * porcii;
                                                    Console.WriteLine("1 - Продолжить заказ");
                                                    Console.WriteLine("2 - Закончить заказ");
                                                    konec = GetNumber();
                                                    switch (konec)
                                                    {
                                                        case 1:
                                                            {
                                                                
                                                                break;
                                                            }
                                                        case 2:
                                                            Console.WriteLine($"Конечная стоимость:{cena}");

                                                            cena = 0;
                                                            break;
                                                    }

                                                    break;

                                                }
                                            case 5:
                                                {
                                                    Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                    porcii = GetNumber();

                                                    cena = cena + tartal.price * porcii;

                                                    for (int i = 1; i <= porcii; i++)
                                                    {
                                                        Spisok.Add(new zakaz(number, tartal.name, tartal.price, tartal.sebeprice, tartal.ves, tartal.time));
                                                        number++;
                                                    }
                                                    viruchka = viruchka + tartal.price * porcii;
                                                    sebestoimost = sebestoimost + tartal.sebeprice * porcii;
                                                    Console.WriteLine("1 - Продолжить заказ");
                                                    Console.WriteLine("2 - Закончить заказ");
                                                    konec = GetNumber();
                                                    switch (konec)
                                                    {
                                                        case 1:
                                                            {
                                                                
                                                                break;
                                                            }
                                                        case 2:
                                                            Console.WriteLine($"Конечная стоимость:{cena}");

                                                            cena = 0;
                                                            break;
                                                    }

                                                    break;

                                                }

                                        }
                                        break;
                                    }
                                case 1:
                                        Console.WriteLine($"1 - {borsh.name} Цена: {borsh.price} Время: {borsh.time}");
                                        Console.WriteLine($"2 - {plov.name} Цена: {plov.price} Время: {plov.time}");
                                        Console.WriteLine($"3 - {grecha.name} Цена: {grecha.price} Время: {grecha.time}");
                                        Console.WriteLine($"4 - {pure.name} Цена: {pure.price} Время: {pure.time}");
                                        Console.WriteLine($"5 - {sirnik.name} Цена: {sirnik.price} Время: {sirnik.time}");
                                    int osnzakaz = GetNumber();
                                        switch (osnzakaz)
                                        {
                                        case 5:
                                            {
                                                Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                porcii = GetNumber();

                                                cena = cena + sirnik.price * porcii;

                                                for (int i = 1; i <= porcii; i++)
                                                {
                                                    Spisok.Add(new zakaz(number, sirnik.name, sirnik.price, sirnik.sebeprice, sirnik.ves, sirnik.time));
                                                    number++;
                                                }
                                                viruchka = viruchka + sirnik.price * porcii;
                                                sebestoimost = sebestoimost + sirnik.sebeprice * porcii;
                                                Console.WriteLine("1 - Продолжить заказ");
                                                Console.WriteLine("2 - Закончить заказ");
                                                konec = GetNumber();
                                                switch (konec)
                                                {
                                                    case 1:
                                                        {
                                                            
                                                            break;
                                                        }
                                                    case 2:
                                                        Console.WriteLine($"Конечная стоимость:{cena}");

                                                        cena = 0;
                                                        break;
                                                }

                                                break;

                                            }
                                        case 4:
                                            {
                                                Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                porcii = GetNumber();

                                                cena = cena + pure.price * porcii;
                                                for (int i = 1; i <= porcii; i++)
                                                {
                                                    Spisok.Add(new zakaz(number, pure.name, pure.price, pure.sebeprice, pure.ves, pure.time));
                                                    number++;
                                                }
                                                viruchka = viruchka + pure.price * porcii;
                                                sebestoimost = sebestoimost + pure.sebeprice * porcii;
                                                Console.WriteLine("1 - Продолжить заказ");
                                                Console.WriteLine("2 - Закончить заказ");
                                                konec = GetNumber();
                                                switch (konec)
                                                {
                                                    case 1:
                                                        {
                                                            
                                                            break;
                                                        }
                                                    case 2:
                                                        Console.WriteLine($"Конечная стоимость:{cena}");

                                                        cena = 0;
                                                        break;
                                                }

                                                break;

                                            }
                                        case 3:
                                            {
                                                Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                porcii = GetNumber();

                                                cena = cena + grecha.price * porcii;

                                                for (int i = 1; i <= porcii; i++)
                                                {
                                                    Spisok.Add(new zakaz(number, grecha.name, grecha.price, grecha.sebeprice, grecha.ves, grecha.time));
                                                    number++;
                                                }
                                                viruchka = viruchka + grecha.price * porcii;
                                                sebestoimost = sebestoimost + grecha.sebeprice * porcii;
                                                Console.WriteLine("1 - Продолжить заказ");
                                                Console.WriteLine("2 - Закончить заказ");
                                                konec = GetNumber();
                                                switch (konec)
                                                {
                                                    case 1:
                                                        {
                                                            
                                                            break;
                                                        }
                                                    case 2:
                                                        Console.WriteLine($"Конечная стоимость:{cena}");

                                                        cena = 0;
                                                        break;
                                                }

                                                break;

                                            }
                                        case 2:
                                            {
                                                Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                porcii = GetNumber();

                                                cena = cena + plov.price * porcii;
                                                for (int i = 1; i <= porcii; i++)
                                                {
                                                    Spisok.Add(new zakaz(number, plov.name, plov.price, plov.sebeprice, plov.ves, plov.time));
                                                    number++;
                                                }
                                                viruchka = viruchka + plov.price * porcii;
                                                sebestoimost = sebestoimost + plov.sebeprice * porcii;
                                                Console.WriteLine("1 - Продолжить заказ");
                                                Console.WriteLine("2 - Закончить заказ");
                                                konec = GetNumber();
                                                switch (konec)
                                                {
                                                    case 1:
                                                        {
                                                            
                                                            break;
                                                        }
                                                    case 2:
                                                        Console.WriteLine($"Конечная стоимость:{cena}");

                                                        cena = 0;
                                                        break;
                                                }

                                                break;

                                            }

                                        case 1:
                                                Console.WriteLine("Сколько порций Вы хотите заказть?");
                                                 porcii = GetNumber();
                                           
                                            cena = cena + borsh.price*porcii;

                                            for (int i = 1; i <= porcii; i++)
                                            {
                                                Spisok.Add(new zakaz(number, borsh.name, borsh.price, borsh.sebeprice, borsh.ves, borsh.time));
                                                number++;
                                            }
                                            viruchka = viruchka + borsh.price * porcii;
                                            sebestoimost = sebestoimost + borsh.sebeprice * porcii;
                                            Console.WriteLine("1 - Продолжить заказ");
                                                Console.WriteLine("2 - Закончить заказ");
                                                konec = GetNumber();
                                                switch (konec)
                                                {
                                                    case 1:
                                                    {   
                                                        break;
                                                    }
                                                    case 2:
                                                        Console.WriteLine($"Конечная стоимость:{cena}");
                                                        
                                                    cena = 0;
                                                    break;
                                                }

                                                break;
                                        }
                                        break;

                                }break;
                                
                            }
                       
                }
                }

            }

            
        }
    }

