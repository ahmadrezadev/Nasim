using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using NasimImageEditor.Services;
using System.Collections.Generic;

namespace NasimImageEditor.Forms
{
    public sealed partial class CompressImageForm : Form
    {
        private bool _validData;
        List<string> _imagePathList;
        private Thread _compressImageThread;
        private string _defaultStatusLabelText;
        private readonly string _saveDirectory;
        private readonly IImageProcess _imageProcess;
        private readonly BackgroundWorker _backgroundWorker;
        private readonly CancellationTokenSource _cancellationTokenSource;

        public CompressImageForm()
        {
            InitializeComponent();
            _saveDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Nasim", "Images");
            if (!Directory.Exists(_saveDirectory))
                Directory.CreateDirectory(_saveDirectory);
            _imageProcess = new ImageProcess();

            _cancellationTokenSource = new CancellationTokenSource();
            _backgroundWorker = new BackgroundWorker
            {
                WorkerSupportsCancellation = true,
            };
            _backgroundWorker.DoWork += BackgroundWorkerOnDoWork;
        }

        private void BackgroundWorkerOnDoWork(object? sender, DoWorkEventArgs e)
        {
            CompressImage();
        }

        private void CompressImageForm_Load(object sender, EventArgs e)
        {
            _imagePathList = new List<string>();
        }

        private void CompressImageForm_DragEnter(object sender, DragEventArgs e)
        {
            _validData = GetFilename(out var filename, e);
            if (_validData)
            {
                _defaultStatusLabelText = lblStatus.Text;
                lblStatus.BackColor = Color.Transparent;
                lblStatus.Text = "برای فشرده سازی تصاویر انتخاب شده، آن ها را رها کنید!";
                lblStatus.Refresh();

                _imagePathList = filename;
                _compressImageThread = new Thread(CompressImage);

                e.Effect = DragDropEffects.Copy;
                pnlMain.BackColor = Color.White;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                pnlMain.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }

        private void CompressImageForm_DragDrop(object sender, DragEventArgs e)
        {
            pnlMain.BackColor = Color.FromKnownColor(KnownColor.Control);
            if (!string.IsNullOrWhiteSpace(_defaultStatusLabelText))
            {
                lblStatus.Text = _defaultStatusLabelText;
                lblStatus.Refresh();
            }

            if (!_validData) return;

            //_backgroundWorker.RunWorkerAsync(_cancellationTokenSource.Token);
            _compressImageThread.Start(_cancellationTokenSource.Token);
            while (_compressImageThread.IsAlive)
            {
                Application.DoEvents();
                Thread.Sleep(0);
            }
        }

        private void CompressImageForm_DragLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_defaultStatusLabelText))
            {
                lblStatus.Text = _defaultStatusLabelText;
                lblStatus.Refresh();
            }

            pnlMain.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private bool GetFilename(out List<string> filename, DragEventArgs e)
        {
            filename = new List<string>();
            if ((e.AllowedEffect & DragDropEffects.Copy) != DragDropEffects.Copy) return false;
            if (e.Data.GetData("FileDrop") is not Array data) return false;
            foreach (var item in data)
            {
                var file = item.ToString();
                var ext = Path.GetExtension(file)?.ToLower();
                if (ext != ".jpg" && ext != ".png" && ext != ".jpeg" && ext != ".tif" && ext != ".tiff" &&
                    ext != ".bmp") continue;
                filename.Add(item.ToString());
            }
            return true;
        }

        private void CompressImage()
        {
            //Enabled = false;
            btnCancel.Visible = true;
            _defaultStatusLabelText = lblStatus.Text;
            lblStatus.Text = "درحال فشرده سازی تصاویر ...";
            pnlMain.Enabled = false;
            pnlMain.Refresh();
            lblStatus.Refresh();
            btnCancel.Refresh();

            try
            {
                var counter = 1;
                var compressedImageCount = 0;
                foreach (var result in from item in _imagePathList
                                       let fileName = Path.GetFileName(item)
                                       select _imageProcess.HardCompression(Image.FromFile(item),
                                           Path.Combine(_saveDirectory, $"{fileName}_compressed.jpeg")))
                {
                    if (result)
                        compressedImageCount++;
                    pbStatus.Value = (100 * counter) / _imagePathList.Count;
                    lblResult.Text = $@"{compressedImageCount:N0} تصویر فشرده سازی شد.";
                    counter++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            //Enabled = true;
            pbStatus.Value = 0;
            pnlMain.Enabled = true;
            btnCancel.Visible = false;
            lblStatus.Text = _defaultStatusLabelText;
            lblStatus.Refresh();
            btnCancel.Refresh();
            pnlMain.Refresh();
        }

        private void btnOpenOutputFiles_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(_saveDirectory))
                {
                    using var pr = Process.Start("explorer.exe", _saveDirectory);
                }
                else
                    MessageBox.Show(this,
                        "محل ذخیره فایل ها یافت نشد، لطفا برنامه را مجددا راه اندازی نمایید",
                        "خطایی رخ داده است!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(this,
                    "خطایی به هنگام اجرای دستور رخ داده است، لطفا دوباره امتحان کنید.",
                    "خطایی رخ داده است!");
            }
        }

        private void btnSelectPersianLanguage_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectEnglishLanguage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, 
                "This will be presented soon and in future releases.",
                "coming soon!");
        }

        private void btnAutoUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            try
            {
                using var pr = Process.Start(@"http://ahmadrezadev.ir/donate");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(this,
                    "خطایی به هنگام اجرای دستور رخ داده است، لطفا دوباره امتحان کنید.",
                    "خطایی رخ داده است!");
            }
        }

        private void btnCheckForUpdate_Click(object sender, EventArgs e)
        {
            btnCheckForUpdate.Enabled = false;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using var fm = new AboutForm();
            fm.ShowDialog();
        }

        private void pnlMain_Click(object sender, EventArgs e)
        {
            var filename = new List<string>();
            var openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                RestoreDirectory = true,
                //Title = "انتخاب تصویر",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = @"Image files (*.png;*.jpeg;*.jpg;*.tif;*.tiff;*.bmp;)|*.png;*.jpeg;*.jpg;*.tif;*.tiff;*.bmp;|All files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            filename.AddRange(openFileDialog.FileNames);
            _imagePathList = filename;

            //_backgroundWorker.RunWorkerAsync(_cancellationTokenSource.Token);
            _compressImageThread = new Thread(CompressImage);
            _compressImageThread.Start(_cancellationTokenSource.Token);
            while (_compressImageThread.IsAlive)
            {
                Application.DoEvents();
                Thread.Sleep(0);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _backgroundWorker?.CancelAsync();
            _cancellationTokenSource?.Cancel();
        }

        private void CompressImageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _backgroundWorker?.Dispose();
            _cancellationTokenSource?.Dispose();
            _compressImageThread?.DisableComObjectEagerCleanup();
        }
    }
}