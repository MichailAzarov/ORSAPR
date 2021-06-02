using FlangeSizes;
using Kompas6API5;
using Kompas6Constants3D;

namespace KompasInteractor
{
    /// <summary>
    /// Создание модели.
    /// </summary>
    public class FlangeModeler
    {
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="kompas">Интерфейс API компаса.</param>
        public FlangeModeler(KompasObject kompas)
        {
            _kompas = kompas;
        }

        /// <summary>
        /// Создание модели на основе входных параметров.
        /// </summary>
        /// <param name="parameters">Размеры фланца.</param>
        public void CreateModel(FlangeParameters parameters)
        {
            _doc3D = (ksDocument3D)_kompas.Document3D();
            _doc3D.Create();
            _doc3D = (ksDocument3D)_kompas.ActiveDocument3D();
            _part = (ksPart)_doc3D.GetPart((short)Part_Type.pTop_Part);
            CreateFlangeBase(parameters.FlangeExternalDiameter, parameters.FlangeLength, 
                parameters.FlangeInnerDiameter);
            CreateHoleBase(parameters.FlangeCenterDistance, parameters.HoleDiameter,
                parameters.FlangeLength, parameters.HoleNumber);
        }

        /// <summary>
        /// Создание основы фланца.
        /// </summary>
        /// <param name="flangeExternalDiameter">Внешний диаметр фланца.</param>
        /// <param name="flangeLength">Толщина фланца.</param>
        /// <param name="flangeInnerDiameter">Внутренний диаметр фланца.</param>
        private void CreateFlangeBase(double flangeExternalDiameter, 
            double flangeLength, double flangeInnerDiameter)
        {
            var offsetPlaneXoz = (ksEntity)_part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            DrawCircle(0, 0, flangeExternalDiameter / 2, offsetPlaneXoz);
            MakeExtrude(flangeLength, _entitySketch);
            DrawCircle(0, 0, flangeInnerDiameter / 2, offsetPlaneXoz);
            MakeCutExtrude (flangeLength*2, _entitySketch, (short)Direction_Type.dtMiddlePlane);
        }

        /// <summary>
        /// Создание крепёжных отверстий.
        /// </summary>
        /// <param name="flangeCenterDistance">Межосевое расстояние.</param>
        /// <param name="holeDiameter">Диаметр отверстия.</param>
        /// <param name="holeNumbert">Количество отверстий.</param>
        /// <param name="flangeLength">Толщина фланца.</param>
        private void CreateHoleBase(double flangeCenterDistance, 
            double holeDiameter, double flangeLength, int holeNumber)
        {
            var offsetPlaneXoz = (ksEntity)_part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            DrawCircle(0, flangeCenterDistance /2 , holeDiameter / 2, offsetPlaneXoz);
            DrawHoles(_entitySketch, (short)Direction_Type.dtMiddlePlane, flangeLength*2, holeNumber);
        }

        /// <summary>
        /// Создать эскиз.
        /// </summary>
        /// <param name="currentPlane">Плоскость, на которой будет создан эскиз.</param>
        private void CreateSketch(ksEntity currentPlane)
        {
            _entitySketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            _sketchDefinition = (ksSketchDefinition)_entitySketch.GetDefinition();
            _sketchDefinition.SetPlane(currentPlane);
            _entitySketch.Create();
        }

        /// <summary>
        /// Выдавливание.
        /// </summary>
        /// <param name="depth">Глубина выдавливания.</param>
        /// <param name="entitySketch">Указатель на интерфейс сущности.</param>
        private void MakeExtrude(double depth, object entitySketch)
        {
            var entityExtrude = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_baseExtrusion);
            var entityExtrudeDefinition = (ksBaseExtrusionDefinition)entityExtrude.GetDefinition();
            entityExtrudeDefinition.SetSideParam(true, 0, depth);
            entityExtrudeDefinition.SetSketch(entitySketch);
            entityExtrude.Create();
        }
        /// <summary>
        /// Вырезать выдавливанием.
        /// </summary>
        /// <param name="entitySketch">Указатель на интерфейс сущности.</param>
        /// <param name="direction">Направление выдавливания.</param>
        /// <param name="depth">Глубина выдавливания.</param>
        private void MakeCutExtrude(double depth, object entitySketch, short direction)
        {
            var entityCutExtrusion = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_cutExtrusion);
            var cutExtrusionDefinition = (ksCutExtrusionDefinition)entityCutExtrusion.GetDefinition();
            cutExtrusionDefinition.directionType = direction;
            cutExtrusionDefinition.SetSideParam(true, 0, depth);
            cutExtrusionDefinition.SetSketch(entitySketch);
            entityCutExtrusion.Create();
        }

        /// <summary>
        /// Нарисовать окружность.
        /// </summary>
        /// <param name="xc">Координата x центра окружности.</param>
        /// <param name="yc">Координата у центра окружности.</param>
        /// <param name="radius">Радиус окружности.</param>
        /// <param name="currentPlane">Плоскость на которой рисуется окружность.</param>
        private void DrawCircle(double xc, double yc, double radius, ksEntity currentPlane)
        {
            CreateSketch(currentPlane);
            _sketchEdit = (ksDocument2D)_sketchDefinition.BeginEdit();
            _sketchEdit.ksCircle(xc, yc, radius, 1);
            _sketchDefinition.EndEdit();
        }

        /// <summary>
        /// Массив по концентрической сетке
        /// </summary>
        /// <param name="entitySketch">Указатель на интерфейс сущности.</param>
        /// <param name="direction">Направление выдавливания.</param>
        /// <param name="depth">Глубина выдавливания.</param>
        /// <param name="holeNumber">Количество отверстий.</param>
        private void DrawHoles(object entitySketch, short direction, double depth, int holeNumber)
        {
            var entityCutExtrusion = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_cutExtrusion);
            var cutExtrusionDefinition = (ksCutExtrusionDefinition)entityCutExtrusion.GetDefinition();
            cutExtrusionDefinition.directionType = direction;
            cutExtrusionDefinition.SetSideParam(true, 0, depth);
            cutExtrusionDefinition.SetSketch(entitySketch);
            entityCutExtrusion.Create();

            var entityAxis = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_axisOZ);

            var entityСircularCopy = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_circularCopy);
            var entityСircularCopyDefinition = (ksCircularCopyDefinition)entityСircularCopy.GetDefinition();
            var entityCollection = (ksEntityCollection)entityСircularCopyDefinition.GetOperationArray();

            entityСircularCopyDefinition.SetCopyParamAlongDir(holeNumber, 360, true, false);
            entityСircularCopyDefinition.SetAxis(entityAxis);
            entityCollection.Add(entityCutExtrusion);
            entityСircularCopy.Create();
        }

        /// <summary>
        ///  Указатель на экземпляр компаса.
        /// </summary>
        private readonly KompasObject _kompas;

        /// <summary>
        ///  Указатель на интерфейс документа.
        /// </summary>
        private ksDocument3D _doc3D;

        /// <summary>
        ///  Указатель на интерфейс компонента.
        /// </summary>
        private ksPart _part;

        /// <summary>
        ///  Указатель на интерфейс сущности.
        /// </summary>
        private ksEntity _entitySketch;

        /// <summary>
        ///  Указатель на интерфейс параметров эскиза.
        /// </summary>
        private ksSketchDefinition _sketchDefinition;

        /// <summary>
        ///  Указатель на эскиз.
        /// </summary>
        private ksDocument2D _sketchEdit;
    }
}
