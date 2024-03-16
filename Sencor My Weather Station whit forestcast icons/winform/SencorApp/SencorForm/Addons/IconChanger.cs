namespace SencorForm.Addons
{
    public class IconChanger
    {
        PictureBox pictureBox = new PictureBox();

        public Image ChangeIcon(string iconNumber)
        {
            switch (iconNumber)
            {
                case "113": return pictureBox.Image = Properties.Resources._113;
                case "116": return pictureBox.Image = Properties.Resources._116;
                case "119": return pictureBox.Image = Properties.Resources._119;
                case "122": return pictureBox.Image = Properties.Resources._122;
                case "143": return pictureBox.Image = Properties.Resources._143;
                case "176": return pictureBox.Image = Properties.Resources._176;
                case "179": return pictureBox.Image = Properties.Resources._179;
                case "182": return pictureBox.Image = Properties.Resources._182;
                case "185": return pictureBox.Image = Properties.Resources._185;
                case "200": return pictureBox.Image = Properties.Resources._200;

                case "227": return pictureBox.Image = Properties.Resources._227;
                case "230": return pictureBox.Image = Properties.Resources._230;
                case "248": return pictureBox.Image = Properties.Resources._248;
                case "260": return pictureBox.Image = Properties.Resources._260;
                case "263": return pictureBox.Image = Properties.Resources._263;
                case "266": return pictureBox.Image = Properties.Resources._266;
                case "281": return pictureBox.Image = Properties.Resources._281;
                case "284": return pictureBox.Image = Properties.Resources._284;
                case "293": return pictureBox.Image = Properties.Resources._293;
                case "296": return pictureBox.Image = Properties.Resources._296;

                case "299": return pictureBox.Image = Properties.Resources._299;
                case "302": return pictureBox.Image = Properties.Resources._302;
                case "305": return pictureBox.Image = Properties.Resources._305;
                case "308": return pictureBox.Image = Properties.Resources._308;
                case "311": return pictureBox.Image = Properties.Resources._311;
                case "314": return pictureBox.Image = Properties.Resources._314;
                case "317": return pictureBox.Image = Properties.Resources._317;
                case "320": return pictureBox.Image = Properties.Resources._320;
                case "323": return pictureBox.Image = Properties.Resources._323;
                case "326": return pictureBox.Image = Properties.Resources._326;

                case "329": return pictureBox.Image = Properties.Resources._329;
                case "332": return pictureBox.Image = Properties.Resources._332;
                case "335": return pictureBox.Image = Properties.Resources._335;
                case "338": return pictureBox.Image = Properties.Resources._338;
                case "350": return pictureBox.Image = Properties.Resources._350;
                case "353": return pictureBox.Image = Properties.Resources._353;
                case "356": return pictureBox.Image = Properties.Resources._356;
                case "359": return pictureBox.Image = Properties.Resources._359;
                case "362": return pictureBox.Image = Properties.Resources._362;
                case "365": return pictureBox.Image = Properties.Resources._365;

                case "368": return pictureBox.Image = Properties.Resources._368;
                case "371": return pictureBox.Image = Properties.Resources._371;
                case "374": return pictureBox.Image = Properties.Resources._374;
                case "377": return pictureBox.Image = Properties.Resources._377;
                case "386": return pictureBox.Image = Properties.Resources._386;
                case "389": return pictureBox.Image = Properties.Resources._389;
                case "392": return pictureBox.Image = Properties.Resources._392;
                case "395": return pictureBox.Image = Properties.Resources._395;
            }
            return pictureBox.Image;
        }
    }
}
