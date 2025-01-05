using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class PythonAppModel : PageModel
{
    private readonly HttpClient _httpClient;

    public string ApiResponse { get; set; }
    
    public PythonAppModel()
    {
        _httpClient = new HttpClient();
    }

    public async Task OnGetAsync(string name)
    {
        // Base URL of your Python API
        var apiUrl = "http://127.0.0.1:5000/hello-name";

        // If a name is provided, add it as a query parameter
        if (!string.IsNullOrEmpty(name))
        {
            apiUrl += $"?name={name}";
        }

        // Call the API using HttpClient
        var response = await _httpClient.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            ApiResponse = await response.Content.ReadAsStringAsync();
        }
        else
        {
            ApiResponse = "Error calling API.";
        }
    }
}