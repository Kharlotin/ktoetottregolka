namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtSideA = new TextBox();
            txtSideB = new TextBox();
            txtSideC = new TextBox();
            btnCheck = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtSideA
            // 
            txtSideA.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSideA.Location = new Point(372, 275);
            txtSideA.Name = "txtSideA";
            txtSideA.Size = new Size(150, 41);
            txtSideA.TabIndex = 0;
            txtSideA.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSideB
            // 
            txtSideB.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSideB.Location = new Point(599, 275);
            txtSideB.Name = "txtSideB";
            txtSideB.Size = new Size(150, 41);
            txtSideB.TabIndex = 1;
            txtSideB.TextAlign = HorizontalAlignment.Center;
            txtSideB.TextChanged += txtSideB_TextChanged;
            // 
            // txtSideC
            // 
            txtSideC.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSideC.Location = new Point(821, 275);
            txtSideC.Name = "txtSideC";
            txtSideC.Size = new Size(150, 41);
            txtSideC.TabIndex = 2;
            txtSideC.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.Transparent;
            btnCheck.ForeColor = SystemColors.ControlText;
            btnCheck.Location = new Point(601, 356);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(148, 58);
            btnCheck.TabIndex = 3;
            btnCheck.Text = "Проверить";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.GhostWhite;
            lblResult.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblResult.Location = new Point(450, 463);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(500, 58);
            lblResult.TabIndex = 4;
            lblResult.Text = "Результат будет здесь.";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            BackColor = Color.Fuchsia;
            BackgroundImage = Properties.Resources.menu;
            ClientSize = new Size(1122, 597);
            Controls.Add(lblResult);
            Controls.Add(btnCheck);
            Controls.Add(txtSideC);
            Controls.Add(txtSideB);
            Controls.Add(txtSideA);
            Name = "Form1";
            Text = "Проверка треугольника";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
