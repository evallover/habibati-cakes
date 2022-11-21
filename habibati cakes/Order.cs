using System.Diagnostics;

namespace habibati_cakes
{
    internal class Order
    {
        public int index = 1;
        private int[] indexArray = new int[2];
        private string[,] menu = new string[30, 30];
        private string name = "HABIBATI CAKES (спонсировано кирюшей бледным)";
        private string pm = "наши тортики настолько вкусные, что их рекомендует сам кирилл бледный!!";
        private string line = "-----------------------------------------------------------------------";
        private int currentMenu = 0;
        Cake orderedCake = new Cake();

        private void DrawUserMenu()
        {

            Console.CursorVisible = false;

            List<string> list = new List<string>();
            int j = 0;

            while (j < 30)
            {
                list.Add(menu[j, currentMenu]);
                j++;
            }

            for (int i = 0; i < list.Count; i++)
            {
                string currentString = menu[i, currentMenu];
                if (string.IsNullOrEmpty(currentString))
                {
                    continue;
                }
                if (index == i)
                {
                    Console.Write("-> ");
                }
                Console.Write($"{currentString}\n");

            }

        }

        private int[] UserMenu()
        {

            ConsoleKey consoleKey;
            do
            { 
                Console.WriteLine($"{name}");
                Console.WriteLine($"{pm}");
                Console.WriteLine($"{line}\n");

                new Thread(DrawUserMenu).Start();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                consoleKey = keyInfo.Key;

                switch (consoleKey)
                {

                    case ConsoleKey.DownArrow:
                        index++;
                        if (menu[index, currentMenu] is null)
                        {
                            index--;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        index--;
                        if (index < 0)
                        {
                            index++;
                        }
                        else if (menu[index, currentMenu] is null)
                        {
                            index++;
                        }
                        break;

                    case ConsoleKey.Escape:
                        if (currentMenu == 0)
                        {
                            Process.GetCurrentProcess().Kill();
                        }
                        currentMenu = 0;
                        index = 1;
                        break;

                }

                Console.Clear();

            } while (consoleKey != ConsoleKey.Enter);

            indexArray[0] = index;
            indexArray[1] = currentMenu;

            return indexArray;
        }

        public Cake MakeOrder()
        {

            int[] indexLocal = new int[2];

            while (true)
            {
                Menu();
                indexLocal = UserMenu();

                switch (indexLocal[1])
                {
                    case 0:
                        switch (indexLocal[0])
                        {
                            case 1:
                                currentMenu = 1;
                                index = 1;
                                break;

                            case 2:
                                currentMenu = 2;
                                index = 1;
                                break;

                            case 3:
                                currentMenu = 3;
                                index = 1;
                                break;

                            case 4:
                                currentMenu = 4;
                                index = 1;
                                break;
                            case 5:
                                currentMenu = 5;
                                index = 1;
                                break;
                            case 6:
                                currentMenu = 6;
                                index = 1;
                                break;
                            case 7:
                                return orderedCake;
                        }
                        break;

                    case 1:
                        switch (indexLocal[0])
                        {
                            case 1:
                                orderedCake.shapeCost = 500;
                                orderedCake.shape = " Круг - 500,";
                                break;

                            case 2:
                                orderedCake.shapeCost = 500;
                                orderedCake.shape = " Квадрат - 500,";
                                break;

                            case 3:
                                orderedCake.shapeCost = 500;
                                orderedCake.shape = " Прямоугольник - 500,";
                                break;

                            case 4:
                                orderedCake.shapeCost = 1000;
                                orderedCake.shape = " Сердечко - 700,";
                                break;
                        }
                        currentMenu = 0;
                        index = 1;
                        break;
                    case 2:
                        switch (indexLocal[0])
                        {
                            case 1:
                                orderedCake.sizeCost = 1000;
                                orderedCake.size = " Маленький(Диаметр 16см, 8 порций) - 1000,";
                                break;

                            case 2:
                                orderedCake.sizeCost = 1200;
                                orderedCake.size = " Обычный(Диаметр 18см, 10 порций) - 1200,";
                                break;

                            case 3:
                                orderedCake.sizeCost = 2000;
                                orderedCake.size = " Большой(Диаметр 28см, 24 порций) - 2000,";
                                break;
                        }
                        currentMenu = 0;
                        index = 2;
                        break;

                    case 3:
                        switch (indexLocal[0])
                        {
                            case 1:
                                orderedCake.tasteCost = 100;
                                orderedCake.taste = " Ванильный - 100,";
                                break;
                                
                            case 2:
                                orderedCake.tasteCost = 100;
                                orderedCake.taste = " Шоколадный - 100,";
                                break;

                            case 3:
                                orderedCake.tasteCost = 150;
                                orderedCake.taste = " Карамельный - 150,";
                                break;

                            case 4:
                                orderedCake.tasteCost = 200;
                                orderedCake.taste = " Ягодный - 200,";
                                break;
                            case 5:
                                orderedCake.tasteCost = 250;
                                orderedCake.taste = " Кокосовый - 250,";
                                break;
                        }
                        currentMenu = 0;
                        index = 3;
                        break;
                    case 4:
                        switch (indexLocal[0])
                        {
                            case 1:
                                orderedCake.quantityCost = 200;
                                orderedCake.quantity = " 1 корж - 200,";
                                break;

                            case 2:
                                orderedCake.quantityCost = 400;
                                orderedCake.quantity = " 2 коржа - 400,";
                                break;

                            case 3:
                                orderedCake.quantityCost = 600;
                                orderedCake.quantity = " 3 коржа - 600,";
                                break;

                            case 4:
                                orderedCake.quantityCost = 800;
                                orderedCake.quantity = " 4 коржа - 800,";
                                break;
                        }
                        currentMenu = 0;
                        index = 4;
                        break;
                    case 5:
                        switch (indexLocal[0])
                        {
                            case 1:
                                orderedCake.glazeCost = 150;
                                orderedCake.glaze = " Шоколадная - 150,";
                                break;

                            case 2:
                                orderedCake.glazeCost = 150;
                                orderedCake.glaze = " Ягодная - 150,";
                                break;

                            case 3:
                                orderedCake.glazeCost = 150;
                                orderedCake.glaze = " Ванильная - 150,";
                                break;
                        }
                        currentMenu = 0;
                        index = 5;
                        break;
                    case 6:
                        switch (indexLocal[0])
                        {
                            case 1:
                                orderedCake.decorCost = 100;
                                orderedCake.decor = " Шоколад - 100,";
                                break;

                            case 2:
                                orderedCake.decorCost = 100;
                                orderedCake.decor = " Крем - 100,";
                                break;

                            case 3:
                                orderedCake.decorCost = 150;
                                orderedCake.decor = " Карамель - 150,";
                                break;

                            case 4:
                                orderedCake.decorCost = 150;
                                orderedCake.decor = " Бизе - 150,";
                                break;
                            case 5:
                                orderedCake.decorCost = 200;
                                orderedCake.decor = " Ягоды - 200,";
                                break;
                        }
                        currentMenu = 0;
                        index = 6;
                        break;
                    

                }
            }
        }

        private void Menu()
        {
            orderedCake.totalCost = orderedCake.shapeCost + orderedCake.sizeCost + orderedCake.tasteCost + orderedCake.quantityCost + orderedCake.decorCost + orderedCake.glazeCost;
            orderedCake.orderOutput = string.Concat(orderedCake.shape, orderedCake.size, orderedCake.taste, orderedCake.decor, orderedCake.glaze, orderedCake.quantity);


            menu[1, 0] = "Форма торта";
            menu[2, 0] = "Размер торта";
            menu[3, 0] = "Вкус коржей";
            menu[4, 0] = "Глазурь";
            menu[5, 0] = "Декор";
            menu[6, 0] = "Кол-во коржей\n";
            menu[7, 0] = "Конец заказа\n";

            menu[10, 0] = $"Цена: {orderedCake.totalCost}";
            menu[11, 0] = $"Ваш тортик: {orderedCake.orderOutput}";

            menu[1, 1] = "Круг - 500";
            menu[2, 1] = "Квадрат - 500";
            menu[3, 1] = "Прямоугольник - 500";
            menu[4, 1] = "Сердечко - 700";

            menu[1, 2] = "Маленький(Диаметр 16см, 8 порций) - 1000";
            menu[2, 2] = "Обычный(Диаметр 18см, 10 порций) - 1200";
            menu[3, 2] = "Большой(Диаметр 28см, 24 порций) - 2000";

            menu[1, 3] = "Ванильный - 100";
            menu[2, 3] = "Шоколадный - 100";
            menu[3, 3] = "Карамельный - 150";
            menu[4, 3] = "Ягодный - 200";
            menu[5, 3] = "Кокосовый - 250";

            menu[1, 4] = "Шоколадная - 150";
            menu[2, 4] = "Ягодная - 150";
            menu[3, 4] = "Ванильная - 150";

            menu[1, 5] = "Шоколад - 100";
            menu[2, 5] = "Крем - 100";
            menu[3, 5] = "Бизе - 150";
            menu[4, 5] = "Драже - 150";
            menu[5, 5] = "Ягоды - 200";

            menu[1, 6] = "1 корж - 200";
            menu[2, 6] = "2 коржа - 400";
            menu[3, 6] = "3 коржа - 600";
            menu[4, 6] = "4 коржа - 800";
        }
    }
}
