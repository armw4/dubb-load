using System.IO;

namespace FinancialPowerDemo.Abstractions
{
    public class FileUploadInfo
    {
        public Stream Contents { get; set; }

        public string FileName { get; set; }
    }
}
