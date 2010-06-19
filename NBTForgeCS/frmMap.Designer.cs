﻿namespace MineEdit
{
    partial class frmMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMap));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tscbMaterial = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuBrush3D = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBrushSphere = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBrushHollow = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbBrushSize = new System.Windows.Forms.ToolStripComboBox();
            this.cbViewingStyle = new System.Windows.Forms.ToolStripComboBox();
            this.tclMap = new System.Windows.Forms.TabControl();
            this.tabMap = new System.Windows.Forms.TabPage();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.invMain = new MineEdit.Inventory();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdApply = new System.Windows.Forms.Button();
            this.cmdHeal = new System.Windows.Forms.Button();
            this.cmdSpawn = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numVelZ = new System.Windows.Forms.NumericUpDown();
            this.numPosZ = new System.Windows.Forms.NumericUpDown();
            this.numVelY = new System.Windows.Forms.NumericUpDown();
            this.numVelX = new System.Windows.Forms.NumericUpDown();
            this.numPosY = new System.Windows.Forms.NumericUpDown();
            this.numPosX = new System.Windows.Forms.NumericUpDown();
            this.numFire = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numHealth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mapPic = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.tclMap.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVelZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVelY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVelX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapPic)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbMaterial,
            this.toolStripDropDownButton1,
            this.tscbBrushSize,
            this.cbViewingStyle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(569, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tscbMaterial
            // 
            this.tscbMaterial.Name = "tscbMaterial";
            this.tscbMaterial.Size = new System.Drawing.Size(121, 25);
            this.tscbMaterial.Text = "Materials...";
            this.tscbMaterial.SelectedIndexChanged += new System.EventHandler(this.tscbMaterial_SelectedIndexChanged);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBrush3D,
            this.mnuBrushSphere,
            this.mnuBrushHollow});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(80, 22);
            this.toolStripDropDownButton1.Text = "Brush Flags";
            // 
            // mnuBrush3D
            // 
            this.mnuBrush3D.Name = "mnuBrush3D";
            this.mnuBrush3D.Size = new System.Drawing.Size(122, 22);
            this.mnuBrush3D.Text = "3D";
            this.mnuBrush3D.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // mnuBrushSphere
            // 
            this.mnuBrushSphere.Name = "mnuBrushSphere";
            this.mnuBrushSphere.Size = new System.Drawing.Size(122, 22);
            this.mnuBrushSphere.Text = "Spherical";
            this.mnuBrushSphere.Click += new System.EventHandler(this.mnuBrushSphere_Click);
            // 
            // mnuBrushHollow
            // 
            this.mnuBrushHollow.Name = "mnuBrushHollow";
            this.mnuBrushHollow.Size = new System.Drawing.Size(122, 22);
            this.mnuBrushHollow.Text = "Hollow";
            this.mnuBrushHollow.Click += new System.EventHandler(this.mnuBrushHollow_Click);
            // 
            // tscbBrushSize
            // 
            this.tscbBrushSize.DropDownWidth = 64;
            this.tscbBrushSize.Name = "tscbBrushSize";
            this.tscbBrushSize.Size = new System.Drawing.Size(75, 25);
            this.tscbBrushSize.Text = "Brush Size";
            // 
            // cbViewingStyle
            // 
            this.cbViewingStyle.Items.AddRange(new object[] {
            "Top Down",
            "Slice E-W",
            "Slice N-S"});
            this.cbViewingStyle.Name = "cbViewingStyle";
            this.cbViewingStyle.Size = new System.Drawing.Size(121, 25);
            this.cbViewingStyle.SelectedIndexChanged += new System.EventHandler(this.cbViewingStyle_SelectedIndexChanged);
            // 
            // tclMap
            // 
            this.tclMap.Controls.Add(this.tabMap);
            this.tclMap.Controls.Add(this.tabInventory);
            this.tclMap.Controls.Add(this.tabPage1);
            this.tclMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclMap.Location = new System.Drawing.Point(0, 25);
            this.tclMap.Name = "tclMap";
            this.tclMap.SelectedIndex = 0;
            this.tclMap.Size = new System.Drawing.Size(569, 318);
            this.tclMap.TabIndex = 2;
            // 
            // tabMap
            // 
            this.tabMap.Location = new System.Drawing.Point(4, 22);
            this.tabMap.Name = "tabMap";
            this.tabMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabMap.Size = new System.Drawing.Size(561, 292);
            this.tabMap.TabIndex = 0;
            this.tabMap.Text = "Map";
            this.tabMap.UseVisualStyleBackColor = true;
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.invMain);
            this.tabInventory.Location = new System.Drawing.Point(4, 22);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(561, 292);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // invMain
            // 
            this.invMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invMain.Location = new System.Drawing.Point(3, 3);
            this.invMain.Map = null;
            this.invMain.Name = "invMain";
            this.invMain.Size = new System.Drawing.Size(555, 286);
            this.invMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmdApply);
            this.tabPage1.Controls.Add(this.cmdHeal);
            this.tabPage1.Controls.Add(this.cmdSpawn);
            this.tabPage1.Controls.Add(this.cmdStop);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numVelZ);
            this.tabPage1.Controls.Add(this.numPosZ);
            this.tabPage1.Controls.Add(this.numVelY);
            this.tabPage1.Controls.Add(this.numVelX);
            this.tabPage1.Controls.Add(this.numPosY);
            this.tabPage1.Controls.Add(this.numPosX);
            this.tabPage1.Controls.Add(this.numFire);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numHealth);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 292);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Player";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmdApply
            // 
            this.cmdApply.Location = new System.Drawing.Point(123, 137);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(75, 23);
            this.cmdApply.TabIndex = 10;
            this.cmdApply.Text = "&Apply";
            this.cmdApply.UseVisualStyleBackColor = true;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // cmdHeal
            // 
            this.cmdHeal.Location = new System.Drawing.Point(249, 19);
            this.cmdHeal.Name = "cmdHeal";
            this.cmdHeal.Size = new System.Drawing.Size(75, 23);
            this.cmdHeal.TabIndex = 9;
            this.cmdHeal.Text = "Heal";
            this.cmdHeal.UseVisualStyleBackColor = true;
            this.cmdHeal.Click += new System.EventHandler(this.cmdHeal_Click);
            // 
            // cmdSpawn
            // 
            this.cmdSpawn.Location = new System.Drawing.Point(501, 71);
            this.cmdSpawn.Name = "cmdSpawn";
            this.cmdSpawn.Size = new System.Drawing.Size(54, 23);
            this.cmdSpawn.TabIndex = 8;
            this.cmdSpawn.Text = "Spawn";
            this.cmdSpawn.UseVisualStyleBackColor = true;
            this.cmdSpawn.Click += new System.EventHandler(this.cmdSpawn_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(501, 97);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(54, 23);
            this.cmdStop.TabIndex = 7;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Velocity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Position:";
            // 
            // numVelZ
            // 
            this.numVelZ.Location = new System.Drawing.Point(375, 100);
            this.numVelZ.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numVelZ.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numVelZ.Name = "numVelZ";
            this.numVelZ.Size = new System.Drawing.Size(120, 20);
            this.numVelZ.TabIndex = 4;
            // 
            // numPosZ
            // 
            this.numPosZ.Location = new System.Drawing.Point(375, 74);
            this.numPosZ.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPosZ.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numPosZ.Name = "numPosZ";
            this.numPosZ.Size = new System.Drawing.Size(120, 20);
            this.numPosZ.TabIndex = 4;
            // 
            // numVelY
            // 
            this.numVelY.Location = new System.Drawing.Point(249, 100);
            this.numVelY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numVelY.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numVelY.Name = "numVelY";
            this.numVelY.Size = new System.Drawing.Size(120, 20);
            this.numVelY.TabIndex = 4;
            // 
            // numVelX
            // 
            this.numVelX.Location = new System.Drawing.Point(123, 100);
            this.numVelX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numVelX.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numVelX.Name = "numVelX";
            this.numVelX.Size = new System.Drawing.Size(120, 20);
            this.numVelX.TabIndex = 4;
            // 
            // numPosY
            // 
            this.numPosY.Location = new System.Drawing.Point(249, 74);
            this.numPosY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPosY.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numPosY.Name = "numPosY";
            this.numPosY.Size = new System.Drawing.Size(120, 20);
            this.numPosY.TabIndex = 4;
            // 
            // numPosX
            // 
            this.numPosX.Location = new System.Drawing.Point(123, 74);
            this.numPosX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPosX.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numPosX.Name = "numPosX";
            this.numPosX.Size = new System.Drawing.Size(120, 20);
            this.numPosX.TabIndex = 4;
            // 
            // numFire
            // 
            this.numFire.Location = new System.Drawing.Point(123, 48);
            this.numFire.Minimum = new decimal(new int[] {
            21,
            0,
            0,
            -2147483648});
            this.numFire.Name = "numFire";
            this.numFire.Size = new System.Drawing.Size(120, 20);
            this.numFire.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fire:";
            // 
            // numHealth
            // 
            this.numHealth.Location = new System.Drawing.Point(123, 22);
            this.numHealth.Name = "numHealth";
            this.numHealth.Size = new System.Drawing.Size(120, 20);
            this.numHealth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health:";
            // 
            // mapPic
            // 
            this.mapPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPic.Location = new System.Drawing.Point(0, 0);
            this.mapPic.Name = "mapPic";
            this.mapPic.Size = new System.Drawing.Size(569, 343);
            this.mapPic.TabIndex = 0;
            this.mapPic.TabStop = false;
            // 
            // frmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 343);
            this.Controls.Add(this.tclMap);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mapPic);
            this.Name = "frmMap";
            this.Text = "frmMap";
            this.Load += new System.EventHandler(this.frmMap_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMap_Paint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tclMap.ResumeLayout(false);
            this.tabInventory.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVelZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVelY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVelX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mapPic;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tscbMaterial;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mnuBrush3D;
        private System.Windows.Forms.ToolStripMenuItem mnuBrushSphere;
        private System.Windows.Forms.ToolStripMenuItem mnuBrushHollow;
        private System.Windows.Forms.ToolStripComboBox tscbBrushSize;
        private System.Windows.Forms.ToolStripComboBox cbViewingStyle;
        private System.Windows.Forms.TabControl tclMap;
        private System.Windows.Forms.TabPage tabMap;
        private System.Windows.Forms.TabPage tabInventory;
        private Inventory invMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cmdHeal;
        private System.Windows.Forms.Button cmdSpawn;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numVelZ;
        private System.Windows.Forms.NumericUpDown numPosZ;
        private System.Windows.Forms.NumericUpDown numVelY;
        private System.Windows.Forms.NumericUpDown numVelX;
        private System.Windows.Forms.NumericUpDown numPosY;
        private System.Windows.Forms.NumericUpDown numPosX;
        private System.Windows.Forms.NumericUpDown numFire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdApply;

    }
}