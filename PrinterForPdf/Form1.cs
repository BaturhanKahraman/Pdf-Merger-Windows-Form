using System;
using System.Windows.Forms;

namespace PrinterForPdf
{
    public partial class Form1 : Form
    {
        private readonly Functions _pdfFunctions;
        public Form1()
        {
            InitializeComponent();
            _pdfFunctions = new Functions();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() != DialogResult.OK || !openFileDialog1.CheckFileExists) return;
            if (openFileDialog1.FileNames.Length < 2)
            {
                MessageBox.Show("Lütfen 2 veya daha fazla pdf dosyası seçin", "Hata", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }

            lboxFileNames.Items.AddRange(openFileDialog1.FileNames);
            _pdfFunctions.FilePaths = openFileDialog1.FileNames;
        }

        private void btnMergeAndSave_Click(object sender, EventArgs e)
        {
            if (_pdfFunctions.FilePaths == null)
            {
                MessageBox.Show(@"Lütfen ilk önce birleştirmek istediğiniz dosyaları seçin.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            if (savePdfDialog.ShowDialog() == DialogResult.OK)
            {
                _pdfFunctions.PathName = savePdfDialog.FileName;
                if (_pdfFunctions.CreateNewPdfFile())
                {
                    MessageBox.Show("Pdf dosyanız başarıyla oluşturuldu.");
                    return;
                }
                MessageBox.Show("Pdf dosyanız oluşturulurken bir hata meydana geldi.");
            }

        }
    }
}
