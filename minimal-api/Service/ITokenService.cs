namespace minimal_api.Services;
public interface ITokenService
{
    string GetToken(DbUser user);
}
