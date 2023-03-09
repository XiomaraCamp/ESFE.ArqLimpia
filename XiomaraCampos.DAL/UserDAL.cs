using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XiomaraCampos.EN;
using XiomaraCampos.EN.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace XiomaraCampos.DAL
{
    public class UserDAL :IUser
    {
        readonly XiomaraCamposDbContext dbContext;
        public UserDAL(XiomaraCamposDbContext pDbContext)
        {
            dbContext = pDbContext;
        }
        public void Create(User pUser)
        {
            dbContext.Add(pUser);
        }

        public void Delete(User pUser)
        {
            dbContext.Remove(pUser);
        }

        public async Task<User> GetById(User pUser)
        {
            User? user = await dbContext.User.FirstOrDefaultAsync(s => s.Id == pUser.Id);
            if (user != null)
                return user;
            else
                return new User();
        }

        public Task<List<User>> Search(User pUser)
        {
            var query = dbContext.User.AsQueryable();
            if (!string.IsNullOrWhiteSpace(pUser.Name))
                query = query.Where(s => s.Name.Contains(pUser.Name));
            if (!string.IsNullOrWhiteSpace(pUser.Email))
                query = query.Where(s => s.Email == pUser.Email);
            return query.ToListAsync();
        }

        public void Update(User pUser)
        {
            dbContext.Update(pUser);
        }
    }
}
