using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;

namespace BabtekCAD.Commands
{
    public class CommandHub
    {
        [CommandMethod("BABTEK_RUN")]
        public void Run()
        {
            Application.DocumentManager.MdiActiveDocument.Editor
                .WriteMessage("\nBabtek CAD Engine Running");
        }
    }
}
