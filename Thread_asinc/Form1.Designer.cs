namespace Thread_asinc
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Prime_button = new System.Windows.Forms.Button();
            this.Prime_start_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Prime_end_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Prime_listBox = new System.Windows.Forms.ListBox();
            this.Stop_Prime = new System.Windows.Forms.Button();
            this.Fibonacci_listBox = new System.Windows.Forms.ListBox();
            this.Fibonacci_stop_button = new System.Windows.Forms.Button();
            this.Fibonacci_end_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Fibonacci_view_button = new System.Windows.Forms.Button();
            this.Prime_pause_button = new System.Windows.Forms.Button();
            this.Fibonacci_pause_button = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stop_all_button = new System.Windows.Forms.Button();
            this.View_all_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Prime_start_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prime_end_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fibonacci_end_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Prime_button
            // 
            this.Prime_button.Location = new System.Drawing.Point(12, 246);
            this.Prime_button.Name = "Prime_button";
            this.Prime_button.Size = new System.Drawing.Size(75, 23);
            this.Prime_button.TabIndex = 1;
            this.Prime_button.Text = "View";
            this.Prime_button.UseVisualStyleBackColor = true;
            this.Prime_button.Click += new System.EventHandler(this.Prime_button_Click);
            // 
            // Prime_start_numericUpDown
            // 
            this.Prime_start_numericUpDown.Location = new System.Drawing.Point(12, 208);
            this.Prime_start_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Prime_start_numericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Prime_start_numericUpDown.Name = "Prime_start_numericUpDown";
            this.Prime_start_numericUpDown.Size = new System.Drawing.Size(120, 23);
            this.Prime_start_numericUpDown.TabIndex = 3;
            this.Prime_start_numericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Prime_end_numericUpDown
            // 
            this.Prime_end_numericUpDown.Location = new System.Drawing.Point(149, 208);
            this.Prime_end_numericUpDown.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.Prime_end_numericUpDown.Name = "Prime_end_numericUpDown";
            this.Prime_end_numericUpDown.Size = new System.Drawing.Size(120, 23);
            this.Prime_end_numericUpDown.TabIndex = 4;
            // 
            // Prime_listBox
            // 
            this.Prime_listBox.FormattingEnabled = true;
            this.Prime_listBox.ItemHeight = 15;
            this.Prime_listBox.Location = new System.Drawing.Point(12, 41);
            this.Prime_listBox.Name = "Prime_listBox";
            this.Prime_listBox.Size = new System.Drawing.Size(257, 154);
            this.Prime_listBox.TabIndex = 5;
            // 
            // Stop_Prime
            // 
            this.Stop_Prime.Location = new System.Drawing.Point(194, 246);
            this.Stop_Prime.Name = "Stop_Prime";
            this.Stop_Prime.Size = new System.Drawing.Size(75, 23);
            this.Stop_Prime.TabIndex = 6;
            this.Stop_Prime.Text = "Stop";
            this.Stop_Prime.UseVisualStyleBackColor = true;
            this.Stop_Prime.Click += new System.EventHandler(this.Stop_Prime_Click);
            // 
            // Fibonacci_listBox
            // 
            this.Fibonacci_listBox.FormattingEnabled = true;
            this.Fibonacci_listBox.ItemHeight = 15;
            this.Fibonacci_listBox.Location = new System.Drawing.Point(341, 41);
            this.Fibonacci_listBox.Name = "Fibonacci_listBox";
            this.Fibonacci_listBox.Size = new System.Drawing.Size(257, 154);
            this.Fibonacci_listBox.TabIndex = 7;
            // 
            // Fibonacci_stop_button
            // 
            this.Fibonacci_stop_button.Location = new System.Drawing.Point(523, 246);
            this.Fibonacci_stop_button.Name = "Fibonacci_stop_button";
            this.Fibonacci_stop_button.Size = new System.Drawing.Size(75, 23);
            this.Fibonacci_stop_button.TabIndex = 11;
            this.Fibonacci_stop_button.Text = "Stop";
            this.Fibonacci_stop_button.UseVisualStyleBackColor = true;
            this.Fibonacci_stop_button.Click += new System.EventHandler(this.Fibonacci_stop_button_Click);
            // 
            // Fibonacci_end_numericUpDown
            // 
            this.Fibonacci_end_numericUpDown.Location = new System.Drawing.Point(408, 201);
            this.Fibonacci_end_numericUpDown.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.Fibonacci_end_numericUpDown.Name = "Fibonacci_end_numericUpDown";
            this.Fibonacci_end_numericUpDown.Size = new System.Drawing.Size(120, 23);
            this.Fibonacci_end_numericUpDown.TabIndex = 10;
            // 
            // Fibonacci_view_button
            // 
            this.Fibonacci_view_button.Location = new System.Drawing.Point(341, 246);
            this.Fibonacci_view_button.Name = "Fibonacci_view_button";
            this.Fibonacci_view_button.Size = new System.Drawing.Size(75, 23);
            this.Fibonacci_view_button.TabIndex = 8;
            this.Fibonacci_view_button.Text = "View";
            this.Fibonacci_view_button.UseVisualStyleBackColor = true;
            this.Fibonacci_view_button.Click += new System.EventHandler(this.Fibonacci_view_button_Click);
            // 
            // Prime_pause_button
            // 
            this.Prime_pause_button.Location = new System.Drawing.Point(102, 246);
            this.Prime_pause_button.Name = "Prime_pause_button";
            this.Prime_pause_button.Size = new System.Drawing.Size(75, 23);
            this.Prime_pause_button.TabIndex = 12;
            this.Prime_pause_button.Text = "Pause";
            this.Prime_pause_button.UseVisualStyleBackColor = true;
            this.Prime_pause_button.Click += new System.EventHandler(this.Prime_pause_button_Click);
            // 
            // Fibonacci_pause_button
            // 
            this.Fibonacci_pause_button.Location = new System.Drawing.Point(432, 246);
            this.Fibonacci_pause_button.Name = "Fibonacci_pause_button";
            this.Fibonacci_pause_button.Size = new System.Drawing.Size(75, 23);
            this.Fibonacci_pause_button.TabIndex = 13;
            this.Fibonacci_pause_button.Text = "Pause";
            this.Fibonacci_pause_button.UseVisualStyleBackColor = true;
            this.Fibonacci_pause_button.Click += new System.EventHandler(this.Fibonacci_pause_button_Click);
            // 
            // stop_all_button
            // 
            this.stop_all_button.Location = new System.Drawing.Point(194, 314);
            this.stop_all_button.Name = "stop_all_button";
            this.stop_all_button.Size = new System.Drawing.Size(116, 56);
            this.stop_all_button.TabIndex = 14;
            this.stop_all_button.Text = "Stop all";
            this.stop_all_button.UseVisualStyleBackColor = true;
            this.stop_all_button.Click += new System.EventHandler(this.stop_all_button_Click);
            // 
            // View_all_button
            // 
            this.View_all_button.Location = new System.Drawing.Point(316, 314);
            this.View_all_button.Name = "View_all_button";
            this.View_all_button.Size = new System.Drawing.Size(116, 56);
            this.View_all_button.TabIndex = 15;
            this.View_all_button.Text = "View All";
            this.View_all_button.UseVisualStyleBackColor = true;
            this.View_all_button.Click += new System.EventHandler(this.View_all_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 443);
            this.Controls.Add(this.View_all_button);
            this.Controls.Add(this.stop_all_button);
            this.Controls.Add(this.Fibonacci_pause_button);
            this.Controls.Add(this.Prime_pause_button);
            this.Controls.Add(this.Fibonacci_stop_button);
            this.Controls.Add(this.Fibonacci_end_numericUpDown);
            this.Controls.Add(this.Fibonacci_view_button);
            this.Controls.Add(this.Fibonacci_listBox);
            this.Controls.Add(this.Stop_Prime);
            this.Controls.Add(this.Prime_listBox);
            this.Controls.Add(this.Prime_end_numericUpDown);
            this.Controls.Add(this.Prime_start_numericUpDown);
            this.Controls.Add(this.Prime_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Prime_start_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prime_end_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fibonacci_end_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button Prime_button;
        private NumericUpDown Prime_start_numericUpDown;
        private NumericUpDown Prime_end_numericUpDown;
        private ListBox Prime_listBox;
        private Button Stop_Prime;
        private ListBox Fibonacci_listBox;
        private Button Fibonacci_stop_button;
        private NumericUpDown Fibonacci_end_numericUpDown;
        private Button Fibonacci_view_button;
        private Button Prime_pause_button;
        private Button Fibonacci_pause_button;
        private BindingSource bindingSource1;
        private Button stop_all_button;
        private Button View_all_button;
    }
}