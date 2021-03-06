﻿namespace AnalisisNumerico.UI
{
    partial class MenuForm
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
            this.raicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodosCerradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biseccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglaFalsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodosAbiertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonRaphsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaDeEcuacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussJordanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussSeidelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raicesToolStripMenuItem,
            this.sistemaDeEcuacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(141, 224);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // raicesToolStripMenuItem
            // 
            this.raicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodosCerradosToolStripMenuItem,
            this.metodosAbiertosToolStripMenuItem});
            this.raicesToolStripMenuItem.Name = "raicesToolStripMenuItem";
            this.raicesToolStripMenuItem.Size = new System.Drawing.Size(134, 19);
            this.raicesToolStripMenuItem.Text = "Raices";
            // 
            // metodosCerradosToolStripMenuItem
            // 
            this.metodosCerradosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biseccionToolStripMenuItem,
            this.reglaFalsaToolStripMenuItem});
            this.metodosCerradosToolStripMenuItem.Name = "metodosCerradosToolStripMenuItem";
            this.metodosCerradosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.metodosCerradosToolStripMenuItem.Text = "Metodos Cerrados";
            // 
            // biseccionToolStripMenuItem
            // 
            this.biseccionToolStripMenuItem.Name = "biseccionToolStripMenuItem";
            this.biseccionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.biseccionToolStripMenuItem.Text = "Biseccion";
            this.biseccionToolStripMenuItem.Click += new System.EventHandler(this.BiseccionToolStripMenuItem_Click);
            // 
            // reglaFalsaToolStripMenuItem
            // 
            this.reglaFalsaToolStripMenuItem.Name = "reglaFalsaToolStripMenuItem";
            this.reglaFalsaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.reglaFalsaToolStripMenuItem.Text = "Regla Falsa";
            this.reglaFalsaToolStripMenuItem.Click += new System.EventHandler(this.ReglaFalsaToolStripMenuItem_Click);
            // 
            // metodosAbiertosToolStripMenuItem
            // 
            this.metodosAbiertosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtonRaphsonToolStripMenuItem,
            this.secanteToolStripMenuItem});
            this.metodosAbiertosToolStripMenuItem.Name = "metodosAbiertosToolStripMenuItem";
            this.metodosAbiertosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.metodosAbiertosToolStripMenuItem.Text = "Metodos Abiertos";
            // 
            // newtonRaphsonToolStripMenuItem
            // 
            this.newtonRaphsonToolStripMenuItem.Name = "newtonRaphsonToolStripMenuItem";
            this.newtonRaphsonToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.newtonRaphsonToolStripMenuItem.Text = "Newton-Raphson (Tangente)";
            this.newtonRaphsonToolStripMenuItem.Click += new System.EventHandler(this.NewtonRaphsonToolStripMenuItem_Click);
            // 
            // secanteToolStripMenuItem
            // 
            this.secanteToolStripMenuItem.Name = "secanteToolStripMenuItem";
            this.secanteToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.secanteToolStripMenuItem.Text = "Secante";
            this.secanteToolStripMenuItem.Click += new System.EventHandler(this.SecanteToolStripMenuItem_Click);
            // 
            // sistemaDeEcuacionesToolStripMenuItem
            // 
            this.sistemaDeEcuacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussJordanToolStripMenuItem,
            this.gaussSeidelToolStripMenuItem});
            this.sistemaDeEcuacionesToolStripMenuItem.Name = "sistemaDeEcuacionesToolStripMenuItem";
            this.sistemaDeEcuacionesToolStripMenuItem.Size = new System.Drawing.Size(134, 19);
            this.sistemaDeEcuacionesToolStripMenuItem.Text = "Sistema de Ecuaciones";
            // 
            // gaussJordanToolStripMenuItem
            // 
            this.gaussJordanToolStripMenuItem.Name = "gaussJordanToolStripMenuItem";
            this.gaussJordanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gaussJordanToolStripMenuItem.Text = "Gauss-Jordan";
            this.gaussJordanToolStripMenuItem.Click += new System.EventHandler(this.GaussJordanToolStripMenuItem_Click);
            // 
            // gaussSeidelToolStripMenuItem
            // 
            this.gaussSeidelToolStripMenuItem.Name = "gaussSeidelToolStripMenuItem";
            this.gaussSeidelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gaussSeidelToolStripMenuItem.Text = "Gauss-Seidel";
            this.gaussSeidelToolStripMenuItem.Click += new System.EventHandler(this.GaussSeidelToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 224);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodosCerradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biseccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reglaFalsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodosAbiertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtonRaphsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaDeEcuacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussJordanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussSeidelToolStripMenuItem;
    }
}