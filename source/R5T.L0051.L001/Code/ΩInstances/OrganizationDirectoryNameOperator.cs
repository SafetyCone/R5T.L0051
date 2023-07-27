using System;


namespace R5T.L0051.L001
{
    public class OrganizationDirectoryNameOperator : IOrganizationDirectoryNameOperator
    {
        #region Infrastructure

        public static IOrganizationDirectoryNameOperator Instance { get; } = new OrganizationDirectoryNameOperator();


        private OrganizationDirectoryNameOperator()
        {
        }

        #endregion
    }
}
