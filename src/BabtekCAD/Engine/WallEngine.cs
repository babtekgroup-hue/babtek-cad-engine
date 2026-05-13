using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.ApplicationServices;

namespace BabtekCAD.Engine
{
    public class WallEngine
    {
        public void Generate()
        {
            var doc = Application.DocumentManager.MdiActiveDocument;
            var db = doc.Database;

            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                var ms = (BlockTableRecord)tr.GetObject(db.CurrentSpaceId, OpenMode.ForWrite);

                ms.AppendEntity(new Line(new Point3d(0,0,0), new Point3d(10000,0,0)));
                ms.AppendEntity(new Line(new Point3d(10000,0,0), new Point3d(10000,8000,0)));
                ms.AppendEntity(new Line(new Point3d(10000,8000,0), new Point3d(0,8000,0)));
                ms.AppendEntity(new Line(new Point3d(0,8000,0), new Point3d(0,0,0)));

                tr.Commit();
            }
        }
    }
}
