﻿namespace ReadmeGenerator_Winforms
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_LoadXML = new System.Windows.Forms.Button();
            this.lbl_XMLPath = new System.Windows.Forms.Label();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txtbox_Readme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.Location = new System.Drawing.Point(307, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(179, 25);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Readme Generator";
            // 
            // btn_LoadXML
            // 
            this.btn_LoadXML.Location = new System.Drawing.Point(61, 57);
            this.btn_LoadXML.Name = "btn_LoadXML";
            this.btn_LoadXML.Size = new System.Drawing.Size(125, 23);
            this.btn_LoadXML.TabIndex = 1;
            this.btn_LoadXML.Text = "Load XML File";
            this.btn_LoadXML.UseVisualStyleBackColor = true;
            this.btn_LoadXML.Click += new System.EventHandler(this.btn_LoadXML_Click);
            // 
            // lbl_XMLPath
            // 
            this.lbl_XMLPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_XMLPath.Location = new System.Drawing.Point(62, 93);
            this.lbl_XMLPath.Name = "lbl_XMLPath";
            this.lbl_XMLPath.Size = new System.Drawing.Size(125, 23);
            this.lbl_XMLPath.TabIndex = 2;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(249, 57);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(125, 23);
            this.btn_Generate.TabIndex = 3;
            this.btn_Generate.Text = "Generate Readme";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(434, 57);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(125, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save File";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(614, 57);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(125, 23);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txtbox_Readme
            // 
            this.txtbox_Readme.AcceptsReturn = true;
            this.txtbox_Readme.Enabled = false;
            this.txtbox_Readme.Location = new System.Drawing.Point(38, 151);
            this.txtbox_Readme.Multiline = true;
            this.txtbox_Readme.Name = "txtbox_Readme";
            this.txtbox_Readme.Size = new System.Drawing.Size(730, 482);
            this.txtbox_Readme.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.txtbox_Readme);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.lbl_XMLPath);
            this.Controls.Add(this.btn_LoadXML);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Title;
        private Button btn_LoadXML;
        private Label lbl_XMLPath;
        private Button btn_Generate;
        private Button btn_Save;
        private Button btn_Exit;
        private TextBox txtbox_Readme;
    }
}