using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Data.Mammals;

namespace SampleHierarchies.Data.Mammals;

/// <summary>
/// Mammal base class.
/// </summary>
public class MammalBase : AnimalBase, IMammal
{
    #region IMammal Implementation 

    /// <inheritdoc/>   
    public MammalSpecies Species { get; set; }

    #endregion // IMammal Implementation

    #region Ctors

    /// <summary>
    /// Mammal base class constructor, with parameters.
    /// </summary>
    /// <param name="name">Name</param>
    /// <param name="age">Age</param>
    /// <param name="species">Species</param>

    public MammalBase(
        string name,
        int age,
        MammalSpecies species) : base(name, age)
    {
        Species = species;
    }

    /// <summary>
    /// Parameterless constructor.
    /// </summary>
    public MammalBase() : base()
    {
        Species = MammalSpecies.None;
    }

    #endregion // Ctors

    #region Public Methods

    /// <inheritdoc/>
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("My name is: {0} and I am making a mammal sound", Name);
    }

    /// <inheritdoc/>
    public override void Move()
    {
        base.Move();
        Console.WriteLine("My name is: {0} and I am moving like a mammal", Name);
    }

    /// <inheritdoc/>
    public override void Hibernation()
    {
        base.Hibernation();
        Console.WriteLine("My name is {0} and I can hibernate like a mammal", Name);

    }

    /// <inheritdoc/>
    public override void Diet()
    {
        base.Diet();
        Console.WriteLine("my name is {0} and I eat like a mammal", Name);
    }

    /// <inheritdoc/>
    public override void Size()
    {
        base.Size();
        Console.WriteLine("My name is {0} and I am mammal size", Name);
    }

    /// <inheritdoc/>
    public override void CurvedClaws()
    {
        base.CurvedClaws();
        Console.WriteLine("My name is {0} and I have curved claws like a mammal", Name);
    }

    /// <inheritdoc/>
    public override void SenseOfSmell()
    {
        base.SenseOfSmell();
        Console.WriteLine("My name is {0} and I can detect prey like a mammal", Name);
    }

    /// <inheritdoc/>
    public override void PredatorType()
    {
        base.PredatorType();
        Console.WriteLine("My name is {0} and I am a predator mammal", Name);
    }

    /// <inheritdoc/>
    public override void Hunting()
    {
        base.Hunting();
        Console.WriteLine("My name is {0} and I hunt in packs like a mammal", Name);
    }

    /// <inheritdoc/>
    public override void Mane()
    {
        base.Mane();
        Console.WriteLine("My name is {0} and I have a mane", Name);
    }

    /// <inheritdoc/>
    public override void CommunicationStyle()
    {
        base.CommunicationStyle();
        Console.WriteLine("My name is {0} and I can communicate like a mammal", Name);
    }

    /// <inheritdoc/>
    public override void TerritoryDefence()
    {
        base.TerritoryDefence();
        Console.WriteLine("My name is {0} and I defend my territory like a mammal", Name);
    }

    /// <inheritdoc/>
    public override void JawsUsage()
    {
        base.JawsUsage();
        Console.WriteLine("My name is {0} and I have strong jaws", Name);
    }

    /// <inheritdoc/>
    public override void Copy(IAnimal animal)
    {
        if (animal is IMammal am)
        {
            base.Copy(animal);
            Species = am.Species;
        }
    }

    #endregion // Public Methods
}
