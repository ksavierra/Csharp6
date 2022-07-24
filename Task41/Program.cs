// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

static void Main(string[] args)
        {   
            Console.WriteLine("Введите числа (для завершения ввода нажмите  q ): ");
            
            string M;
            int[] array = new int[100];
            int i = 0;
            int j = 0;
 
            while ((M = Console.ReadLine()) != "q") 
                array[i++] = Convert.ToInt32(M);

                Console.Write("[");
            for (j = 0; j < i; j++) 
            {
                Console.Write(array[j] + " ");
            }
            Console.Write("]");
            int count = 0;

            for (i = 0; i < array.Length; i++)
            {
              if (array[i] > 0)
               {
                  count++;
               }
            }
                        
            Console.Write(" -> {0}", count);
 
            Console.ReadKey(true);

        }
Main(args);
