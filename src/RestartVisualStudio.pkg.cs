using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace RestartVisualStudio
{
    using Luminous.Framework.VisualStudio.Packages;

    using static PackageGuids;
    using static Vsix;

    [InstalledProductRegistration(Name, Description, Version, IconResourceID = 400)]
    [Guid(RestartVisualStudioPackageString)]

    public sealed class RestartVisualStudioPackage : PackageBase
    {
        public RestartVisualStudioPackage() : base(RestartVisualStudioCommandSet, Name, Description)
        { }

        protected override void Initialize()
        {
            base.Initialize();

            RestartNormalCommand.Instantiate(this);
            RestartElevatedCommand.Instantiate(this);
        }
    }
}
