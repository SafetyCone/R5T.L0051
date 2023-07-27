using System;

using R5T.F0124;
using R5T.T0132;
using R5T.T0180;
using R5T.T0222;

using R5T.L0051.L001.Extensions;


namespace R5T.L0051.L001
{
    [FunctionalityMarker]
    public partial interface IOrganizationsDirectoryPathOperator : IFunctionalityMarker
    {
        public IOrganizationsDirectoryPath Get_OrganizationsDirectoryPath(
            IDirectoryPath parentDirectoryPath,
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            var output = Instances.PathOperator.Get_DirectoryPath(
                parentDirectoryPath,
                Instances.DirectoryNames.Organizations,
                x => x.ToOrganizationsDirectoryPath(),
                ensureDirectoryPathIsDirectoryIndicated);

            return output;
        }

        public IOrganizationsDirectoryPath Get_OrganizationsDirectoryPath(
            IOrganizationsParentDirectoryPath parentDirectoryPath,
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            return this.Get_OrganizationsDirectoryPath(
                parentDirectoryPath as IDirectoryPath,
                ensureDirectoryPathIsDirectoryIndicated);
        }

        public IOrganizationDirectoryPath Get_OrganizationDirectoryPath(
            IOrganizationsDirectoryPath organizationsDirectoryPath,
            IOrganizationDirectoryName organizationDirectoryName,
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            var output = Instances.PathOperator.Get_DirectoryPath(
                organizationsDirectoryPath,
                organizationDirectoryName,
                x => x.ToOrganizationDirectoryPath(),
                ensureDirectoryPathIsDirectoryIndicated);

            return output;
        }

        public IOrganizationDirectoryPath Get_OrganizationDirectoryPath(
           IOrganizationsDirectoryPath organizationsDirectoryPath,
           IOrganizationName organizationName,
           bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            var organizationDirectoryName = Instances.OrganizationDirectoryNameOperator.Get_OrganizationDirectoryName(organizationName);

            return this.Get_OrganizationDirectoryPath(
                organizationsDirectoryPath,
                organizationDirectoryName,
                ensureDirectoryPathIsDirectoryIndicated);
        }
    }
}
