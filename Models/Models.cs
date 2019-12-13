using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Households
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Greating { get; set; }
        public DateTime Created { get; set; }
    }

    public class BankAccounts
    {
        public int Id { get; set; }
        public int HouseholdId { get; set; }
        public string OwnerId { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public enum AccountType { Checking, Savings, Credit }
        public string StartingBalance { get; set; }
        public string CurrentBalance { get; set; }
    }

    public class Budgets
    {
        public int Id { get; set; }
        public int HouseholdId { get; set; }
        public string OwnerId { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public string TargetAmount { get; set; }
        public string CurrentAmount { get; set; }

    }

    public class Transactions
    {
        public int Id { get; set; }
        public int? BudgetItemId { get; set; }
        public int BankAccountId { get; set; }
        public enum TransactionCatagory { Housing, Transportation, Food, Utilities, Clothing, Medical, Insurance, Personal, Debt, Education, Savings, Entertainment }
        public string OwnerId { get; set; }
        public DateTime Created { get; set; }
        public string Amount { get; set; }
        public string Memo { get; set; }
        public bool DipositWithdraw { get; set; }

    }

    public class BudgetItems
    {
        public int Id { get; set; }
        public int BudgetId { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public enum BudgetItemCatagory { Housing, Transportation, Food, Utilities, Clothing, Medical, Insurance, Personal, Debt, Education, Savings, Entertainment }
        public string Amount { get; set; }
        public string Frequency { get; set; }
        public bool IncomeExpense { get; set; }

    }


}