
namespace UNACH.Biblioteca.Window
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
            this.LibrosdataGridView = new System.Windows.Forms.DataGridView();
            this.ISBNtextBox = new System.Windows.Forms.TextBox();
            this.TitulotextBox = new System.Windows.Forms.TextBox();
            this.AñotextBox = new System.Windows.Forms.TextBox();
            this.EditorialtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Insertarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LibrosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LibrosdataGridView
            // 
            this.LibrosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibrosdataGridView.Location = new System.Drawing.Point(32, 39);
            this.LibrosdataGridView.Name = "LibrosdataGridView";
            this.LibrosdataGridView.Size = new System.Drawing.Size(541, 287);
            this.LibrosdataGridView.TabIndex = 0;
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(607, 82);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.Size = new System.Drawing.Size(100, 20);
            this.ISBNtextBox.TabIndex = 1;
            // 
            // TitulotextBox
            // 
            this.TitulotextBox.Location = new System.Drawing.Point(607, 124);
            this.TitulotextBox.Name = "TitulotextBox";
            this.TitulotextBox.Size = new System.Drawing.Size(100, 20);
            this.TitulotextBox.TabIndex = 2;
            // 
            // AñotextBox
            // 
            this.AñotextBox.Location = new System.Drawing.Point(607, 167);
            this.AñotextBox.Name = "AñotextBox";
            this.AñotextBox.Size = new System.Drawing.Size(100, 20);
            this.AñotextBox.TabIndex = 3;
            // 
            // EditorialtextBox
            // 
            this.EditorialtextBox.Location = new System.Drawing.Point(607, 206);
            this.EditorialtextBox.Name = "EditorialtextBox";
            this.EditorialtextBox.Size = new System.Drawing.Size(100, 20);
            this.EditorialtextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "TITULO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "AÑO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "EDITORIAL";
            // 
            // Insertarbutton
            // 
            this.Insertarbutton.Location = new System.Drawing.Point(610, 264);
            this.Insertarbutton.Name = "Insertarbutton";
            this.Insertarbutton.Size = new System.Drawing.Size(75, 23);
            this.Insertarbutton.TabIndex = 9;
            this.Insertarbutton.Text = "Insertar";
            this.Insertarbutton.UseVisualStyleBackColor = true;
            this.Insertarbutton.Click += new System.EventHandler(this.Insertarbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.Insertarbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditorialtextBox);
            this.Controls.Add(this.AñotextBox);
            this.Controls.Add(this.TitulotextBox);
            this.Controls.Add(this.ISBNtextBox);
            this.Controls.Add(this.LibrosdataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibrosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LibrosdataGridView;
        private System.Windows.Forms.TextBox ISBNtextBox;
        private System.Windows.Forms.TextBox TitulotextBox;
        private System.Windows.Forms.TextBox AñotextBox;
        private System.Windows.Forms.TextBox EditorialtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Insertarbutton;
    }
}

