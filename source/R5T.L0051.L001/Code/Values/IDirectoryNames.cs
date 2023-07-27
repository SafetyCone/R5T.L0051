using System;

using R5T.T0131;
using R5T.T0180;
using R5T.T0180.Extensions;


namespace R5T.L0051.L001
{
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
        public IDirectoryName Organizations => "Organizations".ToDirectoryName();
        public IDirectoryName Shared => "Shared".ToDirectoryName();
        public IDirectoryName Data => "Data".ToDirectoryName();
    }
}
