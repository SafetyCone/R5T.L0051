using System;

using R5T.F0124;
using R5T.T0132;
using R5T.T0222;

using R5T.L0051.L001;
using R5T.L0051.L001.Extensions;


namespace R5T.L0051.Internal
{
    [FunctionalityMarker]
    public partial interface IOrganizationDirectoryPathOperator : IFunctionalityMarker
    {
        private static L001.IOrganizationDirectoryPathOperator L001 => L0051.L001.OrganizationDirectoryPathOperator.Instance;


        /// <summary>
        /// Gets the Dropbox organizations directory path.
        /// </summary>
        public IOrganizationsDirectoryPath Get_OrganizationsDirectoryPath_Cloud(
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            // Note: no need to ensure this directory path is directory indicated.
            var dropboxDirectoryPath = Instances.DropboxDirectoryPathOperator.Get_DropboxDirectoryPath();

            var output = Instances.OrganizationsDirectoryPathOperator.Get_OrganizationsDirectoryPath(
                dropboxDirectoryPath,
                ensureDirectoryPathIsDirectoryIndicated);

            return output;
        }

        /// <summary>
        /// Gets the Dropbox organizations directory path.
        /// </summary>
        public IOrganizationDirectoryPath Get_OrganizationDirectoryPath_Cloud(
            IOrganizationName organizationName,
            // Allow customization of organization name to organization directory name.
            Func<IOrganizationName, IOrganizationDirectoryName> organizationDirectoryNameConverter,
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            // Note: no need to ensure this directory path is directory indicated.
            var organizationsDirectoryPath = this.Get_OrganizationsDirectoryPath_Cloud();

            var organizationDirectoryName = organizationDirectoryNameConverter(organizationName);

            var output = Instances.OrganizationsDirectoryPathOperator.Get_OrganizationDirectoryPath(
                organizationsDirectoryPath,
                organizationDirectoryName,
                ensureDirectoryPathIsDirectoryIndicated);

            return output;
        }

        public IOrganizationDirectoryPath Get_OrganizationDirectoryPath_Cloud(
            IOrganizationName organizationName,
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            return this.Get_OrganizationDirectoryPath_Cloud(
                organizationName,
                Instances.OrganizationDirectoryNameOperator.Get_OrganizationDirectoryName,
                ensureDirectoryPathIsDirectoryIndicated);
        }

        public IOrganizationCloudDataDirectoryPath Get_OrganizationCloudDataDirectoryPath(
            IOrganizationName organizationName,
            // Allow customization of organization name to organization directory name.
            Func<IOrganizationName, IOrganizationDirectoryName> organizationDirectoryNameConverter,
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            // Note: no need to ensure this directory path is directory indicated.
            var organizationDirectoryPath = this.Get_OrganizationDirectoryPath_Cloud(
                organizationName,
                organizationDirectoryNameConverter);

            var output = L001.Get_OrganizationDataDirectoryPath(
                organizationDirectoryPath,
                x => x.ToOrganizationCloudDataDirectoryPath(),
                ensureDirectoryPathIsDirectoryIndicated);

            return output;
        }

        public IOrganizationCloudDataDirectoryPath Get_OrganizationCloudDataDirectoryPath(
            IOrganizationName organizationName,
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            return this.Get_OrganizationCloudDataDirectoryPath(
                organizationName,
                Instances.OrganizationDirectoryNameOperator.Get_OrganizationDirectoryName,
                ensureDirectoryPathIsDirectoryIndicated);
        }

        public IOrganizationCloudSharedDataDirectoryPath Get_OrganizationCloudSharedDataDirectoryPath(
            IOrganizationName organizationName,
            // Allow customization of organization name to organization directory name.
            Func<IOrganizationName, IOrganizationDirectoryName> organizationDirectoryNameConverter,
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            // Note: no need to ensure this directory path is directory indicated.
            var organizationDirectoryPath = this.Get_OrganizationDirectoryPath_Cloud(
                organizationName,
                organizationDirectoryNameConverter);

            var output = L001.Get_OrganizationSharedDataDirectoryPath(
                organizationDirectoryPath,
                x => x.ToOrganizationCloudSharedDataDirectoryPath(),
                ensureDirectoryPathIsDirectoryIndicated);

            return output;
        }

        public IOrganizationCloudSharedDataDirectoryPath Get_OrganizationCloudSharedDataDirectoryPath(
            IOrganizationName organizationName,
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            return this.Get_OrganizationCloudSharedDataDirectoryPath(
                organizationName,
                Instances.OrganizationDirectoryNameOperator.Get_OrganizationDirectoryName,
                ensureDirectoryPathIsDirectoryIndicated);
        }
    }
}
