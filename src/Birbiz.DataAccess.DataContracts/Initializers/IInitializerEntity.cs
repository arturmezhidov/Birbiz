using System;

namespace Birbiz.DataAccess.DataContracts.Initializers
{
    public interface IInitializerEntity
    {
        Type EntityType { get; }
    }
}