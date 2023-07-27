using System;

using R5T.T0132;
using R5T.T0222;

using R5T.L0051.L001.Extensions;


namespace R5T.L0051.L001
{
    [FunctionalityMarker]
    public partial interface IOrganizationDirectoryNameOperator : IFunctionalityMarker
    {
        public IOrganizationDirectoryName Get_OrganizationDirectoryName(IOrganizationName organizationName)
        {
            var output = Instances.DirectoryNameOperator.Verify_IsValid(
                organizationName.Value,
                x => x.ToOrganizationDirectoryName());

            return output;
        }
    }
}
