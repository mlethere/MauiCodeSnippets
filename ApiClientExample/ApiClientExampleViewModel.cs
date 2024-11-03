using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiCodeSnippets.ApiClientExample;

/// <summary>
/// This just calls an API that I created with that URL, and it returns some content.
/// I didn't deserialize it, as I couldn't figure out why a simple string list wouldn't work.
/// https://learn.microsoft.com/en-us/dotnet/maui/data-cloud/rest?view=net-maui-8.0
/// </summary>
public partial class ApiClientExampleViewModel : ObservableObject
{
    [ObservableProperty]
    private string apiOutput = string.Empty;

    [RelayCommand]
    private async Task GetData()
    {
        ApiOutput = "Loading...";

        using (HttpClient client = new HttpClient())
        {
            // Can only create new Mock Bins .. cannot change
            Uri uri = new(string.Format("https://7151049f826847ec81e4e500610bd6b9.api.mockbin.io/", string.Empty));

            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();

                // Coultn't get this to work - but was a bit out of my scope
                //     var x = JsonSerializer.Deserialize<List<string>>(content, _serializerOptions);

                ApiOutput = content;
            }
            else
                ApiOutput = "Failed to connect to URI";
        }
    }
}