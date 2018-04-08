using System;

namespace HelloWorldApp
{
    /// <summary>
    /// Основной класс приложения.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Стартовый метод приложения. 
        /// Работа приложения всегда начинается с этого метода.
        /// </summary>
        /// <param name="args"> 
        /// Аргументы, передаваемые в качестве параметров
        /// при вызове приложения из консоли с аргументами. 
        /// </param>
        static void Main(string[] args)
        {
            // Создаем строковую переменную с произвольным текстом.
            string text = "Hello, World";

            // Вызываем метод вывода информации на консоль.
            Console.WriteLine(text);

            // Ожидаем нажатия клавиши Ввод пользователем.
            Console.ReadLine();
        }
    }
}
