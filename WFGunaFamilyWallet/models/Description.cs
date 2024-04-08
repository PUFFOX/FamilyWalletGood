using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFGunaFamilyWallet.models
{
    public class Description
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int CommentId { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }

        public Description()
        {
            Transactions = new List<Transaction>();
        }
    }
}
