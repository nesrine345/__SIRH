using SIRH_DataBase.Entities;


namespace SIRH_Infrastructure.Interface
{
    public interface IJwtTokenGenerator
    {
        public string GenerateToken(ApplicationUser user);
    }
}
