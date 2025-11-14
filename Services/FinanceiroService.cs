using SistemaGestaoDeBovinos.Data;
using SistemaGestaoDeBovinos.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestaoDeBovinos.Services
{
    public class FinanceiroService
    {
        private readonly AppDbContext _context;

        public FinanceiroService()
        {
            _context = new AppDbContext();
        }

        public List<Financeiro> GetAll()
        {
            return _context.Financeiros.ToList();
        }

        public void Add(Financeiro financeiro)
        {
            _context.Financeiros.Add(financeiro);
            _context.SaveChanges();
        }

        public void Update(Financeiro financeiro)
        {
            _context.Financeiros.Update(financeiro);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var financeiro = _context.Financeiros.Find(id);
            if (financeiro != null)
            {
                _context.Financeiros.Remove(financeiro);
                _context.SaveChanges();
            }
        }
    }
}
