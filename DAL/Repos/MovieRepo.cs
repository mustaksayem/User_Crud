using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class MovieRepo : Repo, IRepo<Movie, int, bool>
    {
        public bool Create(Movie obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movie> Read()
        {
            return db.Movies.ToList();

        }

        public Movie Read(int id)
        {
            return db.Movies.Find(id);
        }

        public bool Update(Movie obj)
        {
            throw new NotImplementedException();
        }
    }
}
