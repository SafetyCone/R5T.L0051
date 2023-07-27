using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0051.L001
{
    /// <inheritdoc cref="IOrganizationDataDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class OrganizationDataDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IOrganizationDataDirectoryPath
    {
        public OrganizationDataDirectoryPath(string value)
            : base(value)
        {
        }
    }
}