using SampleHierarchies.Interfaces.Data;

namespace SampleHierarchies.Interfaces.Services;

/// <summary>C
/// Settings service interface.
/// </summary>
public interface ISettingsService
{
    #region Interface Members

    /// <summary>
    /// Read settings.
    /// </summary>
    /// <param name="jsonPath">Json path</param>
    bool Read(string jsonPath);//KeDi

    /// <summary>
    /// Write settings.
    /// </summary>
    /// <param name="jsonPath">Json path</param>
    bool Write(string jsonPath);//KeDi   

    #endregion // Interface Members
}
