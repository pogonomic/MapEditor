﻿/*
 * MapEditor
 * Пользователь: AngryKirC
 * Copyleft - Public Domain
 * Дата: 09.11.2014
 */
namespace MapEditor.XferGui
{
	partial class TriggerEdit
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBoxArea = new System.Windows.Forms.GroupBox();
            this.plateBackColor = new System.Windows.Forms.Button();
            this.plateEdgeColor = new System.Windows.Forms.Button();
            this.sizeY = new System.Windows.Forms.NumericUpDown();
            this.sizeX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.scriptCollided = new System.Windows.Forms.ComboBox();
            this.scriptReleased = new System.Windows.Forms.ComboBox();
            this.scriptActivated = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.flagsBox = new System.Windows.Forms.CheckedListBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxArea
            // 
            this.groupBoxArea.Controls.Add(this.plateBackColor);
            this.groupBoxArea.Controls.Add(this.plateEdgeColor);
            this.groupBoxArea.Controls.Add(this.sizeY);
            this.groupBoxArea.Controls.Add(this.sizeX);
            this.groupBoxArea.Controls.Add(this.label2);
            this.groupBoxArea.Controls.Add(this.label1);
            this.groupBoxArea.Location = new System.Drawing.Point(12, 133);
            this.groupBoxArea.Name = "groupBoxArea";
            this.groupBoxArea.Size = new System.Drawing.Size(211, 130);
            this.groupBoxArea.TabIndex = 0;
            this.groupBoxArea.TabStop = false;
            this.groupBoxArea.Text = "Trigger/PressurePlate only";
            // 
            // plateBackColor
            // 
            this.plateBackColor.ForeColor = System.Drawing.Color.White;
            this.plateBackColor.Location = new System.Drawing.Point(106, 79);
            this.plateBackColor.Name = "plateBackColor";
            this.plateBackColor.Size = new System.Drawing.Size(95, 37);
            this.plateBackColor.TabIndex = 1;
            this.plateBackColor.Text = "Secondary";
            this.plateBackColor.UseVisualStyleBackColor = true;
            this.plateBackColor.Click += new System.EventHandler(this.PlateBackColorClick);
            // 
            // plateEdgeColor
            // 
            this.plateEdgeColor.Location = new System.Drawing.Point(9, 79);
            this.plateEdgeColor.Name = "plateEdgeColor";
            this.plateEdgeColor.Size = new System.Drawing.Size(95, 37);
            this.plateEdgeColor.TabIndex = 1;
            this.plateEdgeColor.Text = "Primary Color";
            this.plateEdgeColor.UseVisualStyleBackColor = true;
            this.plateEdgeColor.Click += new System.EventHandler(this.PlateEdgeColorClick);
            // 
            // sizeY
            // 
            this.sizeY.Location = new System.Drawing.Point(89, 47);
            this.sizeY.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.sizeY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeY.Name = "sizeY";
            this.sizeY.Size = new System.Drawing.Size(103, 20);
            this.sizeY.TabIndex = 3;
            this.sizeY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sizeX
            // 
            this.sizeX.Location = new System.Drawing.Point(89, 25);
            this.sizeX.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.sizeX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeX.Name = "sizeX";
            this.sizeX.Size = new System.Drawing.Size(103, 20);
            this.sizeX.TabIndex = 2;
            this.sizeX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.scriptCollided);
            this.groupBox2.Controls.Add(this.scriptReleased);
            this.groupBox2.Controls.Add(this.scriptActivated);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Script event handlers";
            // 
            // scriptCollided
            // 
            this.scriptCollided.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptCollided.FormattingEnabled = true;
            this.scriptCollided.Location = new System.Drawing.Point(63, 79);
            this.scriptCollided.Name = "scriptCollided";
            this.scriptCollided.Size = new System.Drawing.Size(138, 21);
            this.scriptCollided.TabIndex = 7;
            // 
            // scriptReleased
            // 
            this.scriptReleased.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptReleased.FormattingEnabled = true;
            this.scriptReleased.Location = new System.Drawing.Point(63, 51);
            this.scriptReleased.Name = "scriptReleased";
            this.scriptReleased.Size = new System.Drawing.Size(138, 21);
            this.scriptReleased.TabIndex = 6;
            // 
            // scriptActivated
            // 
            this.scriptActivated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptActivated.FormattingEnabled = true;
            this.scriptActivated.Location = new System.Drawing.Point(63, 23);
            this.scriptActivated.Name = "scriptActivated";
            this.scriptActivated.Size = new System.Drawing.Size(138, 21);
            this.scriptActivated.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Touched";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Released";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Activated";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.flagsBox);
            this.groupBox3.Location = new System.Drawing.Point(229, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 253);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Allowed Activators";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Allowed team";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(116, 224);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // flagsBox
            // 
            this.flagsBox.FormattingEnabled = true;
            this.flagsBox.Items.AddRange(new object[] {
            "MONSTER",
            "PLAYER",
            "MISSILE",
            "OBSTACLE",
            "NPC",
            "FOOD (Solo Only)",
            "WEAPON (Solo Only)",
            "ARMOR (Solo Only)",
            "TREASURE",
            "WAND (Solo Only)",
            "MONSTERGENERATOR"});
            this.flagsBox.Location = new System.Drawing.Point(6, 19);
            this.flagsBox.Name = "flagsBox";
            this.flagsBox.Size = new System.Drawing.Size(199, 199);
            this.flagsBox.TabIndex = 2;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(187, 272);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 29);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOKClick);
            // 
            // TriggerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 307);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TriggerEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TriggerXfer";
            this.groupBoxArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button plateEdgeColor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown sizeX;
		private System.Windows.Forms.NumericUpDown sizeY;
        private System.Windows.Forms.GroupBox groupBoxArea;
        private System.Windows.Forms.CheckedListBox flagsBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox scriptCollided;
        private System.Windows.Forms.ComboBox scriptReleased;
        private System.Windows.Forms.ComboBox scriptActivated;
        private System.Windows.Forms.Button plateBackColor;
    }
}
