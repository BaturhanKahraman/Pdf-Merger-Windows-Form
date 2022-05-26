using System;
using System.Windows.Forms;
using PrinterForPdf.Entity;
using PrinterForPdf.Utility;

namespace PrinterForPdf
{
    public partial class Form1 : Form
    {
        private readonly PrintObject _printObject;
        public Form1()
        {
            InitializeComponent();
            _printObject = new PrintObject();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() != DialogResult.OK || !openFileDialog1.CheckFileExists) return;
            if (openFileDialog1.FileNames.Length < 2)
            {
                MessageBox.Show("Lütfen 2 veya daha fazla pdf dosyası seçin", "Hata", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }
            lboxFileNames.Items.Clear();
            lboxFileNames.Items.AddRange(openFileDialog1.SafeFileNames);
            _printObject.FilePaths = openFileDialog1.FileNames;
        }

        private void btnMergeAndSave_Click(object sender, EventArgs e)
        {
            if (_printObject.FilePaths == null)
            {
                MessageBox.Show(@"Lütfen ilk önce birleştirmek istediğiniz dosyaları seçin.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            if (savePdfDialog.ShowDialog() != DialogResult.OK) return;
            _printObject.PathName = savePdfDialog.FileName;
            if (Functions.CreateNewPdfFile(_printObject))
            {
                MessageBox.Show("Pdf dosyanız başarıyla oluşturuldu.");
                return;
            }
            MessageBox.Show("Pdf dosyanız oluşturulurken bir hata meydana geldi.");

        }
        
    }
}
