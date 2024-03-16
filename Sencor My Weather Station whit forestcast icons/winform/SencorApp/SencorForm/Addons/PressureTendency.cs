namespace SencorForm.Addons
{
    public class PressureTendency
    {
        PictureBox pictureBox = new PictureBox();

        public Image PressureIcon(string airPressTend)
        {
            switch (airPressTend)
            {
                case "-2": return pictureBox.Image = Properties.Resources.highfalling;
                case "-1": return pictureBox.Image = Properties.Resources.falling;
                case "0": return pictureBox.Image = Properties.Resources.steady;
                case "1": return pictureBox.Image = Properties.Resources.rising;
                case "2": return pictureBox.Image = Properties.Resources.highrising;
            }
            return pictureBox.Image;
        }
    }
}
