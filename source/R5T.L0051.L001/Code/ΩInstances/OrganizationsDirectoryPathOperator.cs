using System;


namespace R5T.L0051.L001
{
    public class OrganizationsDirectoryPathOperator : IOrganizationsDirectoryPathOperator
    {
        #region Infrastructure

        public static IOrganizationsDirectoryPathOperator Instance { get; } = new OrganizationsDirectoryPathOperator();


        private OrganizationsDirectoryPathOperator()
        {
        }

        #endregion
    }
}
