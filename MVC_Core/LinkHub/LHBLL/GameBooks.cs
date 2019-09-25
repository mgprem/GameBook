using LHBOL;
using System;
using System.Collections.Generic;
using LHBLL;
using LHDAL;

namespace LHBLL
{
    public interface IGamebookBs
    {
        IEnumerable<Gamebooks> GetAll();
        Gamebooks GetById(int id);
        bool Create(Gamebooks gamebooks);
        bool Update(Gamebooks gamebooks);
        bool Delete(int id);
    }
    public class GameBookBs : IGamebookBs
    {
        IGamebookDb GamebookDB;
        public GameBookBs(IGamebookDb _GamebookDB)
        {
            GamebookDB = _GamebookDB;
        }
        public bool Create(Gamebooks gamebooks)
        {
            return GamebookDB.Create(gamebooks);
        }

        public bool Delete(int id)
        {
            return GamebookDB.Delete(id);
        }

        public IEnumerable<Gamebooks> GetAll()
        {
            var gamebook = GamebookDB.GetAll();
            return gamebook;
        }

        public Gamebooks GetById(int id)
        {
            var gamebook = GamebookDB.GetById(id);
            return gamebook;
        }

        public bool Update(Gamebooks gamebooks)
        {
            return GamebookDB.Update(gamebooks);
        }
    }
}
