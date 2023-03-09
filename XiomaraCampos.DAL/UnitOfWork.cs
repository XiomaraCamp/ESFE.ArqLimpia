using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XiomaraCampos.EN.Interfaces;

namespace XiomaraCampos.DAL
{
    public  class UnitOfWork
    {
        readonly XiomaraCamposDbContext dbContext;
        public UnitOfWork(XiomaraCamposDbContext pDbContext)
        {
            dbContext = pDbContext;
        }
        public Task<int> SaveChangesAsync()
        {
            return dbContext.SaveChangesAsync();
        }
    }
}
