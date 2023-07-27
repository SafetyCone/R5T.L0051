using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0051.L001
{
    /// <inheritdoc cref="IOrganizationLocalDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class OrganizationLocalDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IOrganizationLocalDirectoryPath
    {
        public OrganizationLocalDirectoryPath(string value)
            : base(value)
        {
        }
    }
}