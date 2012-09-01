using System.Linq;

namespace _004_RepositoryPattern.Models
{
    public class GeneroRepository
    {
        private readonly Entities _entities = new Entities();
        public IQueryable<Genero> GetGeneros()
        {
            return _entities.Generos;
        }

        public static void Save(Genero genero)
        {
            using (var db = new Entities())
            {
                if (genero.Id != 0) return;

                db.AddToGeneros(genero);
                db.SaveChanges();
            }
        }
    }
}