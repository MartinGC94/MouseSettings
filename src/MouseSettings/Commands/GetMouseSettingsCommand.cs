using System.Management.Automation;

namespace MouseSettings.Commands
{
    [OutputType(typeof(PublicTypes.MouseSettings))]
    [Cmdlet(VerbsCommon.Get, "MouseSettings")]
    public sealed class GetMouseSettingsCommand : Cmdlet
    {
        protected override void EndProcessing()
        {
            WriteObject(new PublicTypes.MouseSettings());
        }
    }
}