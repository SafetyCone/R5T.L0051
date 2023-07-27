using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0051.L001
{
    /// <inheritdoc cref="IOrganizationsParentDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class OrganizationsParentDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IOrganizationsParentDirectoryPath
    {
        public OrganizationsParentDirectoryPath(string value)
            : base(value)
        {
        }
    }
}