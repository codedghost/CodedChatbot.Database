namespace CoreCodedChatbot.Database.Context.Interfaces
{
    public interface IEntityWithUsername : IEntity
    {
        public string Username { get; set; }
    }
}