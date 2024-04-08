using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFGunaFamilyWallet.models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsFirstLogin { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }

        public bool IsLoggedIn { get; set; }
    }


}

