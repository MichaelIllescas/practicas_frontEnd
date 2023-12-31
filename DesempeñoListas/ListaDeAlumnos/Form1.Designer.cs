namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLegajoMayor = new Button();
            txtLegajoMayor = new TextBox();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            txtCantidad = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnNombre = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            label5 = new Label();
            txtHasta = new TextBox();
            txtDesde = new TextBox();
            btndesdeHasta = new Button();
            groupBox6 = new GroupBox();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // btnLegajoMayor
            // 
            btnLegajoMayor.Location = new Point(17, 55);
            btnLegajoMayor.Name = "btnLegajoMayor";
            btnLegajoMayor.Size = new Size(113, 30);
            btnLegajoMayor.TabIndex = 0;
            btnLegajoMayor.Text = "Consultar";
            btnLegajoMayor.UseVisualStyleBackColor = true;
            btnLegajoMayor.Click += btnLegajoMayor_Click;
            // 
            // txtLegajoMayor
            // 
            txtLegajoMayor.Location = new Point(17, 26);
            txtLegajoMayor.Name = "txtLegajoMayor";
            txtLegajoMayor.Size = new Size(128, 23);
            txtLegajoMayor.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLegajoMayor);
            groupBox1.Controls.Add(txtLegajoMayor);
            groupBox1.Location = new Point(323, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(163, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Legajo mayor a ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(296, 379);
            listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(687, 38);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(246, 319);
            listBox2.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Enabled = false;
            txtCantidad.Location = new Point(748, 372);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(128, 23);
            txtCantidad.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(687, 380);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 6;
            label1.Text = "Cantidad";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnNombre);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Location = new Point(323, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(163, 100);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cuyo nombre contiene";
            // 
            // btnNombre
            // 
            btnNombre.Location = new Point(17, 55);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(113, 30);
            btnNombre.TabIndex = 0;
            btnNombre.Text = "Consultar";
            btnNombre.UseVisualStyleBackColor = true;
            btnNombre.Click += btnNombre_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(17, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(128, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(687, 20);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 8;
            label2.Text = "Lista resultado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 21);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 10;
            label4.Text = "Lista de alumnos";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(323, 224);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(163, 100);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nacidos en el año...";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(323, 330);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(163, 100);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Con mas de x materias";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(txtHasta);
            groupBox5.Controls.Add(txtDesde);
            groupBox5.Controls.Add(btndesdeHasta);
            groupBox5.Location = new Point(492, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(163, 100);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "Con  cant de materias entre X e Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 43);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 4;
            label5.Text = "y";
            // 
            // txtHasta
            // 
            txtHasta.Location = new Point(74, 36);
            txtHasta.Name = "txtHasta";
            txtHasta.Size = new Size(37, 23);
            txtHasta.TabIndex = 3;
            // 
            // txtDesde
            // 
            txtDesde.Location = new Point(14, 36);
            txtDesde.Name = "txtDesde";
            txtDesde.Size = new Size(37, 23);
            txtDesde.TabIndex = 2;
            // 
            // btndesdeHasta
            // 
            btndesdeHasta.Location = new Point(14, 65);
            btndesdeHasta.Name = "btndesdeHasta";
            btndesdeHasta.Size = new Size(113, 30);
            btndesdeHasta.TabIndex = 2;
            btndesdeHasta.Text = "Consultar";
            btndesdeHasta.UseVisualStyleBackColor = true;
            btndesdeHasta.Click += btndesdeHasta_Click;
            // 
            // groupBox6
            // 
            groupBox6.Location = new Point(492, 118);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(163, 100);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "Cuyo nombre contiene una letra \"..\" o una letra \"..\" ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 233);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 15;
            label3.Text = "Inventá mas consultas....";
            // 
            // button1
            // 
            button1.Location = new Point(537, 319);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "cargar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(528, 290);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(txtCantidad);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLegajoMayor;
        private TextBox txtLegajoMayor;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox txtCantidad;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnNombre;
        private TextBox txtNombre;
        private Label label2;
        private Label label4;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Label label3;
        private ComboBox comboBox1;
        private Button btndesdeHasta;
        private Label label5;
        private TextBox txtHasta;
        private TextBox txtDesde;
        private Button button1;
        private TextBox textBox1;
    }
}