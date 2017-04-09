namespace Birbiz.DataAccess.DataContracts.Initializers
{
    public interface IInitializable
    {
        void Seed(IDatabaseInitializer initializer);
    }
}