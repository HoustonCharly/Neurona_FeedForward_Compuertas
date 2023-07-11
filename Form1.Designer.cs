namespace Practica_6_Feedforward
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkXOR = new System.Windows.Forms.CheckBox();
            this.checkEjercicio = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TablaGridView1 = new System.Windows.Forms.DataGridView();
            this.lBsalida = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TablaGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkXOR
            // 
            this.checkXOR.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkXOR.Location = new System.Drawing.Point(35, 37);
            this.checkXOR.Name = "checkXOR";
            this.checkXOR.Size = new System.Drawing.Size(88, 25);
            this.checkXOR.TabIndex = 0;
            this.checkXOR.Text = "XOR";
            this.checkXOR.UseVisualStyleBackColor = true;
            this.checkXOR.CheckedChanged += new System.EventHandler(this.checkXOR_CheckedChanged);
            // 
            // checkEjercicio
            // 
            this.checkEjercicio.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEjercicio.Location = new System.Drawing.Point(33, 65);
            this.checkEjercicio.Name = "checkEjercicio";
            this.checkEjercicio.Size = new System.Drawing.Size(118, 27);
            this.checkEjercicio.TabIndex = 1;
            this.checkEjercicio.Text = "EJERCICIO";
            this.checkEjercicio.UseVisualStyleBackColor = true;
            this.checkEjercicio.CheckedChanged += new System.EventHandler(this.checkEjercicio_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(182, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "FeedForward";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TablaGridView1
            // 
            this.TablaGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.TablaGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaGridView1.Location = new System.Drawing.Point(8, 101);
            this.TablaGridView1.Name = "TablaGridView1";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablaGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaGridView1.Size = new System.Drawing.Size(416, 207);
            this.TablaGridView1.TabIndex = 3;
            // 
            // lBsalida
            // 
            this.lBsalida.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBsalida.FormattingEnabled = true;
            this.lBsalida.ItemHeight = 16;
            this.lBsalida.Items.AddRange(new object[] {
            " "});
            this.lBsalida.Location = new System.Drawing.Point(431, 12);
            this.lBsalida.Name = "lBsalida";
            this.lBsalida.Size = new System.Drawing.Size(233, 292);
            this.lBsalida.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(671, 315);
            this.Controls.Add(this.lBsalida);
            this.Controls.Add(this.TablaGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkEjercicio);
            this.Controls.Add(this.checkXOR);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FEEDFORWARD";
            ((System.ComponentModel.ISupportInitialize)(this.TablaGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkXOR;
        private System.Windows.Forms.CheckBox checkEjercicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView TablaGridView1;
        private System.Windows.Forms.ListBox lBsalida;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

