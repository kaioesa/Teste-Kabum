using IMS.CoreBusiness;

namespace IMS.UseCases.Interfaces
{
    public interface IViewUsersByNameUseCase
    {
        Task<IEnumerable<User>> ExecuteAsync(string name = "");
    }
}