using Microsoft.EntityFrameworkCore;
using SIRH_DataBase;
using System;

namespace SIRH_Infrastructure
{
    public class BaseDataAccess : IDisposable
    {
        protected readonly DatabaseContext _context;
        public BaseDataAccess(DbContextOptions<DatabaseContext> options)
        {
            _context = new DatabaseContext(options);
        }

        #region IDisposable Support

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                    _context.Dispose();
                disposedValue = true;
            }
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}

