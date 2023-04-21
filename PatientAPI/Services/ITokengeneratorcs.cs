namespace PatientAPI.Services
{
    public interface ITokengeneratorcs
    {
        string GenerateToken(int id, string name);
    }
}
