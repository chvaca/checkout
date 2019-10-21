using System;
using System.Collections.Generic;
using fvaca.Checkout.Entities.Models;

namespace fvaca.Checkout.Contracts
{
    public interface IPaymentRepository: IRepositoryBase<Payment>
    {
        IEnumerable<Payment> PaymentById(Guid ownerId);
        IEnumerable<Payment> GetAllPayments(Guid ownerId);
        void CreateCard(Card owner);
    }
}
