using System.Threading.Tasks;

namespace todo_blazor.Services
{
  public interface IStorageService
  {
    Task<T> GetItemAsync<T>(string key);
    Task ClearLocalStorage();
    Task UpdateLocalStorage(string key, object data);
  }
}