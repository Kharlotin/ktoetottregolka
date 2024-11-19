namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            string sideAInput = txtSideA.Text;
            string sideBInput = txtSideB.Text;
            string sideCInput = txtSideC.Text;

            // це числа?
            if (int.TryParse(sideAInput, out int sideA) &&
            int.TryParse(sideBInput, out int sideB) &&
            int.TryParse(sideCInput, out int sideC))
            {
                // сущ треуг
                if (sideA + sideB > sideC && sideB + sideC > sideA && sideC + sideA > sideB)
                {
                    // типчик треугольника
                    if (sideA == sideB && sideB == sideC)
                    {
                        lblResult.Text = "Это равносторонний треугольник.";
                    }
                    else if (sideA == sideB || sideB == sideC || sideA == sideC)
                    {
                        lblResult.Text = "Это равнобедренный треугольник.";
                    }
                    else
                    {
                        lblResult.Text = "Это разносторонний треугольник.";
                    }
                }
                else
                {
                    lblResult.Text = "С указанными сторонами треугольник не существует.";
                }
            }
            else
            {
                lblResult.Text = "Введите корректные целые числа для всех сторон.";
            }
        }

        private void txtSideB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
