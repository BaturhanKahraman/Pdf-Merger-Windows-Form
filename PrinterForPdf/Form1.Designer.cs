
namespace PrinterForPdf
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
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lboxFileNames = new System.Windows.Forms.ListBox();
            this.btnMergeAndSave = new System.Windows.Forms.Button();
            this.savePdfDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(550, 172);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(238, 26);
            this.btnSelectFiles.TabIndex = 0;
            this.btnSelectFiles.Text = "Dosyaları Seç";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(302, 240);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 15);
            this.lblOutput.TabIndex = 1;
            // 
            // lboxFileNames
            // 
            this.lboxFileNames.FormattingEnabled = true;
            this.lboxFileNames.ItemHeight = 15;
            this.lboxFileNames.Location = new System.Drawing.Point(12, 12);
            this.lboxFileNames.Name = "lboxFileNames";
            this.lboxFileNames.Size = new System.Drawing.Size(776, 154);
            this.lboxFileNames.TabIndex = 3;
            // 
            // btnMergeAndSave
            // 
            this.btnMergeAndSave.Location = new System.Drawing.Point(605, 405);
            this.btnMergeAndSave.Name = "btnMergeAndSave";
            this.btnMergeAndSave.Size = new System.Drawing.Size(183, 33);
            this.btnMergeAndSave.TabIndex = 4;
            this.btnMergeAndSave.Text = "Birleştir ve Kaydet";
            this.btnMergeAndSave.UseVisualStyleBackColor = true;
            this.btnMergeAndSave.Click += new System.EventHandler(this.btnMergeAndSave_Click);
            // 
            // savePdfDialog
            // 
            this.savePdfDialog.DefaultExt = "pdf";
            this.savePdfDialog.Filter = "PDF Files (.pdf)| *.pdf";
            this.savePdfDialog.Title = "Lütfen birleştirilmiş pdf\'i kayıt edin.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMergeAndSave);
            this.Controls.Add(this.lboxFileNames);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSelectFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Pdf Birleştirici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ListBox lboxFileNames;
        private System.Windows.Forms.Button btnMergeAndSave;
        private System.Windows.Forms.SaveFileDialog savePdfDialog;
    }
}

