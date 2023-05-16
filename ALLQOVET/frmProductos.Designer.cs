namespace ALLQOVET
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            ctncerrar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(334, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTOS";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.producto;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(310, 450);
            button1.Name = "button1";
            button1.Size = new Size(234, 40);
            button1.TabIndex = 2;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // ctncerrar
            // 
            ctncerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctncerrar.AutoSize = true;
            ctncerrar.Cursor = Cursors.Hand;
            ctncerrar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ctncerrar.ForeColor = Color.Gray;
            ctncerrar.Location = new Point(791, 9);
            ctncerrar.Name = "ctncerrar";
            ctncerrar.Size = new Size(18, 20);
            ctncerrar.TabIndex = 3;
            ctncerrar.Text = "X";
            ctncerrar.Click += ctncerrar_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 502);
            Controls.Add(ctncerrar);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductos";
            Text = "frmProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label ctncerrar;
    }
}