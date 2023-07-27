using System;


namespace R5T.L0051.L001.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToOrganizationCloudDataDirectoryPath(string)"/>
        public static IOrganizationCloudDataDirectoryPath ToOrganizationCloudDataDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToOrganizationCloudDataDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToOrganizationCloudSharedDataDirectoryPath(string)"/>
        public static IOrganizationCloudSharedDataDirectoryPath ToOrganizationCloudSharedDataDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToOrganizationCloudSharedDataDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToOrganizationDirectoryName(string)"/>
        public static IOrganizationDirectoryName ToOrganizationDirectoryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToOrganizationDirectoryName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToOrganizationDirectoryPath(string)"/>
        public static IOrganizationDirectoryPath ToOrganizationDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToOrganizationDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToOrganizationsDirectoryPath(string)"/>
        public static IOrganizationsDirectoryPath ToOrganizationsDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToOrganizationsDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToOrganizationsParentDirectoryPath(string)"/>
        public static IOrganizationsParentDirectoryPath ToOrganizationsParentDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToOrganizationsParentDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToOrganizationCloudDirectoryPath(string)"/>
        public static IOrganizationCloudDirectoryPath ToOrganizationCloudDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToOrganizationCloudDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToOrganizationDataDirectoryPath(string)"/>
        public static IOrganizationDataDirectoryPath ToOrganizationDataDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToOrganizationDataDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToOrganizationLocalDirectoryPath(string)"/>
        public static IOrganizationLocalDirectoryPath ToOrganizationLocalDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToOrganizationLocalDirectoryPath(value);
        }
    }
}
