namespace FinancialPowerDemo.Abstractions
{
    public interface IFileUploadAuthorization
    {
        bool Authorize(string path);

        bool Authorize(string group, string topic = null, string descriminator = null);
    }
}
