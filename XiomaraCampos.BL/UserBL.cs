using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XiomaraCampos.BL.Interfaces;
using XiomaraCampos.EN.Interfaces;
using XiomaraCampos.EN;
using XiomaraCampos.BL.DTOs.UserDTOs;

namespace XiomaraCampos.BL
{
    public class UserBL : IUserBL
    {
        public Task<CreateUserOutputDTO> Create(CreateUserInputDTO pUser)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(DeleteUserDTO pUser)
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdUserOutputDTO> GetById(GetByIdUserInputDTO pUser)
        {
            throw new NotImplementedException();
        }

        public Task<List<SearchUserOutputDTO>> Search(SearchUserInputDTO pUser)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(UpdateUserDTO pUser)
        {
            throw new NotImplementedException();
        }
    }
}
