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

            // �� �����?
            if (int.TryParse(sideAInput, out int sideA) &&
            int.TryParse(sideBInput, out int sideB) &&
            int.TryParse(sideCInput, out int sideC))
            {
                // ��� �����
                if (sideA + sideB > sideC && sideB + sideC > sideA && sideC + sideA > sideB)
                {
                    // ������ ������������
                    if (sideA == sideB && sideB == sideC)
                    {
                        lblResult.Text = "��� �������������� �����������.";
                    }
                    else if (sideA == sideB || sideB == sideC || sideA == sideC)
                    {
                        lblResult.Text = "��� �������������� �����������.";
                    }
                    else
                    {
                        lblResult.Text = "��� �������������� �����������.";
                    }
                }
                else
                {
                    lblResult.Text = "� ���������� ��������� ����������� �� ����������.";
                }
            }
            else
            {
                lblResult.Text = "������� ���������� ����� ����� ��� ���� ������.";
            }
        }

        private void txtSideB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
