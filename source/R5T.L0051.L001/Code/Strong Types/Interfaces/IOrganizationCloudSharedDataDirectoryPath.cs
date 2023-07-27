using System;

using R5T.T0178;
using R5T.T0190;
using R5T.T0191;


namespace R5T.L0051.L001
{
    /// <summary>
    /// Strongly-types a string as the path of an organization's cloud, shared, data directory path.
    /// </summary>
    /// <remarks>
    /// <see cref="IOrganizationCloudDataDirectoryPath"/> has a sibling relationship (separate inheritance hierarchy) from <see cref="IOrganizationCloudSharedDataDirectoryPath"/>
    /// to help prevent private data from being shared.
    /// It is recommended to make these directories siblings (not ancestors) in the file system directory structure as well.
    /// </remarks>
    [StrongTypeMarker]
    public interface IOrganizationCloudSharedDataDirectoryPath : IStrongTypeMarker,
        ICloudDirectoryPath,
        ISharedDirectoryPath,
        IDataDirectoryPath
    {
    }
}