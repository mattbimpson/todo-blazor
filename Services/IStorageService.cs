namespace todo_blazor.Services
{
  public interface IStorageService
  {
    void UpdateLocalStorage();

    void ClearLocalStorage();
  }
}