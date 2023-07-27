using System;

using R5T.T0141;


namespace R5T.L0051.Construction
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        // See R5T.S0093.IDemonstrations.
        public void Get_RivetCloudSharedDataDirectoryPath()
        {
            var directoryPath = Instances.OrganizationDirectoryPathOperator.Get_Rivet_CloudSharedDataDirectoryPath();

            Console.WriteLine(directoryPath);
        }
    }
}
