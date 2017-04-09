namespace Birbiz.DataAccess.DataContracts.Initializers
{
    public interface IInitializable
    {
        void Init(IDatabaseInitializer initializer);
    }
}