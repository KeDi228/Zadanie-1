using SampleHierarchies.Data;

namespace SampleHierarchies.Gui;

/// <summary>C
/// Abstract base class for a screen.
/// </summary>
public abstract class Screen
{
    #region Public Properties and Methods

    public static List<ScreenSettings>? ScreenSetting = new List<ScreenSettings>();

    /// <summary>
    /// Show the screen.
    /// </summary>
    public virtual void Show()
    {
        Console.WriteLine("Showing screen");
    }
    
    #endregion // Public Methods
}
