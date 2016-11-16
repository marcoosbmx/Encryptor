﻿using Encryptor.Views.Shared;

namespace Encryptor.Views.grupo
{
    partial class GrupoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrupoFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mike = new System.Windows.Forms.PictureBox();
            this.lucas = new System.Windows.Forms.PictureBox();
            this.diego = new System.Windows.Forms.PictureBox();
            this.header1 = new Encryptor.Views.Shared.Header();
            ((System.ComponentModel.ISupportInitialize)(this.mike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diego)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "GRUPO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "MARCOS GONÇALVES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "DIEGO LOPES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "LUCAS COUTINHO";
            // 
            // mike
            // 
            this.mike.Image = global::Encryptor.Properties.Resources._01;
            this.mike.Location = new System.Drawing.Point(25, 134);
            this.mike.Name = "mike";
            this.mike.Size = new System.Drawing.Size(150, 150);
            this.mike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mike.TabIndex = 4;
            this.mike.TabStop = false;
            this.mike.MouseEnter += new System.EventHandler(this.Image_1_Mike);
            this.mike.MouseLeave += new System.EventHandler(this.Image_0_Mike);
            // 
            // lucas
            // 
            this.lucas.Image = ((System.Drawing.Image)(resources.GetObject("lucas.Image")));
            this.lucas.Location = new System.Drawing.Point(546, 134);
            this.lucas.Name = "lucas";
            this.lucas.Size = new System.Drawing.Size(150, 150);
            this.lucas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lucas.TabIndex = 3;
            this.lucas.TabStop = false;
            // 
            // diego
            // 
            this.diego.Image = ((System.Drawing.Image)(resources.GetObject("diego.Image")));
            this.diego.Location = new System.Drawing.Point(291, 134);
            this.diego.Name = "diego";
            this.diego.Size = new System.Drawing.Size(150, 150);
            this.diego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diego.TabIndex = 2;
            this.diego.TabStop = false;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Transparent;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(720, 166);
            this.header1.TabIndex = 0;
            // 
            // GrupoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mike);
            this.Controls.Add(this.lucas);
            this.Controls.Add(this.diego);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrupoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.mike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Header header1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox diego;
        private System.Windows.Forms.PictureBox lucas;
        private System.Windows.Forms.PictureBox mike;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}