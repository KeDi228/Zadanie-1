using SampleHierarchies.Interfaces.Data.Mammals;

namespace SampleHierarchies.Interfaces.Data;

/// <summary>
/// Mammals collection.
/// </summary>
public interface IMammals
{
    #region Interface Members

    /// <summary>
    /// Dogs collection.
    /// </summary>
    List<IDog> Dogs { get; set; }

    /// <summary>
    /// Bears collection.
    /// </summary>
    List<IBear> Bears { get; set; }

    /// <summary>
    /// Lions collection.
    /// </summary>
    List<ILion> Lions { get; set; }

    /// <summary>
    /// Wolves collection.
    /// </summary>
    List<IWolf> Wolves { get; set; }

    #endregion // Interface Members
}
