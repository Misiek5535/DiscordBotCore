﻿using System;
using DiscordBot.Discord;
using DiscordBot.Discord.Entities;

namespace DiscordBot
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");

            var discordBotConfig = new DiscordBotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };
        }
    }
}

