namespace SampleHierarchies.Interfaces.Data.Mammals;

/// <summary>
/// Interface depicting a Wolf.
/// </summary>
public interface IWolf : IMammal
{
    #region Interface Members

    /// <summary>
    /// Breed of Wolf.
    /// </summary>
    string Breed { get; set; }

    #endregion // Interface Members
}