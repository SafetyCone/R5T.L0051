using System;


namespace R5T.L0051.Internal
{
    public class OrganizationDirectoryPathOperator : IOrganizationDirectoryPathOperator
    {
        #region Infrastructure

        public static IOrganizationDirectoryPathOperator Instance { get; } = new OrganizationDirectoryPathOperator();


        private OrganizationDirectoryPathOperator()
        {
        }

        #endregion
    }
}
