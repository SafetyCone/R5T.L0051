using System;

using R5T.T0178;
using R5T.T0190;
using R5T.T0191;


namespace R5T.L0051.L001
{
    /// <summary>
    /// Strongly-types a string as the path of a cloud data directory path.
    /// </summary>
    /// <inheritdoc cref="IOrganizationCloudSharedDataDirectoryPath" path="/remarks"/>
    [StrongTypeMarker]
    public interface IOrganizationCloudDataDirectoryPath : IStrongTypeMarker,
        ICloudDirectoryPath,
        IDataDirectoryPath
    {
    }
}
