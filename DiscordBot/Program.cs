using System;
using DiscordBot.Storage;
using DiscordBot.Storage.Implementations;

namespace DiscordBot
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");
        }
    }
}

