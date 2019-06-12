using RegisterApi.Models;

namespace RegisterApi.Services 
{
    public interface IDataBaseService
    {
        string CreateRegister(Person person);
        Person[] GetAll();
    }
}