

namespace CompMathLab5
{
    public partial class Form1 : Form
    {
        private LeftRectangles _leftRectangles;




        public Form1()
        {
            InitializeComponent();
            numericUpperLimit.Controls.RemoveAt(0);
            numericLowerLimit.Controls.RemoveAt(0);
            numericAccuracy.Controls.RemoveAt(0);



        }


        private void LeftRectangles()
        {
            _leftRectangles = new();
            (double integral, double step) answer = _leftRectangles.ApplyMethod((double)numericLowerLimit.Value, (double)numericUpperLimit.Value, (double)numericAccuracy.Value);
            textIntegral.Text = answer.integral.ToString();
            textStep.Text = answer.step.ToString();
        }

        private void Trapezoids()
        {

        }

        private void FourthOrder()
        {

        }



        private void comboBoxMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonApplyMethod_Click(object sender, EventArgs e)
        {
            if (numericUpperLimit.Value <= numericLowerLimit.Value)
                MessageBox.Show("�������� ������� ��������������");

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
                        MessageBox.Show("�������� �����");
                        break;
                }
            }
        }
    }
}
