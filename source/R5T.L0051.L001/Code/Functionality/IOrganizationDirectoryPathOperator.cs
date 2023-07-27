using System;

using R5T.F0124;
using R5T.T0132;
using R5T.T0180;
using R5T.T0222;


namespace R5T.L0051.L001
{
    [FunctionalityMarker]
    public partial interface IOrganizationDirectoryPathOperator : IFunctionalityMarker
    {
        public IOrganizationDirectoryPath Get_OrganizationDirectoryPath(
            IOrganizationsDirectoryPath organizationsDirectoryPath,
            IOrganizationDirectoryName organizationDirectoryName,
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            return Instances.OrganizationsDirectoryPathOperator.Get_OrganizationDirectoryPath(
                organizationsDirectoryPath,
                organizationDirectoryName,
                ensureDirectoryPathIsDirectoryIndicated);
        }

        public IOrganizationDirectoryPath Get_OrganizationDirectoryPath(
           IOrganizationsDirectoryPath organizationsDirectoryPath,
           IOrganizationName organizationName,
           bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            return Instances.OrganizationsDirectoryPathOperator.Get_OrganizationDirectoryPath(
                organizationsDirectoryPath,
                organizationName,
                ensureDirectoryPathIsDirectoryIndicated);
        }

        public TDirectoryPath Get_OrganizationSharedDataDirectoryPath<TDirectoryPath>(
            IOrganizationDirectoryPath organizationDirectoryPath,
            Func<string, TDirectoryPath> directoryPathConstructor,
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
            where TDirectoryPath : IDirectoryPath
        {
            return Instances.PathOperator.Get_DirectoryPath(
                organizationDirectoryPath,
                directoryPathConstructor,
                ensureDirectoryPathIsDirectoryIndicated,
                Instances.DirectoryNames.Shared,
                Instances.DirectoryNames.Data);
        }

        public TDirectoryPath Get_OrganizationDataDirectoryPath<TDirectoryPath>(
            IOrganizationDirectoryPath organizationDirectoryPath,
            Func<string, TDirectoryPath> directoryPathConstructor,
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
            where TDirectoryPath : IDirectoryPath
        {
            return Instances.PathOperator.Get_DirectoryPath(
                organizationDirectoryPath,
                directoryPathConstructor,
                ensureDirectoryPathIsDirectoryIndicated,
                Instances.DirectoryNames.Data);
        }
    }
}
