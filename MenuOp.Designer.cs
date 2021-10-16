namespace SG
{
    partial class MenuOp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuOp));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btn_establo = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lbl_op = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.cerrar = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.establos1 = new SG.establos();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
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
            this.btn_establo.Location = new System.Drawing.Point(4, 176);
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
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.gunaPanel1.Controls.Add(this.btn_establo);
            this.gunaPanel1.Controls.Add(this.lbl_op);
            this.gunaPanel1.Controls.Add(this.gunaPanel4);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(200, 450);
            this.gunaPanel1.TabIndex = 1;
            // 
            // lbl_op
            // 
            this.lbl_op.AutoSize = true;
            this.lbl_op.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_op.ForeColor = System.Drawing.Color.White;
            this.lbl_op.Location = new System.Drawing.Point(30, 136);
            this.lbl_op.Name = "lbl_op";
            this.lbl_op.Size = new System.Drawing.Size(136, 21);
            this.lbl_op.TabIndex = 1;
            this.lbl_op.Text = "Nombre operador";
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel4.BackgroundImage")));
            this.gunaPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gunaPanel4.Location = new System.Drawing.Point(22, 12);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(148, 121);
            this.gunaPanel4.TabIndex = 0;
            // 
            // cerrar
            // 
            this.cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrar.BackgroundImage")));
            this.cerrar.BaseColor = System.Drawing.Color.White;
            this.cerrar.Location = new System.Drawing.Point(507, 3);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(29, 29);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar.TabIndex = 0;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.cerrar);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(200, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(548, 50);
            this.gunaPanel2.TabIndex = 2;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.establos1);
            this.gunaPanel3.Location = new System.Drawing.Point(207, 57);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(529, 381);
            this.gunaPanel3.TabIndex = 3;
            // 
            // establos1
            // 
            this.establos1.Location = new System.Drawing.Point(3, 3);
            this.establos1.Name = "establos1";
            this.establos1.Size = new System.Drawing.Size(523, 378);
            this.establos1.TabIndex = 0;
            // 
            // MenuOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuOp";
            this.Text = "MenuOp";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btn_establo;
        private Guna.UI.WinForms.GunaLabel lbl_op;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPictureBox cerrar;
        private establos establos1;
    }
}