namespace SG
{
    partial class Menuadmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuadmin));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btn_establo = new Guna.UI.WinForms.GunaButton();
            this.btn_regop = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.agregarop1 = new SG.agregarop();
            this.white1 = new SG.establos();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.gunaPanel1.Controls.Add(this.gunaCircleButton1);
            this.gunaPanel1.Controls.Add(this.btn_establo);
            this.gunaPanel1.Controls.Add(this.btn_regop);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.gunaPanel4);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(200, 450);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btn_establo
            // 
            this.btn_establo.AnimationHoverSpeed = 0.07F;
            this.btn_establo.AnimationSpeed = 0.03F;
            this.btn_establo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_establo.BorderColor = System.Drawing.Color.Black;
            this.btn_establo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_establo.FocusedColor = System.Drawing.Color.Empty;
            this.btn_establo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_establo.ForeColor = System.Drawing.Color.White;
            this.btn_establo.Image = ((System.Drawing.Image)(resources.GetObject("btn_establo.Image")));
            this.btn_establo.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_establo.Location = new System.Drawing.Point(5, 226);
            this.btn_establo.Name = "btn_establo";
            this.btn_establo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_establo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_establo.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_establo.OnHoverImage = null;
            this.btn_establo.OnPressedColor = System.Drawing.Color.Black;
            this.btn_establo.Size = new System.Drawing.Size(192, 42);
            this.btn_establo.TabIndex = 3;
            this.btn_establo.Text = "Establos";
            this.btn_establo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_establo.Click += new System.EventHandler(this.Btn_establo_Click);
            // 
            // btn_regop
            // 
            this.btn_regop.AnimationHoverSpeed = 0.07F;
            this.btn_regop.AnimationSpeed = 0.03F;
            this.btn_regop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_regop.BorderColor = System.Drawing.Color.Black;
            this.btn_regop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_regop.FocusedColor = System.Drawing.Color.Empty;
            this.btn_regop.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regop.ForeColor = System.Drawing.Color.White;
            this.btn_regop.Image = ((System.Drawing.Image)(resources.GetObject("btn_regop.Image")));
            this.btn_regop.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_regop.Location = new System.Drawing.Point(5, 178);
            this.btn_regop.Name = "btn_regop";
            this.btn_regop.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_regop.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_regop.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_regop.OnHoverImage = null;
            this.btn_regop.OnPressedColor = System.Drawing.Color.Black;
            this.btn_regop.Size = new System.Drawing.Size(192, 42);
            this.btn_regop.TabIndex = 2;
            this.btn_regop.Text = "Registrar operador";
            this.btn_regop.Click += new System.EventHandler(this.Btn_regop_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(40, 136);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(116, 21);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Nombre admin";
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel4.BackgroundImage")));
            this.gunaPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gunaPanel4.Location = new System.Drawing.Point(22, 12);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(148, 121);
            this.gunaPanel4.TabIndex = 0;
            this.gunaPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel4_Paint);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(200, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(548, 50);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.BackgroundImage")));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(507, 3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(29, 29);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.GunaPictureBox1_Click);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.White;
            this.gunaPanel3.Controls.Add(this.agregarop1);
            this.gunaPanel3.Controls.Add(this.white1);
            this.gunaPanel3.Location = new System.Drawing.Point(207, 57);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(529, 381);
            this.gunaPanel3.TabIndex = 2;
            // 
            // agregarop1
            // 
            this.agregarop1.Location = new System.Drawing.Point(3, 0);
            this.agregarop1.Name = "agregarop1";
            this.agregarop1.Size = new System.Drawing.Size(529, 381);
            this.agregarop1.TabIndex = 0;
            // 
            // white1
            // 
            this.white1.Location = new System.Drawing.Point(6, 0);
            this.white1.Name = "white1";
            this.white1.Size = new System.Drawing.Size(523, 378);
            this.white1.TabIndex = 1;
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = null;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.Location = new System.Drawing.Point(33, 274);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(123, 90);
            this.gunaCircleButton1.TabIndex = 2;
            this.gunaCircleButton1.Text = "gunaCircleButton1";
            this.gunaCircleButton1.Click += new System.EventHandler(this.gunaCircleButton1_Click);
            // 
            // Menuadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menuadmin";
            this.Text = "Form1";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btn_establo;
        private Guna.UI.WinForms.GunaButton btn_regop;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private agregarop agregarop1;
        private establos white1;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
    }
}

