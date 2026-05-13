using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.ApplicationServices;

namespace BabtekCAD.Engine
{
    public class PlanEngine
    {
        public void Generate()
        {
            var doc = Application.DocumentManager.MdiActiveDocument;
            var db = doc.Database;

            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                var ms = (BlockTableRecord)tr.GetObject(db.CurrentSpaceId, OpenMode.ForWrite);

                Polyline rect = new Polyline();
                rect.AddVertexAt(0, new Point2d(0, 0), 0, 0, 0);
                rect.AddVertexAt(1, new Point2d(10000, 0), 0, 0, 0);
                rect.AddVertexAt(2, new Point2d(10000, 8000), 0, 0, 0);
                rect.AddVertexAt(3, new Point2d(0, 8000), 0, 0, 0);
                rect.Closed = true;

                ms.AppendEntity(rect);
                tr.AddNewlyCreatedDBObject(rect, true);

                tr.Commit();
            }
        }
    }
}
