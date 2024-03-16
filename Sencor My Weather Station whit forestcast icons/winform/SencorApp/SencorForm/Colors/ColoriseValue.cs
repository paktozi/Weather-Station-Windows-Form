namespace SencorForm.Colors
{
    public class ColoriseValue
    {
        public Color SetColor(double value, double index)
        {
            if (value >= 35 * index)
            {
                return Color.DarkRed;
            }
            else if (value >= 30 * index)
            {
                return Color.Red;
            }
            else if (value >= 25 * index)
            {
                return Color.OrangeRed;
            }
            else if (value >= 20 * index)
            {
                return Color.GreenYellow;
            }
            else if (value >= 15 * index)
            {
                return Color.Green;
            }
            else if (value >= 10 * index)
            {
                return Color.LightBlue;
            }
            else if (value >= 0 * index)
            {
                return Color.Blue;
            }
            else if (value <= -5 * index)
            {
                return Color.DarkBlue;
            }
            return Color.Gray;
        }
    }
}
