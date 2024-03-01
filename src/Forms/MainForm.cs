using System.IO;
using System.Security.AccessControl;

namespace DynamicComponents.Forms;

public partial class MainForm : Form
{
    private int _nextY = 0;
    private FileInfo[] _files;

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        var directory = new DirectoryInfo(".");

        _files = directory.GetFiles();

        RenderFiles();
    }

    private void RenderFiles()
    {
        for (int i = 0; i < _files.Length; i++)
            RenderFile(i);
    }

    private void RenderFile(int fileIndex)
    {
        var file = _files[fileIndex];

        var textBox = new TextBox();
        textBox.Text = file.Name;
        textBox.Tag = fileIndex;
        textBox.Location = new Point(12, _nextY);
        textBox.Width = 200;
        Controls.Add(textBox);

        var updateButton = new Button();
        updateButton.Text = "Update";
        updateButton.Tag = fileIndex;
        updateButton.Location = new Point(230, _nextY);
        updateButton.Height = 30;
        updateButton.Click += UpdateButtonClick;
        Controls.Add(updateButton);

        var deleteButton = new Button();
        deleteButton.Text = "Delete";
        deleteButton.Tag = fileIndex;
        deleteButton.Location = new Point(320, _nextY);
        deleteButton.Height = 30;
        deleteButton.Click += DeleteButtonClick;
        Controls.Add(deleteButton);

        _nextY += 25;
    }

    private void UpdateButtonClick(object? sender, EventArgs e)
    {
        var button = sender as Button;
        var fileIndex = (int)button.Tag;

        foreach (var control in Controls)
        {
            if (control is TextBox textBox)
            {
                if ((int)textBox.Tag == fileIndex)
                {
                    File.Move(_files[fileIndex].FullName, textBox.Text);
                    var directory = new DirectoryInfo(".");

                    _files = directory.GetFiles();

                    Controls.Clear();
                    _nextY = 0;
                    RenderFiles();
                }
            }
        }
    }
    private void DeleteButtonClick(object? sender, EventArgs e)
    {
        var button = sender as Button;
        var fileIndex = (int)button.Tag;

        foreach (var control in Controls)
        {
            if (control is TextBox textBox)
            {
                if ((int)textBox.Tag == fileIndex)
                {
                    File.Delete(_files[fileIndex].FullName);
                    var directory = new DirectoryInfo(".");

                    _files = directory.GetFiles();
                    Controls.Clear();
                    _nextY = 0;
                    RenderFiles();
                }
            }
        }
    }
}
