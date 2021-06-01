using FlangeSizes;
using Kompas6API5;
using Kompas6Constants;
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
        /// <param name="parameters">Размеры чехла.</param>
        public void CreateModel(FlangeParameters parameters)
        {

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
