using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace WFGunaFamilyWallet.models
{
    public class BudgetContext : DbContext
    {
        

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Description> Descriptions { get; set; }

        static BudgetContext()
        {
            Database.SetInitializer(new BudgetContextInitializer());
        }

        public void AddCategory(string categoryName)
        {
            Categories.Add(new Category { NameCategory = categoryName});
            
            SaveChanges();
        }

        public void AddUser(string username, string password)
        {
            Users.Add(new User { Username = username, Password = password, IsLoggedIn = false });
        }

        public void AddTransaction(int userId, int categoryId, DateTime dateTime, decimal amount, Transaction.TransactionType type, string comment)
        {
            var transaction = new Transaction
            {
                UserId = userId,
                CategoryId = categoryId,
                DateTime = dateTime,
                Amount = amount,
                Type = type,
                Description = new Description { Comment = comment }
            };

            Transactions.Add(transaction);
            SaveChanges(); // Збереження транзакції у базі даних
        }



    }



}
