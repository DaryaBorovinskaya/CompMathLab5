using CompMathLab5.CalculationIntegral;

namespace CompMathLab5
{
    public partial class Form1 : Form
    {
        private IterativeProcess _iterativeProcess = new();
        private LeftRectangles _leftRectangles;
        private FourthOrder _fourthOrder;
        private Function _function = new();
        private TrapezoidMethod _trapezoidMethod;

        public Form1()
        {
            InitializeComponent();
            numericUpperLimit.Controls.RemoveAt(0);
            numericLowerLimit.Controls.RemoveAt(0);
            numericAccuracy.Controls.RemoveAt(0);
        }

        private void LeftRectangles()
        {
            _leftRectangles = new(_function,(double)numericLowerLimit.Value, (double)numericUpperLimit.Value);
            (double integral, double step) answer = _iterativeProcess.ApplyMethod(_leftRectangles, (double)numericAccuracy.Value, 1, 2);
            textIntegral.Text = answer.integral.ToString();
            textStep.Text = answer.step.ToString();
        }

        private void Trapezoids()
        {
            _trapezoidMethod = new(_function, (double)numericLowerLimit.Value, (double)numericUpperLimit.Value);
            (double integral, double step) answer = _iterativeProcess.ApplyMethod(_trapezoidMethod, (double)numericAccuracy.Value, 2, 2);
            textIntegral.Text = answer.integral.ToString();
            textStep.Text = answer.step.ToString();
        }

        private void FourthOrder()
        {
            _fourthOrder = new(_function, (double)numericLowerLimit.Value, (double)numericUpperLimit.Value);
            (double integral, double step) answer = _iterativeProcess.ApplyMethod(_fourthOrder, (double)numericAccuracy.Value, 6,4);
            textIntegral.Text = answer.integral.ToString();
            textStep.Text = answer.step.ToString();
        }

        private void buttonApplyMethod_Click(object sender, EventArgs e)
        {
            if (numericUpperLimit.Value <= numericLowerLimit.Value)
                MessageBox.Show("Неверные пределы интегрирования");

            else
            {
                switch (comboBoxMethods.SelectedIndex)
                {
                    case 0:
                        LeftRectangles();
                        break;
                    case 1:
                        Trapezoids();
                        break;
                    case 2:
                        FourthOrder();
                        break;
                    default:
                        MessageBox.Show("Выберите метод");
                        break;
                }
            }
        }
    }
}
