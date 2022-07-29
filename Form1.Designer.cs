
namespace Primer__proyecto__de__formularios__en_Visual
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
            this.btnclik = new System.Windows.Forms.Button();
            this.lblholamundo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclik
            // 
            this.btnclik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclik.Location = new System.Drawing.Point(150, 124);
            this.btnclik.Name = "btnclik";
            this.btnclik.Size = new System.Drawing.Size(110, 36);
            this.btnclik.TabIndex = 0;
            this.btnclik.Text = "Haga clic ";
            this.btnclik.UseVisualStyleBackColor = true;
            this.btnclik.Click += new System.EventHandler(this.btnclik_Click);
            // 
            // lblholamundo
            // 
            this.lblholamundo.AutoSize = true;
            this.lblholamundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblholamundo.Location = new System.Drawing.Point(184, 193);
            this.lblholamundo.Name = "lblholamundo";
            this.lblholamundo.Size = new System.Drawing.Size(41, 13);
            this.lblholamundo.TabIndex = 1;
            this.lblholamundo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.lblholamundo);
            this.Controls.Add(this.btnclik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclik;
        private System.Windows.Forms.Label lblholamundo;
    }
}

