namespace Vista
{
    partial class AddProductoForm
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
            this.productoDesc = new System.Windows.Forms.TextBox();
            this.decripcion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productoDesc
            // 
            this.productoDesc.Location = new System.Drawing.Point(115, 140);
            this.productoDesc.Name = "productoDesc";
            this.productoDesc.Size = new System.Drawing.Size(100, 23);
            this.productoDesc.TabIndex = 0;
            // 
            // decripcion
            // 
            this.decripcion.AutoSize = true;
            this.decripcion.Location = new System.Drawing.Point(34, 143);
            this.decripcion.Name = "decripcion";
            this.decripcion.Size = new System.Drawing.Size(68, 15);
            this.decripcion.TabIndex = 1;
            this.decripcion.Text = "descripcion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.decripcion);
            this.Controls.Add(this.productoDesc);
            this.Name = "AddProductoForm";
            this.Text = "AddProductoForm";
            this.Load += new System.EventHandler(this.AddProductoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox productoDesc;
        private Label decripcion;
        private Button button1;
    }
}