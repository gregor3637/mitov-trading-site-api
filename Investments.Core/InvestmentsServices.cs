using Investments.DB;
using Microsoft.EntityFrameworkCore;

namespace Investments.Core
{
    public class InvestmentsServices : IInvestmentsServices
    {
        private AppDbContext _context;
        public InvestmentsServices(AppDbContext context)
        {
            _context = context;
        }

        public Investment CreateInvestment(Investment investment)
        {
            _context.Add(investment);
            _context.SaveChanges();
            return investment;
        }

        public void DeleteInvestment(Investment investment)
        {
            _context.Investments.Remove(investment);
            _context.SaveChanges();
        }

        public Investment EditInvestment(int id)
        {
            var found = _context.Investments.First(e => e.Id == id);
            found.Status = "closed";
            _context.SaveChanges();

            return found;
        }

        public Investment GetInvestment(int id)
        {
            return _context.Investments.First(e => e.Id == id);
        }

        public List<Investment> GetInvestments()
        {
            return _context.Investments.ToList();
        }
    }
}
