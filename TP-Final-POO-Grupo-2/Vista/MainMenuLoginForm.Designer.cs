﻿namespace Vista
{
    partial class MainMenuLoginForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formGestionarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.formUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.formProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formGestionarUsuarios,
            this.formUsuario,
            this.formProducto});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // formGestionarUsuarios
            // 
            this.formGestionarUsuarios.Enabled = false;
            this.formGestionarUsuarios.Name = "formGestionarUsuarios";
            this.formGestionarUsuarios.Size = new System.Drawing.Size(180, 22);
            this.formGestionarUsuarios.Text = "Gestionar";
            this.formGestionarUsuarios.Click += new System.EventHandler(this.formGestionarUsuarios_Click);
            // 
            // formUsuario
            // 
            this.formUsuario.Enabled = false;
            this.formUsuario.Name = "formUsuario";
            this.formUsuario.Size = new System.Drawing.Size(180, 22);
            this.formUsuario.Text = "Agregar";
            this.formUsuario.Click += new System.EventHandler(this.formUsuario_Click);
            // 
            // formProducto
            // 
            this.formProducto.Enabled = false;
            this.formProducto.Name = "formProducto";
            this.formProducto.Size = new System.Drawing.Size(180, 22);
            this.formProducto.Text = "Producto";
            this.formProducto.Click += new System.EventHandler(this.formProducto_Click);
            // 
            // MainMenuLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenuLoginForm";
            this.Text = "MainMenuLoginForm";
            this.Load += new System.EventHandler(this.MainMenuLoginForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem formGestionarUsuarios;
        private ToolStripMenuItem formUsuario;
        private ToolStripMenuItem formProducto;
    }
}