namespace SampleHierarchies.Interfaces.Data.Mammals;

/// <summary>
/// Interface depicting a Bear.
/// </summary>
public interface IBear : IMammal
{
    #region Interface Members

    /// <summary>
    /// Breed of Bear.
    /// </summary>
    string Breed { get; set; }

    #endregion // Interface Members
}