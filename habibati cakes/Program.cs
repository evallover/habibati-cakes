namespace habibati_cakes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order Order = new Order();
            Cake orderedCake = Order.MakeOrder();

            string filePath = "C:\\Users\\girll\\Desktop\\habibati cakes\\История заказов.txt";

            string[] orderOutput = new string[3];
            orderOutput[0] = $"Заказ от {DateTime.Now}";
            orderOutput[1] = $"\tЗаказ: {orderedCake.orderOutput}";
            orderOutput[2] = $"\tЦена: {orderedCake.totalCost}\n";

            File.AppendAllLines(filePath, orderOutput);
        }
    }
}