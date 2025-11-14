using SistemaGestaoDeBovinos.Data;
using SistemaGestaoDeBovinos.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestaoDeBovinos.Services
{
    public class LoteService
    {
        private readonly AppDbContext _context;

        public LoteService()
        {
            _context = new AppDbContext();
        }

        public List<Lote> GetAll()
        {
            return _context.Lotes.ToList();
        }

        public void Add(Lote lote)
        {
            _context.Lotes.Add(lote);
            _context.SaveChanges();
        }

        public void Update(Lote lote)
        {
            _context.Lotes.Update(lote);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var lote = _context.Lotes.Find(id);
            if (lote != null)
            {
                _context.Lotes.Remove(lote);
                _context.SaveChanges();
            }
        }
    }
}
