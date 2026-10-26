using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form7 : Form
    {
        private const string PlaceholderText = "...";
        private const int MaxPreviewCharacters = 1000000;

        private static readonly string[] ImageExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
        private static readonly string[] TextExtensions =
        {
            ".txt", ".md", ".csv", ".log", ".json", ".xml", ".html", ".htm", ".css", ".js",
            ".cs", ".py", ".java", ".c", ".cpp", ".h", ".ini", ".config", ".yml", ".yaml", ".sql"
        };

        public Form7()
        {
            InitializeComponent();

            tvFolder.BeforeExpand += tvFolder_BeforeExpand;
            tvFolder.AfterSelect += tvFolder_AfterSelect;

            LoadDrives();
        }

        private void LoadDrives()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (!drive.IsReady)
                {
                    continue;
                }

                string label = string.IsNullOrEmpty(drive.VolumeLabel)
                    ? drive.Name
                    : drive.VolumeLabel + " (" + drive.Name + ")";

                TreeNode driveNode = new TreeNode(label);
                driveNode.Tag = drive.Name;
                driveNode.Nodes.Add(PlaceholderText);
                tvFolder.Nodes.Add(driveNode);
            }
        }

        private void tvFolder_BeforeExpand(object? sender, TreeViewCancelEventArgs e)
        {
            if (e.Node == null)
            {
                return;
            }

            TreeNode node = e.Node;
            bool notLoadedYet = node.Nodes.Count == 1 && node.Nodes[0].Text == PlaceholderText;
            if (notLoadedYet)
            {
                PopulateChildren(node);
            }
        }

        private void PopulateChildren(TreeNode parentNode)
        {
            string parentPath = parentNode.Tag as string ?? "";
            parentNode.Nodes.Clear();

            try
            {
                foreach (string directory in Directory.GetDirectories(parentPath).OrderBy(path => path, StringComparer.OrdinalIgnoreCase))
                {
                    TreeNode directoryNode = new TreeNode(Path.GetFileName(directory));
                    directoryNode.Tag = directory;
                    directoryNode.Nodes.Add(PlaceholderText);
                    parentNode.Nodes.Add(directoryNode);
                }

                foreach (string file in Directory.GetFiles(parentPath).OrderBy(path => path, StringComparer.OrdinalIgnoreCase))
                {
                    TreeNode fileNode = new TreeNode(Path.GetFileName(file));
                    fileNode.Tag = file;
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("(không có quyền truy cập)");
            }
            catch (IOException ex)
            {
                parentNode.Nodes.Add("(lỗi: " + ex.Message + ")");
            }
        }

        private void tvFolder_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            string path = e.Node?.Tag as string ?? "";
            ClearPreview();

            if (path.Length == 0 || !File.Exists(path))
            {
                return;
            }

            string extension = Path.GetExtension(path).ToLowerInvariant();

            try
            {
                if (ImageExtensions.Contains(extension))
                {
                    ShowImage(path);
                }
                else if (TextExtensions.Contains(extension))
                {
                    ShowText(path);
                }
                else
                {
                    rtbContent.Text = "Không hỗ trợ xem trước định dạng \"" + extension + "\".\n" +
                                      "Kích thước: " + new FileInfo(path).Length + " bytes";
                }
            }
            catch (Exception ex)
            {
                rtbContent.Text = "Không mở được file:\n" + ex.Message;
            }
        }

        private void ShowImage(string path)
        {
            using (Image original = Image.FromFile(path))
            {
                picContent.Image = new Bitmap(original);
            }

            rtbContent.Visible = false;
            picContent.Visible = true;
        }

        private void ShowText(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                char[] buffer = new char[MaxPreviewCharacters];
                int charactersRead = reader.Read(buffer, 0, buffer.Length);
                string text = new string(buffer, 0, charactersRead);

                if (!reader.EndOfStream)
                {
                    text += "\n\n... (đã cắt bớt, chỉ hiển thị phần đầu file)";
                }

                rtbContent.Text = text;
            }
        }

        private void ClearPreview()
        {
            if (picContent.Image != null)
            {
                picContent.Image.Dispose();
                picContent.Image = null;
            }

            picContent.Visible = false;
            rtbContent.Visible = true;
            rtbContent.Clear();
        }
    }
}