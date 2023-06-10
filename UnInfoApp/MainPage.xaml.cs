using UnInfoApp.Code;
using UnInfoApp.Models;

namespace UnInfoApp;

public partial class MainPage : ContentPage
{
	private List<Rootobject> rootobjects;
    private HttpHelper httpHelper;
    public MainPage()
	{
		InitializeComponent();
        rootobjects=new List<Rootobject>();
        httpHelper=new HttpHelper();

    }

    private void ButtonSearch_Clicked(object sender, EventArgs e)
    {
        if (countryName.Text != null)
        {

            LoadData(countryName.Text);


        }
    }

    private async void LoadData(string countryName)
    {

        // Clear
        rootobjects.Clear();
        ConLayout.Clear();
        // Get Respone and Fill root UN
        IndicatorLoading.IsRunning = true; IndicatorLoading.IsVisible = true;
        var respone =await httpHelper.GetResponeAsync("http://universities.hipolabs.com/search?country="+ countryName);
        rootobjects=Newtonsoft.Json.JsonConvert.DeserializeObject<List<Rootobject>>(respone); 
        // Foor loop into rootobjetcs
        for (int i = 0; i < rootobjects.Count; i++)
        {
            var item = rootobjects[i];
            ConLayout.Add(new Views.UnInfoView(item.name, item.web_pages[0]));
        }
        IndicatorLoading.IsRunning = false; IndicatorLoading.IsVisible = false;

    }
}

