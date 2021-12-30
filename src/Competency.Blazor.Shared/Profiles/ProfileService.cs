using Blazored.LocalStorage;
using Microsoft.JSInterop;

namespace Competency.Blazor.Shared.Profiles;

public class ProfileService
{
  private readonly ILocalStorageService _localStorageService;
  private readonly IJSRuntime _jsRuntime;

  public ProfileService(ILocalStorageService localStorageService,
    IJSRuntime jsRuntime)
  {
    _localStorageService = localStorageService;
    _jsRuntime = jsRuntime;
  }

  public event Action<Preference>? Onchange; 

  public async Task ToggleDarkMode()
  {
    var preferences = await GetPreferences();
    var newPreferences = preferences with { DarkMode = !preferences.DarkMode };

    await _localStorageService.SetItemAsync("preferences", newPreferences);
    Onchange?.Invoke(newPreferences);
  }

  public async Task<Preference> GetPreferences()
  {
    if (await _localStorageService.ContainKeyAsync("preferences"))
      return await _localStorageService.GetItemAsync<Preference>("preferences") ?? new Preference();
    bool prefersDarkMode = false;
    try
    {
      prefersDarkMode = await _jsRuntime.InvokeAsync<bool>("prefersDarkMode");
    }
    catch (Exception ex)
    {
      Console.Write(ex.ToString());
    }

    return new Preference { DarkMode = prefersDarkMode };
  }
}
