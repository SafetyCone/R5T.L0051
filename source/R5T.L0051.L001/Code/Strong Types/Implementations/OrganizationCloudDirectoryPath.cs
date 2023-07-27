using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0051.L001
{
    /// <inheritdoc cref="IOrganizationCloudDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class OrganizationCloudDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IOrganizationCloudDirectoryPath
    {
        public OrganizationCloudDirectoryPath(string value)
            : base(value)
        {
        }
    }
}