namespace DynamicComponents.Forms;

partial class MainForm
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
        mainButton = new Button();
        SuspendLayout();
        // 
        // mainButton
        // 
        mainButton.Location = new Point(12, 12);
        mainButton.Name = "mainButton";
        mainButton.Size = new Size(261, 54);
        mainButton.TabIndex = 0;
        mainButton.Text = "Click me";
        mainButton.UseVisualStyleBackColor = true;
        mainButton.Click += mainButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(285, 345);
        Controls.Add(mainButton);
        Name = "MainForm";
        Text = "Main";
        ResumeLayout(false);
    }

    #endregion

    private Button mainButton;
}
