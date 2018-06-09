namespace DiscordBot.Storage
{
    public interface IDateStorage
    {
        void StorObject(object obj, string key);

        T RestoreObject<T>(string key);
    }
}
