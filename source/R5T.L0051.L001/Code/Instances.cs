using System;


namespace R5T.L0051.L001
{
    public static class Instances
    {
        public static F0124.IDirectoryNameOperator DirectoryNameOperator => F0124.DirectoryNameOperator.Instance;
        public static IDirectoryNames DirectoryNames => L001.DirectoryNames.Instance;
        public static IOrganizationDirectoryNameOperator OrganizationDirectoryNameOperator => L001.OrganizationDirectoryNameOperator.Instance;
        public static IOrganizationsDirectoryPathOperator OrganizationsDirectoryPathOperator => L001.OrganizationsDirectoryPathOperator.Instance;
        public static F0124.IPathOperator PathOperator => F0124.PathOperator.Instance;
        public static Extensions.IStringOperator StringOperator_Extensions => Extensions.StringOperator.Instance;
    }
}