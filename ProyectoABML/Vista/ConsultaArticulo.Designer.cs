namespace Vista
{
    partial class ConsultaArticulo
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
            this.dvgArticulo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgArticulo
            // 
            this.dvgArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgArticulo.Location = new System.Drawing.Point(29, 12);
            this.dvgArticulo.Name = "dvgArticulo";
            this.dvgArticulo.Size = new System.Drawing.Size(742, 324);
            this.dvgArticulo.TabIndex = 0;
            // 
            // ConsultaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvgArticulo);
            this.Name = "ConsultaArticulo";
            this.Text = "ConsultaArticulo";
            this.Load += new System.EventHandler(this.ConsultaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgArticulo;
    }
}