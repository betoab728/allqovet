namespace ALLQOVET
{
    partial class frmMenu
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
            Contenedor = new Panel();
            pictureBox1 = new PictureBox();
            btnprod = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            MenuVertical = new Panel();
            btnslide = new PictureBox();
            iconcerrar = new PictureBox();
            iconminimizar = new PictureBox();
            iconmaximizar = new PictureBox();
            iconrestaurar = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnslide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Contenedor
            // 
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(250, 66);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(1050, 584);
            Contenedor.TabIndex = 2;
            Contenedor.Paint += Contenedor_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logoallqovet;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnprod
            // 
            btnprod.FlatAppearance.BorderSize = 0;
            btnprod.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnprod.FlatStyle = FlatStyle.Flat;
            btnprod.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnprod.ForeColor = Color.White;
            btnprod.Image = Properties.Resources.producto;
            btnprod.ImageAlign = ContentAlignment.MiddleLeft;
            btnprod.Location = new Point(0, 168);
            btnprod.Name = "btnprod";
            btnprod.Size = new Size(250, 40);
            btnprod.TabIndex = 1;
            btnprod.Text = "Productos";
            btnprod.UseVisualStyleBackColor = true;
            btnprod.Click += btnprod_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.venta;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 214);
            button2.Name = "button2";
            button2.Size = new Size(250, 40);
            button2.TabIndex = 2;
            button2.Text = "Ventas";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.clientes;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 260);
            button3.Name = "button3";
            button3.Size = new Size(250, 40);
            button3.TabIndex = 3;
            button3.Text = "Clientes";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.compras;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 306);
            button4.Name = "button4";
            button4.Size = new Size(250, 40);
            button4.TabIndex = 4;
            button4.Text = "Proveedores";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.venta1;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 352);
            button5.Name = "button5";
            button5.Size = new Size(250, 40);
            button5.TabIndex = 5;
            button5.Text = "Compras";
            button5.UseVisualStyleBackColor = true;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(153, 128, 154);
            MenuVertical.Controls.Add(button5);
            MenuVertical.Controls.Add(button4);
            MenuVertical.Controls.Add(button3);
            MenuVertical.Controls.Add(button2);
            MenuVertical.Controls.Add(btnprod);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(250, 650);
            MenuVertical.TabIndex = 0;
            // 
            // btnslide
            // 
            btnslide.Cursor = Cursors.Hand;
            btnslide.Image = Properties.Resources._134216_menu_lines_hamburger_icon;
            btnslide.Location = new Point(6, 9);
            btnslide.Name = "btnslide";
            btnslide.Size = new Size(35, 35);
            btnslide.SizeMode = PictureBoxSizeMode.Zoom;
            btnslide.TabIndex = 0;
            btnslide.TabStop = false;
            btnslide.Click += btnslide_Click;
            // 
            // iconcerrar
            // 
            iconcerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconcerrar.Cursor = Cursors.Hand;
            iconcerrar.Image = Properties.Resources._3017944_blunder_close_error_failure_fault_icon__1_;
            iconcerrar.Location = new Point(1022, 3);
            iconcerrar.Name = "iconcerrar";
            iconcerrar.Size = new Size(20, 20);
            iconcerrar.SizeMode = PictureBoxSizeMode.Zoom;
            iconcerrar.TabIndex = 1;
            iconcerrar.TabStop = false;
            iconcerrar.Click += iconcerrar_Click;
            // 
            // iconminimizar
            // 
            iconminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconminimizar.Cursor = Cursors.Hand;
            iconminimizar.Image = Properties.Resources._4168572_remove_cancel_close_delete_minus_icon;
            iconminimizar.Location = new Point(970, 3);
            iconminimizar.Name = "iconminimizar";
            iconminimizar.Size = new Size(20, 20);
            iconminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconminimizar.TabIndex = 2;
            iconminimizar.TabStop = false;
            iconminimizar.Click += iconminimizar_Click;
            // 
            // iconmaximizar
            // 
            iconmaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconmaximizar.Cursor = Cursors.Hand;
            iconmaximizar.Image = Properties.Resources.icon_maximizar;
            iconmaximizar.Location = new Point(996, 3);
            iconmaximizar.Name = "iconmaximizar";
            iconmaximizar.Size = new Size(20, 20);
            iconmaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconmaximizar.TabIndex = 3;
            iconmaximizar.TabStop = false;
            iconmaximizar.Click += iconmaximizar_Click;
            // 
            // iconrestaurar
            // 
            iconrestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconrestaurar.Cursor = Cursors.Hand;
            iconrestaurar.Image = Properties.Resources.icon_restaurar;
            iconrestaurar.Location = new Point(996, 3);
            iconrestaurar.Name = "iconrestaurar";
            iconrestaurar.Size = new Size(20, 20);
            iconrestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            iconrestaurar.TabIndex = 4;
            iconrestaurar.TabStop = false;
            iconrestaurar.Visible = false;
            iconrestaurar.Click += iconrestaurar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(iconrestaurar);
            panel1.Controls.Add(iconmaximizar);
            panel1.Controls.Add(iconminimizar);
            panel1.Controls.Add(iconcerrar);
            panel1.Controls.Add(btnslide);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 66);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(Contenedor);
            Controls.Add(panel1);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnslide).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel Contenedor;
        private PictureBox pictureBox1;
        private Button btnprod;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel MenuVertical;
        private PictureBox btnslide;
        private PictureBox iconcerrar;
        private PictureBox iconminimizar;
        private PictureBox iconmaximizar;
        private PictureBox iconrestaurar;
        private Panel panel1;
    }
}