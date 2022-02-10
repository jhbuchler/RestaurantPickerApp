namespace MyDataManagerWinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CusineComboBox1 = new System.Windows.Forms.ComboBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.pricePointComboBox = new System.Windows.Forms.ComboBox();
            this.ConvenienceComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.conveniencelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CusineComboBox1
            // 
            this.CusineComboBox1.FormattingEnabled = true;
            this.CusineComboBox1.Location = new System.Drawing.Point(512, 266);
            this.CusineComboBox1.Name = "CusineComboBox1";
            this.CusineComboBox1.Size = new System.Drawing.Size(180, 23);
            this.CusineComboBox1.TabIndex = 9;
            this.CusineComboBox1.SelectedIndexChanged += new System.EventHandler(this.CusineComboBox1_SelectedIndexChanged);
            // 
            // dgItems
            // 
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Location = new System.Drawing.Point(117, 376);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowTemplate.Height = 25;
            this.dgItems.Size = new System.Drawing.Size(575, 274);
            this.dgItems.TabIndex = 1;
            this.dgItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellContentClick);
            // 
            // pricePointComboBox
            // 
            this.pricePointComboBox.FormattingEnabled = true;
            this.pricePointComboBox.Location = new System.Drawing.Point(117, 266);
            this.pricePointComboBox.Name = "pricePointComboBox";
            this.pricePointComboBox.Size = new System.Drawing.Size(180, 23);
            this.pricePointComboBox.TabIndex = 10;
            this.pricePointComboBox.SelectedIndexChanged += new System.EventHandler(this.pricePointComboBox_SelectedIndexChanged);
            // 
            // ConvenienceComboBox
            // 
            this.ConvenienceComboBox.FormattingEnabled = true;
            this.ConvenienceComboBox.Location = new System.Drawing.Point(314, 266);
            this.ConvenienceComboBox.Name = "ConvenienceComboBox";
            this.ConvenienceComboBox.Size = new System.Drawing.Size(180, 23);
            this.ConvenienceComboBox.TabIndex = 11;
            this.ConvenienceComboBox.SelectedIndexChanged += new System.EventHandler(this.ConvenienceComboBox_SelectedIndexChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(188, 236);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(33, 15);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Price";
            this.priceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // conveniencelabel
            // 
            this.conveniencelabel.AutoSize = true;
            this.conveniencelabel.Location = new System.Drawing.Point(370, 236);
            this.conveniencelabel.Name = "conveniencelabel";
            this.conveniencelabel.Size = new System.Drawing.Size(76, 15);
            this.conveniencelabel.TabIndex = 13;
            this.conveniencelabel.Text = "Convenience";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cuisine";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(370, 335);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 15;
            this.testButton.Text = "Test Button";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 690);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conveniencelabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.ConvenienceComboBox);
            this.Controls.Add(this.pricePointComboBox);
            this.Controls.Add(this.CusineComboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgItems);
            this.Name = "MainForm";
            this.Text = "Restaurant Picker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private ComboBox CusineComboBox1;
        private DataGridView dgItems;
        private ComboBox pricePointComboBox;
        private ComboBox ConvenienceComboBox;
        private Label priceLabel;
        private Label conveniencelabel;
        private Label label3;
        private Button testButton;
        private Label label1;
    }
}