using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ConnectingKompas;
using FlangeSizes;
using KompasInteractor;

namespace FlangeUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Экземпляр класса соединения с компасом.
        /// </summary>
        private KompasConnector _kompas;

        /// <summary>
        /// Экземпляр класса параметров.
        /// </summary>
        private FlangeParameters _parameters;

        public MainForm()
        {
            InitializeComponent();
            _kompas = new KompasConnector();
            _parameters = new FlangeParameters();
        }

        private void BuildModelButton_Click(object sender, EventArgs e)
        {
            CreateFlange();
        }

        /// <summary>
        /// Создание модели чехла.
        /// </summary>
        private void CreateFlange()
        {
            try
            {
                 //TODO: RSDN
                _parameters.FlangeExternalDiameter 
                    = double.Parse(FlangeExternalDiameterTextBox.Text);
                _parameters.FlangeCenterDistance 
                    = double.Parse(FlangeCenterDistanceTextBox.Text);
                _parameters.FlangeInnerDiameter 
                    = double.Parse(FlangeInnerDiameterTextBox.Text);
                _parameters.FlangeLength 
                    = double.Parse(FlangeLengthTextBox.Text);
                _parameters.HoleDiameter 
                    = double.Parse(HoleDiameterTextBox.Text);
                _parameters.HoleNumber = int.Parse(HoleNumberTextBox.Text);

                _kompas.OpenKompas();
                var model = new FlangeModeler(_kompas.Kompas);
                model.CreateModel(_parameters);
            }
            catch (FormatException)
            {
                 //TODO: RSDN
                MessageBox.Show(@"Есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                 //TODO: RSDN
                MessageBox.Show(ex.Message, @"Предупреждение", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Метод валидации введеных параметров в текстовом поле, ввод чисел.
        /// </summary>
        /// <param name="sender">Заполненный TextBox.</param>
        /// <param name="e"></param>
        private void ValidateDoubleTextBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b,]");
        }

        /// <summary>
        /// Очистка полей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            FlangeExternalDiameterTextBox.Text = "";
            FlangeCenterDistanceTextBox.Text = "";
            FlangeInnerDiameterTextBox.Text = "";
            FlangeLengthTextBox.Text = "";
            HoleDiameterTextBox.Text = "";
            HoleNumberTextBox.Text = "";
        }

        /// <summary>
        /// Метод валидации введеных параметров.
        /// </summary>
        /// <param name="control">Заполненный TextBox.</param>
        private void ValidateParameter(Control control)
        {
            try
            {
                if (control.Equals(FlangeExternalDiameterTextBox))
                {
                    _parameters.FlangeExternalDiameter = double.Parse(control.Text);
                }
                if (control.Equals(FlangeCenterDistanceTextBox))
                {
                    _parameters.FlangeCenterDistance = double.Parse(control.Text);
                }
                if (control.Equals(FlangeInnerDiameterTextBox))
                {
                    _parameters.FlangeInnerDiameter = double.Parse(control.Text);
                }
                if (control.Equals(FlangeLengthTextBox))
                {
                    _parameters.FlangeLength = double.Parse(control.Text);
                }
                if (control.Equals(HoleDiameterTextBox))
                {
                    _parameters.HoleDiameter = double.Parse(control.Text);
                }
                if (control.Equals(HoleNumberTextBox))
                {
                    _parameters.HoleNumber = int.Parse(control.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Данные введены некорректно. " +
                    "Возможно, заполнены не все обязательные поля или введены лишние запятые.",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                control.Focus();
            }
        }

        /// <summary>
        /// Событие обработки выхода из поля.
        /// </summary>
        private void TextBox_Leave(object sender, EventArgs e)
        {
            ValidateParameter((TextBox)sender);
        }
    }
}
