namespace SwimmingCompetition.service;

public class ServiceException : Exception
{
    public String myMessage { get; }

    public ServiceException(String myMessage)
    {
        this.myMessage = myMessage;
    }
}