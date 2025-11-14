using SistemaGestaoDeBovinos.Data;
using SistemaGestaoDeBovinos.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestaoDeBovinos.Services
{
    public class EstoqueService
    {
        private readonly AppDbContext _context;

        public EstoqueService()
        {
            _context = new AppDbContext();
        }

        public List<Estoque> GetAll()
        {
            return _context.Estoques.ToList();
        }

        public void Add(Estoque estoque)
        {
            _context.Estoques.Add(estoque);
            _context.SaveChanges();
        }

        public void Update(Estoque estoque)
        {
            _context.Estoques.Update(estoque);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var estoque = _context.Estoques.Find(id);
            if (estoque != null)
            {
                _context.Estoques.Remove(estoque);
                _context.SaveChanges();
            }
        }
    }
}
