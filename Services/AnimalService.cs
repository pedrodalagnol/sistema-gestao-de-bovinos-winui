using SistemaGestaoDeBovinos.Data;
using SistemaGestaoDeBovinos.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestaoDeBovinos.Services
{
    public class AnimalService
    {
        private readonly AppDbContext _context;

        public AnimalService()
        {
            _context = new AppDbContext();
        }

        public List<Animal> GetAll()
        {
            return _context.Animais.ToList();
        }

        public void Add(Animal animal)
        {
            _context.Animais.Add(animal);
            _context.SaveChanges();
        }

        public void Update(Animal animal)
        {
            _context.Animais.Update(animal);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var animal = _context.Animais.Find(id);
            if (animal != null)
            {
                _context.Animais.Remove(animal);
                _context.SaveChanges();
            }
        }
    }
}
