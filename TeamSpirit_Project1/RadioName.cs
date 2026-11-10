using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TeamSpirit_Project1.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TeamSpirit_Project1
{
    internal class RadioName
    {
        public Control radioBtn;

        public Control radioChecked;
        public PictureBox pictureBox;


        public void radioFunc()
        {
            if (radioBtn.Name == "buttonlion")
            {
                pictureBox.Image = ((System.Drawing.Image)(Resources.Icon01));

            }
            else if (radioBtn.Name == "buttonshrek")
            {
                pictureBox.Image = ((System.Drawing.Image)(Resources.Icon02));

            }
            else if (radioBtn.Name == "buttonbird")
            {
                pictureBox.Image = ((System.Drawing.Image)(Resources.Icon03));

            }
            else if (radioBtn.Name == "buttonsmurf")
            {
                pictureBox.Image = ((System.Drawing.Image)(Resources.Icon04));

            }
        }

    }
}
