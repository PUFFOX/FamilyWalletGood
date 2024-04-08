using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFGunaFamilyWallet.models
{
    public class Category
    {
        public int Id { get; set; }
        public string NameCategory { get; set; }
         
        //public string Description { get; set; }

        public int CategoryId { get; set; }

        //public int DescriptionId { get; set; }

      
        public virtual ICollection<Transaction> Transactions { get; set; }

        public Category()
        { 
            Transactions = new List<Transaction>();
        }


    }

    
}

