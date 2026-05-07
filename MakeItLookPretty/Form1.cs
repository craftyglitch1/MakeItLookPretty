namespace MakeItLookPretty
{
    public partial class Form1 : Form
    {
        const int WM_PAINT = 0x000F;
        bool? leftHalf;

        Color windowColor;
        Brush windowBrush;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            comBoxColor.Enabled = false;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch(m.Msg)
            {
                case WM_PAINT:
                    Graphics g = Graphics.FromHwnd(this.Handle);
                    if (leftHalf == true)
                    {
                        Rectangle rect = new Rectangle(0, 0, this.Width / 2, this.Height);
                        g.FillRectangle(windowBrush, rect);
                    }
                    else if (leftHalf == false)
                    {
                        Rectangle rect = new Rectangle(409, 0, this.Width / 2, this.Height);
                        g.FillRectangle(windowBrush, rect);
                    }
                    g.Dispose();
                    break;
            }
        }

        private void comBoxColor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            double bright;
            switch (comBoxColor.SelectedIndex)
            {
                case 0:
                    this.BackColor = SystemColors.Control;
                    foreach(Control control in this.Controls)
                       control.BackColor = ColorTranslator.FromHtml(txtColorCode.Text);
                    leftHalf = true;
                    this.Refresh();
                    break;
                case 1:
                    foreach (Control control in this.Controls)
                        control.BackColor = SystemColors.Control;
                    this.BackColor = SystemColors.Control;
                    leftHalf = false;
                    this.Refresh();
                    break;
                case 2:
                    foreach (Control control in this.Controls)
                        control.BackColor = ColorTranslator.FromHtml(txtColorCode.Text);
                    leftHalf = null;
                    this.Refresh();
                    this.BackColor = ColorTranslator.FromHtml(txtColorCode.Text);
                    break;
                case 3:
                    foreach (Control control in this.Controls)
                        control.BackColor = SystemColors.Control;
                    leftHalf = null;
                    this.Refresh();
                    this.BackColor = SystemColors.Control;
                    break;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtColorCode.Text != string.Empty)
            {
                bool valid = txtColorCode.Text.StartsWith('#');
                bool validLength = txtColorCode.Text.Length == 7;
                string validChars = "0123456789ABCDEF";

                bool hasValidChars = true;
                foreach(char letter in txtColorCode.Text.Substring(1).ToUpper())
                {
                    if(!validChars.Contains(letter))
                    {
                        hasValidChars = false;
                        break;
                    }
                }
                if(valid && validLength && hasValidChars)
                {
                    windowColor = ColorTranslator.FromHtml(txtColorCode.Text);
                    windowBrush = new SolidBrush(windowColor);
                    comBoxColor.Enabled = true;
                }
                else
                {
                    MessageBox.Show("invalud");
                }
            }
        }

        private double getPixelBrightness(Color color)
        {
            // https://stackoverflow.com/questions/26233781/detect-the-brightness-of-a-pixel-or-the-area-surrounding-it
            return (0.2126 * color.R + 0.7152 * color.G + 0.0722 * color.B);
        }
    }
}