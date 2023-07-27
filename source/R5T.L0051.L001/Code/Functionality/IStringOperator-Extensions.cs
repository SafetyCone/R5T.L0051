using System;

using R5T.T0132;


namespace R5T.L0051.L001.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IOrganizationCloudDataDirectoryPath"/>
        public IOrganizationCloudDataDirectoryPath ToOrganizationCloudDataDirectoryPath(string value)
        {
            var output = new OrganizationCloudDataDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IOrganizationCloudSharedDataDirectoryPath"/>
        public IOrganizationCloudSharedDataDirectoryPath ToOrganizationCloudSharedDataDirectoryPath(string value)
        {
            var output = new OrganizationCloudSharedDataDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IOrganizationDirectoryName"/>
        public IOrganizationDirectoryName ToOrganizationDirectoryName(string value)
        {
            var output = new OrganizationDirectoryName(value);
            return output;
        }

        /// <inheritdoc cref="IOrganizationDirectoryPath"/>
        public IOrganizationDirectoryPath ToOrganizationDirectoryPath(string value)
        {
            var output = new OrganizationDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IOrganizationsDirectoryPath"/>
        public IOrganizationsDirectoryPath ToOrganizationsDirectoryPath(string value)
        {
            var output = new OrganizationsDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IOrganizationsParentDirectoryPath"/>
        public IOrganizationsParentDirectoryPath ToOrganizationsParentDirectoryPath(string value)
        {
            var output = new OrganizationsParentDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IOrganizationCloudDirectoryPath"/>
        public IOrganizationCloudDirectoryPath ToOrganizationCloudDirectoryPath(string value)
        {
            var output = new OrganizationCloudDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IOrganizationDataDirectoryPath"/>
        public IOrganizationDataDirectoryPath ToOrganizationDataDirectoryPath(string value)
        {
            var output = new OrganizationDataDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IOrganizationLocalDirectoryPath"/>
        public IOrganizationLocalDirectoryPath ToOrganizationLocalDirectoryPath(string value)
        {
            var output = new OrganizationLocalDirectoryPath(value);
            return output;
        }
    }
}
