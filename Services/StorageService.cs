using System.Threading.Tasks;
using Blazored.LocalStorage;

namespace todo_blazor.Services
{
  public class StorageService : IStorageService
  {
    private readonly ILocalStorageService _localStorageService;

    public StorageService(ILocalStorageService localStorageService)
    {
        _localStorageService = localStorageService;
    }

    public async Task<T> GetItemAsync<T>(string key)
    {
      return await _localStorageService.GetItemAsync<T>(key);
    }

    public async Task ClearLocalStorage()
    {
      await _localStorageService.ClearAsync();
    }

    public async Task UpdateLocalStorage(string key, object data)
    {
      await _localStorageService.SetItemAsync(key, data);
    }
  }
}