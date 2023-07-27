using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0051.L001
{
    /// <inheritdoc cref="IOrganizationCloudDataDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class OrganizationCloudDataDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IOrganizationCloudDataDirectoryPath
    {
        public OrganizationCloudDataDirectoryPath(string value)
            : base(value)
        {
        }
    }
}