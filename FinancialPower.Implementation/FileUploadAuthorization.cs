using FinancialPowerDemo.Abstractions;

namespace FinancialPower.Implementation
{
    public class FileUploadAuthorization : IFileUploadAuthorization
    {
        public bool Authorize(string path)
        {
            throw new System.NotImplementedException();
        }

        public bool Authorize(string @group, string topic = null, string descriminator = null)
        {
            throw new System.NotImplementedException();
        }
    }
}
