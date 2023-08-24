namespace ConvertidorLab
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_lb_kg = new System.Windows.Forms.Button();
            this.tb_kg_lb = new System.Windows.Forms.TextBox();
            this.btn_kg_lb = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_g_lb = new System.Windows.Forms.Button();
            this.btn_lb_g = new System.Windows.Forms.Button();
            this.tb_lb_g = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_lb_oz = new System.Windows.Forms.Button();
            this.btn_oz_lb = new System.Windows.Forms.Button();
            this.tb_lb_oz = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(5, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 279);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_lb_kg);
            this.tabPage1.Controls.Add(this.tb_kg_lb);
            this.tabPage1.Controls.Add(this.btn_kg_lb);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kg And Lb";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(558, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "INGRESE LOS EL VALOR QUE DESEA CONVERTIR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "KILOGRAMOS Y LIBRAS";
            // 
            // btn_lb_kg
            // 
            this.btn_lb_kg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lb_kg.Location = new System.Drawing.Point(498, 177);
            this.btn_lb_kg.Name = "btn_lb_kg";
            this.btn_lb_kg.Size = new System.Drawing.Size(129, 43);
            this.btn_lb_kg.TabIndex = 4;
            this.btn_lb_kg.Text = "LB a KG";
            this.btn_lb_kg.UseVisualStyleBackColor = true;
            this.btn_lb_kg.Click += new System.EventHandler(this.btn_lb_kg_Click);
            // 
            // tb_kg_lb
            // 
            this.tb_kg_lb.Location = new System.Drawing.Point(286, 83);
            this.tb_kg_lb.Multiline = true;
            this.tb_kg_lb.Name = "tb_kg_lb";
            this.tb_kg_lb.Size = new System.Drawing.Size(217, 77);
            this.tb_kg_lb.TabIndex = 1;
            // 
            // btn_kg_lb
            // 
            this.btn_kg_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kg_lb.Location = new System.Drawing.Point(144, 177);
            this.btn_kg_lb.Name = "btn_kg_lb";
            this.btn_kg_lb.Size = new System.Drawing.Size(129, 43);
            this.btn_kg_lb.TabIndex = 0;
            this.btn_kg_lb.Text = "KG a LB";
            this.btn_kg_lb.UseVisualStyleBackColor = true;
            this.btn_kg_lb.Click += new System.EventHandler(this.btn_kg_lb_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btn_g_lb);
            this.tabPage2.Controls.Add(this.btn_lb_g);
            this.tabPage2.Controls.Add(this.tb_lb_g);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lb and G";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(270, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "LIBRAS Y GRAMOS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(558, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "INGRESE LOS EL VALOR QUE DESEA CONVERTIR";
            // 
            // btn_g_lb
            // 
            this.btn_g_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_g_lb.Location = new System.Drawing.Point(506, 170);
            this.btn_g_lb.Name = "btn_g_lb";
            this.btn_g_lb.Size = new System.Drawing.Size(127, 45);
            this.btn_g_lb.TabIndex = 4;
            this.btn_g_lb.Text = "G a LB";
            this.btn_g_lb.UseVisualStyleBackColor = true;
            this.btn_g_lb.Click += new System.EventHandler(this.btn_g_lb_Click);
            // 
            // btn_lb_g
            // 
            this.btn_lb_g.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lb_g.Location = new System.Drawing.Point(133, 170);
            this.btn_lb_g.Name = "btn_lb_g";
            this.btn_lb_g.Size = new System.Drawing.Size(127, 45);
            this.btn_lb_g.TabIndex = 2;
            this.btn_lb_g.Text = "LB a G";
            this.btn_lb_g.UseVisualStyleBackColor = true;
            this.btn_lb_g.Click += new System.EventHandler(this.btn_lb_g_Click);
            // 
            // tb_lb_g
            // 
            this.tb_lb_g.Location = new System.Drawing.Point(275, 76);
            this.tb_lb_g.Multiline = true;
            this.tb_lb_g.Name = "tb_lb_g";
            this.tb_lb_g.Size = new System.Drawing.Size(189, 70);
            this.tb_lb_g.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btn_lb_oz);
            this.tabPage3.Controls.Add(this.btn_oz_lb);
            this.tabPage3.Controls.Add(this.tb_lb_oz);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(766, 253);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "LB and Oz";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(558, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "INGRESE LOS EL VALOR QUE DESEA CONVERTIR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "LIBRAS Y ONZAS";
            // 
            // btn_lb_oz
            // 
            this.btn_lb_oz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lb_oz.Location = new System.Drawing.Point(496, 163);
            this.btn_lb_oz.Name = "btn_lb_oz";
            this.btn_lb_oz.Size = new System.Drawing.Size(127, 45);
            this.btn_lb_oz.TabIndex = 6;
            this.btn_lb_oz.Text = "LB a OZ";
            this.btn_lb_oz.UseVisualStyleBackColor = true;
            this.btn_lb_oz.Click += new System.EventHandler(this.btn_lb_oz_Click);
            // 
            // btn_oz_lb
            // 
            this.btn_oz_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_oz_lb.Location = new System.Drawing.Point(118, 163);
            this.btn_oz_lb.Name = "btn_oz_lb";
            this.btn_oz_lb.Size = new System.Drawing.Size(127, 45);
            this.btn_oz_lb.TabIndex = 5;
            this.btn_oz_lb.Text = "OZ a LB";
            this.btn_oz_lb.UseVisualStyleBackColor = true;
            this.btn_oz_lb.Click += new System.EventHandler(this.btn_oz_lb_Click);
            // 
            // tb_lb_oz
            // 
            this.tb_lb_oz.Location = new System.Drawing.Point(271, 77);
            this.tb_lb_oz.Multiline = true;
            this.tb_lb_oz.Name = "tb_lb_oz";
            this.tb_lb_oz.Size = new System.Drawing.Size(194, 63);
            this.tb_lb_oz.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Convertido de pesaje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tb_kg_lb;
        private System.Windows.Forms.Button btn_kg_lb;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_lb_kg;
        private System.Windows.Forms.Button btn_g_lb;
        private System.Windows.Forms.Button btn_lb_g;
        private System.Windows.Forms.TextBox tb_lb_g;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_lb_oz;
        private System.Windows.Forms.Button btn_oz_lb;
        private System.Windows.Forms.TextBox tb_lb_oz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

