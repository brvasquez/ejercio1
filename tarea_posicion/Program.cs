using System;

namespace tarea_posicion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 20; i <= 80; i++)
            {
                Console.SetCursorPosition(i, 5); Console.WriteLine("▄");
                Console.SetCursorPosition(i, 20); Console.WriteLine("▄");
            }


            for (int i = 6; i <= 20; i++)
            {
                Console.SetCursorPosition(20, i); Console.WriteLine("▓");
                Console.SetCursorPosition(80, i); Console.WriteLine("▓");
            }

            Console.Clear();

            int pcs;

            Console.Clear();

            do

            {

                Console.Clear();

                Console.SetCursorPosition(40, 9); Console.WriteLine("   1.   QUIENES SOMOS   ");
                Console.SetCursorPosition(40, 13); Console.WriteLine("   2.   MENU APLICACION  ");
                Console.SetCursorPosition(40, 17); Console.WriteLine("   0.   SALIR   ");

                for (int i = 20; i <= 80; i++)
                {
                    Console.SetCursorPosition(i, 5); Console.WriteLine("▄");
                    Console.SetCursorPosition(i, 20); Console.WriteLine("▄");
                }


                for (int i = 6; i <= 20; i++)
                {
                    Console.SetCursorPosition(20, i); Console.WriteLine("▓");
                    Console.SetCursorPosition(80, i); Console.WriteLine("▓");
                }


                pcs = int.Parse(Console.ReadLine());


                Console.Clear();

                switch (pcs)

                {

                    case 1:

                        Console.Clear();

                        for (int i = 20; i <= 80; i++)
                        {
                            Console.SetCursorPosition(i, 5); Console.WriteLine("▄");
                            Console.SetCursorPosition(i, 20); Console.WriteLine("▄");
                        }


                        for (int i = 6; i <= 20; i++)
                        {
                            Console.SetCursorPosition(20, i); Console.WriteLine("▓");
                            Console.SetCursorPosition(80, i); Console.WriteLine("▓");
                        }

                        Console.SetCursorPosition(31, 9); Console.WriteLine(" 1. COMO SE LLAMA:?  ");
                        Console.SetCursorPosition(31, 14); ; Console.WriteLine("Brayan Steven Vasquez Gutierrez");


                        Console.SetCursorPosition(30, 18); ; Console.WriteLine(" PRESIONE ENTER PARA REGRESAR ");

                        Console.ReadKey();
                        break;


                    case 2:

                        Console.Clear();

                        for (int i = 20; i <= 80; i++)
                        {
                            
                            Console.SetCursorPosition(i, 5); Console.WriteLine("▄");
                            Console.SetCursorPosition(i, 20); Console.WriteLine("▄");
                        }


                        for (int i = 6; i <= 20; i++)
                        {
                            Console.SetCursorPosition(20, i); Console.WriteLine("▓");
                            Console.SetCursorPosition(80, i); Console.WriteLine("▓");
                        }

                        Console.SetCursorPosition(33, 7); Console.WriteLine("   2.1   MENU APLICACION  ");
                        Console.SetCursorPosition(35, 11); ; Console.WriteLine(" 1.  Agregar Personaje");
                        Console.SetCursorPosition(35, 13); ; Console.WriteLine(" 2.  Listar Personajes");
                        Console.SetCursorPosition(35, 15); ; Console.WriteLine(" 3.  Buscar Personaje ");
                        Console.SetCursorPosition(35, 18); ; Console.WriteLine(" PRESIONE ENTER PARA REGRESAR ");


                        Console.ReadKey();

                        break;                                                                      
                                           

                }


            } while (pcs != 0);


            Console.ReadKey();

        }
    }
}
