using System;

namespace P001.DependencyInjection.Services
{
    public class SingletonOperation : ISingletonOperation
    {
        private Guid Uid { get; }

        public SingletonOperation()
        {
            Uid = Guid.NewGuid();
        }

        public string Id => Uid.ToString();

        public string GetId()
        {
            return Id;
        }
    }
}