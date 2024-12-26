using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;
using System.Runtime.InteropServices.ComTypes;

namespace FilenameChanger
{
	public partial class fMain : Form
	{
		public fMain()
		{
			InitializeComponent();
			this.txtDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		}

		private void CheckClipboard()
		{
			if (Clipboard.ContainsText())
			{
				string clipboardText = Clipboard.GetText();
				if (clipboardText.Length > 0 && Directory.Exists(clipboardText))
				{
					txtDirectory.Text = clipboardText;
				}
			}
		}

		private void fMain_Validated(object sender, EventArgs e)
		{
			CheckClipboard();
		}

		private void btnSelectDirectory_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			DialogResult result = folderBrowserDialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				txtDirectory.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void btnReplace_Click(object sender, EventArgs e)
		{
			// Check if directory is empty
			if (txtDirectory.Text.Length == 0)
			{
				MessageBox.Show("Please select a directory first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Check if directory exists
			if (!Directory.Exists(txtDirectory.Text))
			{
				MessageBox.Show("Directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			ReplaceInDirectory(txtDirectory.Text);

			// Check if user wants to include subfolders
			if (cbIncludeSubfolders.CheckState == CheckState.Checked)
				ReplaceInSubfolders();
		}

		private void ReplaceInDirectory(string directory)
		{
			string[] files = Directory.GetFiles(directory);
			int filesRenamed = 0;

			foreach (string file in files)
			{
				string fileName = Path.GetFileName(file);
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
				string extension = Path.GetExtension(file);
				string newFileName = GetNewFilename(fileNameWithoutExtension, extension);

				if (fileName == newFileName)
					continue;

				if (File.Exists(Path.Combine(directory, newFileName)))
				{
					MessageBox.Show($"File {newFileName} already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					continue;
				}

				File.Move(file, Path.Combine(directory, newFileName));
				filesRenamed++;
			}

			MessageBox.Show($"{filesRenamed} files renamed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ReplaceInSubfolders()
		{
			string[] directories = Directory.GetDirectories(txtDirectory.Text);

			foreach (string directory in directories)
				ReplaceInDirectory(directory);
		}

		private string GetNewFilename(string fileNameWithoutExtension, string extension)
		{
			string newFileName = fileNameWithoutExtension;

			if (txtCharToReplace.Text.Length > 0)
				newFileName = fileNameWithoutExtension.Replace(txtCharToReplace.Text, txtNewCharacters.Text);

			if (cbTrimStart.CheckState == CheckState.Checked)
				newFileName = newFileName.TrimStart();

			if (cbTrimEnd.CheckState == CheckState.Checked)
				newFileName = newFileName.TrimEnd();

			return newFileName + extension;
		}

		private void ToggleCheckState(Guna2CustomCheckBox checkBox)
		{
			checkBox.CheckState = checkBox.CheckState == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked;
		}

		private void lblIncludeSubfolders_Click(object sender, EventArgs e)
		{
			ToggleCheckState(cbIncludeSubfolders);
		}

		private void lblTrimEnd_Click(object sender, EventArgs e)
		{
			ToggleCheckState(cbTrimEnd);
		}

		private void lblTrimStart_Click(object sender, EventArgs e)
		{
			ToggleCheckState(cbTrimStart);
		}
	}
}
