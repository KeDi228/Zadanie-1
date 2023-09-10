// KeDi

using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Data.Mammals;

namespace SampleHierarchies.Data.Mammals;

/// <summary>
/// Lion class.
/// </summary>
public class Lion : MammalBase, ILion
{
    #region Public Methods

    /// <inheritdoc/>
    public override void Display()
    {
        Console.WriteLine($"My name is: {Name}, my age is: {Age} and I am a {Breed} Lion");
    }

    /// <inheritdoc/>
    public override void PredatorType()
    {
        Console.WriteLine("My name is {0} and I prey on large herbivores", Name);
    }

    /// <inheritdoc/>
    public override void Hunting()
    {
        Console.WriteLine("My name is {0} and I hunt in groups", Name);
    }

    /// <inheritdoc/>
    public override void Mane()
    {
        Console.WriteLine("My name is {0} and my mane is light and spiky", Name);
    }

    /// <inheritdoc/>
    public override void CommunicationStyle()
    {
        Console.WriteLine("My name is {0} and my roaring can be heard from over 8 kilometers away", Name);
    }

    /// <inheritdoc/>
    public override void TerritoryDefence()
    {
        Console.WriteLine("My name is {0} and I mark territory with urine", Name);
    }

    /// <inheritdoc/>
    public override void Copy(IAnimal animal)
    {
        if (animal is ILion ad)
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
    public Lion(string name, int age, string breed) : base(name, age, MammalSpecies.Lion)
    {
        Breed = breed;
    }

    #endregion // Ctors And Properties
}

// KeDi