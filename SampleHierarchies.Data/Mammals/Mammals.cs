using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Data.Mammals;

namespace SampleHierarchies.Data.Mammals;

/// <summary>
/// Mammals collection.
/// </summary>
public class Mammals : IMammals
{
    #region IMammals Implementation

    /// <inheritdoc/>
    public List<IDog> Dogs { get; set; }

    // KeDi
    /// <inheritdoc/>
    public List<IBear> Bears { get; set; }

    /// <inheritdoc/>
    public List<ILion> Lions { get; set; }

    /// <inheritdoc/>
    public List<IWolf> Wolves { get; set; }
    // KeDi

    #endregion // IMammals Implementation

    #region Ctors

    /// <summary>
    /// Default ctor.
    /// </summary>
    public Mammals()
    {
        Dogs = new List<IDog>();

        // KeDi
        Bears = new List<IBear>();

        Lions = new List<ILion>();

        Wolves = new List<IWolf>();
        // KeDi
    }

    #endregion // Ctors
}
