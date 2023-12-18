﻿
namespace Tyuiu.GrigorjanAM.Sprint7.Project.V9
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialogMain_GAM = new System.Windows.Forms.OpenFileDialog();
            this.panelUpper_GAM = new System.Windows.Forms.Panel();
            this.panelDown_GAM = new System.Windows.Forms.Panel();
            this.panelMiddle_GAM = new System.Windows.Forms.Panel();
            this.buttonLoad_GAM = new System.Windows.Forms.Button();
            this.buttonSave_GAM = new System.Windows.Forms.Button();
            this.pictureBoxLoad_GAM = new System.Windows.Forms.PictureBox();
            this.pictureBoxSave_GAM = new System.Windows.Forms.PictureBox();
            this.buttonManagement_GAM = new System.Windows.Forms.Button();
            this.buttonAbout_GAM = new System.Windows.Forms.Button();
            this.pictureBoxManagement_GAM = new System.Windows.Forms.PictureBox();
            this.pictureBoxAbout_GAM = new System.Windows.Forms.PictureBox();
            this.groupBoxBase_GAM = new System.Windows.Forms.GroupBox();
            this.dataGridViewBase_GAM = new System.Windows.Forms.DataGridView();
            this.buttonSort_GAM = new System.Windows.Forms.Button();
            this.pictureBoxSort_GAM = new System.Windows.Forms.PictureBox();
            this.pictureBoxFilter_GAM = new System.Windows.Forms.PictureBox();
            this.buttonFilter_GAM = new System.Windows.Forms.Button();
            this.buttonRight_GAM = new System.Windows.Forms.Button();
            this.buttonLeft_GAM = new System.Windows.Forms.Button();
            this.panelUpper_GAM.SuspendLayout();
            this.panelDown_GAM.SuspendLayout();
            this.panelMiddle_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoad_GAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave_GAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManagement_GAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_GAM)).BeginInit();
            this.groupBoxBase_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase_GAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSort_GAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter_GAM)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogMain_GAM
            // 
            this.openFileDialogMain_GAM.FileName = "openFileDialog1";
            // 
            // panelUpper_GAM
            // 
            this.panelUpper_GAM.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelUpper_GAM.Controls.Add(this.pictureBoxAbout_GAM);
            this.panelUpper_GAM.Controls.Add(this.pictureBoxSave_GAM);
            this.panelUpper_GAM.Controls.Add(this.pictureBoxManagement_GAM);
            this.panelUpper_GAM.Controls.Add(this.pictureBoxLoad_GAM);
            this.panelUpper_GAM.Controls.Add(this.buttonAbout_GAM);
            this.panelUpper_GAM.Controls.Add(this.buttonSave_GAM);
            this.panelUpper_GAM.Controls.Add(this.buttonManagement_GAM);
            this.panelUpper_GAM.Controls.Add(this.buttonLoad_GAM);
            this.panelUpper_GAM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpper_GAM.Location = new System.Drawing.Point(0, 0);
            this.panelUpper_GAM.Name = "panelUpper_GAM";
            this.panelUpper_GAM.Size = new System.Drawing.Size(804, 49);
            this.panelUpper_GAM.TabIndex = 0;
            // 
            // panelDown_GAM
            // 
            this.panelDown_GAM.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelDown_GAM.Controls.Add(this.buttonLeft_GAM);
            this.panelDown_GAM.Controls.Add(this.buttonRight_GAM);
            this.panelDown_GAM.Controls.Add(this.buttonFilter_GAM);
            this.panelDown_GAM.Controls.Add(this.pictureBoxFilter_GAM);
            this.panelDown_GAM.Controls.Add(this.buttonSort_GAM);
            this.panelDown_GAM.Controls.Add(this.pictureBoxSort_GAM);
            this.panelDown_GAM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown_GAM.Location = new System.Drawing.Point(0, 412);
            this.panelDown_GAM.Name = "panelDown_GAM";
            this.panelDown_GAM.Size = new System.Drawing.Size(804, 49);
            this.panelDown_GAM.TabIndex = 1;
            // 
            // panelMiddle_GAM
            // 
            this.panelMiddle_GAM.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMiddle_GAM.Controls.Add(this.groupBoxBase_GAM);
            this.panelMiddle_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle_GAM.Location = new System.Drawing.Point(0, 49);
            this.panelMiddle_GAM.Name = "panelMiddle_GAM";
            this.panelMiddle_GAM.Size = new System.Drawing.Size(804, 363);
            this.panelMiddle_GAM.TabIndex = 2;
            // 
            // buttonLoad_GAM
            // 
            this.buttonLoad_GAM.Location = new System.Drawing.Point(41, 6);
            this.buttonLoad_GAM.Name = "buttonLoad_GAM";
            this.buttonLoad_GAM.Size = new System.Drawing.Size(75, 34);
            this.buttonLoad_GAM.TabIndex = 0;
            this.buttonLoad_GAM.Text = "Выбрать файл";
            this.buttonLoad_GAM.UseVisualStyleBackColor = true;
            this.buttonLoad_GAM.Click += new System.EventHandler(this.buttonLoad_GAM_Click);
            // 
            // buttonSave_GAM
            // 
            this.buttonSave_GAM.Location = new System.Drawing.Point(162, 6);
            this.buttonSave_GAM.Name = "buttonSave_GAM";
            this.buttonSave_GAM.Size = new System.Drawing.Size(75, 34);
            this.buttonSave_GAM.TabIndex = 0;
            this.buttonSave_GAM.Text = "Сохранить файл";
            this.buttonSave_GAM.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLoad_GAM
            // 
            this.pictureBoxLoad_GAM.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoad_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLoad_GAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLoad_GAM.ErrorImage = null;
            this.pictureBoxLoad_GAM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoad_GAM.Image")));
            this.pictureBoxLoad_GAM.InitialImage = null;
            this.pictureBoxLoad_GAM.Location = new System.Drawing.Point(3, 6);
            this.pictureBoxLoad_GAM.Name = "pictureBoxLoad_GAM";
            this.pictureBoxLoad_GAM.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxLoad_GAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoad_GAM.TabIndex = 1;
            this.pictureBoxLoad_GAM.TabStop = false;
            // 
            // pictureBoxSave_GAM
            // 
            this.pictureBoxSave_GAM.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSave_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSave_GAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSave_GAM.ErrorImage = null;
            this.pictureBoxSave_GAM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSave_GAM.Image")));
            this.pictureBoxSave_GAM.InitialImage = null;
            this.pictureBoxSave_GAM.Location = new System.Drawing.Point(122, 6);
            this.pictureBoxSave_GAM.Name = "pictureBoxSave_GAM";
            this.pictureBoxSave_GAM.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxSave_GAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSave_GAM.TabIndex = 1;
            this.pictureBoxSave_GAM.TabStop = false;
            // 
            // buttonManagement_GAM
            // 
            this.buttonManagement_GAM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonManagement_GAM.Location = new System.Drawing.Point(594, 6);
            this.buttonManagement_GAM.Name = "buttonManagement_GAM";
            this.buttonManagement_GAM.Size = new System.Drawing.Size(86, 34);
            this.buttonManagement_GAM.TabIndex = 0;
            this.buttonManagement_GAM.Text = "Руководство";
            this.buttonManagement_GAM.UseVisualStyleBackColor = true;
            // 
            // buttonAbout_GAM
            // 
            this.buttonAbout_GAM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAbout_GAM.Location = new System.Drawing.Point(726, 6);
            this.buttonAbout_GAM.Name = "buttonAbout_GAM";
            this.buttonAbout_GAM.Size = new System.Drawing.Size(75, 34);
            this.buttonAbout_GAM.TabIndex = 0;
            this.buttonAbout_GAM.Text = "О программе";
            this.buttonAbout_GAM.UseVisualStyleBackColor = true;
            // 
            // pictureBoxManagement_GAM
            // 
            this.pictureBoxManagement_GAM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxManagement_GAM.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxManagement_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxManagement_GAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxManagement_GAM.ErrorImage = null;
            this.pictureBoxManagement_GAM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxManagement_GAM.Image")));
            this.pictureBoxManagement_GAM.InitialImage = null;
            this.pictureBoxManagement_GAM.Location = new System.Drawing.Point(554, 6);
            this.pictureBoxManagement_GAM.Name = "pictureBoxManagement_GAM";
            this.pictureBoxManagement_GAM.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxManagement_GAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxManagement_GAM.TabIndex = 1;
            this.pictureBoxManagement_GAM.TabStop = false;
            // 
            // pictureBoxAbout_GAM
            // 
            this.pictureBoxAbout_GAM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxAbout_GAM.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAbout_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAbout_GAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAbout_GAM.ErrorImage = null;
            this.pictureBoxAbout_GAM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout_GAM.Image")));
            this.pictureBoxAbout_GAM.InitialImage = null;
            this.pictureBoxAbout_GAM.Location = new System.Drawing.Point(686, 6);
            this.pictureBoxAbout_GAM.Name = "pictureBoxAbout_GAM";
            this.pictureBoxAbout_GAM.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxAbout_GAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAbout_GAM.TabIndex = 1;
            this.pictureBoxAbout_GAM.TabStop = false;
            // 
            // groupBoxBase_GAM
            // 
            this.groupBoxBase_GAM.Controls.Add(this.dataGridViewBase_GAM);
            this.groupBoxBase_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBase_GAM.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBase_GAM.Name = "groupBoxBase_GAM";
            this.groupBoxBase_GAM.Size = new System.Drawing.Size(804, 363);
            this.groupBoxBase_GAM.TabIndex = 0;
            this.groupBoxBase_GAM.TabStop = false;
            this.groupBoxBase_GAM.Text = "Данные";
            // 
            // dataGridViewBase_GAM
            // 
            this.dataGridViewBase_GAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBase_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBase_GAM.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewBase_GAM.Name = "dataGridViewBase_GAM";
            this.dataGridViewBase_GAM.Size = new System.Drawing.Size(798, 344);
            this.dataGridViewBase_GAM.TabIndex = 0;
            // 
            // buttonSort_GAM
            // 
            this.buttonSort_GAM.Location = new System.Drawing.Point(43, 6);
            this.buttonSort_GAM.Name = "buttonSort_GAM";
            this.buttonSort_GAM.Size = new System.Drawing.Size(75, 34);
            this.buttonSort_GAM.TabIndex = 0;
            this.buttonSort_GAM.Text = "Сортировка";
            this.buttonSort_GAM.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSort_GAM
            // 
            this.pictureBoxSort_GAM.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSort_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSort_GAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSort_GAM.ErrorImage = null;
            this.pictureBoxSort_GAM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSort_GAM.Image")));
            this.pictureBoxSort_GAM.InitialImage = null;
            this.pictureBoxSort_GAM.Location = new System.Drawing.Point(3, 6);
            this.pictureBoxSort_GAM.Name = "pictureBoxSort_GAM";
            this.pictureBoxSort_GAM.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxSort_GAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSort_GAM.TabIndex = 1;
            this.pictureBoxSort_GAM.TabStop = false;
            // 
            // pictureBoxFilter_GAM
            // 
            this.pictureBoxFilter_GAM.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFilter_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFilter_GAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFilter_GAM.ErrorImage = null;
            this.pictureBoxFilter_GAM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFilter_GAM.Image")));
            this.pictureBoxFilter_GAM.InitialImage = null;
            this.pictureBoxFilter_GAM.Location = new System.Drawing.Point(122, 6);
            this.pictureBoxFilter_GAM.Name = "pictureBoxFilter_GAM";
            this.pictureBoxFilter_GAM.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxFilter_GAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFilter_GAM.TabIndex = 1;
            this.pictureBoxFilter_GAM.TabStop = false;
            // 
            // buttonFilter_GAM
            // 
            this.buttonFilter_GAM.Location = new System.Drawing.Point(162, 6);
            this.buttonFilter_GAM.Name = "buttonFilter_GAM";
            this.buttonFilter_GAM.Size = new System.Drawing.Size(75, 34);
            this.buttonFilter_GAM.TabIndex = 0;
            this.buttonFilter_GAM.Text = "Фильтр";
            this.buttonFilter_GAM.UseVisualStyleBackColor = true;
            // 
            // buttonRight_GAM
            // 
            this.buttonRight_GAM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRight_GAM.BackColor = System.Drawing.Color.Transparent;
            this.buttonRight_GAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight_GAM.BackgroundImage")));
            this.buttonRight_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight_GAM.FlatAppearance.BorderSize = 0;
            this.buttonRight_GAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight_GAM.Location = new System.Drawing.Point(758, 6);
            this.buttonRight_GAM.Name = "buttonRight_GAM";
            this.buttonRight_GAM.Size = new System.Drawing.Size(34, 34);
            this.buttonRight_GAM.TabIndex = 0;
            this.buttonRight_GAM.UseVisualStyleBackColor = false;
            // 
            // buttonLeft_GAM
            // 
            this.buttonLeft_GAM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonLeft_GAM.BackColor = System.Drawing.Color.Transparent;
            this.buttonLeft_GAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft_GAM.BackgroundImage")));
            this.buttonLeft_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft_GAM.FlatAppearance.BorderSize = 0;
            this.buttonLeft_GAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft_GAM.Location = new System.Drawing.Point(718, 6);
            this.buttonLeft_GAM.Name = "buttonLeft_GAM";
            this.buttonLeft_GAM.Size = new System.Drawing.Size(34, 34);
            this.buttonLeft_GAM.TabIndex = 0;
            this.buttonLeft_GAM.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.panelMiddle_GAM);
            this.Controls.Add(this.panelDown_GAM);
            this.Controls.Add(this.panelUpper_GAM);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог видеоклипов";
            this.panelUpper_GAM.ResumeLayout(false);
            this.panelDown_GAM.ResumeLayout(false);
            this.panelMiddle_GAM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoad_GAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave_GAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManagement_GAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_GAM)).EndInit();
            this.groupBoxBase_GAM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase_GAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSort_GAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter_GAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialogMain_GAM;
        private System.Windows.Forms.Panel panelUpper_GAM;
        private System.Windows.Forms.PictureBox pictureBoxLoad_GAM;
        private System.Windows.Forms.Button buttonSave_GAM;
        private System.Windows.Forms.Button buttonLoad_GAM;
        private System.Windows.Forms.Panel panelDown_GAM;
        private System.Windows.Forms.Panel panelMiddle_GAM;
        private System.Windows.Forms.PictureBox pictureBoxSave_GAM;
        private System.Windows.Forms.PictureBox pictureBoxAbout_GAM;
        private System.Windows.Forms.PictureBox pictureBoxManagement_GAM;
        private System.Windows.Forms.Button buttonAbout_GAM;
        private System.Windows.Forms.Button buttonManagement_GAM;
        private System.Windows.Forms.Button buttonLeft_GAM;
        private System.Windows.Forms.Button buttonRight_GAM;
        private System.Windows.Forms.Button buttonFilter_GAM;
        private System.Windows.Forms.PictureBox pictureBoxFilter_GAM;
        private System.Windows.Forms.Button buttonSort_GAM;
        private System.Windows.Forms.PictureBox pictureBoxSort_GAM;
        private System.Windows.Forms.GroupBox groupBoxBase_GAM;
        private System.Windows.Forms.DataGridView dataGridViewBase_GAM;
    }
}
