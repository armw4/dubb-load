using System;

namespace FinancialPowerDemo.Abstractions
{
    public class FileAuthorizationGroup : IFileAuthorizationInfo
    {
        public string Name { get; set; }

        public string Roles { get; set; }
    }

    public class FileAuthorizationTopic : IFileAuthorizationInfo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public FileAuthorizationGroup Group { get; set; }

        public string Roles { get; set; }
    }

    public class FileAuthorizationDescriminator : IFileAuthorizationInfo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public FileAuthorizationTopic Topic { get; set; }

        public string Roles { get; set; }
    }

    public interface IFileAuthorizationInfo
    {
        string Roles { get; set; }
    }
}
