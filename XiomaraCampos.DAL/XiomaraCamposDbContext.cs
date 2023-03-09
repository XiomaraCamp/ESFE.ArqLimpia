using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESFE.ArqLimpia.EN;
using Microsoft.EntityFrameworkCore;
using XiomaraCampos.EN.Interfaces;

namespace XiomaraCampos.DAL
{
    public class XiomaraCamposDbContext : DbContext
    {
        public XiomaraCamposDbContext(DbContextOptions<XiomaraCamposDbContext> options) : base(options) { }
        public DbSet<User> User { get; set; }
    }
}
