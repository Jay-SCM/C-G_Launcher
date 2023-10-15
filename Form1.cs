using System;//using System.Collections.Generic;
using System.Windows.Forms;//using System.Linq;
using System.Drawing;//using System.Windows.
namespace Miruku_GL//System.Windows.Forms
{
    public partial class Form1 : Form//System.Windows.Forms.Form
    {
        private string[] imageResourceNames = { "image1.jpg", "image2.jpg", "image3.jpg" };//private string[] imageResourceNames = { "image1.jpg", "image2.jpg", "image3.jpg" };
        private int currentIndex = 0; // Index of the current image.

        public Form1()
        {
            InitializeComponent();
            // Set the initial image using a resource name.
            pictureBoxSlider.Image = Properties.Resources.image1;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Replace the path with the actual path to your Game 3 executable.
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\World of Warcraft\World of Warcraft Launcher.exe");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Replace the path with the actual path to your Game 2 executable.
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\World of Warcraft\World of Warcraft Launcher.exe");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Replace the path with the actual path to your Game 1 executable.
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\World of Warcraft\World of Warcraft Launcher.exe");
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Show the next image.
            currentIndex = (currentIndex + 1) % imageResourceNames.Length; // Increment the index and wrap around to 0 if necessary.
            pictureBoxSlider.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageResourceNames[currentIndex]); // Get the image from the resources and show it.
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Show the previous image.
            currentIndex = (currentIndex - 1 + imageResourceNames.Length) % imageResourceNames.Length;
            pictureBoxSlider.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageResourceNames[currentIndex]);
        }
        private void tsmiGame1_Click(object sender, EventArgs e)
        {
            // Code to handle the click on Game 1.

            // You can launch your game here.
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\World of Warcraft\World of Warcraft Launcher.exe");
        }
        private void tsmiGame2_Click(object sender, EventArgs e)
        {
            // Code to handle the click on Game 2.
            // You can launch your second game here.
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\World of Warcraft\World of Warcraft Launcher.exe");
        }
        private void tsmiGame3_Click(object sender, EventArgs e)
        {
            // Code to handle the click on Game 3.

            // You can launch your third game here.
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\World of Warcraft\World of Warcraft Launcher.exe");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            try
            {
                webBrowser1.Navigate(new Uri(url));
            }
            catch (UriFormatException)
            {
                // Handle invalid URL format.
                MessageBox.Show("Invalid URL format");
            }
            catch (Exception ex)
            {
                // Handle other exceptions, e.g., network issues.
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void StartGame(string path)
        {
            try
            {
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}