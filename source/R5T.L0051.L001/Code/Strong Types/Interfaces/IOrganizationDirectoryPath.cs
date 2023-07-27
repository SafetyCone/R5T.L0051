using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.L0051.L001
{
    /// <summary>
    /// Strongly-types a string as a the path of an organization directory.
    /// </summary>
    [StrongTypeMarker]
    public interface IOrganizationDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}