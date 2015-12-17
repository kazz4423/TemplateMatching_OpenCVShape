namespace TemplateMatchingOpenCVShape
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxIpl2 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxIpl1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(512, 825);
            this.pictureBoxIpl1.TabIndex = 0;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "テンプレート画像";
            // 
            // pictureBoxIpl2
            // 
            this.pictureBoxIpl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxIpl2.Location = new System.Drawing.Point(779, 43);
            this.pictureBoxIpl2.Name = "pictureBoxIpl2";
            this.pictureBoxIpl2.Size = new System.Drawing.Size(223, 766);
            this.pictureBoxIpl2.TabIndex = 2;
            this.pictureBoxIpl2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "マッチング開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "相関係数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "0";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CV_TM_SQDIFF",
            "CV_TM_SQDIFF_NORMED",
            "CV_TM_CCORR",
            "CV_TM_CCORR_NORMED",
            "CV_TM_CCOEFF",
            "CV_TM_CCOEFF_NORMED"});
            this.comboBox1.Location = new System.Drawing.Point(534, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "CV_TM_SQDIFF";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "エッジ検出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1075, 861);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxIpl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Name = "Form1";
            this.Text = "テンプレートマッチングテスト";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.Label label1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}

