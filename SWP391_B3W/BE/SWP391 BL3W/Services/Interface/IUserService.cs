using Microsoft.AspNetCore.Mvc;
using SWP391_BL3W.DTO;

namespace SWP391_BL3W.Services.Interface
{
    public interface IUserService
    {
        Task<IActionResult> EditAvater(string link, int userId);
<<<<<<< HEAD

        Task<StatusResponse<UserResponseDto>> SignIn(string email, string password);
=======
>>>>>>> a6a0077817a1ecc44bc9adab798a0df24c169694
        Task<StatusResponse<UserResponseDto>> CreateUser(CreateUserDTO user);

        Task<IEnumerable<UserResponseDto>> GetUsers(int? pageNumber, int? pageSize);

        Task<StatusResponse<UserResponseDto>> GetUser(int id);

        Task<StatusResponse<UserResponseDto>> UpdateUser(UpdateUserDTO user);
    }
}
