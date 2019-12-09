namespace HerramientasTesis
{
    partial class Principal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lab_tipoUser = new System.Windows.Forms.Label();
            this.lab_nomProducto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_precio = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_enviarSimulacro = new System.Windows.Forms.Button();
            this.lab_descripcionProducto = new System.Windows.Forms.Label();
            this.lab_categoriaProducto = new System.Windows.Forms.Label();
            this.lab_stock = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_marcaProducto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tex_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_NuevaConsulta = new System.Windows.Forms.Button();
            this.btn_enviarComentario = new System.Windows.Forms.Button();
            this.tex_comentarioDescripcion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tex_comentarioNombre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_total = new System.Windows.Forms.Label();
            this.lab_iva = new System.Windows.Forms.Label();
            this.lab_subTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_limpirDatos = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.lab_simuNombreProducto = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tex_unidad = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1107, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Yellow;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(124, 22);
            this.toolStripLabel1.Text = "AGREGAR PRODUCTO";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(142, 22);
            this.toolStripLabel2.Text = "ACTUALIZAR PRODCUTO";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click_1);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripLabel3.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(125, 22);
            this.toolStripLabel3.Text = "ELIMINAR PRODUCTO";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // lab_tipoUser
            // 
            this.lab_tipoUser.AutoSize = true;
            this.lab_tipoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tipoUser.Location = new System.Drawing.Point(193, 55);
            this.lab_tipoUser.Name = "lab_tipoUser";
            this.lab_tipoUser.Size = new System.Drawing.Size(129, 24);
            this.lab_tipoUser.TabIndex = 1;
            this.lab_tipoUser.Text = "Tipo de user";
            // 
            // lab_nomProducto
            // 
            this.lab_nomProducto.AutoSize = true;
            this.lab_nomProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nomProducto.Location = new System.Drawing.Point(107, 23);
            this.lab_nomProducto.Name = "lab_nomProducto";
            this.lab_nomProducto.Size = new System.Drawing.Size(129, 16);
            this.lab_nomProducto.TabIndex = 2;
            this.lab_nomProducto.Text = "Nombre Porducto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lab_precio);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btn_enviarSimulacro);
            this.panel1.Controls.Add(this.lab_descripcionProducto);
            this.panel1.Controls.Add(this.lab_categoriaProducto);
            this.panel1.Controls.Add(this.lab_stock);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lab_marcaProducto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tex_codigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lab_nomProducto);
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 371);
            this.panel1.TabIndex = 3;
            // 
            // lab_precio
            // 
            this.lab_precio.AutoSize = true;
            this.lab_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_precio.Location = new System.Drawing.Point(267, 337);
            this.lab_precio.Name = "lab_precio";
            this.lab_precio.Size = new System.Drawing.Size(33, 20);
            this.lab_precio.TabIndex = 14;
            this.lab_precio.Text = "xxx";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(182, 340);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 16);
            this.label16.TabIndex = 13;
            this.label16.Text = "Precio";
            // 
            // btn_enviarSimulacro
            // 
            this.btn_enviarSimulacro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_enviarSimulacro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enviarSimulacro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enviarSimulacro.Location = new System.Drawing.Point(15, 330);
            this.btn_enviarSimulacro.Name = "btn_enviarSimulacro";
            this.btn_enviarSimulacro.Size = new System.Drawing.Size(130, 23);
            this.btn_enviarSimulacro.TabIndex = 12;
            this.btn_enviarSimulacro.Text = "Enviar al Simulacro";
            this.btn_enviarSimulacro.UseVisualStyleBackColor = false;
            this.btn_enviarSimulacro.Click += new System.EventHandler(this.btn_enviarSimulacro_Click);
            // 
            // lab_descripcionProducto
            // 
            this.lab_descripcionProducto.AutoSize = true;
            this.lab_descripcionProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_descripcionProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_descripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_descripcionProducto.Location = new System.Drawing.Point(26, 239);
            this.lab_descripcionProducto.Name = "lab_descripcionProducto";
            this.lab_descripcionProducto.Size = new System.Drawing.Size(247, 66);
            this.lab_descripcionProducto.TabIndex = 11;
            this.lab_descripcionProducto.Text = "xxx                                               xxxx\r\nxxx\r\nxxx\r\nxxx";
            // 
            // lab_categoriaProducto
            // 
            this.lab_categoriaProducto.AutoSize = true;
            this.lab_categoriaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_categoriaProducto.Location = new System.Drawing.Point(135, 167);
            this.lab_categoriaProducto.Name = "lab_categoriaProducto";
            this.lab_categoriaProducto.Size = new System.Drawing.Size(29, 16);
            this.lab_categoriaProducto.TabIndex = 10;
            this.lab_categoriaProducto.Text = "xxx";
            // 
            // lab_stock
            // 
            this.lab_stock.AutoSize = true;
            this.lab_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_stock.Location = new System.Drawing.Point(267, 311);
            this.lab_stock.Name = "lab_stock";
            this.lab_stock.Size = new System.Drawing.Size(33, 20);
            this.lab_stock.TabIndex = 9;
            this.lab_stock.Text = "xxx";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(182, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Stock";
            // 
            // lab_marcaProducto
            // 
            this.lab_marcaProducto.AutoSize = true;
            this.lab_marcaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_marcaProducto.Location = new System.Drawing.Point(135, 123);
            this.lab_marcaProducto.Name = "lab_marcaProducto";
            this.lab_marcaProducto.Size = new System.Drawing.Size(29, 16);
            this.lab_marcaProducto.TabIndex = 7;
            this.lab_marcaProducto.Text = "xxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marca";
            // 
            // tex_codigo
            // 
            this.tex_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_codigo.Location = new System.Drawing.Point(110, 65);
            this.tex_codigo.Name = "tex_codigo";
            this.tex_codigo.Size = new System.Drawing.Size(142, 22);
            this.tex_codigo.TabIndex = 0;
            this.tex_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(411, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 160);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(119, 517);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Ceado por xxx";
            // 
            // btn_NuevaConsulta
            // 
            this.btn_NuevaConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NuevaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevaConsulta.Location = new System.Drawing.Point(401, 497);
            this.btn_NuevaConsulta.Name = "btn_NuevaConsulta";
            this.btn_NuevaConsulta.Size = new System.Drawing.Size(312, 35);
            this.btn_NuevaConsulta.TabIndex = 6;
            this.btn_NuevaConsulta.Text = "Nueva Consulta";
            this.btn_NuevaConsulta.UseVisualStyleBackColor = true;
            // 
            // btn_enviarComentario
            // 
            this.btn_enviarComentario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enviarComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviarComentario.Location = new System.Drawing.Point(827, 488);
            this.btn_enviarComentario.Name = "btn_enviarComentario";
            this.btn_enviarComentario.Size = new System.Drawing.Size(268, 35);
            this.btn_enviarComentario.TabIndex = 7;
            this.btn_enviarComentario.Text = "Enviar Comentario";
            this.btn_enviarComentario.UseVisualStyleBackColor = true;
            // 
            // tex_comentarioDescripcion
            // 
            this.tex_comentarioDescripcion.Location = new System.Drawing.Point(827, 400);
            this.tex_comentarioDescripcion.Multiline = true;
            this.tex_comentarioDescripcion.Name = "tex_comentarioDescripcion";
            this.tex_comentarioDescripcion.Size = new System.Drawing.Size(268, 68);
            this.tex_comentarioDescripcion.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(879, 331);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Comentario del Sistema";
            // 
            // tex_comentarioNombre
            // 
            this.tex_comentarioNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_comentarioNombre.Location = new System.Drawing.Point(827, 362);
            this.tex_comentarioNombre.Name = "tex_comentarioNombre";
            this.tex_comentarioNombre.Size = new System.Drawing.Size(126, 22);
            this.tex_comentarioNombre.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(974, 365);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Nombre";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 84);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.lab_total);
            this.panel2.Controls.Add(this.lab_iva);
            this.panel2.Controls.Add(this.lab_subTotal);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_limpirDatos);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.lab_simuNombreProducto);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.tex_unidad);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(401, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 224);
            this.panel2.TabIndex = 15;
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_total.Location = new System.Drawing.Point(279, 190);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(67, 16);
            this.lab_total.TabIndex = 23;
            this.lab_total.Text = "- - - - - - -";
            // 
            // lab_iva
            // 
            this.lab_iva.AutoSize = true;
            this.lab_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_iva.Location = new System.Drawing.Point(279, 164);
            this.lab_iva.Name = "lab_iva";
            this.lab_iva.Size = new System.Drawing.Size(67, 16);
            this.lab_iva.TabIndex = 22;
            this.lab_iva.Text = "- - - - - - -";
            // 
            // lab_subTotal
            // 
            this.lab_subTotal.AutoSize = true;
            this.lab_subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_subTotal.Location = new System.Drawing.Point(279, 132);
            this.lab_subTotal.Name = "lab_subTotal";
            this.lab_subTotal.Size = new System.Drawing.Size(67, 16);
            this.lab_subTotal.TabIndex = 21;
            this.lab_subTotal.Text = "- - - - - - -";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(193, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Iva 14%:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "SubTotal:";
            // 
            // btn_limpirDatos
            // 
            this.btn_limpirDatos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_limpirDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpirDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpirDatos.ForeColor = System.Drawing.Color.Black;
            this.btn_limpirDatos.Location = new System.Drawing.Point(10, 178);
            this.btn_limpirDatos.Name = "btn_limpirDatos";
            this.btn_limpirDatos.Size = new System.Drawing.Size(130, 23);
            this.btn_limpirDatos.TabIndex = 17;
            this.btn_limpirDatos.Text = "Limpiar Datos";
            this.btn_limpirDatos.UseVisualStyleBackColor = false;
            this.btn_limpirDatos.Click += new System.EventHandler(this.btn_limpirDatos_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(25, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Nombre de Producto";
            // 
            // lab_simuNombreProducto
            // 
            this.lab_simuNombreProducto.AutoSize = true;
            this.lab_simuNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_simuNombreProducto.Location = new System.Drawing.Point(25, 43);
            this.lab_simuNombreProducto.Name = "lab_simuNombreProducto";
            this.lab_simuNombreProducto.Size = new System.Drawing.Size(76, 16);
            this.lab_simuNombreProducto.TabIndex = 16;
            this.lab_simuNombreProducto.Text = "- - - - - - - -";
            this.lab_simuNombreProducto.Click += new System.EventHandler(this.label19_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(10, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Enviar Consulta\r\n";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(25, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 16);
            this.label18.TabIndex = 15;
            this.label18.Text = "Unidades";
            // 
            // tex_unidad
            // 
            this.tex_unidad.Location = new System.Drawing.Point(28, 103);
            this.tex_unidad.Name = "tex_unidad";
            this.tex_unidad.Size = new System.Drawing.Size(100, 20);
            this.tex_unidad.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 7;
            this.listBox1.Location = new System.Drawing.Point(228, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 95);
            this.listBox1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(397, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(308, 24);
            this.label15.TabIndex = 16;
            this.label15.Text = "Simulacro De Compra Mayorista";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 117);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 24);
            this.label21.TabIndex = 17;
            this.label21.Text = "Datos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(683, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(382, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(85, 22);
            this.toolStripLabel4.Text = "Pnael Principal";
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1107, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tex_comentarioNombre);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tex_comentarioDescripcion);
            this.Controls.Add(this.btn_enviarComentario);
            this.Controls.Add(this.btn_NuevaConsulta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lab_tipoUser);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Label lab_nomProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_descripcionProducto;
        private System.Windows.Forms.Label lab_categoriaProducto;
        private System.Windows.Forms.Label lab_stock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_marcaProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tex_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_NuevaConsulta;
        private System.Windows.Forms.Button btn_enviarComentario;
        private System.Windows.Forms.TextBox tex_comentarioDescripcion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tex_comentarioNombre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lab_precio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_enviarSimulacro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lab_simuNombreProducto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tex_unidad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_limpirDatos;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lab_total;
        private System.Windows.Forms.Label lab_iva;
        private System.Windows.Forms.Label lab_subTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lab_tipoUser;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
    }
}