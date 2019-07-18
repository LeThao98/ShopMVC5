namespace TeduShop.Data.Infrastructure
{
    internal interface IUnitOfWork
    {
        void Commit();
    }
}