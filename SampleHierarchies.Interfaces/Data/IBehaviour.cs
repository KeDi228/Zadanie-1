namespace SampleHierarchies.Interfaces.Data;

/// <summary>
/// Behaviour actions.
/// </summary>
public interface IBehaviour
{
    #region Interface Members

    /// <summary>
    /// Describes, how the animal makes a sound.
    /// </summary>
    void MakeSound();

    /// <summary>
    /// Describes, how the animal moves.
    /// </summary>
    void Move();

    /// <summary>
    /// Describes seasonal behaviour of the animal.
    /// </summary>
    void Hibernation();

    /// <summary>
    /// Describes the diet of the animal.
    /// </summary>
    void Diet();

    /// <summary>
    /// Describes the size of the animal.
    /// </summary>
    void Size();

    /// <summary>
    /// Describes curved claws of the animal.
    /// </summary>
    void CurvedClaws();

    /// <summary>
    /// Describes the sense of smell of the animal.
    /// </summary>
    void SenseOfSmell();

    


    /// <summary>
    /// Describes the predator type of the animal.
    /// </summary>
    void PredatorType();

    /// <summary>
    /// Describes the hunting behaviour of the animal.
    /// </summary>
    void Hunting();

    /// <summary>
    /// Describes the mane of the animal.
    /// </summary>
    void Mane();

    /// <summary>
    /// Describes the communication style of the animal.
    /// </summary>
    void CommunicationStyle();

    /// <summary>
    /// Describes the territory defence style of the animal.
    /// </summary>
    void TerritoryDefence();

    /// <summary>
    /// Describes the usage of jaws of the animal.
    /// </summary>
    void JawsUsage();

    /// <summary>
    /// Displays information about animal.
    /// </summary>
    void Display();

    #endregion // Interface Members
}
