// KeDi

using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Data.Mammals;

namespace SampleHierarchies.Data.Mammals;

/// <summary>
/// Grizzly bear class.
/// </summary>
public class Bear : MammalBase, IBear
{
    #region Public Methods

    /// <inheritdoc/>
    public override void Hibernation()
    {
        Console.WriteLine("My name is {0} and I can hibernate up to {1} months", Name, 6);
    }

    /// <inheritdoc/>
    public override void Diet()
    {
        Console.WriteLine("My name is {0} and I eat {1} ", Name, "both plants and animals");
    }

    /// <inheritdoc/>
    public override void Size()
    {
        Console.WriteLine("My name is {0} and I am ", Name, "large");
    }

    /// <inheritdoc/>
    public override void CurvedClaws()
    {
        Console.WriteLine("My name is {0} and my curved claws are used for {1} ", Name, "digging");
    }

    /// <inheritdoc/>
    public override void SenseOfSmell()
    {
        Console.WriteLine("My name is {0} and I can detect {1} from the distance {2} kilometer", Name, "prey", 1);
    }

    /// <inheritdoc/>
    public override void Display()
    {
        Console.WriteLine($"My name is: {Name}, my age is: {Age} and I am a {Breed} Bear");
    }

    /// <inheritdoc/>
    public override void Copy(IAnimal animal)
    {
        if (animal is IBear ad)
        {
            base.Copy(animal);
            Breed = ad.Breed;
        }
    }

    #endregion // Public Methods

    #region Ctors And Properties

    /// <inheritdoc/>
    public string Breed { get; set; }

    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="name">Name</param>
    /// <param name="age">Age</param>
    /// <param name="breed">Breed</param>
    public Bear(string name, int age, string breed) : base(name, age, MammalSpecies.Bear)
    {
        Breed = breed;
    }

    #endregion // Ctors And Properties
}

// KeDi