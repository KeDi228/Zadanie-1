// KeDi

using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Data.Mammals;

namespace SampleHierarchies.Data.Mammals;

/// <summary>
/// Wolf class.
/// </summary>
public class Wolf : MammalBase, IWolf
{
    #region Public Methods

    /// <inheritdoc/>
    public override void Diet()
    {
        Console.WriteLine("My name is {0} and I eat a variety of prey including deer and elk", Name);
    }

    /// <inheritdoc/>
    public override void Hunting()
    {
        Console.WriteLine("My name is {0} and I hunt in coordinated groups", Name);
    }

    /// <inheritdoc/>
    public override void CommunicationStyle()
    {
        Console.WriteLine("My name is {0} and I am howling to locate other pack members and establish territory", Name);
    }

    /// <inheritdoc/>
    public override void JawsUsage()
    {
        Console.WriteLine("My name is {0} and I can crush through bones and flesh", Name);
    }

    /// <inheritdoc/>
    public override void SenseOfSmell()
    {
        Console.WriteLine("My name is {0} and I can detect prey from a distance of over 2 kilometers", Name);
    }

    /// <inheritdoc/>
    public override void Display()
    {
        Console.WriteLine($"My name is: {Name}, my age is: {Age} and I am a {Breed} Wolf");
    }

    /// <inheritdoc/>
    public override void Copy(IAnimal animal)
    {
        if (animal is IWolf ad)
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
    public Wolf(string name, int age, string breed) : base(name, age, MammalSpecies.Wolf)
    {
        Breed = breed;
    }

    #endregion // Ctors And Properties
}

// KeDi