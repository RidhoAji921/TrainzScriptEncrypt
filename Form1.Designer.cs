namespace TrainzEncrypt
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_PathFolderTrainz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBox_PathFileGS = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder Trainz";
            // 
            // TxtBox_PathFolderTrainz
            // 
            this.TxtBox_PathFolderTrainz.Location = new System.Drawing.Point(129, 9);
            this.TxtBox_PathFolderTrainz.Name = "TxtBox_PathFolderTrainz";
            this.TxtBox_PathFolderTrainz.ReadOnly = true;
            this.TxtBox_PathFolderTrainz.Size = new System.Drawing.Size(541, 31);
            this.TxtBox_PathFolderTrainz.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "cari";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "File .gs";
            // 
            // TxtBox_PathFileGS
            // 
            this.TxtBox_PathFileGS.Location = new System.Drawing.Point(129, 64);
            this.TxtBox_PathFileGS.Name = "TxtBox_PathFileGS";
            this.TxtBox_PathFileGS.ReadOnly = true;
            this.TxtBox_PathFileGS.Size = new System.Drawing.Size(541, 31);
            this.TxtBox_PathFileGS.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "cari";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "enkripsi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 181);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtBox_PathFileGS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtBox_PathFolderTrainz);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GS to GSE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtBox_PathFolderTrainz;
        private Button button1;
        private Label label2;
        private TextBox TxtBox_PathFileGS;
        private Button button2;
        private Button button3;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
    }
}