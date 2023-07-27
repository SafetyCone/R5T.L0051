using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.L0051.L001
{
    /// <summary>
    /// Strongly-types a string as the path of a directory containing the organizations directory as a child.
    /// </summary>
    [StrongTypeMarker]
    public interface IOrganizationsParentDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}