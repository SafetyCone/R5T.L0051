using System;

using R5T.F0124;
using R5T.T0132;

using R5T.L0051.L001;


namespace R5T.L0051
{
    [FunctionalityMarker]
    public partial interface IOrganizationDirectoryPathOperator : IFunctionalityMarker
    {
        private static Internal.IOrganizationDirectoryPathOperator Internal => L0051.Internal.OrganizationDirectoryPathOperator.Instance;


        public IOrganizationCloudDataDirectoryPath Get_Rivet_CloudDataDirectoryPath(
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            return Internal.Get_OrganizationCloudDataDirectoryPath(
                Instances.OrganizationNames.Rivet,
                ensureDirectoryPathIsDirectoryIndicated);
        }

        public IOrganizationCloudSharedDataDirectoryPath Get_Rivet_CloudSharedDataDirectoryPath(
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            return Internal.Get_OrganizationCloudSharedDataDirectoryPath(
                Instances.OrganizationNames.Rivet,
                ensureDirectoryPathIsDirectoryIndicated);
        }
    }
}
