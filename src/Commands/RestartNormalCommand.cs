using Microsoft.VisualStudio.Shell;

namespace RestartVisualStudio
{
    using Luminous.Framework.VisualStudio.Commands;
    using Luminous.Framework.VisualStudio.Packages;

    internal sealed class RestartNormalCommand : DynamicCommand
    {
        //***

        private static int CommandId
            => PackageIds.RestartNormalCommand;

        //===M

        private RestartNormalCommand(PackageBase package) : base(package, CommandId)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new RestartNormalCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.RestartVisualStudio();

        //***
    }
}