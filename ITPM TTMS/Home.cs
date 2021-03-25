using System.Windows.Forms;

namespace ITPM_TTMS
{
    internal class Home : Form
    {
        private Button button1;

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(560, 261);
            this.Controls.Add(this.button1);
            this.Name = "Home";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }
    }
}