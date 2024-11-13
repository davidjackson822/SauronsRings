using System;

namespace Application.Interfaces
{
    interface IFactory
    {
        public IForge createForge(string ringToCreate);
    }
}