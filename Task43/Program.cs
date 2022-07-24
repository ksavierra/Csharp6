// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;  
// значения b1, k1, b2 и k2 задаются пользователем.


static void Main(string[] args)
{
    Console.Write("Задайте координаты прямых:  k1 = ");
    int k1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Задайте координаты прямых:  b1 = ");
    int b1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Задайте координаты прямых:  k2 = ");
    int k2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Задайте координаты прямых:  b2 = ");
    int b2 = Convert.ToInt32(Console.ReadLine());

    int x = -(b1 + b2)/ (k1 - k2);
    int y = (-(b1 + b2)/ (k1 - k2))*k2 + b2;;

  
      Console.Write("Точка пересечения двух прямых: " + "(" + x + "," + y + ")");        
   

}
Main(args);

