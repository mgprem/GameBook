using LHBOL;
using System;
using System.Collections.Generic;

namespace LHDAL
{
    public interface IGamebookDb
    {
        IEnumerable<Gamebooks> GetAll();
        Gamebooks GetById(int id);
        bool Create(Gamebooks gamebooks);
        bool Update(Gamebooks gamebooks);
        bool Delete(int id);
    }
    public class GamebookDb : IGamebookDb
    {
        LHDbContext LHDbContext;
        public GamebookDb(LHDbContext _lHDbContext)
        {
            LHDbContext =  _lHDbContext;
        }

        public bool Create(Gamebooks gamebooks)
        {
            LHDbContext.Add(gamebooks);
            LHDbContext.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var Gamebooks = LHDbContext.Gamebooks.Find(id);
            LHDbContext.Remove<Gamebooks>(Gamebooks);
            LHDbContext.SaveChanges();
            return true;
        }

        public IEnumerable<Gamebooks> GetAll()
        {
            return LHDbContext.Gamebooks; 
        }

        public Gamebooks GetById(int id)
        {
            var Gamebooks = LHDbContext.Gamebooks.Find(id);
            return Gamebooks;
        }

        public bool Update(Gamebooks gamebooks)
        {
            LHDbContext.Update<Gamebooks>(gamebooks);
            LHDbContext.SaveChanges();
            return true;
        }
    }
}
