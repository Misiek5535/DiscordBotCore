using Discord.WebSocket;

namespace DiscordBot.Discord.Entities
{
    public class DiscordBotConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}