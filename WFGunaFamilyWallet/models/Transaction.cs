using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFGunaFamilyWallet.models
{
    public class Transaction
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int CategoryId { get; set; } //?
        public virtual Category Category { get; set; }

        public int DescriptionId { get; set; } //?
        public virtual Description Description { get; set; }

        public decimal Amount { get; set; }

        public TransactionType Type { get; set; } // Додатковий атрибут для визначення типу транзакції

        public enum TransactionType
        {
            Income,
            Expense
        }
    }

}
