﻿
namespace EDEapp
{
    partial class CreateBooking_SelectServiceType
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
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_backMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_import
            // 
            this.btn_import.Font = new System.Drawing.Font("PMingLiU", 30F);
            this.btn_import.Location = new System.Drawing.Point(123, 100);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(250, 250);
            this.btn_import.TabIndex = 0;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("PMingLiU", 30F);
            this.btn_export.Location = new System.Drawing.Point(423, 100);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(250, 250);
            this.btn_export.TabIndex = 1;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_backMenu
            // 
            this.btn_backMenu.Location = new System.Drawing.Point(12, 12);
            this.btn_backMenu.Name = "btn_backMenu";
            this.btn_backMenu.Size = new System.Drawing.Size(116, 21);
            this.btn_backMenu.TabIndex = 4;
            this.btn_backMenu.Text = "Back To Menu";
            this.btn_backMenu.UseVisualStyleBackColor = true;
            this.btn_backMenu.Click += new System.EventHandler(this.btn_backMenu_Click);
            // 
            // CreateBooking_SelectServiceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_backMenu);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_import);
            this.Name = "CreateBooking_SelectServiceType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateBooking_SelectServiceType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_backMenu;
    }
}