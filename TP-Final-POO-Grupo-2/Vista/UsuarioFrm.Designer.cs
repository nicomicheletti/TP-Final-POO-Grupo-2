namespace Vista
{
    partial class UsuarioFrm
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
            this.nombreValue = new System.Windows.Forms.TextBox();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.dniValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.perfilCombobox = new System.Windows.Forms.ComboBox();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contraseñaValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreValue
            // 
            this.nombreValue.Location = new System.Drawing.Point(153, 22);
            this.nombreValue.Name = "nombreValue";
            this.nombreValue.Size = new System.Drawing.Size(100, 23);
            this.nombreValue.TabIndex = 0;
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(153, 63);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(100, 23);
            this.emailValue.TabIndex = 1;
            // 
            // dniValue
            // 
            this.dniValue.Location = new System.Drawing.Point(153, 153);
            this.dniValue.Name = "dniValue";
            this.dniValue.Size = new System.Drawing.Size(100, 23);
            this.dniValue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dni";
            // 
            // perfilCombobox
            // 
            this.perfilCombobox.DataSource = this.perfilBindingSource;
            this.perfilCombobox.FormattingEnabled = true;
            this.perfilCombobox.Location = new System.Drawing.Point(153, 197);
            this.perfilCombobox.Name = "perfilCombobox";
            this.perfilCombobox.Size = new System.Drawing.Size(100, 23);
            this.perfilCombobox.TabIndex = 6;
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataSource = typeof(Modelo.Perfil);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Perfil";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(84, 237);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contraseñaValue
            // 
            this.contraseñaValue.Location = new System.Drawing.Point(153, 109);
            this.contraseñaValue.Name = "contraseñaValue";
            this.contraseñaValue.Size = new System.Drawing.Size(100, 23);
            this.contraseñaValue.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contraseña";
            // 
            // UsuarioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 337);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contraseñaValue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.perfilCombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dniValue);
            this.Controls.Add(this.emailValue);
            this.Controls.Add(this.nombreValue);
            this.Name = "UsuarioFrm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.UsuarioFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nombreValue;
        private TextBox emailValue;
        private TextBox dniValue;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox perfilCombobox;
        private Label label4;
        private Button btnGuardar;
        private Button button2;
        private BindingSource perfilBindingSource;
        private TextBox contraseñaValue;
        private Label label5;
    }
}