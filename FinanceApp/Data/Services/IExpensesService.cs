using FinanceApp.Models;

namespace FinanceApp.Data.Services
{
    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetAll();
        Task Add(Expense expense);
        Task<Expense> GetById(int id);
        Task Update(Expense expense);
        Task Delete(int id);
        IQueryable GetChartData();
    }
}
