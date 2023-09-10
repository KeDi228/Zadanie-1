using Newtonsoft.Json;
using SampleHierarchies.Data;
using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Services;
using System.Diagnostics;

namespace SampleHierarchies.Services;

/// <summary>C
/// Implementation of Settings service.
/// </summary>
public class SettingsService : ISettingsService
{
    #region ISettings Implementation

    public ScreenSettings? ScreenSettings { get; set; }//KeDi

    public bool Read(string jsonPath)//KeDi
    {
        bool result = true;
        try
        {
            string jsonContent = File.ReadAllText(jsonPath);
            var jsonSettings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Objects
            };
            ScreenSettings = JsonConvert.DeserializeObject<ScreenSettings>(jsonContent, jsonSettings);
            if (ScreenSettings is null)
            {
                result = false;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            result = false;
        }
        return result;
        //KeDi
    }

    public bool Write(string jsonPath)
    {
        bool result = true;
        try
        {
            var jsonSettings = new JsonSerializerSettings();
            string jsonContent = JsonConvert.SerializeObject(ScreenSettings);          
            string jsonContentFormatted = jsonContent.FormatJson();
            File.WriteAllText(jsonPath, jsonContentFormatted);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            result = false;
        }
        return result;
    }
    #endregion // ISettings Implementation

    #region Public methods

    public void RenderScreen(List<ScreenSettings> screenSettings, int screenNumber)
    {
        if (screenSettings.Exists(x => x.ScreenNumber == screenNumber))
        {
            Console.ForegroundColor = screenSettings.Find(x => x.ScreenNumber == screenNumber).MainTextColor;
            Console.BackgroundColor = screenSettings.Find(x => x.ScreenNumber == screenNumber).MainBackgroundColor;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
 
    #endregion//Public methods
}