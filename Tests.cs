using System;

namespace Lab
{
    class Tests
    {
        public static void RunAll()
        {
            Console.WriteLine("Запуск тестов класса MyString и ExtendedString...");
            TestMyString();
            TestExtendedString();
            Console.WriteLine("Все тесты завершены.");
        }

        private static void TestMyString()
        {
            Console.WriteLine("Тест класса MyString:");
            MyString myStr = new MyString("Hello, World!");
            Console.WriteLine($"Исходная строка: {myStr}");
            myStr.AddExclamations();
            Console.WriteLine($"Со знаками: {myStr}");
            Console.WriteLine();
        }

        private static void TestExtendedString()
        {
            Console.WriteLine("Тест класса ExtendedString:");
            ExtendedString extStr = new ExtendedString("Hello, World! This is a test.");
            Console.WriteLine($"Исходная строка: {extStr}");
            Console.WriteLine($"Количество слов: {extStr.CountWords()}");
            Console.WriteLine($"Количество символов: {extStr.CountCharacters()}");
            extStr.AddExclamations();
            Console.WriteLine($"После добавления восклицательных знаков: {extStr}");
            Console.WriteLine();
        }
    }
}