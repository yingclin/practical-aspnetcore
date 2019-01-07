using System;

namespace P001.DependencyInjection.Services
{
    public class TransientOperation
    {
        private Guid Uid { get; }

        public TransientOperation()
        {
            Uid = Guid.NewGuid();
        }

        public string Id => Uid.ToString();
    }
}