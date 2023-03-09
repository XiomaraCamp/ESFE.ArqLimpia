using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XiomaraCampos.BL.DTOs;
using XiomaraCampos.BL.DTOs.UserDTOs;

namespace XiomaraCampos.BL.Interfaces
{
    public interface IUserBL
    {
        Task<CreateUserOutputDTO> Create(CreateUserInputDTO pUser);
        Task<int> Update(UpdateUserDTO pUser);
        Task<int> Delete(DeleteUserDTO pUser);
        Task<GetByIdUserOutputDTO> GetById(GetByIdUserInputDTO pUser);
        Task<List<SearchUserOutputDTO>> Search(SearchUserInputDTO pUser);
    }
}
