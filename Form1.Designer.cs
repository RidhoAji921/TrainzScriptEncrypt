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
            label1 = new Label();
            TxtBox_PathFolderTrainz = new TextBox();
            button1 = new Button();
            label2 = new Label();
            TxtBox_PathFileGS = new TextBox();
            button2 = new Button();
            button3 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            openTrainzUtil = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "TrainzUtil";
            // 
            // TxtBox_PathFolderTrainz
            // 
            TxtBox_PathFolderTrainz.Location = new Point(154, 9);
            TxtBox_PathFolderTrainz.Name = "TxtBox_PathFolderTrainz";
            TxtBox_PathFolderTrainz.ReadOnly = true;
            TxtBox_PathFolderTrainz.Size = new Size(516, 31);
            TxtBox_PathFolderTrainz.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(676, 9);
            button1.Name = "button1";
            button1.Size = new Size(112, 32);
            button1.TabIndex = 2;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 3;
            label2.Text = "File .gs";
            // 
            // TxtBox_PathFileGS
            // 
            TxtBox_PathFileGS.Location = new Point(154, 64);
            TxtBox_PathFileGS.Name = "TxtBox_PathFileGS";
            TxtBox_PathFileGS.ReadOnly = true;
            TxtBox_PathFileGS.Size = new Size(516, 31);
            TxtBox_PathFileGS.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(676, 63);
            button2.Name = "button2";
            button2.Size = new Size(112, 32);
            button2.TabIndex = 5;
            button2.Text = "search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(154, 117);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 6;
            button3.Text = "encrypt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openTrainzUtil
            // 
            openTrainzUtil.FileName = "openTrainzUtil";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 181);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(TxtBox_PathFileGS);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(TxtBox_PathFolderTrainz);
            Controls.Add(label1);
            Name = "Form1";
            Text = "GS to GSE";
            ResumeLayout(false);
            PerformLayout();
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
        private OpenFileDialog openTrainzUtil;
    }
}