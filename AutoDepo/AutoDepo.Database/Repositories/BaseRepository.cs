using AutoDepoDB.Database.Context;

namespace AutoDepoDB.Database.Repositories
{
    public class BaseRepository
    {
        protected readonly AutoDepoDBContext _autodepoDBContext;

        public BaseRepository(AutoDepoDBContext autodepoDBContext)
        {
            this._autodepoDBContext = autodepoDBContext;
        }

        public void SaveChanges()
        {
            _autodepoDBContext.SaveChanges();
        }
    }
}
