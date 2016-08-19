using Microsoft.VisualStudio.Shell;

namespace RestartVisualStudio
{
    using Luminous.Framework.VisualStudio.Commands;
    using Luminous.Framework.VisualStudio.Packages;

    internal sealed class RestartElevatedCommand : DynamicCommand
    {
        //***

        private static int CommandId
            => PackageIds.RestartElevatedCommand;

        //===M

        private RestartElevatedCommand(PackageBase package) : base(package, CommandId)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new RestartElevatedCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.RestartVisualStudio(elevated: true);

        //***
    }
}