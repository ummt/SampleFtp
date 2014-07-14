using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleFTP
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // アップロード
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            { 
                FtpManager.UploadAsync("/upload.txt", @"C:\ftptest\upload.txt");
                MessageBox.Show("アップロードしました", "アップロード", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 削除
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FtpManager.Delete("/upload.txt");
                MessageBox.Show("削除しました", "削除", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ダウンロード
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                FtpManager.Download("/upload.txt", @"C:\ftptest\uploadDownLoad.txt");
                MessageBox.Show("ダウンロードしました", "ダウンロード", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ディレクトリ存在確認
        private void buttonExistsDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (FtpManager.ExistsDirectory("/test/"))
                {
                    MessageBox.Show("ディレクトリがありました", "ディレクトリ存在確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("ディレクトリはありません", "ディレクトリ存在確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ディレクトリ作成
        private void buttonMakeDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                FtpManager.MakeDirectory("/testMake/");
                MessageBox.Show("ディレクトリを作成しました", "ディレクトリ作成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
