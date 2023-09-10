using SampleHierarchies.Interfaces.Data;

namespace SampleHierarchies.Data;

/// <summary>
/// Animal base class with basic implementations.
/// </summary>
public abstract class AnimalBase : IAnimal, IBehaviour
{
    #region IAnimal Implementation

    /// <inheritdoc/>
    public string Name { get; set; }

    /// <inheritdoc/>
    public int Age { get; set; }

    /// <inheritdoc/>
    public virtual void Copy(IAnimal animal)
    {
        Name = animal.Name;
        Age = animal.Age;
    }

    #endregion // IAnimal Impementation

    #region IBehaviour Implementation

    /// <inheritdoc/>
    public virtual void MakeSound()
    {
        Console.WriteLine("My name is {0} and I make noise like an animal", Name);
    }

    /// <inheritdoc/>
    public virtual void Move()
    {
        Console.WriteLine("My name is {0} and I move like an animal", Name);
    }

    /// <inheritdoc/>
    public virtual void Hibernation()
    {
        Console.WriteLine("My name is {0} and I can hibernate like an animal", Name);
    }

    /// <inheritdoc/>
    public virtual void Diet()
    {
        Console.WriteLine("My name is {0} and I eat like an animal", Name);
    }

    /// <inheritdoc/>
    public virtual void Size()
    {
        Console.WriteLine("My name is {0} and I am animal size", Name);
    }

    /// <inheritdoc/>
    public virtual void CurvedClaws()
    {
        Console.WriteLine("My name is {0} and I have curved claws like an animal", Name);
    }

    /// <inheritdoc/>
    public virtual void SenseOfSmell()
    {
        Console.WriteLine("My name is {0} and I can detect prey like an animal", Name);
    }


    /// <inheritdoc/>
    public virtual void PredatorType()
    {
        Console.WriteLine("My name is {0} and I am a predator animal", Name);
    }

    /// <inheritdoc/>
    public virtual void Hunting()
    {
        Console.WriteLine("My name is {0} and I hunt in packs like an animal", Name);
    }

    /// <inheritdoc/>
    public virtual void Mane()
    {
        Console.WriteLine("My name is {0} and I have a mane", Name);
    }

    /// <inheritdoc/>
    public virtual void CommunicationStyle()
    {
        Console.WriteLine("My name is {0} and I can communicate like an animal", Name);
    }

    /// <inheritdoc/>
    public virtual void TerritoryDefence()
    {
        Console.WriteLine("My name is {0} and I defend my territory like an animal", Name);
    }

    /// <inheritdoc/>
    public virtual void JawsUsage()
    {
        Console.WriteLine("My name is {0} and I have strong jaws", Name);
    }

    /// <inheritdoc/>
    public virtual void Display()
    {
        Console.WriteLine("My name is: {0} and I am: {1} years old", Name, Age);
    }

    #endregion // IBehaviour Implementation

    #region Ctors

    /// <summary>
    /// Ctor.
    /// </summary>
    public AnimalBase()
    {
        Name = string.Empty;
        Age = 0;
    }

    /// <summary>
    /// Constructor with parameters
    /// </summary>
    /// <param name="name">Name</param>
    /// <param name="age">Age</param>
    public AnimalBase(
        string name,
        int age)
    {
        Name = name;
        Age = age;
    }

    #endregion // Ctors
}
