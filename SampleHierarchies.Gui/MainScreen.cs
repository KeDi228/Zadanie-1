using SampleHierarchies.Enums;
using SampleHierarchies.Interfaces.Services;
using SampleHierarchies.Services;

namespace SampleHierarchies.Gui;

/// <summary>
/// Application main screen.
/// </summary>
public sealed class MainScreen : Screen
{
    #region Properties And Ctor

    /// <summary>
    /// Data service.
    /// </summary>
    private IDataService _dataService;

    /// <summary>
    /// Animals screen.
    /// </summary>
    private AnimalsScreen _animalsScreen;

    /// <summary>
    /// Colors screen.
    /// </summary>
    private ColorScreen _colorScreen;

    private readonly SettingsService settingsService = new();//KeDi

    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="dataService">Data service reference</param>
    /// <param name="animalsScreen">Animals screen</param>
    /// <param name="colorScreen">Colors screen</param>

    public MainScreen(
        IDataService dataService,
        AnimalsScreen animalsScreen,
        ColorScreen colorScreen)

    {
        _dataService = dataService;
        _animalsScreen = animalsScreen;
        _colorScreen = colorScreen;
    }


    #endregion Properties And Ctor

    #region Public Methods

        /// <inheritdoc/>
    public override void Show()
    {
        Console.Clear();
        settingsService.RenderScreen(ScreenSetting,1);
        while (true)
        {
          
            Console.WriteLine("Your available choices are:");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Animals");
            Console.WriteLine("2. Adjust color settings");
            Console.Write("Please enter your choice: ");

            string? choiceAsString = Console.ReadLine();

            // Validate choice
            try
            {
                if (choiceAsString is null)
                {
                    throw new ArgumentNullException(nameof(choiceAsString));
                }

                MainScreenChoices choice = (MainScreenChoices)Int32.Parse(choiceAsString);
                switch (choice)
                {
                    case MainScreenChoices.Animals:
                        _animalsScreen.Show();
                        break;

                    case MainScreenChoices.Settings:
                        _colorScreen.Show();        //KeDi
                        break;

                    case MainScreenChoices.Exit:
                        Console.WriteLine("Goodbye.");
                        return;

                }
            }
            catch
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }

    #endregion // Public Methods
}