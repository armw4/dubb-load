namespace FinancialPowerDemo.Abstractions
{
    public interface IFileAuthorizationRepository
    {
        IFileAuthorizationInfo Get(string path);

        IFileAuthorizationInfo Get(string group, string topic = null, string descriminator = null);
    }
}
