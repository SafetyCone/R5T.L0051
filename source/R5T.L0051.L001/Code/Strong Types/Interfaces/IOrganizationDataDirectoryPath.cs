using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0051.L001
{
    /// <summary>
    /// Strongly-types a string as a %%%.
    /// </summary>
    [StrongTypeMarker]
    public interface IOrganizationDataDirectoryPath : IStrongTypeMarker,
        ITyped<string>
    {
    }
}