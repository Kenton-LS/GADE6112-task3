﻿namespace GADE6112___Task3
{
    partial class FrmMain
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
            this.btnStartPauseSim = new System.Windows.Forms.Button();
            this.lblMap = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblBuildings = new System.Windows.Forms.Label();
            this.tbxUnitsInfo = new System.Windows.Forms.TextBox();
            this.tbxBuildingsInfo = new System.Windows.Forms.TextBox();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbxDetails = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartPauseSim
            // 
            this.btnStartPauseSim.Location = new System.Drawing.Point(838, 129);
            this.btnStartPauseSim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartPauseSim.Name = "btnStartPauseSim";
            this.btnStartPauseSim.Size = new System.Drawing.Size(229, 33);
            this.btnStartPauseSim.TabIndex = 0;
            this.btnStartPauseSim.Text = "START";
            this.btnStartPauseSim.UseVisualStyleBackColor = true;
            this.btnStartPauseSim.Click += new System.EventHandler(this.BtnStartPauseSim_Click);
            // 
            // lblMap
            // 
            this.lblMap.BackColor = System.Drawing.Color.White;
            this.lblMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMap.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap.Location = new System.Drawing.Point(12, 11);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(805, 692);
            this.lblMap.TabIndex = 1;
            this.lblMap.Text = "EMPTY MAP";
            this.lblMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRound
            // 
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(1094, 9);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(228, 31);
            this.lblRound.TabIndex = 3;
            this.lblRound.Text = "Round: 0";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(838, 205);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(229, 33);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(838, 167);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(229, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUnits
            // 
            this.lblUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.Location = new System.Drawing.Point(1094, 61);
            this.lblUnits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(228, 18);
            this.lblUnits.TabIndex = 7;
            this.lblUnits.Text = "Units";
            this.lblUnits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBuildings
            // 
            this.lblBuildings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildings.Location = new System.Drawing.Point(1093, 381);
            this.lblBuildings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuildings.Name = "lblBuildings";
            this.lblBuildings.Size = new System.Drawing.Size(229, 19);
            this.lblBuildings.TabIndex = 8;
            this.lblBuildings.Text = "Buildings";
            this.lblBuildings.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxUnitsInfo
            // 
            this.tbxUnitsInfo.Location = new System.Drawing.Point(1094, 82);
            this.tbxUnitsInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUnitsInfo.Multiline = true;
            this.tbxUnitsInfo.Name = "tbxUnitsInfo";
            this.tbxUnitsInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxUnitsInfo.Size = new System.Drawing.Size(228, 286);
            this.tbxUnitsInfo.TabIndex = 14;
            // 
            // tbxBuildingsInfo
            // 
            this.tbxBuildingsInfo.Location = new System.Drawing.Point(1094, 404);
            this.tbxBuildingsInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxBuildingsInfo.Multiline = true;
            this.tbxBuildingsInfo.Name = "tbxBuildingsInfo";
            this.tbxBuildingsInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxBuildingsInfo.Size = new System.Drawing.Size(228, 299);
            this.tbxBuildingsInfo.TabIndex = 15;
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(954, 83);
            this.numHeight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(113, 22);
            this.numHeight.TabIndex = 16;
            this.numHeight.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numHeight.ValueChanged += new System.EventHandler(this.NumHeight_ValueChanged);
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(838, 83);
            this.numWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(113, 22);
            this.numWidth.TabIndex = 17;
            this.numWidth.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWidth.ValueChanged += new System.EventHandler(this.NumWidth_ValueChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(900, 61);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(51, 18);
            this.lblWidth.TabIndex = 18;
            this.lblWidth.Text = "Width";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(1011, 61);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(56, 18);
            this.lblHeight.TabIndex = 19;
            this.lblHeight.Text = "Height";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxDetails
            // 
            this.tbxDetails.BackColor = System.Drawing.Color.White;
            this.tbxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDetails.Location = new System.Drawing.Point(838, 258);
            this.tbxDetails.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDetails.Multiline = true;
            this.tbxDetails.Name = "tbxDetails";
            this.tbxDetails.Size = new System.Drawing.Size(228, 445);
            this.tbxDetails.TabIndex = 20;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1345, 721);
            this.Controls.Add(this.tbxDetails);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.tbxBuildingsInfo);
            this.Controls.Add(this.tbxUnitsInfo);
            this.Controls.Add(this.lblBuildings);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.btnStartPauseSim);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "GADE6211 - Task2";
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartPauseSim;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblBuildings;
        private System.Windows.Forms.TextBox tbxUnitsInfo;
        private System.Windows.Forms.TextBox tbxBuildingsInfo;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox tbxDetails;
    }
}

