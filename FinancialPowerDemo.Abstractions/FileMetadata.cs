using System;

namespace FinancialPowerDemo.Abstractions
{
    public class FileMetadata
    {
        public Guid Id { get; set; }

        public string Tag { get; set; }

        public DateTime DateCreated { get; set; }

        public string Path { get; set; }

        public Guid UploadedBy { get; set; }
    }
}
