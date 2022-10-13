using System.Runtime.InteropServices;

namespace Lab1._1
{
    public partial class Form1 : Form
    {

        //For form with rounded corners

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        //

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        //exit
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //minimize
        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //For custom panel (border) (functinality to move)

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        //File menu

        //Message
        private void messageMenuStrip_Click(object sender, EventArgs e)
        {
            messageMenuStrip.Enabled = messageToolStripMenuItem1.Enabled;
            if (!messageMenuStrip.Enabled)
            {
                messageMenuStrip.Enabled = messageToolStripMenuItem1.Enabled;
                return;
            }
            MessageBox.Show("Default message.","Show message");
        }

        //Check
        private void checkMenuStrip_Click(object sender, EventArgs e)
        {
            checkMenuStrip.Checked = checkContextMenuStrip.Checked;
            switch (checkContextMenuStrip.Checked) 
            {
                case true:
                    messageMenuStrip.Enabled = false;
                    break;

                case false:
                    messageMenuStrip.Enabled = true;

                    break;
            }
            messageToolStripMenuItem1.Enabled = messageMenuStrip.Enabled;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button) 
            {
                case MouseButtons.Right:
                    contextMenuStrip1.Show(PointToScreen(e.Location));
                        break;
            }
        }

        //Size menu
        private sbyte how_many_times_button_pressed = 1;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D || e.KeyChar == (char)100)
            {
                switch (how_many_times_button_pressed)
                {
                    case 1:
                        how_many_times_button_pressed++;
                        sizeToolStripMenuItem.DropDownItems[0].Visible = true; 

                        break;

                    case 2:
                        how_many_times_button_pressed++;
                        sizeToolStripMenuItem.DropDownItems[1].Visible = true;
                        break;

                    case 3:
                        how_many_times_button_pressed++;
                        sizeToolStripMenuItem.DropDownItems[2].Visible = true;
                        break;

                    default:
                        MessageBox.Show("You added maximum sizes.", "The limit has been reached");
                        break;
                }
            }
            else if (e.KeyChar == (char)Keys.S || e.KeyChar == (char)115)
            {
                if (how_many_times_button_pressed >= 2) 
                {
                    toolStripMenuItem3.Checked = true;
                }
            }
        }
    
        //About menu
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can use File menu, Size menu and Help menu, which located in the top of the program, by mouse " +
                "or by keyboard shortcuts(all shortcuts written near the commands). Also you have context menu, that corresponds to" +
                "'File menu'.\n" +
                "By pressing the D key, items 50%, 75%, 100% are added to 'Size menu'. When pressing S key, checkbox is set near 75% item in the menu.", 
                "About program");
        }

        //Contex Menu

        //Message
        private void messageContextMenuStrip_Click(object sender, EventArgs e)
        {
            if (!messageMenuStrip.Enabled)
            {
                messageToolStripMenuItem1.Enabled = messageMenuStrip.Enabled;
                return;
            }
            messageMenuStrip_Click(sender, e);
        }

        //Check
        private void checkContextMenuStrip_Click(object sender, EventArgs e)
        {
            //fileToolStripMenuItem.DropDown.Items[0].
            checkContextMenuStrip.Checked =  checkMenuStrip.Checked;
            checkMenuStrip_Click(sender, e);
        }
    }
}