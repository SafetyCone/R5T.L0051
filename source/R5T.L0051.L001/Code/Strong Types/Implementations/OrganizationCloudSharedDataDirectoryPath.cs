using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0051.L001
{
    /// <inheritdoc cref="IOrganizationCloudSharedDataDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class OrganizationCloudSharedDataDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IOrganizationCloudSharedDataDirectoryPath
    {
        public OrganizationCloudSharedDataDirectoryPath(string value)
            : base(value)
        {
        }
    }
}