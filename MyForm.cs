using System;
using System.Windows.Forms;

public class MyForm : Form
{
    Button btn;

    public MyForm()
    {
        btn = new Button();
        btn.Text = "Click me";
        btn.Click += Btn_Click;
        Controls.Add(btn);
    }

    private void Btn_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Button clicked!");
    }

    public static void Main()
    {
        Application.Run(new MyForm());
    }
}
