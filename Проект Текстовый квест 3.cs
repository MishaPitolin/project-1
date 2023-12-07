using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace текстовый_квест_проект
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тема: Текстовый квест");

            Console.WriteLine("Пропустить обучение?");
            Console.WriteLine("1) Нет");
            Console.WriteLine("2) Да");
            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("Правила игры: ");
                Console.ReadKey();
                Console.WriteLine("1) До слов 'Сделайте выбор' нажимать только продолжить, 'Enter' ");
                string inscryption = "Правила игры: ";
                inscryption += "1. Не обманывайте. ";
                inscryption += "2. Уважайте соперников. ";
                inscryption += "3. Следуйте инструкциям. ";
                Console.WriteLine(inscryption);

                Console.ReadKey();
                Console.WriteLine("Данная игра вдохновлялась сюжетом игры 'Inscryption'");
                Console.ReadKey();

                Console.WriteLine("———————————");
                Console.WriteLine("|  *****  |");
                Console.WriteLine("|—————————|");
                Console.WriteLine("|        0| <—— Цена карты");
                Console.WriteLine("| ******* |");
                Console.WriteLine("| ******* |");
                Console.WriteLine("| ******* |");
                Console.WriteLine("|—————————|");
                Console.WriteLine("| 0     0 |");
                Console.WriteLine("———————————");
                Console.WriteLine("  |     |");
                Console.WriteLine("атака здоровье");
                Console.ReadKey();
                Console.Clear();

                Console.ReadKey();
                Console.WriteLine("Начнём игру!!! ");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Перед вами сейчас повиться игровое поле: ");

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("В самом верхнем ряду находятся карты противника, но они ещё не на игровом поле");
                Console.ReadKey();

                Console.WriteLine("Далее идут 2 ряда: ");
                Console.ReadKey();

                Console.WriteLine("Средний - на нём распалогаются крты противника которые могут нанести вам урон");
                Console.ReadKey();
                Console.WriteLine("И нижний на нём рассполагаются ваши карты с помощью которых вы скорее всего сможете победить");

                Console.ReadKey();
                Console.Clear();

                Console.ReadKey();
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                /*
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                */
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("На данный момент у тебя в колоде присутствует 5 карт и 10 белок");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Белки — бесплатные, но ограниченные карты которые не атакуют");
                Console.ReadKey();
                Console.Clear();


                Console.WriteLine("———————————");
                Console.WriteLine("|  БЕЛКА  |");
                Console.WriteLine("|—————————|");
                Console.WriteLine("|        0|");
                Console.WriteLine("| (|___|) |");
                Console.WriteLine("| (='.'=) |");
                Console.WriteLine("| (')_(') |");
                Console.WriteLine("|—————————|");
                Console.WriteLine("| 0     1 |");
                Console.WriteLine("——————————— *10");

                Console.Clear();

                Console.WriteLine("Для удачного начала игры нужно:");
                Console.WriteLine("Кидать белку так как она бесплатная");
                Console.WriteLine("Далее нужно постепенно увеличивать колличество карт на столе");
                Console.WriteLine("Вот только после этого кидать более сильные карты избавляясь от менее сильных");

                Console.ReadKey();
                Console.Clear();
            }
            /*
            ——————————— ———————————
            |..БЕЛКА..| |ГОРНОСТАЙ|
            |—————————| |—————————|
            |........0| |........1|
            |.(|___|).| |../\_/\..|
            |.(='.'=).| |.(='.'=).|
            |.(')_(').| |.(')_(').|
            |—————————| |—————————|
            |.0.....1.| |.1.....3.|
            ——————————— ———————————

            ——————————— ———————————
            |...Волк..| |...Клоп..|
            |—————————| |—————————|
            |./\__/\.2| |...,-..]]|
            |/.\../.\.| |...\_/...|
            ||......|.| |..(о.о)..|
            |.\_||_/..| |..~...~..|
            |—————————| |—————————|
            |.3.....2.| |.1.§§§.3.|
            ——————————— ———————————

            ——————————— ———————————
            |ВОЛЧЁНОК.| |Мал.Волк.|
            |—————————| |—————————|
            |........1| |.<_____>2|
            |../\_/\..| |./.....\.|
            |.( о.о ).| |.|.°.°.|.|
            |..>.^.<..| |.\__∆__/.|
            |—————————| |—————————|
            |.1.1»>.1.| |.2.....2.|
            ——————————— ———————————

            ——————————— ———————————
            |..ВОРОН..| |..ЖАБА...|
            |—————————| |—————————|
            |........2| |........1|
            |.....__..| |..@___@..|
            |..../.о>.| |.(='o'.).|
            |..(____).| |..\...\\.|
            |—————————| |—————————|
            |.2./#..3.| |.1.\#..2.|
            ——————————— ———————————

            ——————————— ———————————
            |.ОПОССУМ.| |.БОГОМОЛ.|
            |—————————| |—————————|
            |.......]]| |........1|
            |.(.......| |()....().|
            |.\/(==*)>| ||......|.|
            |....\.\\.| |\ (**) /.|
            |—————————| |—————————|
            |.1.....1.| |.1.<.>.1.|
            ——————————— ———————————

            ——————————— ———————————
            |БОГОМОЛ.Б| |.ГАДЮКА..|
            |—————————| |—————————|
            |........0| |........1|
            |.^..^..^.| |.__...._/|
            |.|..|..|.| |(°°)__/_/|
            |.\(*_*)/.| |..\____/.|
            |—————————| |—————————|
            |.1.<^>.1.| |.1..×..3.|
            ——————————— ———————————
            */
            else if (a == 2)
            {
                Console.WriteLine("Вот список твоих карт: ");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine( "——————————— ——————————— ——————————— ———————————");
                Console.WriteLine( "|ГОРНОСТАЙ| |..ЖАБА...| |..ВОРОН..| |...Клоп..|");
                Console.WriteLine( "|—————————| |—————————| |—————————| |—————————|");
                Console.WriteLine( "|........1| |........1| |........2| |...,-,.]]|");
                Console.WriteLine(@"|../\_/\..| |..@___@..| |.....__..| |...\_/...|");
                Console.WriteLine( "|.(='.'=).| |.(='o'.).| |..../.о>.| |..(о.о)..|");
                Console.WriteLine(@"|.(')_(').| |..\...\\.| |..(____).| |..~...~..|");
                Console.WriteLine( "|—————————| |—————————| |—————————| |—————————|");
                Console.WriteLine(@"|.1.....3.| |.1.\#..2.| |.2./#..3.| |.1.§§§.3.|");
                Console.WriteLine( "——————————— ——————————— ——————————— ———————————");
                Console.ReadKey();
                Console.Clear();
            }

            Random rnd = new Random();
            int value = rnd.Next(1, 4);

            if (value == 1)
            {
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|..ВОРОН..| |         | |         | |         |");
                Console.WriteLine("|—————————| |         | |         | |         |");
                Console.WriteLine("|........2| |         | |         | |         |");
                Console.WriteLine("|.....__..| |         | |         | |         |");
                Console.WriteLine("|..../.о>.| |         | |         | |         |");
                Console.WriteLine("|..(____).| |         | |         | |         |");
                Console.WriteLine("|—————————| |         | |         | |         |");
                Console.WriteLine("|.2./#..3.| |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Console.WriteLine("Выбери и брось свою карту");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|ГОРНОСТАЙ| |..ЖАБА...| |..ВОРОН..| |...Клоп..|");
                Console.WriteLine(@"|—————————| |—————————| |—————————| |—————————|");
                Console.WriteLine(@"|........1| |........1| |........2| |...,-,.]]|");
                Console.WriteLine(@"|../\_/\..| |..@___@..| |.....__..| |...\_/...|");
                Console.WriteLine(@"|.(='.'=).| |.(='o'.).| |..../.о>.| |..(о.о)..|");
                Console.WriteLine(@"|.(')_(').| |..\...\\.| |..(____).| |..~...~..|");
                Console.WriteLine(@"|—————————| |—————————| |—————————| |—————————|");
                Console.WriteLine(@"|.1.....3.| |.1.\#..2.| |.2./#..3.| |.1.§§§.3.|");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.ReadKey();



                /*
                 * 
                 *  Console.WriteLine(" |..БЕЛКА..| |         | |         | |         |");
                    Console.WriteLine( "|—————————| |         | |         | |         |");
                    Console.WriteLine( "|.........| |         | |         | |         |");
                    Console.WriteLine(@"|.(|___|).| |         | |         | |         |");
                    Console.WriteLine( "|.(='.'=).| |         | |         | |         |");
                    Console.WriteLine( "|.(')_(').| |         | |         | |         |");
                    Console.WriteLine( "|—————————| |         | |         | |         |");
                    Console.WriteLine( "|.0.....1.| |         | |         | |         |");
                    Console.WriteLine( "——————————— ——————————— ——————————— ———————————");

                    Console.WriteLine("|         | |..БЕЛКА..| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |.........| |         | |         |");
                   Console.WriteLine(@"|         | |.(|___|).| |         | |         |");
                    Console.WriteLine("|         | |.(='.'=).| |         | |         |");
                    Console.WriteLine("|         | |.(')_(').| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |.0.....1.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Console.WriteLine("|         | |         | |..БЕЛКА..| |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |.........| |         |");
                   Console.WriteLine(@"|         | |         | |.(|___|).| |         |");
                    Console.WriteLine("|         | |         | |.(='.'=).| |         |");
                    Console.WriteLine("|         | |         | |.(')_(').| |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |.0.....1.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Console.WriteLine("|         | |         | |         | |..БЕЛКА..|");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |.........|");
                   Console.WriteLine(@"|         | |         | |         | |.(|___|).|");
                    Console.WriteLine("|         | |         | |         | |.(='.'=).|");
                    Console.WriteLine("|         | |         | |         | |.(')_(').|");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |.0.....1.|");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                */

                Console.WriteLine("1) Белка");
                Console.WriteLine("2) Горностай");
                Console.WriteLine("3) Жаба");
                Console.WriteLine("4) Ворон");
                Console.WriteLine("5) Клоп вонючка");

                Console.WriteLine("Выбор твоей карты зависит от числа которые ты введёшь от 1 до 4");
                Console.WriteLine("Введи число:");
                int mesto = int.Parse(Console.ReadLine());

                Console.WriteLine("Теперь выбери куда ты хочешь поставить свою карту");
                Console.WriteLine("Введи число:");
                int vibor = int.Parse(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();

                if (vibor == 1 && mesto == 1)
                {
                    Console.WriteLine( "——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine( "|..ВОРОН..| |         | |         | |         |");
                    Console.WriteLine( "|—————————| |         | |         | |         |");
                    Console.WriteLine( "|........2| |         | |         | |         |");
                    Console.WriteLine( "|.....__..| |         | |         | |         |");
                    Console.WriteLine( "|..../.о>.| |         | |         | |         |");
                    Console.WriteLine( "|..(____).| |         | |         | |         |");
                    Console.WriteLine( "|—————————| |         | |         | |         |");
                    Console.WriteLine( "|.2./#..3.| |         | |         | |         |");
                    Console.WriteLine( "——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine( "——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine( "|         | |         | |         | |         |");
                    Console.WriteLine( "|         | |         | |         | |         |");
                    Console.WriteLine( "|         | |         | |         | |         |");
                    Console.WriteLine( "|         | |         | |         | |         |");
                    Console.WriteLine( "|         | |         | |         | |         |");
                    Console.WriteLine( "|         | |         | |         | |         |");
                    Console.WriteLine( "|         | |         | |         | |         |");
                    Console.WriteLine( "|         | |         | |         | |         |");
                    Console.WriteLine( "——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(" |..БЕЛКА..| |         | |         | |         |");
                    Console.WriteLine( "|—————————| |         | |         | |         |");
                    Console.WriteLine( "|.........| |         | |         | |         |");
                    Console.WriteLine(@"|.(|___|).| |         | |         | |         |");
                    Console.WriteLine( "|.(='.'=).| |         | |         | |         |");
                    Console.WriteLine( "|.(')_(').| |         | |         | |         |");
                    Console.WriteLine( "|—————————| |         | |         | |         |");
                    Console.WriteLine( "|.0.....1.| |         | |         | |         |");
                    Console.WriteLine( "——————————— ——————————— ——————————— ———————————");
                }
                else if (vibor == 1 && mesto == 2)
                {
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..ВОРОН..| |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|........2| |         | |         | |         |");
                    Console.WriteLine("|.....__..| |         | |         | |         |");
                    Console.WriteLine("|..../.о>.| |         | |         | |         |");
                    Console.WriteLine("|..(____).| |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|.2./#..3.| |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |..БЕЛКА..| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |.........| |         | |         |");
                   Console.WriteLine(@"|         | |.(|___|).| |         | |         |");
                    Console.WriteLine("|         | |.(='.'=).| |         | |         |");
                    Console.WriteLine("|         | |.(')_(').| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |.0.....1.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                }
                else if (vibor == 1 && mesto == 3)
                {
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..ВОРОН..| |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|........2| |         | |         | |         |");
                    Console.WriteLine("|.....__..| |         | |         | |         |");
                    Console.WriteLine("|..../.о>.| |         | |         | |         |");
                    Console.WriteLine("|..(____).| |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|.2./#..3.| |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |..БЕЛКА..| |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |.........| |         |");
                   Console.WriteLine(@"|         | |         | |.(|___|).| |         |");
                    Console.WriteLine("|         | |         | |.(='.'=).| |         |");
                    Console.WriteLine("|         | |         | |.(')_(').| |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |.0.....1.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                }
                else if (vibor == 1 && mesto == 4)
                {
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..ВОРОН..| |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|........2| |         | |         | |         |");
                    Console.WriteLine("|.....__..| |         | |         | |         |");
                    Console.WriteLine("|..../.о>.| |         | |         | |         |");
                    Console.WriteLine("|..(____).| |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|.2./#..3.| |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |..БЕЛКА..|");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |.........|");
                   Console.WriteLine(@"|         | |         | |         | |.(|___|).|");
                    Console.WriteLine("|         | |         | |         | |.(='.'=).|");
                    Console.WriteLine("|         | |         | |         | |.(')_(').|");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |.0.....1.|");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");  
                }
            }
            else if (value == 2)
            {
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |..ВОРОН..| |         | |         |");
                Console.WriteLine("|         | |—————————| |         | |         |");
                Console.WriteLine("|         | |........2| |         | |         |");
                Console.WriteLine("|         | |.....__..| |         | |         |");
                Console.WriteLine("|         | |..../.о>.| |         | |         |");
                Console.WriteLine("|         | |..(____).| |         | |         |");
                Console.WriteLine("|         | |—————————| |         | |         |");
                Console.WriteLine("|         | |.2./#..3.| |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Console.WriteLine("1) Белка");
                Console.WriteLine("2) Горностай");
                Console.WriteLine("3) Жаба");
                Console.WriteLine("4) Ворон");
                Console.WriteLine("5) Клоп вонючка");

                Console.WriteLine("Выбор твоей карты зависит от числа которые ты введёшь от 1 до 4");
                Console.WriteLine("Введи число:");
                int vibor_Karti = int.Parse(Console.ReadLine());

                Console.WriteLine("Теперь выбери куда ты хочешь поставить свою карту");
                Console.WriteLine("Введи число:");
                int mesto = int.Parse(Console.ReadLine());
                                
                if (vibor_Karti == 1 & mesto == 1)
                {
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |..ВОРОН..| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |........2| |         | |         |");
                    Console.WriteLine("|         | |.....__..| |         | |         |");
                    Console.WriteLine("|         | |..../.о>.| |         | |         |");
                    Console.WriteLine("|         | |..(____).| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |.2./#..3.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..БЕЛКА..| |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|.........| |         | |         | |         |");
                   Console.WriteLine(@"|.(|___|).| |         | |         | |         |");
                    Console.WriteLine("|.(='.'=).| |         | |         | |         |");
                    Console.WriteLine("|.(')_(').| |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|.0.....1.| |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                }

                else if (vibor_Karti == 1 & mesto == 2)
                {
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |..ВОРОН..| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |........2| |         | |         |");
                    Console.WriteLine("|         | |.....__..| |         | |         |");
                    Console.WriteLine("|         | |..../.о>.| |         | |         |");
                    Console.WriteLine("|         | |..(____).| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |.2./#..3.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |..БЕЛКА..| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |.........| |         | |         |");
                   Console.WriteLine(@"|         | |.(|___|).| |         | |         |");
                    Console.WriteLine("|         | |.(='.'=).| |         | |         |");
                    Console.WriteLine("|         | |.(')_(').| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |.0.....1.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                }
                else if (vibor_Karti == 1 & mesto == 3)
                {
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |..ВОРОН..| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |........2| |         | |         |");
                    Console.WriteLine("|         | |.....__..| |         | |         |");
                    Console.WriteLine("|         | |..../.о>.| |         | |         |");
                    Console.WriteLine("|         | |..(____).| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |.2./#..3.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |..БЕЛКА..| |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |.........| |         |");
                   Console.WriteLine(@"|         | |         | |.(|___|).| |         |");
                    Console.WriteLine("|         | |         | |.(='.'=).| |         |");
                    Console.WriteLine("|         | |         | |.(')_(').| |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |.0.....1.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                }
                else if (vibor_Karti == 1 & mesto == 4)
                {
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |..ВОРОН..| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |........2| |         | |         |");
                    Console.WriteLine("|         | |.....__..| |         | |         |");
                    Console.WriteLine("|         | |..../.о>.| |         | |         |");
                    Console.WriteLine("|         | |..(____).| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |.2./#..3.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |..БЕЛКА..|");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |.........|");
                   Console.WriteLine(@"|         | |         | |         | |.(|___|).|");
                    Console.WriteLine("|         | |         | |         | |.(='.'=).|");
                    Console.WriteLine("|         | |         | |         | |.(')_(').|");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |.0.....1.|");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                }
                else if (value == 3)
                {

                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |..ВОРОН..| |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |........2| |         |");
                    Console.WriteLine("|         | |         | |.....__..| |         |");
                    Console.WriteLine("|         | |         | |..../.о>.| |         |");
                    Console.WriteLine("|         | |         | |..(____).| |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |.2./#..3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    if(vibor_Karti == 1 & mesto == 1) 
                    {
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |..ВОРОН..| |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |........2| |         |");
                        Console.WriteLine("|         | |         | |.....__..| |         |");
                        Console.WriteLine("|         | |         | |..../.о>.| |         |");
                        Console.WriteLine("|         | |         | |..(____).| |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |.2./#..3.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|..БЕЛКА..| |         | |         | |         |");
                        Console.WriteLine("|—————————| |         | |         | |         |");
                        Console.WriteLine("|.........| |         | |         | |         |");
                       Console.WriteLine(@"|.(|___|).| |         | |         | |         |");
                        Console.WriteLine("|.(='.'=).| |         | |         | |         |");
                        Console.WriteLine("|.(')_(').| |         | |         | |         |");
                        Console.WriteLine("|—————————| |         | |         | |         |");
                        Console.WriteLine("|.0.....1.| |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    }
                    else if(vibor_Karti == 1 & mesto == 2)
                    {
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |..ВОРОН..| |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |........2| |         |");
                        Console.WriteLine("|         | |         | |.....__..| |         |");
                        Console.WriteLine("|         | |         | |..../.о>.| |         |");
                        Console.WriteLine("|         | |         | |..(____).| |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |.2./#..3.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |..БЕЛКА..| |         | |         |");
                        Console.WriteLine("|         | |—————————| |         | |         |");
                        Console.WriteLine("|         | |.........| |         | |         |");
                       Console.WriteLine(@"|         | |.(|___|).| |         | |         |");
                        Console.WriteLine("|         | |.(='.'=).| |         | |         |");
                        Console.WriteLine("|         | |.(')_(').| |         | |         |");
                        Console.WriteLine("|         | |—————————| |         | |         |");
                        Console.WriteLine("|         | |.0.....1.| |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    }
                    else if(vibor_Karti == 1 & mesto == 1)
                    {
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |..ВОРОН..| |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |........2| |         |");
                        Console.WriteLine("|         | |         | |.....__..| |         |");
                        Console.WriteLine("|         | |         | |..../.о>.| |         |");
                        Console.WriteLine("|         | |         | |..(____).| |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |.2./#..3.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |..БЕЛКА..| |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |.........| |         |");
                       Console.WriteLine(@"|         | |         | |.(|___|).| |         |");
                        Console.WriteLine("|         | |         | |.(='.'=).| |         |");
                        Console.WriteLine("|         | |         | |.(')_(').| |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |.0.....1.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    }
                    else if(vibor_Karti == 1 & mesto == 4) 
                    {
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |..ВОРОН..| |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |........2| |         |");
                        Console.WriteLine("|         | |         | |.....__..| |         |");
                        Console.WriteLine("|         | |         | |..../.о>.| |         |");
                        Console.WriteLine("|         | |         | |..(____).| |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |.2./#..3.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |..БЕЛКА..|");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |.........|");
                       Console.WriteLine(@"|         | |         | |         | |.(|___|).|");
                        Console.WriteLine("|         | |         | |         | |.(='.'=).|");
                        Console.WriteLine("|         | |         | |         | |.(')_(').|");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |.0.....1.|");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    }
                }
                else if (value == 4)
                {
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |..ВОРОН..|");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |........2|");
                    Console.WriteLine("|         | |         | |         | |.....__..|");
                    Console.WriteLine("|         | |         | |         | |..../.о>.|");
                    Console.WriteLine("|         | |         | |         | |..(____).|");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |.2./#..3.|");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    if (vibor_Karti == 1 && mesto == 1)
                    {
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |..ВОРОН..|");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |........2|");
                        Console.WriteLine("|         | |         | |         | |.....__..|");
                        Console.WriteLine("|         | |         | |         | |..../.о>.|");
                        Console.WriteLine("|         | |         | |         | |..(____).|");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |.2./#..3.|");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|..БЕЛКА..| |         | |         | |         |");
                        Console.WriteLine("|—————————| |         | |         | |         |");
                        Console.WriteLine("|.........| |         | |         | |         |");
                       Console.WriteLine(@"|.(|___|).| |         | |         | |         |");
                        Console.WriteLine("|.(='.'=).| |         | |         | |         |");
                        Console.WriteLine("|.(')_(').| |         | |         | |         |");
                        Console.WriteLine("|—————————| |         | |         | |         |");
                        Console.WriteLine("|.0.....1.| |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    }
                    else if (vibor_Karti == 1 & mesto == 2)
                    {
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |..ВОРОН..|");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |........2|");
                        Console.WriteLine("|         | |         | |         | |.....__..|");
                        Console.WriteLine("|         | |         | |         | |..../.о>.|");
                        Console.WriteLine("|         | |         | |         | |..(____).|");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |.2./#..3.|");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |..БЕЛКА..| |         | |         |");
                        Console.WriteLine("|         | |—————————| |         | |         |");
                        Console.WriteLine("|         | |.........| |         | |         |");
                       Console.WriteLine(@"|         | |.(|___|).| |         | |         |");
                        Console.WriteLine("|         | |.(='.'=).| |         | |         |");
                        Console.WriteLine("|         | |.(')_(').| |         | |         |");
                        Console.WriteLine("|         | |—————————| |         | |         |");
                        Console.WriteLine("|         | |.0.....1.| |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    }
                    else if(vibor_Karti == 1 & mesto == 3) 
                    {
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |..ВОРОН..|");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |........2|");
                        Console.WriteLine("|         | |         | |         | |.....__..|");
                        Console.WriteLine("|         | |         | |         | |..../.о>.|");
                        Console.WriteLine("|         | |         | |         | |..(____).|");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |.2./#..3.|");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |..БЕЛКА..| |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |.........| |         |");
                       Console.WriteLine(@"|         | |         | |.(|___|).| |         |");
                        Console.WriteLine("|         | |         | |.(='.'=).| |         |");
                        Console.WriteLine("|         | |         | |.(')_(').| |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |.0.....1.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    }
                    else if(vibor_Karti == 1 & mesto == 4)
                    {
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |..ВОРОН..|");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |........2|");
                        Console.WriteLine("|         | |         | |         | |.....__..|");
                        Console.WriteLine("|         | |         | |         | |..../.о>.|");
                        Console.WriteLine("|         | |         | |         | |..(____).|");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |.2./#..3.|");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |..БЕЛКА..|");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |.........|");
                       Console.WriteLine(@"|         | |         | |         | |.(|___|).|");
                        Console.WriteLine("|         | |         | |         | |.(='.'=).|");
                        Console.WriteLine("|         | |         | |         | |.(')_(').|");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |.0.....1.|");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    }
                }
            }           
        }
    }
}