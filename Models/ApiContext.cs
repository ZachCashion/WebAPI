using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebAPI.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext()
            :base("APIConnection")
        {
        }

        public static ApiContext create()
        {
            return new ApiContext();
        }

        // Household
        public async Task<List<Households>> GetAllHouseholdData()
        {
            return await Database.SqlQuery<Households>("GetAllHouseholdData").ToListAsync();
        }

        public async Task<Households> GetHouseholds(int id)
        {
            return await Database.SqlQuery<Households>("GetHousehold @id",
                new SqlParameter("id", id)).FirstOrDefaultAsync();
        }

        public int AddHousehold(string name, string greeting)
        {
            return Database.ExecuteSqlCommand("AddHousehold @name, @greeting",
                new SqlParameter("name", name),
                new SqlParameter("greeting", greeting));
        }

        public int UpdateHousehold(int id, string name, string greeting)
        {
            return Database.ExecuteSqlCommand("UpdateHousehold @id, @name, @greeting",
                new SqlParameter("id", id),
                new SqlParameter("name", name),
                new SqlParameter("greeting", greeting));
        }

        //Bank Accounts
        public async Task<List<BankAccounts>> GetBankAccounts(int id)
        {
            return await Database.SqlQuery<BankAccounts>("GetBankAccounts @id",
                new SqlParameter("id", id)).ToListAsync();
        }

        public async Task<BankAccounts> GetBankAccountDetail(int id)
        {
            return await Database.SqlQuery<BankAccounts>("GetBankAccounts @id",
                new SqlParameter("id", id)).FirstOrDefaultAsync();
        }

        public int AddBankAccount(int hhId, string ownerId, string name, string start, string current, int accountType)
        {
            return Database.ExecuteSqlCommand("AddBankAccount @hhId, @ownerId, @name, @start, @current, @accountType",
                new SqlParameter("hhId", hhId),
                new SqlParameter("ownerId", ownerId),
                new SqlParameter("name", name),
                new SqlParameter("start", start),
                new SqlParameter("current", current),
                new SqlParameter("accountType", accountType));
        }

        //Transactions
        public int AddTransaction(int budgetId, int bankAccId, string ownerId, string amount, string memo, bool dipositWithdraw, int transactionCatagory)
        {
            return Database.ExecuteSqlCommand("AddTransaction @budgetId, @bankAcctId, @ownerId, @amount, @memo, @dipositWithdraw, @transactionCatagory",
                new SqlParameter("budgetId", budgetId),
                new SqlParameter("bankAcctId", bankAccId),
                new SqlParameter("ownerId", ownerId),
                new SqlParameter("amount", amount),
                new SqlParameter("memo", memo),
                new SqlParameter("dipositWithdraw", dipositWithdraw),
                new SqlParameter("transactionCatagory", transactionCatagory));
        }

        public async Task<List<Transactions>> GetTransactions(int id)
        {
            return await Database.SqlQuery<Transactions>("GetTransactions @id",
                new SqlParameter("id", id)).ToListAsync();
        }

        public async Task<Transactions> GetTransactionDetail(int id)
        {
            return await Database.SqlQuery<Transactions>("GetTransactionDetail @id",
                new SqlParameter("id", id)).FirstOrDefaultAsync();
        }

        //Budget
        public int AddBudget(int hhId, string ownerId, string name, string target, string current)
        {
            return Database.ExecuteSqlCommand("AddBudget @hhId, @ownerId, @name, @target, @current",
                new SqlParameter("hhId", hhId),
                new SqlParameter("ownerId", ownerId),
                new SqlParameter("name", name),
                new SqlParameter("target", target),
                new SqlParameter("current", current));
        }

        public async Task<List<Budgets>> GetBudgets(int id)
        {
            return await Database.SqlQuery<Budgets>("GetBudgets @id",
                new SqlParameter("id", id)).ToListAsync();
        }

        public async Task<Budgets> GetBudgetDetail(int id)
        {
            return await Database.SqlQuery<Budgets>("GetBudgetDetail @id",
                new SqlParameter("id", id)).FirstOrDefaultAsync();
        }

        //BudgetItems
        public async Task<List<BudgetItems>> GetBudgetItems(int id)
        {
            return await Database.SqlQuery<BudgetItems>("GetBudgetItems @id",
                new SqlParameter("id", id)).ToListAsync();
        }

        public async Task<BudgetItems> GetBudgetItemDetail(int id)
        {
            return await Database.SqlQuery<BudgetItems>("GetBudgetItemDetail @id",
                new SqlParameter("id", id)).FirstOrDefaultAsync();
        }
    }
}