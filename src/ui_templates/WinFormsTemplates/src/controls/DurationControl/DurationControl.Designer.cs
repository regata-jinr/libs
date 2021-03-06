﻿/***************************************************************************
 *                                                                         *
 *                                                                         *
 * Copyright(c) 2021, REGATA Experiment at FLNP|JINR                       *
 * Author: [Boris Rumyantsev](mailto:bdrum@jinr.ru)                        *
 *                                                                         *
 * The REGATA Experiment team license this file to you under the           *
 * GNU GENERAL PUBLIC LICENSE                                              *
 *                                                                         *
 ***************************************************************************/

namespace Regata.Core.UI.WinForms.Controls
{
    partial class DurationControl
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
                DurationControlNumericUpDownDays.ValueChanged -= DurationControlNumericUpDownDays_ValueChanged;
                DurationControlNumericUpDownHours.ValueChanged -= DurationControlNumericUpDownHours_ValueChanged;
                DurationControlNumericUpDownMinutes.ValueChanged -= DurationControlNumericUpDownMinutes_ValueChanged;
                DurationControlNumericUpDownSeconds.ValueChanged -= DurationControlNumericUpDownSeconds_ValueChanged;
                components.Dispose();

            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DurationControlLabelDays = new System.Windows.Forms.Label();
            this.DurationControlNumericUpDownDays = new System.Windows.Forms.NumericUpDown();
            this.DurationControlNumericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.DurationControlLabelMinutes = new System.Windows.Forms.Label();
            this.DurationControlNumericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.DurationControlLabelSeconds = new System.Windows.Forms.Label();
            this.DurationControlLabelHours = new System.Windows.Forms.Label();
            this.DurationControlNumericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.DurationControlGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DurationControlNumericUpDownDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationControlNumericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationControlNumericUpDownSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationControlNumericUpDownHours)).BeginInit();
            this.DurationControlGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DurationControlLabelDays
            // 
            this.DurationControlLabelDays.AutoSize = true;
            this.DurationControlLabelDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurationControlLabelDays.Location = new System.Drawing.Point(4, 0);
            this.DurationControlLabelDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DurationControlLabelDays.Name = "DurationControlLabelDays";
            this.DurationControlLabelDays.Size = new System.Drawing.Size(65, 23);
            this.DurationControlLabelDays.TabIndex = 24;
            this.DurationControlLabelDays.Text = "Дни";
            this.DurationControlLabelDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DurationControlNumericUpDownDays
            // 
            this.DurationControlNumericUpDownDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurationControlNumericUpDownDays.Location = new System.Drawing.Point(1, 24);
            this.DurationControlNumericUpDownDays.Margin = new System.Windows.Forms.Padding(1);
            this.DurationControlNumericUpDownDays.Name = "DurationControlNumericUpDownDays";
            this.DurationControlNumericUpDownDays.Size = new System.Drawing.Size(71, 23);
            this.DurationControlNumericUpDownDays.TabIndex = 23;
            this.DurationControlNumericUpDownDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DurationControlNumericUpDownMinutes
            // 
            this.DurationControlNumericUpDownMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurationControlNumericUpDownMinutes.Location = new System.Drawing.Point(147, 24);
            this.DurationControlNumericUpDownMinutes.Margin = new System.Windows.Forms.Padding(1);
            this.DurationControlNumericUpDownMinutes.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DurationControlNumericUpDownMinutes.Name = "DurationControlNumericUpDownMinutes";
            this.DurationControlNumericUpDownMinutes.Size = new System.Drawing.Size(71, 23);
            this.DurationControlNumericUpDownMinutes.TabIndex = 21;
            this.DurationControlNumericUpDownMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DurationControlLabelMinutes
            // 
            this.DurationControlLabelMinutes.AutoSize = true;
            this.DurationControlLabelMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurationControlLabelMinutes.Location = new System.Drawing.Point(150, 0);
            this.DurationControlLabelMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DurationControlLabelMinutes.Name = "DurationControlLabelMinutes";
            this.DurationControlLabelMinutes.Size = new System.Drawing.Size(65, 23);
            this.DurationControlLabelMinutes.TabIndex = 22;
            this.DurationControlLabelMinutes.Text = "Мин.";
            this.DurationControlLabelMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DurationControlNumericUpDownSeconds
            // 
            this.DurationControlNumericUpDownSeconds.AutoSize = true;
            this.DurationControlNumericUpDownSeconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurationControlNumericUpDownSeconds.Location = new System.Drawing.Point(220, 24);
            this.DurationControlNumericUpDownSeconds.Margin = new System.Windows.Forms.Padding(1);
            this.DurationControlNumericUpDownSeconds.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DurationControlNumericUpDownSeconds.Name = "DurationControlNumericUpDownSeconds";
            this.DurationControlNumericUpDownSeconds.Size = new System.Drawing.Size(73, 23);
            this.DurationControlNumericUpDownSeconds.TabIndex = 17;
            this.DurationControlNumericUpDownSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DurationControlLabelSeconds
            // 
            this.DurationControlLabelSeconds.AutoSize = true;
            this.DurationControlLabelSeconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurationControlLabelSeconds.Location = new System.Drawing.Point(223, 0);
            this.DurationControlLabelSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DurationControlLabelSeconds.Name = "DurationControlLabelSeconds";
            this.DurationControlLabelSeconds.Size = new System.Drawing.Size(67, 23);
            this.DurationControlLabelSeconds.TabIndex = 25;
            this.DurationControlLabelSeconds.Text = "Сек.";
            this.DurationControlLabelSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DurationControlLabelHours
            // 
            this.DurationControlLabelHours.AutoSize = true;
            this.DurationControlLabelHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurationControlLabelHours.Location = new System.Drawing.Point(77, 0);
            this.DurationControlLabelHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DurationControlLabelHours.Name = "DurationControlLabelHours";
            this.DurationControlLabelHours.Size = new System.Drawing.Size(65, 23);
            this.DurationControlLabelHours.TabIndex = 20;
            this.DurationControlLabelHours.Text = "Часы";
            this.DurationControlLabelHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DurationControlNumericUpDownHours
            // 
            this.DurationControlNumericUpDownHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurationControlNumericUpDownHours.Location = new System.Drawing.Point(74, 24);
            this.DurationControlNumericUpDownHours.Margin = new System.Windows.Forms.Padding(1);
            this.DurationControlNumericUpDownHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DurationControlNumericUpDownHours.Name = "DurationControlNumericUpDownHours";
            this.DurationControlNumericUpDownHours.Size = new System.Drawing.Size(71, 23);
            this.DurationControlNumericUpDownHours.TabIndex = 19;
            this.DurationControlNumericUpDownHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DurationControlGroupBox
            // 
            this.DurationControlGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.DurationControlGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurationControlGroupBox.Location = new System.Drawing.Point(0, 0);
            this.DurationControlGroupBox.Name = "DurationControlGroupBox";
            this.DurationControlGroupBox.Size = new System.Drawing.Size(300, 100);
            this.DurationControlGroupBox.TabIndex = 25;
            this.DurationControlGroupBox.TabStop = false;
            this.DurationControlGroupBox.Text = "Duration";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.DurationControlNumericUpDownHours, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DurationControlLabelMinutes, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DurationControlNumericUpDownDays, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DurationControlLabelDays, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DurationControlNumericUpDownMinutes, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.DurationControlLabelHours, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DurationControlNumericUpDownSeconds, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.DurationControlLabelSeconds, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 78);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // DurationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DurationControlGroupBox);
            this.Name = "DurationControl";
            this.Size = new System.Drawing.Size(300, 100);
            ((System.ComponentModel.ISupportInitialize)(this.DurationControlNumericUpDownDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationControlNumericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationControlNumericUpDownSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationControlNumericUpDownHours)).EndInit();
            this.DurationControlGroupBox.ResumeLayout(false);
            this.DurationControlGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DurationControlLabelDays;
        private System.Windows.Forms.Label DurationControlLabelMinutes;
        private System.Windows.Forms.Label DurationControlLabelSeconds;
        private System.Windows.Forms.Label DurationControlLabelHours;
        private System.Windows.Forms.NumericUpDown DurationControlNumericUpDownDays;
        private System.Windows.Forms.NumericUpDown DurationControlNumericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown DurationControlNumericUpDownSeconds;
        private System.Windows.Forms.NumericUpDown DurationControlNumericUpDownHours;
        private System.Windows.Forms.GroupBox DurationControlGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    } // partial class DurationControl
}     // namespace Regata.Core.UI.WinForms
