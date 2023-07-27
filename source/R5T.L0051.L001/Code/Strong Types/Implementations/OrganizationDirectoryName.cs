using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0051.L001
{
    /// <inheritdoc cref="IOrganizationDirectoryName"/>
    [StrongTypeImplementationMarker]
    public class OrganizationDirectoryName : TypedBase<string>, IStrongTypeMarker,
        IOrganizationDirectoryName
    {
        public OrganizationDirectoryName(string value)
            : base(value)
        {
        }
    }
}