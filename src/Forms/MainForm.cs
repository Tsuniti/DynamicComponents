namespace DynamicComponents.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void mainButton_Click(object sender, EventArgs e)
    {
        var newLabel = new Label();
        newLabel.Size = new Size(50,30);
        newLabel.Text = DateTime.Now.Millisecond.ToString();
        newLabel.Location = new Point(10, 100);
        
        // �������� ��������� � ������ � ���������� �� �����
        Controls.Add(newLabel);
    }
}
