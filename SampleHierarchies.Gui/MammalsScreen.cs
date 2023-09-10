using SampleHierarchies.Data;
using SampleHierarchies.Enums;
using SampleHierarchies.Interfaces.Services;
using SampleHierarchies.Services;

namespace SampleHierarchies.Gui;

/// <summary>C
/// Mammals main screen.
/// </summary>
public sealed class MammalsScreen : Screen
{
    #region Properties And Ctor

    /// <summary>
    /// Animals screen.
    /// </summary>
    private DogsScreen _dogsScreen;

    /// <summary>
    /// Animals screen.
    /// </summary>
    private BearsScreen _bearsScreen;  // KeDi

    /// <summary>
    /// Animals screen.
    /// </summary>
    private LionsScreen _lionsScreen;  // KeDi

    /// <summary>
    /// Animals screen.
    /// </summary>
    private WolvesScreen _wolvesScreen;  // KeDi

    private readonly SettingsService settingsService = new();// KeDi

    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="dataService">Data service reference</param>
    /// <param name="dogsScreen">Dogs screen</param>
    /// <param name="bearsScreen">Bears screen</param>  // KeDi
    /// <param name="lionsScreen">Lions screen</param>  // KeDi
    /// <param name="wolvesScreen">Lions screen</param>  // KeDi

    public MammalsScreen(DogsScreen dogsScreen, BearsScreen bearsScreen,
        WolvesScreen wolvesScreen, LionsScreen lionsScreen) // KeDi
    {
        _dogsScreen = dogsScreen;
        _bearsScreen = bearsScreen;  // KeDi
        _lionsScreen = lionsScreen;  // KeDi
        _wolvesScreen = wolvesScreen;  // KeDi
    }

    #endregion Properties And Ctor

    #region Public Methods

    /// <inheritdoc/>
    public override void Show()
    {
        Console.Clear();

        settingsService.RenderScreen(ScreenSetting,3);

        while (true)
        {
            
            Console.WriteLine("Your available choices are:");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Dogs");
            Console.WriteLine("2. Bears");  // KeDi
            Console.WriteLine("3. Lions");  // KeDi
            Console.WriteLine("4. Wolves");  // KeDi
            Console.Write("Please enter your choice: ");

            string? choiceAsString = Console.ReadLine();

            // Validate choice
            try
            {
                if (choiceAsString is null)
                {
                    throw new ArgumentNullException(nameof(choiceAsString));
                }

                MammalsScreenChoices choice = (MammalsScreenChoices)Int32.Parse(choiceAsString);
                switch (choice)
                {
                    case MammalsScreenChoices.Dogs:
                        _dogsScreen.Show();
                        break;

                    // KeDi
                    case MammalsScreenChoices.Bears:
                        _bearsScreen.Show();
                        break;

                    case MammalsScreenChoices.Lions:
                        _lionsScreen.Show();
                        break;

                    case MammalsScreenChoices.Wolves:
                        _wolvesScreen.Show();
                        break;
                    // KeDi

                    case MammalsScreenChoices.Exit:
                        Console.Clear();

                        settingsService.RenderScreen(ScreenSetting, 2);

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
