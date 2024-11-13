using System;

namespace Application
{
    interface IFactory<T>
    {
        public IForge createForge(string ringToCreate);
    }
}