using System;
using ConsoleBot;

namespace BotForManager
{
    class Program
    {
        static void Main()
        {
            ConsoleBotE bot;
            string message;
            Console.WriteLine("Здраствуйте, Вас приветствует помошник заместителя генерального директора.");
            while(true)
            {
                message = Console.ReadLine();
                bot = new ConsoleBotE(message);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(bot.Answer());
                Console.ResetColor();
            }           
        }
    }
}
