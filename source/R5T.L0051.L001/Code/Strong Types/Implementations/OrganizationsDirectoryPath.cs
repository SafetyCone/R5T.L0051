using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0051.L001
{
    /// <inheritdoc cref="IOrganizationsDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class OrganizationsDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IOrganizationsDirectoryPath
    {
        public OrganizationsDirectoryPath(string value)
            : base(value)
        {
        }
    }
}