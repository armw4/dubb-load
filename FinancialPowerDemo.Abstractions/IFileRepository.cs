using System;
using System.Collections.Generic;

namespace FinancialPowerDemo.Abstractions
{
    public interface IFileRepository
    {
        FileMetadata Get(Guid id);

        IEnumerable<FileMetadata> Get(string group, string tag = null, string descriminator = null);

        void Create();

        void Create(FileUploadInfo info);

        void Create(IEnumerable<FileUploadInfo> info);

        void Delete(Guid id);
    }
}
