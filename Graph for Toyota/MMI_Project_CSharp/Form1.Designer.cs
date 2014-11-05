namespace MMI_Project_CSharp
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            this.data1.AllowUserToDeleteRows = false;
            this.data1.AllowUserToResizeColumns = false;
            this.data1.AllowUserToResizeRows = false;
            this.data1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data1.BackgroundColor = System.Drawing.Color.White;
            this.data1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data1.DefaultCellStyle = dataGridViewCellStyle5;
            this.data1.EnableHeadersVisualStyles = false;
            this.data1.Location = new System.Drawing.Point(83, 445);
            this.data1.Name = "data1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.data1.RowHeadersVisible = false;
            this.data1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data1.RowTemplate.Height = 21;
            this.data1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.data1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.data1.Size = new System.Drawing.Size(868, 102);
            this.data1.TabIndex = 1;
            this.data1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_Validated);
            this.data1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.data1_CellValidating);
            this.data1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.data1_EditingControlShowing);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(5, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "グラフ表示";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnUpdate);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.SystemColors.Control;
            this.btnRead.Location = new System.Drawing.Point(5, 74);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(132, 38);
            this.btnRead.TabIndex = 16;
            this.btnRead.Text = "呼出";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.SystemColors.Control;
            this.btnWrite.Location = new System.Drawing.Point(5, 118);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(132, 38);
            this.btnWrite.TabIndex = 15;
            this.btnWrite.Text = "登録";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "パターンNo.";
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(68, 49);
            this.numUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.ReadOnly = true;
            this.numUpDown.Size = new System.Drawing.Size(34, 19);
            this.numUpDown.TabIndex = 17;
            this.numUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Step";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "移行時間";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "到達温度";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "到達湿度";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(959, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "(%)";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(957, 492);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "(℃)";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(957, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "(分)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "ファイル名";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(5, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 38);
            this.button3.TabIndex = 27;
            this.button3.Text = "ファイル書込";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(5, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 38);
            this.button2.TabIndex = 28;
            this.button2.Text = "ファイル読込";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(67, 211);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(70, 19);
            this.txtFile.TabIndex = 29;
            // 
            // lineChart
            // 
            this.lineChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.LabelStyle.Format = "{d}:00";
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea2.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea2.AxisX.ScrollBar.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.ScrollBar.Size = 12D;
            chartArea2.AxisX.Title = "時間";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MaximumAutoSize = 0F;
            chartArea2.AxisX2.ScrollBar.Enabled = false;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.Format = "{d}°C";
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Maximum = 30D;
            chartArea2.AxisY.Minimum = -30D;
            chartArea2.AxisY.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea2.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.AxisY.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.ResetZoom;
            chartArea2.AxisY.ScrollBar.Enabled = false;
            chartArea2.AxisY.ScrollBar.IsPositionedInside = false;
            chartArea2.AxisY.ScrollBar.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.ScrollBar.Size = 12D;
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea2.AxisY.Title = "温度";
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY2.LabelStyle.Format = "{d}%";
            chartArea2.AxisY2.Maximum = 100D;
            chartArea2.AxisY2.MaximumAutoSize = 10F;
            chartArea2.AxisY2.Minimum = 0D;
            chartArea2.AxisY2.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.AxisY2.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea2.AxisY2.ScrollBar.IsPositionedInside = false;
            chartArea2.AxisY2.ScrollBar.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY2.ScrollBar.Size = 12D;
            chartArea2.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea2.AxisY2.Title = "湿度";
            chartArea2.AxisY2.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.Red;
            chartArea2.BorderWidth = 2;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            legend2.Title = "Legend";
            this.lineChart.Legends.Add(legend2);
            this.lineChart.Location = new System.Drawing.Point(143, 4);
            this.lineChart.Name = "lineChart";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "温度";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Violet;
            series4.Legend = "Legend1";
            series4.Name = "湿度";
            series4.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.lineChart.Series.Add(series3);
            this.lineChart.Series.Add(series4);
            this.lineChart.Size = new System.Drawing.Size(835, 435);
            this.lineChart.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lineChart);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data1);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(871, 526);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "パターン設定";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
    }
}

