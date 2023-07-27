using System;


namespace R5T.L0051
{
    public static class Instances
    {
        public static L0050.IDropboxDirectoryPathOperator DropboxDirectoryPathOperator => L0050.DropboxDirectoryPathOperator.Instance;
        public static L001.IOrganizationDirectoryNameOperator OrganizationDirectoryNameOperator => L001.OrganizationDirectoryNameOperator.Instance;
        //public static IOrganizationDirectoryPathOperator OrganizationDirectoryPathOperator => L0051.OrganizationDirectoryPathOperator.Instance;
        public static L001.IOrganizationsDirectoryPathOperator OrganizationsDirectoryPathOperator => L001.OrganizationsDirectoryPathOperator.Instance;
        public static Z0059.IOrganizationNames OrganizationNames => Z0059.OrganizationNames.Instance;
    }
}