using SistemaGestaoDeBovinos.Data;
using SistemaGestaoDeBovinos.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestaoDeBovinos.Services
{
    public class PastoService
    {
        private readonly AppDbContext _context;

        public PastoService()
        {
            _context = new AppDbContext();
        }

        public List<Pasto> GetAll()
        {
            return _context.Pastos.ToList();
        }

        public void Add(Pasto pasto)
        {
            _context.Pastos.Add(pasto);
            _context.SaveChanges();
        }

        public void Update(Pasto pasto)
        {
            _context.Pastos.Update(pasto);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var pasto = _context.Pastos.Find(id);
            if (pasto != null)
            {
                _context.Pastos.Remove(pasto);
                _context.SaveChanges();
            }
        }
    }
}
