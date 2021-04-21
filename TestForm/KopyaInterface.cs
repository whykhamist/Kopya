using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kopya;

namespace TestForm
{
    public partial class Form1 : Form
    {
        private bool Copying = false;

        private readonly CancellationTokenSource CancelToken;

        public Form1()
        {
            InitializeComponent();
            CancelToken = new CancellationTokenSource();

            ResetErrorMessages();

            this.Height -= 106;
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                await ResizeForm(true);
                if (Copying)
                {
                    CancelToken.Cancel();
                    CancelCopy();
                }
                else
                {
                    Copying = true;
                    StartBtn.Text = "Cancel";
                    if (FileRadio.Checked)
                    {
                        var fileProgress = new Progress<FileCopyProgressInfo>(cProgress =>
                        {
                            StatMsgLbl.Text = $"Copying {cProgress.FileName} {cProgress.FileSizeCopied}/{cProgress.FileSize}";
                            TotalProg.Value = CurrentProg.Value = (int)cProgress.Progress;
                            TotalProgLbl.Text = CurrentProgLbl.Text = $"{cProgress.Progress}%";
                        });
                        await Copy.File(SourceTxt.Text, DestinationTxt.Text, fileProgress, CancelToken.Token);
                        if(!CancelToken.IsCancellationRequested) await CopyComplete();
                    }
                    else
                    {

                    }
                }
            }
        }

        private async Task CopyComplete()
        {
            StatMsgLbl.Text = "Done!";
            Copying = false;
            StartBtn.Text = "Start";
            await Task.Delay(3500);
            await ResizeForm(false);
        }

        private void CancelCopy()
        {
            StatMsgLbl.Text = "Copy cancelled! Stopped by user!";
            Copying = false;
            StartBtn.Text = "Start";
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (string.IsNullOrWhiteSpace(SourceTxt.Text))
            {
                SourceErrorLbl.Text = "* Source is required!";
                SourceTxt.Focus();
                output = false;
            }

            if (string.IsNullOrWhiteSpace(DestinationTxt.Text))
            {
                DestinationErrorLbl.Text = "* Destination is required!";
                SourceTxt.Focus();
                output = false;
            }

            return output;
        }

        private void ResetErrorMessages()
        {
            SourceErrorLbl.Text = DestinationErrorLbl.Text = string.Empty;
        }

        private async Task ResizeForm(bool expand)
        {
            int speed = 16;
            if (expand)
            {
                while(this.Height < 300)
                {
                    this.Height += speed;
                    await Task.Delay(10);
                }
                this.Height = 300;
            }
            else
            {
                while (this.Height > 194)
                {
                    this.Height -= speed;
                    await Task.Delay(10);
                }
                this.Height = 194;
            }
        }

        private void SourceBtn_Click(object sender, EventArgs e)
        {
            if (FileRadio.Checked)
            {
                var FD = new OpenFileDialog();
                var result = FD.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string Filename = FD.FileName;
                    SourceTxt.Text = Filename;
                }
            }
            else
            {

            }
        }

        private void SourceTxt_TextChanged(object sender, EventArgs e)
        {
            DestinationBtn.Enabled = DestinationTxt.Enabled = (!string.IsNullOrWhiteSpace(SourceTxt.Text));
        }

        private void DestinationBtn_Click(object sender, EventArgs e)
        {
            if (FileRadio.Checked)
            {
                var sfd = new SaveFileDialog();
                var file = new FileInfo(SourceTxt.Text);
                sfd.FileName = file.Name;
                sfd.Filter = $"File (*{file.Extension})|*{file.Extension}";
                sfd.DefaultExt = file.Extension.Replace(".", "");
                sfd.AddExtension = true;
                var result = sfd.ShowDialog();
                if(result == DialogResult.OK)
                {
                    DestinationTxt.Text = sfd.FileName;
                }
            }
            else
            {

            }
        }
    }
}
