// KeDi

using SampleHierarchies.Data.Mammals;
using SampleHierarchies.Enums;
using SampleHierarchies.Interfaces.Services;

namespace SampleHierarchies.Gui;

/// <summary>
/// Mammals main screen.
/// </summary>
public sealed class BearsScreen : Screen
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
    public BearsScreen(IDataService dataService)
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
            
            Console.WriteLine("Your available choices are:");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. List all Bears");
            Console.WriteLine("2. Create a new Bear");
            Console.WriteLine("3. Delete existing Bear");
            Console.WriteLine("4. Modify existing Bear");
            Console.Write("Please enter your choice: ");

            string? choiceAsString = Console.ReadLine();

            // Validate choice
            try
            {
                if (choiceAsString is null)
                {
                    throw new ArgumentNullException(nameof(choiceAsString));
                }

                BearsScreenChoices choice = (BearsScreenChoices)Int32.Parse(choiceAsString);
                switch (choice)
                {
                    case BearsScreenChoices.List:
                        ListBears();
                        break;

                    case BearsScreenChoices.Create:
                        AddBear(); break;

                    case BearsScreenChoices.Delete:
                        DeleteBear();
                        break;

                    case BearsScreenChoices.Modify:
                        EditBearMain();
                        break;

                    case BearsScreenChoices.Exit:
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
    /// List all bears.
    /// </summary>
    private void ListBears()
    {
        Console.WriteLine();
        if (_dataService?.Animals?.Mammals?.Bears is not null &&
            _dataService.Animals.Mammals.Bears.Count > 0)
        {
            Console.WriteLine("Here's a list of Bears:");
            int i = 1;
            foreach (Bear bear in _dataService.Animals.Mammals.Bears)
            {
                Console.Write($"Bear number {i}, ");
                bear.Display();
                i++;
            }
        }
        else
        {
            Console.WriteLine("The list of bears is empty.");
        }
    }

    /// <summary>
    /// Add a bear.
    /// </summary>
    private void AddBear()
    {
        try
        {
            Bear bear = AddEditBear();
            _dataService?.Animals?.Mammals?.Bears?.Add(bear);
            Console.WriteLine("Bear with name: {0} has been added to a list of bears", bear.Name);
        }
        catch
        {
            Console.WriteLine("Invalid input.");
        }
    }

    /// <summary>
    /// Deletes a bear.
    /// </summary>
    private void DeleteBear()
    {
        try
        {
            Console.Write("What is the name of the bear you want to delete? ");
            string? name = Console.ReadLine();
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            Bear? bear = (Bear?)(_dataService?.Animals?.Mammals?.Bears
                ?.FirstOrDefault(d => d is not null && string.Equals(d.Name, name)));
            if (bear is not null)
            {
                _dataService?.Animals?.Mammals?.Bears?.Remove(bear);
                Console.WriteLine("Bear with name: {0} has been deleted from a list of bears", bear.Name);
            }
            else
            {
                Console.WriteLine("Bear not found.");
            }
        }
        catch
        {
            Console.WriteLine("Invalid input.");
        }
    }

    /// <summary>
    /// Edits an existing bear after choice made.
    /// </summary>
    private void EditBearMain()
    {
        try
        {
            Console.Write("What is the name of the bear you want to edit? ");
            string? name = Console.ReadLine();
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            Bear? bear = (Bear?)(_dataService?.Animals?.Mammals?.Bears
                ?.FirstOrDefault(d => d is not null && string.Equals(d.Name, name)));
            if (bear is not null)
            {
                Bear bearEdited = AddEditBear();
                bear.Copy(bearEdited);
                Console.Write("Bear after edit:");
                bear.Display();
            }
            else
            {
                Console.WriteLine("Bear not found.");
            }
        }
        catch
        {
            Console.WriteLine("Invalid input. Try again.");
        }
    }

    /// <summary>
    /// Adds/edit specific bear.
    /// </summary>
    /// <exception cref="ArgumentNullException"></exception>
    private Bear AddEditBear()
    {
        Console.Write("What name of the bear? ");
        string? name = Console.ReadLine();
        Console.Write("What is the bear's age? ");
        string? ageAsString = Console.ReadLine();
        Console.Write("What is the bear's breed? ");
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
        Bear bear = new Bear(name, age, breed);

        return bear;
    }

    #endregion // Private Methods
}

// KeDi