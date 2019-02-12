using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Infra.Repositories
{
    public class UserRepository: RepositoryBase<User>, IUserRepository
    {
    }
}
