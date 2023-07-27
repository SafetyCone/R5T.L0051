using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0051.L001
{
    /// <inheritdoc cref="IOrganizationDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class OrganizationDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IOrganizationDirectoryPath
    {
        public OrganizationDirectoryPath(string value)
            : base(value)
        {
        }
    }
}