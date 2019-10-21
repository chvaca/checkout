using System;
using System.Collections.Generic;
using fvaca.Checkout.Contracts;
using fvaca.Checkout.Entities;
using fvaca.Checkout.Entities.Models;

namespace fvaca.Checkout.Repository
{
    public class PaymentRepository: RepositoryBase<Payment>, IPaymentRepository
    {
        public PaymentRepository(RepositoryContext repositoryContext)
             : base(repositoryContext)
        {
        }

        public void CreateCard(Card owner)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Payment> GetAllPayments(Guid ownerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Payment> PaymentById(Guid ownerId)
        {
            throw new NotImplementedException();
        }
    }
}
