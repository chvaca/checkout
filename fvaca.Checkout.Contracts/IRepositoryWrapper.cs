using System;
namespace fvaca.Checkout.Contracts
{
    public interface IRepositoryWrapper
    {
        ICardRepository Card { get; }
        IPaymentRepository Payment { get; }
        void Save();
    }
}
