namespace SampleHierarchies.Interfaces.Data.Mammals;

/// <summary>
/// Interface depicting a Lion.
/// </summary>
public interface ILion : IMammal
{
    #region Interface Members

    /// <summary>
    /// Breed of Lion.
    /// </summary>
    string Breed { get; set; }

    #endregion // Interface Members
}