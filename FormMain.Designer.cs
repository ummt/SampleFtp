namespace SampleFTP
{
    partial class FormMain
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
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonExistsDirectory = new System.Windows.Forms.Button();
            this.buttonMakeDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(13, 13);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 0;
            this.buttonUpload.Text = "アップロード";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(13, 43);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(13, 73);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 2;
            this.buttonDownload.Text = "ダウンロード";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonExistsDirectory
            // 
            this.buttonExistsDirectory.Location = new System.Drawing.Point(13, 103);
            this.buttonExistsDirectory.Name = "buttonExistsDirectory";
            this.buttonExistsDirectory.Size = new System.Drawing.Size(118, 23);
            this.buttonExistsDirectory.TabIndex = 3;
            this.buttonExistsDirectory.Text = "ディレクトリ存在確認";
            this.buttonExistsDirectory.UseVisualStyleBackColor = true;
            this.buttonExistsDirectory.Click += new System.EventHandler(this.buttonExistsDirectory_Click);
            // 
            // buttonMakeDirectory
            // 
            this.buttonMakeDirectory.Location = new System.Drawing.Point(13, 133);
            this.buttonMakeDirectory.Name = "buttonMakeDirectory";
            this.buttonMakeDirectory.Size = new System.Drawing.Size(118, 23);
            this.buttonMakeDirectory.TabIndex = 4;
            this.buttonMakeDirectory.Text = "ディレクトリ作成";
            this.buttonMakeDirectory.UseVisualStyleBackColor = true;
            this.buttonMakeDirectory.Click += new System.EventHandler(this.buttonMakeDirectory_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonMakeDirectory);
            this.Controls.Add(this.buttonExistsDirectory);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpload);
            this.Name = "FormMain";
            this.Text = "FTPサンプル";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonExistsDirectory;
        private System.Windows.Forms.Button buttonMakeDirectory;
    }
}

