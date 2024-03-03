namespace Timespinner_Calculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orbLevelInput = new System.Windows.Forms.NumericUpDown();
            this.willpowerInput = new System.Windows.Forms.NumericUpDown();
            this.orbDamageOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.orbSelector = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.orbLevelInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.willpowerInput)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Blue Orb.png");
            this.imageList1.Images.SetKeyName(1, "Blade Orb.png");
            this.imageList1.Images.SetKeyName(2, "Fire Orb.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Orb Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Willpower";
            // 
            // orbLevelInput
            // 
            this.orbLevelInput.Location = new System.Drawing.Point(163, 12);
            this.orbLevelInput.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.orbLevelInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.orbLevelInput.Name = "orbLevelInput";
            this.orbLevelInput.Size = new System.Drawing.Size(41, 20);
            this.orbLevelInput.TabIndex = 3;
            this.orbLevelInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // willpowerInput
            // 
            this.willpowerInput.Location = new System.Drawing.Point(163, 38);
            this.willpowerInput.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.willpowerInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.willpowerInput.Name = "willpowerInput";
            this.willpowerInput.Size = new System.Drawing.Size(41, 20);
            this.willpowerInput.TabIndex = 3;
            this.willpowerInput.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // orbDamageOutput
            // 
            this.orbDamageOutput.AutoSize = true;
            this.orbDamageOutput.Location = new System.Drawing.Point(104, 61);
            this.orbDamageOutput.Name = "orbDamageOutput";
            this.orbDamageOutput.Size = new System.Drawing.Size(91, 13);
            this.orbDamageOutput.TabIndex = 4;
            this.orbDamageOutput.Text = "Orb Damage: ???";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(12, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orbSelector
            // 
            this.orbSelector.FormattingEnabled = true;
            this.orbSelector.Items.AddRange(new object[] {
            "Blue Orb",
            "Blade Orb",
            "Fire Orb",
            "Plasma Orb",
            "Iron Orb",
            "Ice Orb",
            "Wind Orb",
            "Gun Orb",
            "Umbra Orb",
            "Empire Orb",
            "Eye Orb",
            "Blood Orb",
            "Forbidden Tome",
            "Shattered Orb",
            "Nether Orb",
            "Radiant Orb"});
            this.orbSelector.Location = new System.Drawing.Point(12, 12);
            this.orbSelector.Name = "orbSelector";
            this.orbSelector.Size = new System.Drawing.Size(86, 212);
            this.orbSelector.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 264);
            this.Controls.Add(this.orbSelector);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orbDamageOutput);
            this.Controls.Add(this.willpowerInput);
            this.Controls.Add(this.orbLevelInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Damage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.orbLevelInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.willpowerInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown orbLevelInput;
        private System.Windows.Forms.NumericUpDown willpowerInput;
        private System.Windows.Forms.Label orbDamageOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox orbSelector;
    }
}

