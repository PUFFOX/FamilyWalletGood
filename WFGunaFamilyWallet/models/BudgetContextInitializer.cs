using System;
using System.Data.Entity;
using System.Linq;


namespace WFGunaFamilyWallet.models
{
    public class BudgetContextInitializer : DropCreateDatabaseIfModelChanges<BudgetContext>
    {
        //public BudgetContextInitializer()
        //{
        //    // Ініціалізуємо базу даних при створенні нового контексту
        //    Seed(new BudgetContext());
        //}

        protected override void Seed(BudgetContext context)
        {
            using (var dbContext = new BudgetContext())
            {
                AddCategory(dbContext, "Робота");//1
                AddCategory(dbContext, "Продукти харчування");//2
                AddCategory(dbContext, "Автомобіль");//3
                AddCategory(dbContext, "Дім");//4
                AddCategory(dbContext, "Подарунки");//5
                AddCategory(dbContext, "Борги");//6
                AddCategory(dbContext, "Ремонт");//7
                AddCategory(dbContext, "Навчання");//8
                AddCategory(dbContext, "Здоров'я");//9
                AddCategory(dbContext, "Благодійність");//10
                AddCategory(dbContext, "Розваги");//11
                AddCategory(dbContext, "Банк");//12
                AddCategory(dbContext, "Одяг та взуття");//13
                AddCategory(dbContext, "Домашні тварини");//14
                AddCategory(dbContext, "Інше");//15
                AddCategory(dbContext, "Аванс");//16



                //Додавання користувачів
                AddUser(dbContext, "Тато", "1111", true);
                AddUser(dbContext, "Мама", "2222", true);


                AddTransaction(context, 1, 4, new DateTime(2023, 12, 1), 8000.00m, Transaction.TransactionType.Expense, "Квартплата");
                AddTransaction(context, 1, 4, new DateTime(2023, 12, 1), 2250.00m, Transaction.TransactionType.Expense, "Комунальні виплати");
                AddTransaction(context, 1, 1, new DateTime(2023, 12, 5), 6000.00m, Transaction.TransactionType.Income, "Бонус");
                AddTransaction(context, 1, 3, new DateTime(2023, 12, 10), 3500.00m, Transaction.TransactionType.Expense, "Пальне");
                AddTransaction(context, 1, 1, new DateTime(2023, 12, 10), 20000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 2, 1, new DateTime(2023, 12, 15), 15000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 2, 1, new DateTime(2023, 12, 25), 5000.00m, Transaction.TransactionType.Income, "Різдвяний бонус");
                AddTransaction(context, 2, 5, new DateTime(2023, 12, 28), 3000.00m, Transaction.TransactionType.Expense, "Подарунки");
                AddTransaction(context, 2, 11, new DateTime(2023, 12, 18), 2000.00m, Transaction.TransactionType.Income, "Виграш у лотереї");
                AddTransaction(context, 3, 8, new DateTime(2023, 12, 22), 450.00m, Transaction.TransactionType.Expense, "Книга");
                AddTransaction(context, 1, 10, new DateTime(2023, 12, 3), 300.00m, Transaction.TransactionType.Expense, "Благодійний внесок");
                AddTransaction(context, 1, 3, new DateTime(2023, 12, 8), 2800.00m, Transaction.TransactionType.Expense, "СТО");
                AddTransaction(context, 3, 13, new DateTime(2023, 12, 26), 1500.00m, Transaction.TransactionType.Expense, "Спортивний костюм");
                AddTransaction(context, 1, 5, new DateTime(2023, 12, 30), 800.00m, Transaction.TransactionType.Income, "Подарунок від друзів");
                AddTransaction(context, 2, 2, new DateTime(2023, 12, 25), 3500.00m, Transaction.TransactionType.Expense, "Різдвяний стіл");
                AddTransaction(context, 2, 5, new DateTime(2023, 12, 29), 2300.00m, Transaction.TransactionType.Expense, "Подарунки дитині");
                AddTransaction(context, 2, 5, new DateTime(2023, 12, 29), 2700.00m, Transaction.TransactionType.Expense, "Подарунки чоловіку");
                AddTransaction(context, 2, 5, new DateTime(2023, 12, 29), 3700.00m, Transaction.TransactionType.Expense, "Подарунки дружині");


                AddTransaction(context, 1, 4, new DateTime(2023, 10, 1), 8000.00m, Transaction.TransactionType.Expense, "Квартплата");
                AddTransaction(context, 1, 4, new DateTime(2023, 10, 1), 2300.00m, Transaction.TransactionType.Expense, "Комунальні виплати");
                AddTransaction(context, 1, 1, new DateTime(2023, 11, 10), 20000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 2, 1, new DateTime(2023, 11, 15), 15000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 1, 3, new DateTime(2023, 11, 10), 3500.00m, Transaction.TransactionType.Expense, "Пальне");
                AddTransaction(context, 1, 4, new DateTime(2023, 11, 1), 250.00m, Transaction.TransactionType.Expense, "Оплата інтернету");
                AddTransaction(context, 3, 8, new DateTime(2023, 11, 30), 1300.00m, Transaction.TransactionType.Expense, "Курси англійської");
                AddTransaction(context, 2, 2, new DateTime(2023, 11, 5), 2800.00m, Transaction.TransactionType.Income, "Продукти");
                AddTransaction(context, 3, 11, new DateTime(2023, 11, 20), 400.00m, Transaction.TransactionType.Expense, "Концертний квиток");
                AddTransaction(context, 2, 6, new DateTime(2023, 11, 25), 2500.00m, Transaction.TransactionType.Income, "Допомога від друзів");
                AddTransaction(context, 2, 8, new DateTime(2023, 11, 12), 780.00m, Transaction.TransactionType.Expense, "Книги");
                AddTransaction(context, 1, 4, new DateTime(2023, 11, 22), 15.00m, Transaction.TransactionType.Expense, "Кава з друзями");
                AddTransaction(context, 3, 11, new DateTime(2023, 11, 15), 1800.00m, Transaction.TransactionType.Expense, "Кіно");
                AddTransaction(context, 1, 2, new DateTime(2023, 11, 20), 950.00m, Transaction.TransactionType.Expense, "Ремонт комп'ютера");
                AddTransaction(context, 3, 5, new DateTime(2023, 11, 25), 400.00m, Transaction.TransactionType.Income, "Подарунок від бабусі");


                AddTransaction(context, 1, 4, new DateTime(2023, 10, 1), 8000.00m, Transaction.TransactionType.Expense, "Квартплата");
                AddTransaction(context, 1, 4, new DateTime(2023, 10, 1), 2200.00m, Transaction.TransactionType.Expense, "Комунальні виплати");
                AddTransaction(context, 1, 1, new DateTime(2023, 10, 10), 20000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 2, 1, new DateTime(2023, 10, 15), 15000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 1, 3, new DateTime(2023, 10, 10), 3500.00m, Transaction.TransactionType.Expense, "Пальне");
                AddTransaction(context, 1, 4, new DateTime(2023, 10, 3), 250.00m, Transaction.TransactionType.Expense, "Оплата інтернету");
                AddTransaction(context, 3, 8, new DateTime(2023, 10, 14), 1300.00m, Transaction.TransactionType.Expense, "Курси англійської");
                AddTransaction(context, 2, 2, new DateTime(2023, 10, 5), 2800.00m, Transaction.TransactionType.Income, "Продукти");
                AddTransaction(context, 1, 3, new DateTime(2023, 10, 25), 740.00m, Transaction.TransactionType.Expense, "Ремонт авто");
                AddTransaction(context, 2, 2, new DateTime(2023, 10, 28), 18.00m, Transaction.TransactionType.Income, "Курси англійської");
                AddTransaction(context, 1, 5, new DateTime(2023, 10, 3), 1400.00m, Transaction.TransactionType.Expense, "Подарунок бабусі");
                AddTransaction(context, 1, 10, new DateTime(2023, 10, 3), 200.00m, Transaction.TransactionType.Expense, "Благодійний внесок");


                AddTransaction(context, 1, 4, new DateTime(2023, 9, 1), 8000.00m, Transaction.TransactionType.Expense, "Квартплата");
                AddTransaction(context, 1, 4, new DateTime(2023, 9, 1), 2200.00m, Transaction.TransactionType.Expense, "Комунальні виплати");
                AddTransaction(context, 1, 1, new DateTime(2023, 9, 10), 20000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 2, 1, new DateTime(2023, 9, 15), 15000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 1, 3, new DateTime(2023, 9, 10), 3500.00m, Transaction.TransactionType.Expense, "Пальне");
                AddTransaction(context, 1, 4, new DateTime(2023, 9, 3), 250.00m, Transaction.TransactionType.Expense, "Оплата інтернету");
                AddTransaction(context, 3, 8, new DateTime(2023, 9, 14), 1300.00m, Transaction.TransactionType.Expense, "Курси англійської");
                AddTransaction(context, 3, 8, new DateTime(2023, 9, 1), 300.00m, Transaction.TransactionType.Expense, "Школа");
                AddTransaction(context, 2, 2, new DateTime(2023, 9, 5), 2800.00m, Transaction.TransactionType.Income, "Продукти");
                AddTransaction(context, 1, 10, new DateTime(2023, 9, 3), 100.00m, Transaction.TransactionType.Expense, "Благодійний внесок");


                AddTransaction(context, 1, 4, new DateTime(2023, 8, 1), 8000.00m, Transaction.TransactionType.Expense, "Квартплата");
                AddTransaction(context, 1, 4, new DateTime(2023, 8, 1), 2200.00m, Transaction.TransactionType.Expense, "Комунальні виплати");
                AddTransaction(context, 1, 1, new DateTime(2023, 8, 10), 20000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 2, 1, new DateTime(2023, 8, 15), 15000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 1, 3, new DateTime(2023, 8, 10), 3500.00m, Transaction.TransactionType.Expense, "Пальне");
                AddTransaction(context, 1, 4, new DateTime(2023, 8, 3), 250.00m, Transaction.TransactionType.Expense, "Оплата інтернету");
                AddTransaction(context, 3, 8, new DateTime(2023, 8, 14), 1300.00m, Transaction.TransactionType.Expense, "Курси англійської");
                AddTransaction(context, 3, 8, new DateTime(2023, 8, 10), 1800.00m, Transaction.TransactionType.Expense, "Літній лагерь");
                AddTransaction(context, 2, 2, new DateTime(2023, 8, 5), 2800.00m, Transaction.TransactionType.Income, "Продукти");
                AddTransaction(context, 2, 5, new DateTime(2023, 8, 3), 6500.00m, Transaction.TransactionType.Expense, "Подарунок чоловіку");
                AddTransaction(context, 2, 10, new DateTime(2023, 8, 3), 320.00m, Transaction.TransactionType.Expense, "Благодійний внесок");


                AddTransaction(context, 1, 4, new DateTime(2023, 7, 1), 8000.00m, Transaction.TransactionType.Expense, "Квартплата");
                AddTransaction(context, 1, 4, new DateTime(2023, 7, 1), 2200.00m, Transaction.TransactionType.Expense, "Комунальні виплати");
                AddTransaction(context, 1, 1, new DateTime(2023, 7, 10), 20000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 2, 1, new DateTime(2023, 7, 15), 15000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 1, 3, new DateTime(2023, 7, 10), 3500.00m, Transaction.TransactionType.Expense, "Пальне");
                AddTransaction(context, 1, 4, new DateTime(2023, 7, 3), 250.00m, Transaction.TransactionType.Expense, "Оплата інтернету");
                AddTransaction(context, 3, 8, new DateTime(2023, 7, 14), 1300.00m, Transaction.TransactionType.Expense, "Курси англійської");
                AddTransaction(context, 3, 8, new DateTime(2023, 7, 10), 1810.00m, Transaction.TransactionType.Expense, "Літній лагерь");
                AddTransaction(context, 2, 2, new DateTime(2023, 7, 5), 2800.00m, Transaction.TransactionType.Income, "Продукти");
                AddTransaction(context, 1, 10, new DateTime(2023, 7, 3), 200.00m, Transaction.TransactionType.Expense, "Благодійний внесок");


                AddTransaction(context, 1, 4, new DateTime(2023, 6, 1), 8000.00m, Transaction.TransactionType.Expense, "Квартплата");
                AddTransaction(context, 1, 4, new DateTime(2023, 6, 1), 2200.00m, Transaction.TransactionType.Expense, "Комунальні виплати");
                AddTransaction(context, 1, 1, new DateTime(2023, 6, 10), 20000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 2, 1, new DateTime(2023, 6, 15), 15000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 1, 3, new DateTime(2023, 6, 10), 3500.00m, Transaction.TransactionType.Expense, "Пальне");
                AddTransaction(context, 1, 4, new DateTime(2023, 6, 3), 250.00m, Transaction.TransactionType.Expense, "Оплата інтернету");
                AddTransaction(context, 3, 8, new DateTime(2023, 6, 14), 1300.00m, Transaction.TransactionType.Expense, "Курси англійської");
                AddTransaction(context, 3, 8, new DateTime(2023, 6, 10), 1600.00m, Transaction.TransactionType.Expense, "Літній лагерь");
                AddTransaction(context, 2, 2, new DateTime(2023, 6, 5), 2800.00m, Transaction.TransactionType.Income, "Продукти");
                AddTransaction(context, 1, 10, new DateTime(2023, 6, 7), 500.00m, Transaction.TransactionType.Expense, "Благодійний внесок");


                AddTransaction(context, 1, 4, new DateTime(2023, 5, 1), 8000.00m, Transaction.TransactionType.Expense, "Квартплата");
                AddTransaction(context, 1, 4, new DateTime(2023, 5, 1), 2200.00m, Transaction.TransactionType.Expense, "Комунальні виплати");
                AddTransaction(context, 1, 1, new DateTime(2023, 5, 10), 20000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 2, 1, new DateTime(2023, 5, 15), 15000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 1, 3, new DateTime(2023, 5, 10), 3500.00m, Transaction.TransactionType.Expense, "Пальне");
                AddTransaction(context, 1, 4, new DateTime(2023, 5, 3), 250.00m, Transaction.TransactionType.Expense, "Оплата інтернету");
                AddTransaction(context, 3, 8, new DateTime(2023, 5, 14), 1300.00m, Transaction.TransactionType.Expense, "Курси англійської");
                AddTransaction(context, 3, 8, new DateTime(2023, 5, 10), 1500.00m, Transaction.TransactionType.Expense, "Школа");
                AddTransaction(context, 2, 2, new DateTime(2023, 5, 5), 2800.00m, Transaction.TransactionType.Income, "Продукти");
                AddTransaction(context, 1, 5, new DateTime(2023, 5, 29), 1050.00m, Transaction.TransactionType.Expense, "Подарунок сестрі");
                AddTransaction(context, 1, 10, new DateTime(2023, 5, 5), 450.00m, Transaction.TransactionType.Expense, "Благодійний внесок");


                AddTransaction(context, 1, 4, new DateTime(2023, 4, 1), 8000.00m, Transaction.TransactionType.Expense, "Квартплата");
                AddTransaction(context, 1, 4, new DateTime(2023, 4, 1), 2200.00m, Transaction.TransactionType.Expense, "Комунальні виплати");
                AddTransaction(context, 1, 1, new DateTime(2023, 4, 10), 20000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 2, 1, new DateTime(2023, 4, 15), 15000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 1, 3, new DateTime(2023, 4, 10), 3500.00m, Transaction.TransactionType.Expense, "Пальне");
                AddTransaction(context, 1, 4, new DateTime(2023, 4, 3), 250.00m, Transaction.TransactionType.Expense, "Оплата інтернету");
                AddTransaction(context, 3, 8, new DateTime(2023, 4, 14), 1300.00m, Transaction.TransactionType.Expense, "Курси англійської");
                AddTransaction(context, 3, 8, new DateTime(2023, 4, 10), 1500.00m, Transaction.TransactionType.Expense, "Школа");
                AddTransaction(context, 2, 2, new DateTime(2023, 4, 5), 2800.00m, Transaction.TransactionType.Expense, "Продукти");
                AddTransaction(context, 1, 10, new DateTime(2023, 4, 3), 360.00m, Transaction.TransactionType.Expense, "Благодійний внесок");


                AddTransaction(context, 1, 4, new DateTime(2023, 3, 1), 8000.00m, Transaction.TransactionType.Expense, "Квартплата");
                AddTransaction(context, 1, 4, new DateTime(2023, 3, 1), 2200.00m, Transaction.TransactionType.Expense, "Комунальні виплати");
                AddTransaction(context, 1, 1, new DateTime(2023, 3, 10), 20000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 2, 1, new DateTime(2023, 3, 15), 15000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 1, 3, new DateTime(2023, 3, 10), 3500.00m, Transaction.TransactionType.Expense, "Пальне");
                AddTransaction(context, 1, 4, new DateTime(2023, 3, 3), 250.00m, Transaction.TransactionType.Expense, "Оплата інтернету");
                AddTransaction(context, 3, 8, new DateTime(2023, 3, 14), 1300.00m, Transaction.TransactionType.Expense, "Курси англійської");
                AddTransaction(context, 3, 8, new DateTime(2023, 3, 10), 1500.00m, Transaction.TransactionType.Expense, "Школа");
                AddTransaction(context, 2, 2, new DateTime(2023, 3, 5), 2800.00m, Transaction.TransactionType.Expense, "Продукти");
                AddTransaction(context, 1, 5, new DateTime(2023, 3, 18), 1200.00m, Transaction.TransactionType.Expense, "Подарунок дідусю");
                AddTransaction(context, 1, 5, new DateTime(2023, 3, 25), 4200.00m, Transaction.TransactionType.Expense, "Подарунок дитині");
                AddTransaction(context, 1, 10, new DateTime(2023, 3, 10), 700.00m, Transaction.TransactionType.Expense, "Благодійний внесок");


                AddTransaction(context, 1, 4, new DateTime(2023, 2, 1), 8000.00m, Transaction.TransactionType.Expense, "Квартплата");
                AddTransaction(context, 1, 4, new DateTime(2023, 2, 1), 2200.00m, Transaction.TransactionType.Expense, "Комунальні виплати");
                AddTransaction(context, 1, 1, new DateTime(2023, 2, 10), 20000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 2, 1, new DateTime(2023, 2, 15), 15000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 1, 3, new DateTime(2023, 2, 10), 3500.00m, Transaction.TransactionType.Expense, "Пальне");
                AddTransaction(context, 1, 4, new DateTime(2023, 2, 3), 250.00m, Transaction.TransactionType.Expense, "Оплата інтернету");
                AddTransaction(context, 3, 8, new DateTime(2023, 2, 14), 1300.00m, Transaction.TransactionType.Expense, "Курси англійської");
                AddTransaction(context, 3, 8, new DateTime(2023, 2, 10), 1500.00m, Transaction.TransactionType.Expense, "Школа");
                AddTransaction(context, 2, 2, new DateTime(2023, 2, 5), 2800.00m, Transaction.TransactionType.Expense, "Продукти");
                AddTransaction(context, 1, 5, new DateTime(2023, 2, 12), 5600.00m, Transaction.TransactionType.Expense, "Подарунок дружині");
                AddTransaction(context, 1, 10, new DateTime(2023, 2, 22), 2000.00m, Transaction.TransactionType.Expense, "Благодійний внесок");


                AddTransaction(context, 1, 4, new DateTime(2023, 1, 1), 8000.00m, Transaction.TransactionType.Expense, "Квартплата");
                AddTransaction(context, 1, 4, new DateTime(2023, 1, 1), 2200.00m, Transaction.TransactionType.Expense, "Комунальні виплати");
                AddTransaction(context, 1, 1, new DateTime(2023, 1, 10), 20000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 2, 1, new DateTime(2023, 1, 15), 15000.00m, Transaction.TransactionType.Income, "Зарплата");
                AddTransaction(context, 1, 3, new DateTime(2023, 1, 10), 3500.00m, Transaction.TransactionType.Expense, "Пальне");
                AddTransaction(context, 1, 4, new DateTime(2023, 1, 3), 250.00m, Transaction.TransactionType.Expense, "Оплата інтернету");
                AddTransaction(context, 3, 8, new DateTime(2023, 1, 14), 1300.00m, Transaction.TransactionType.Expense, "Курси англійської");
                AddTransaction(context, 3, 8, new DateTime(2023, 1, 10), 1500.00m, Transaction.TransactionType.Expense, "Школа");
                AddTransaction(context, 2, 2, new DateTime(2023, 1, 5), 2800.00m, Transaction.TransactionType.Expense, "Продукти");
                AddTransaction(context, 2, 5, new DateTime(2023, 1, 2), 1000.00m, Transaction.TransactionType.Expense, "Подарунок дідусю");




                //Збереження змін у базі даних
                dbContext.SaveChanges();
            }
        }

