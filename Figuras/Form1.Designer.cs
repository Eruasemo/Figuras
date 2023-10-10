namespace Figuras
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rTriangle = new System.Windows.Forms.RadioButton();
            this.rCircle = new System.Windows.Forms.RadioButton();
            this.rRectangle = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lSide = new System.Windows.Forms.Label();
            this.lRadio = new System.Windows.Forms.Label();
            this.lWidth = new System.Windows.Forms.Label();
            this.lHeight = new System.Windows.Forms.Label();
            this.tSide = new System.Windows.Forms.TextBox();
            this.tRadius = new System.Windows.Forms.TextBox();
            this.tWidth = new System.Windows.Forms.TextBox();
            this.tHeight = new System.Windows.Forms.TextBox();
            this.bArea = new System.Windows.Forms.Button();
            this.bPerimeter = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rTriangle);
            this.groupBox1.Controls.Add(this.rCircle);
            this.groupBox1.Controls.Add(this.rRectangle);
            this.groupBox1.Location = new System.Drawing.Point(45, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de figura";
            // 
            // rTriangle
            // 
            this.rTriangle.AutoSize = true;
            this.rTriangle.Location = new System.Drawing.Point(35, 117);
            this.rTriangle.Name = "rTriangle";
            this.rTriangle.Size = new System.Drawing.Size(125, 17);
            this.rTriangle.TabIndex = 2;
            this.rTriangle.TabStop = true;
            this.rTriangle.Text = "Triánguulo Equilátero";
            this.rTriangle.UseVisualStyleBackColor = true;
            this.rTriangle.CheckedChanged += new System.EventHandler(this.rTriangle_CheckedChanged);
            // 
            // rCircle
            // 
            this.rCircle.AutoSize = true;
            this.rCircle.Location = new System.Drawing.Point(35, 83);
            this.rCircle.Name = "rCircle";
            this.rCircle.Size = new System.Drawing.Size(57, 17);
            this.rCircle.TabIndex = 1;
            this.rCircle.TabStop = true;
            this.rCircle.Text = "Circulo";
            this.rCircle.UseVisualStyleBackColor = true;
            this.rCircle.CheckedChanged += new System.EventHandler(this.rCircle_CheckedChanged);
            // 
            // rRectangle
            // 
            this.rRectangle.AutoSize = true;
            this.rRectangle.Location = new System.Drawing.Point(35, 51);
            this.rRectangle.Name = "rRectangle";
            this.rRectangle.Size = new System.Drawing.Size(80, 17);
            this.rRectangle.TabIndex = 0;
            this.rRectangle.TabStop = true;
            this.rRectangle.Text = "Rectángulo";
            this.rRectangle.UseVisualStyleBackColor = true;
            this.rRectangle.CheckedChanged += new System.EventHandler(this.rRectangle_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lSide);
            this.groupBox2.Controls.Add(this.lRadio);
            this.groupBox2.Controls.Add(this.lWidth);
            this.groupBox2.Controls.Add(this.lHeight);
            this.groupBox2.Controls.Add(this.tSide);
            this.groupBox2.Controls.Add(this.tRadius);
            this.groupBox2.Controls.Add(this.tWidth);
            this.groupBox2.Controls.Add(this.tHeight);
            this.groupBox2.Location = new System.Drawing.Point(45, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Figura";
            // 
            // lSide
            // 
            this.lSide.AutoSize = true;
            this.lSide.Location = new System.Drawing.Point(28, 121);
            this.lSide.Name = "lSide";
            this.lSide.Size = new System.Drawing.Size(31, 13);
            this.lSide.TabIndex = 7;
            this.lSide.Text = "Lado";
            // 
            // lRadio
            // 
            this.lRadio.AutoSize = true;
            this.lRadio.Location = new System.Drawing.Point(28, 95);
            this.lRadio.Name = "lRadio";
            this.lRadio.Size = new System.Drawing.Size(35, 13);
            this.lRadio.TabIndex = 6;
            this.lRadio.Text = "Radio";
            // 
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Location = new System.Drawing.Point(28, 69);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(38, 13);
            this.lWidth.TabIndex = 5;
            this.lWidth.Text = "Ancho";
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(28, 47);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(34, 13);
            this.lHeight.TabIndex = 4;
            this.lHeight.Text = "Largo";
            // 
            // tSide
            // 
            this.tSide.Location = new System.Drawing.Point(69, 118);
            this.tSide.Name = "tSide";
            this.tSide.Size = new System.Drawing.Size(100, 20);
            this.tSide.TabIndex = 3;
            // 
            // tRadius
            // 
            this.tRadius.Location = new System.Drawing.Point(69, 92);
            this.tRadius.Name = "tRadius";
            this.tRadius.Size = new System.Drawing.Size(100, 20);
            this.tRadius.TabIndex = 2;
            // 
            // tWidth
            // 
            this.tWidth.Location = new System.Drawing.Point(69, 66);
            this.tWidth.Name = "tWidth";
            this.tWidth.Size = new System.Drawing.Size(100, 20);
            this.tWidth.TabIndex = 1;
            // 
            // tHeight
            // 
            this.tHeight.Location = new System.Drawing.Point(69, 40);
            this.tHeight.Name = "tHeight";
            this.tHeight.Size = new System.Drawing.Size(100, 20);
            this.tHeight.TabIndex = 0;
            // 
            // bArea
            // 
            this.bArea.Location = new System.Drawing.Point(367, 60);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(77, 67);
            this.bArea.TabIndex = 2;
            this.bArea.Text = "Calcular Área";
            this.bArea.UseVisualStyleBackColor = true;
            this.bArea.Click += new System.EventHandler(this.bArea_Click);
            // 
            // bPerimeter
            // 
            this.bPerimeter.Location = new System.Drawing.Point(367, 166);
            this.bPerimeter.Name = "bPerimeter";
            this.bPerimeter.Size = new System.Drawing.Size(77, 67);
            this.bPerimeter.TabIndex = 3;
            this.bPerimeter.Text = "Calcular Perímetro";
            this.bPerimeter.UseVisualStyleBackColor = true;
            this.bPerimeter.Click += new System.EventHandler(this.bPerimeter_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(367, 265);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(77, 67);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "Salir";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bPerimeter);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Figuras Geométricas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rTriangle;
        private System.Windows.Forms.RadioButton rCircle;
        private System.Windows.Forms.RadioButton rRectangle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lSide;
        private System.Windows.Forms.Label lRadio;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.TextBox tSide;
        private System.Windows.Forms.TextBox tRadius;
        private System.Windows.Forms.TextBox tWidth;
        private System.Windows.Forms.TextBox tHeight;
        private System.Windows.Forms.Button bArea;
        private System.Windows.Forms.Button bPerimeter;
        private System.Windows.Forms.Button bExit;
    }
}

