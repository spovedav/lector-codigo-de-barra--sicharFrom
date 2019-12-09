namespace HerramientasTesis
{
    partial class PanelControl
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
            this.label_usuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_actualizarProducto = new System.Windows.Forms.Button();
            this.btn_eliminarProducto = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.Location = new System.Drawing.Point(26, 22);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(179, 25);
            this.label_usuario.TabIndex = 0;
            this.label_usuario.Text = "Tipo de Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "CONSULTAR PRODUCTO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "AGREAGR PRODUCTO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_actualizarProducto
            // 
            this.btn_actualizarProducto.Location = new System.Drawing.Point(223, 221);
            this.btn_actualizarProducto.Name = "btn_actualizarProducto";
            this.btn_actualizarProducto.Size = new System.Drawing.Size(237, 33);
            this.btn_actualizarProducto.TabIndex = 6;
            this.btn_actualizarProducto.Text = "ACTUALIZAR PRODUCTO";
            this.btn_actualizarProducto.UseVisualStyleBackColor = true;
            this.btn_actualizarProducto.Click += new System.EventHandler(this.btn_actualizarProducto_Click);
            // 
            // btn_eliminarProducto
            // 
            this.btn_eliminarProducto.Location = new System.Drawing.Point(223, 268);
            this.btn_eliminarProducto.Name = "btn_eliminarProducto";
            this.btn_eliminarProducto.Size = new System.Drawing.Size(237, 33);
            this.btn_eliminarProducto.TabIndex = 7;
            this.btn_eliminarProducto.Text = "ELIMINAR PRODUCTO";
            this.btn_eliminarProducto.UseVisualStyleBackColor = true;
            this.btn_eliminarProducto.Click += new System.EventHandler(this.btn_eliminarProducto_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HerramientasTesis.Properties.Resources.admin;
            this.pictureBox2.Location = new System.Drawing.Point(31, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(371, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 91);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 313);
            this.Controls.Add(this.btn_eliminarProducto);
            this.Controls.Add(this.btn_actualizarProducto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_usuario);
            this.Name = "PanelControl";
            this.Text = "PanelControl";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_actualizarProducto;
        private System.Windows.Forms.Button btn_eliminarProducto;
        public System.Windows.Forms.Label label_usuario;
        public System.Windows.Forms.PictureBox pictureBox2;
    }
}