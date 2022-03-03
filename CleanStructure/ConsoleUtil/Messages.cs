using System;

namespace CleanStructure.ConsoleUtil
{
    public static class Messages
    {
        public static void Print(object? value, MessageType type = MessageType.None)
        {
            var color = type switch
            {
                MessageType.Success => ConsoleColor.Green,
                MessageType.Error => ConsoleColor.Red,
                MessageType.None => ConsoleColor.White,
                _ => default
            };

            Console.ForegroundColor = color;
            Console.Write(value);
            Console.ResetColor();
        }

        public static void Println(object? value, MessageType type = MessageType.None)
        {
            Print($"{value}\n", type);
        }
    }
}