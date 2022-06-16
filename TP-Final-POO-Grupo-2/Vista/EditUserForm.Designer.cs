namespace Vista
{
    partial class EditUserForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreValue = new System.Windows.Forms.TextBox();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.dniValue = new System.Windows.Forms.TextBox();
            this.contraseñaValue = new System.Windows.Forms.TextBox();
            this.perfilCombobox = new System.Windows.Forms.ComboBox();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreValue
            // 
            this.nombreValue.Location = new System.Drawing.Point(133, 51);
            this.nombreValue.Name = "nombreValue";
            this.nombreValue.Size = new System.Drawing.Size(100, 23);
            this.nombreValue.TabIndex = 5;
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(133, 83);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(100, 23);
            this.emailValue.TabIndex = 6;
            // 
            // dniValue
            // 
            this.dniValue.Location = new System.Drawing.Point(133, 119);
            this.dniValue.Name = "dniValue";
            this.dniValue.Size = new System.Drawing.Size(100, 23);
            this.dniValue.TabIndex = 7;
            // 
            // contraseñaValue
            // 
            this.contraseñaValue.Location = new System.Drawing.Point(133, 153);
            this.contraseñaValue.Name = "contraseñaValue";
            this.contraseñaValue.Size = new System.Drawing.Size(100, 23);
            this.contraseñaValue.TabIndex = 8;
            // 
            // perfilCombobox
            // 
            this.perfilCombobox.DataSource = this.perfilBindingSource;
            this.perfilCombobox.FormattingEnabled = true;
            this.perfilCombobox.Location = new System.Drawing.Point(133, 196);
            this.perfilCombobox.Name = "perfilCombobox";
            this.perfilCombobox.Size = new System.Drawing.Size(100, 23);
            this.perfilCombobox.TabIndex = 9;
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataSource = typeof(Modelo.Perfil);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 297);
            this.Controls.Add(this.perfilCombobox);
            this.Controls.Add(this.contraseñaValue);
            this.Controls.Add(this.dniValue);
            this.Controls.Add(this.emailValue);
            this.Controls.Add(this.nombreValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditUserForm";
            this.Text = "ModificarUsuarioFrm";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox nombreValue;
        private TextBox emailValue;
        private TextBox dniValue;
        private TextBox contraseñaValue;
        private ComboBox perfilCombobox;
        private BindingSource perfilBindingSource;
    }
}