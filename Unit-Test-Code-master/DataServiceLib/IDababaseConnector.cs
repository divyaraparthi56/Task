namespace DataServiceLib
{
    public interface IDababaseConnector
    {
        string GetMessageFromMsgTble();

        string WelcomeMsg(string userId);
        string HelloMsg(string Name);
    }
}