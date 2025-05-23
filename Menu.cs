using System;

namespace EditorHTML {

    public static class Menu 
    {

        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOptions(option);
        }


        public static void DrawScreen()
        {
            TopLine();
            MiddleLines();
            BottomLine();
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1- Novo Arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2- Abrir");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("3- Sair");
            Console.SetCursorPosition(3,10);
            Console.WriteLine("Opção:");
        }

        public static void HandleMenuOptions(short option)
        {
            switch(option){
                case 1 : Editor.Show();break;
                case 2: Console.WriteLine("View"); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show();break;
            
            }
        }
        public static void TopLine()
        {
            Console.Write("+");
            for( int i=0; i<=30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }
    
        public static void BottomLine()
        {
            Console.Write("+");
                for( int i=0; i<=30; i++)
                    Console.Write("-");

                Console.Write("+");
                Console.Write("\n");
        }

        public static void  MiddleLines()
        {
            for(int lines = 0; lines <=10; lines++)
            {
                Console.Write("|");
                for( int i=0; i<=30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }



}
}
