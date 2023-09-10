// KeDi

using SampleHierarchies.Data.Mammals;
using SampleHierarchies.Enums;
using SampleHierarchies.Interfaces.Services;

namespace SampleHierarchies.Gui;

/// <summary>
/// Mammals main screen.
/// </summary>
public sealed class WolvesScreen : Screen
{
    #region Properties And Ctor

    /// <summary>
    /// Data service.
    /// </summary>
    public IDataService _dataService;

    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="dataService">Data service reference</param>
    public WolvesScreen(IDataService dataService)
    {
        _dataService = dataService;
    }

    #endregion Properties And Ctor

    #region Public Methods

    /// <inheritdoc/>
    public override void Show()
    {
        Console.Clear();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Your available choices are:");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. List all Wolves");
            Console.WriteLine("2. Create a new Wolf");
            Console.WriteLine("3. Delete existing Wolf");
            Console.WriteLine("4. Modify existing Wolf");
            Console.Write("Please enter your choice: ");

            string? choiceAsString = Console.ReadLine();

            // Validate choice
            try
            {
                if (choiceAsString is null)
                {
                    throw new ArgumentNullException(nameof(choiceAsString));
                }

                WolvesScreenChoices choice = (WolvesScreenChoices)Int32.Parse(choiceAsString);
                switch (choice)
                {
                    case WolvesScreenChoices.List:
                        ListWolves();
                        break;

                    case WolvesScreenChoices.Create:
                        AddWolf(); break;

                    case WolvesScreenChoices.Delete:
                        DeleteWolf();
                        break;

                    case WolvesScreenChoices.Modify:
                        EditWolfMain();
                        break;

                    case WolvesScreenChoices.Exit:
                        Console.WriteLine("Going back to previous menu.");
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

    #region Private Methods

    /// <summary>
    /// List all wolves.
    /// </summary>
    private void ListWolves()
    {
        Console.WriteLine();
        if (_dataService?.Animals?.Mammals?.Wolves is not null &&
            _dataService.Animals.Mammals.Wolves.Count > 0)
        {
            Console.WriteLine("Here's a list of Wolves:");
            int i = 1;
            foreach (Wolf wolf in _dataService.Animals.Mammals.Wolves)
            {
                Console.Write($"Wolf number {i}, ");
                wolf.Display();
                i++;
            }
        }
        else
        {
            Console.WriteLine("The list of wolves is empty.");
        }
    }

    /// <summary>
    /// Add a wolf.
    /// </summary>
    private void AddWolf()
    {
        try
        {
            Wolf wolf = AddEditWolf();
            _dataService?.Animals?.Mammals?.Wolves?.Add(wolf);
            Console.WriteLine("Wolf with name: {0} has been added to a list of wolves", wolf.Name);
        }
        catch
        {
            Console.WriteLine("Invalid input.");
        }
    }

    /// <summary>
    /// Deletes a wolf.
    /// </summary>
    private void DeleteWolf()
    {
        try
        {
            Console.Write("What is the name of the wolf you want to delete? ");
            string? name = Console.ReadLine();
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            Wolf? wolf = (Wolf?)(_dataService?.Animals?.Mammals?.Wolves
                ?.FirstOrDefault(d => d is not null && string.Equals(d.Name, name)));
            if (wolf is not null)
            {
                _dataService?.Animals?.Mammals?.Wolves?.Remove(wolf);
                Console.WriteLine("Wolf with name: {0} has been deleted from a list of wolves", wolf.Name);
            }
            else
            {
                Console.WriteLine("Wolf not found.");
            }
        }
        catch
        {
            Console.WriteLine("Invalid input.");
        }
    }

    /// <summary>
    /// Edits an existing wolf after choice made.
    /// </summary>
    private void EditWolfMain()
    {
        try
        {
            Console.Write("What is the name of the wolf you want to edit? ");
            string? name = Console.ReadLine();
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            Wolf? wolf = (Wolf?)(_dataService?.Animals?.Mammals?.Wolves
                ?.FirstOrDefault(d => d is not null && string.Equals(d.Name, name)));
            if (wolf is not null)
            {
                Wolf wolfEdited = AddEditWolf();
                wolf.Copy(wolfEdited);
                Console.Write("Wolf after edit:");
                wolf.Display();
            }
            else
            {
                Console.WriteLine("Wolf not found.");
            }
        }
        catch
        {
            Console.WriteLine("Invalid input. Try again.");
        }
    }

    /// <summary>
    /// Adds/edit specific wolf.
    /// </summary>
    /// <exception cref="ArgumentNullException"></exception>
    private Wolf AddEditWolf()
    {
        Console.Write("What name of the wolf? ");
        string? name = Console.ReadLine();
        Console.Write("What is the wolf's age? ");
        string? ageAsString = Console.ReadLine();
        Console.Write("What is the wolf's breed? ");
        string? breed = Console.ReadLine();

        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }
        if (ageAsString is null)
        {
            throw new ArgumentNullException(nameof(ageAsString));
        }
        if (breed is null)
        {
            throw new ArgumentNullException(nameof(breed));
        }
        int age = Int32.Parse(ageAsString);
        Wolf wolf = new Wolf(name, age, breed);

        return wolf;
    }

    #endregion // Private Methods
}

// KeDi