        private void AddCategory(BudgetContext context, string categoryName)
        {
            var category = context.Categories.FirstOrDefault(c => c.NameCategory == categoryName);

            if (category == null)
            {
                category = new Category { NameCategory = categoryName };
                context.Categories.Add(category);
                context.SaveChanges(); // Збереження категорії у базі даних
            }
        }

        private void AddUser(BudgetContext context, string username, string password, bool isFirstLogin)
        {
            // нижній регістр
            username = username.ToLower();

            // Перевірка чи користувач вже існує за ім'ям
            var existingUser = context.Users.FirstOrDefault(u => u.Username == username);

            if (existingUser == null)
            {
                // Якщо користувача з таким ім'ям ще немає, то додати його
                var newUser = new User
                {
                    Username = username,
                    Password = password, 
                    IsFirstLogin = isFirstLogin
                };

                context.Users.Add(newUser);
                context.SaveChanges(); 

            }
            else
            {
                Console.WriteLine($"Користувач з ім'ям {username} вже існує.");
            }
        }

        private void AddTransaction(BudgetContext context, int userId, int categoryId, DateTime dateTime, decimal amount, Transaction.TransactionType type, string comment)
        {
            var user = context.Users.Find(userId);
            var category = context.Categories.Find(categoryId);

            if (user != null && category != null)
            {
                var transaction = new Transaction
                {
                    User = user,
                    Category = category,
                    DateTime = dateTime,
                    Amount = amount,
                    Type = type,
                    Description = new Description { Comment = comment }
                };

                context.Transactions.Add(transaction);
                context.SaveChanges(); // Збереження транзакції у базі даних
            }
        }

    }
}

