namespace SencorForm
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            refreshButton = new Button();
            temperatureBox = new TextBox();
            humidityBox = new TextBox();
            temperatureGuage = new AGauge();
            humidGuage = new AGauge();
            pressureBox = new TextBox();
            pressureGauge = new AGauge();
            windSpeedGauge = new AGauge();
            windSpeedBox = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timeBox = new TextBox();
            rainPrecipGauge = new AGauge();
            rainPrecipBox = new TextBox();
            solarRadiationBox = new TextBox();
            solarRadiationGauge = new AGauge();
            contextMenuStrip1 = new ContextMenuStrip(components);
            windGustBox = new TextBox();
            windGustGuage = new AGauge();
            uvBox = new TextBox();
            uvGauge = new AGauge();
            label1 = new Label();
            label2 = new Label();
            pressureLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            windDirectionGauge = new AGauge();
            windDirectionBox = new TextBox();
            n = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            rainPrecipitProgressBar = new VerticalProgressBar();
            day0PicBox = new PictureBox();
            day0textBox = new TextBox();
            label12 = new Label();
            label13 = new Label();
            day1textBox = new TextBox();
            day1PicBox = new PictureBox();
            label14 = new Label();
            day2textBox = new TextBox();
            day2PicBox = new PictureBox();
            label15 = new Label();
            day3textBox = new TextBox();
            day3PicBox = new PictureBox();
            label16 = new Label();
            day4textBox = new TextBox();
            day4PicBox = new PictureBox();
            label17 = new Label();
            day5textBox = new TextBox();
            day5PicBox = new PictureBox();
            label18 = new Label();
            label19 = new Label();
            label21 = new Label();
            label24 = new Label();
            pressureTendpictureBox1 = new PictureBox();
            WeathercheckBox = new CheckBox();
            MaxMincheckBox = new CheckBox();
            MaxMinTextBox = new RichTextBox();
            label3 = new Label();
            label25 = new Label();
            ((System.ComponentModel.ISupportInitialize)day0PicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)day1PicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)day2PicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)day3PicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)day4PicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)day5PicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pressureTendpictureBox1).BeginInit();
            SuspendLayout();
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.Transparent;
            refreshButton.BackgroundImage = (Image)resources.GetObject("refreshButton.BackgroundImage");
            refreshButton.BackgroundImageLayout = ImageLayout.Zoom;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.ForeColor = SystemColors.ButtonHighlight;
            refreshButton.Location = new Point(1373, 376);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(106, 95);
            refreshButton.TabIndex = 1;
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += button1_Click;
            // 
            // temperatureBox
            // 
            temperatureBox.BackColor = Color.WhiteSmoke;
            temperatureBox.BorderStyle = BorderStyle.FixedSingle;
            temperatureBox.Location = new Point(111, 207);
            temperatureBox.Name = "temperatureBox";
            temperatureBox.ReadOnly = true;
            temperatureBox.Size = new Size(60, 31);
            temperatureBox.TabIndex = 13;
            temperatureBox.MouseHover += button1_Click;
            // 
            // humidityBox
            // 
            humidityBox.BorderStyle = BorderStyle.FixedSingle;
            humidityBox.Location = new Point(360, 202);
            humidityBox.Name = "humidityBox";
            humidityBox.ReadOnly = true;
            humidityBox.Size = new Size(65, 31);
            humidityBox.TabIndex = 15;
            // 
            // temperatureGuage
            // 
            temperatureGuage.BackgroundImageLayout = ImageLayout.None;
            temperatureGuage.BaseArcColor = Color.Silver;
            temperatureGuage.BaseArcRadius = 80;
            temperatureGuage.BaseArcStart = 135;
            temperatureGuage.BaseArcSweep = 270;
            temperatureGuage.BaseArcWidth = 5;
            temperatureGuage.Center = new Point(130, 120);
            temperatureGuage.Location = new Point(12, 33);
            temperatureGuage.MaxValue = 50F;
            temperatureGuage.MinValue = -40F;
            temperatureGuage.Name = "temperatureGuage";
            temperatureGuage.NeedleColor1 = AGaugeNeedleColor.Red;
            temperatureGuage.NeedleColor2 = Color.DimGray;
            temperatureGuage.NeedleRadius = 80;
            temperatureGuage.NeedleType = NeedleType.Advance;
            temperatureGuage.NeedleWidth = 2;
            temperatureGuage.ScaleLinesInterColor = Color.Black;
            temperatureGuage.ScaleLinesInterInnerRadius = 73;
            temperatureGuage.ScaleLinesInterOuterRadius = 80;
            temperatureGuage.ScaleLinesInterWidth = 1;
            temperatureGuage.ScaleLinesMajorColor = Color.Black;
            temperatureGuage.ScaleLinesMajorInnerRadius = 70;
            temperatureGuage.ScaleLinesMajorOuterRadius = 80;
            temperatureGuage.ScaleLinesMajorStepValue = 10F;
            temperatureGuage.ScaleLinesMajorWidth = 2;
            temperatureGuage.ScaleLinesMinorColor = Color.Gray;
            temperatureGuage.ScaleLinesMinorInnerRadius = 75;
            temperatureGuage.ScaleLinesMinorOuterRadius = 80;
            temperatureGuage.ScaleLinesMinorTicks = 9;
            temperatureGuage.ScaleLinesMinorWidth = 1;
            temperatureGuage.ScaleNumbersColor = Color.Black;
            temperatureGuage.ScaleNumbersFormat = null;
            temperatureGuage.ScaleNumbersRadius = 95;
            temperatureGuage.ScaleNumbersRotation = 0;
            temperatureGuage.ScaleNumbersStartScaleLine = 0;
            temperatureGuage.ScaleNumbersStepScaleLines = 1;
            temperatureGuage.Size = new Size(262, 211);
            temperatureGuage.TabIndex = 16;
            temperatureGuage.Text = "aGauge1";
            temperatureGuage.Value = -40F;
            // 
            // humidGuage
            // 
            humidGuage.BaseArcColor = Color.Silver;
            humidGuage.BaseArcRadius = 80;
            humidGuage.BaseArcStart = 135;
            humidGuage.BaseArcSweep = 270;
            humidGuage.BaseArcWidth = 5;
            humidGuage.Center = new Point(110, 120);
            humidGuage.Location = new Point(284, 33);
            humidGuage.MaxValue = 100F;
            humidGuage.MinValue = 0F;
            humidGuage.Name = "humidGuage";
            humidGuage.NeedleColor1 = AGaugeNeedleColor.Red;
            humidGuage.NeedleColor2 = Color.DimGray;
            humidGuage.NeedleRadius = 80;
            humidGuage.NeedleType = NeedleType.Advance;
            humidGuage.NeedleWidth = 2;
            humidGuage.ScaleLinesInterColor = Color.Black;
            humidGuage.ScaleLinesInterInnerRadius = 73;
            humidGuage.ScaleLinesInterOuterRadius = 80;
            humidGuage.ScaleLinesInterWidth = 1;
            humidGuage.ScaleLinesMajorColor = Color.Black;
            humidGuage.ScaleLinesMajorInnerRadius = 70;
            humidGuage.ScaleLinesMajorOuterRadius = 80;
            humidGuage.ScaleLinesMajorStepValue = 10F;
            humidGuage.ScaleLinesMajorWidth = 2;
            humidGuage.ScaleLinesMinorColor = Color.Gray;
            humidGuage.ScaleLinesMinorInnerRadius = 75;
            humidGuage.ScaleLinesMinorOuterRadius = 80;
            humidGuage.ScaleLinesMinorTicks = 9;
            humidGuage.ScaleLinesMinorWidth = 1;
            humidGuage.ScaleNumbersColor = Color.Black;
            humidGuage.ScaleNumbersFormat = null;
            humidGuage.ScaleNumbersRadius = 95;
            humidGuage.ScaleNumbersRotation = 0;
            humidGuage.ScaleNumbersStartScaleLine = 0;
            humidGuage.ScaleNumbersStepScaleLines = 1;
            humidGuage.Size = new Size(227, 211);
            humidGuage.TabIndex = 17;
            humidGuage.Text = "aGauge2";
            humidGuage.Value = 0F;
            // 
            // pressureBox
            // 
            pressureBox.BorderStyle = BorderStyle.FixedSingle;
            pressureBox.Location = new Point(605, 204);
            pressureBox.Name = "pressureBox";
            pressureBox.ReadOnly = true;
            pressureBox.Size = new Size(93, 31);
            pressureBox.TabIndex = 18;
            // 
            // pressureGauge
            // 
            pressureGauge.BaseArcColor = Color.Silver;
            pressureGauge.BaseArcRadius = 80;
            pressureGauge.BaseArcStart = 135;
            pressureGauge.BaseArcSweep = 270;
            pressureGauge.BaseArcWidth = 5;
            pressureGauge.Center = new Point(120, 110);
            pressureGauge.Location = new Point(528, 35);
            pressureGauge.MaxValue = 1100F;
            pressureGauge.MinValue = 700F;
            pressureGauge.Name = "pressureGauge";
            pressureGauge.NeedleColor1 = AGaugeNeedleColor.Red;
            pressureGauge.NeedleColor2 = Color.IndianRed;
            pressureGauge.NeedleRadius = 80;
            pressureGauge.NeedleType = NeedleType.Advance;
            pressureGauge.NeedleWidth = 2;
            pressureGauge.ScaleLinesInterColor = Color.Black;
            pressureGauge.ScaleLinesInterInnerRadius = 73;
            pressureGauge.ScaleLinesInterOuterRadius = 80;
            pressureGauge.ScaleLinesInterWidth = 1;
            pressureGauge.ScaleLinesMajorColor = Color.Black;
            pressureGauge.ScaleLinesMajorInnerRadius = 70;
            pressureGauge.ScaleLinesMajorOuterRadius = 80;
            pressureGauge.ScaleLinesMajorStepValue = 50F;
            pressureGauge.ScaleLinesMajorWidth = 2;
            pressureGauge.ScaleLinesMinorColor = Color.Gray;
            pressureGauge.ScaleLinesMinorInnerRadius = 75;
            pressureGauge.ScaleLinesMinorOuterRadius = 80;
            pressureGauge.ScaleLinesMinorTicks = 9;
            pressureGauge.ScaleLinesMinorWidth = 1;
            pressureGauge.ScaleNumbersColor = Color.Black;
            pressureGauge.ScaleNumbersFormat = null;
            pressureGauge.ScaleNumbersRadius = 95;
            pressureGauge.ScaleNumbersRotation = 0;
            pressureGauge.ScaleNumbersStartScaleLine = 0;
            pressureGauge.ScaleNumbersStepScaleLines = 1;
            pressureGauge.Size = new Size(253, 218);
            pressureGauge.TabIndex = 19;
            pressureGauge.Text = "aGauge1";
            pressureGauge.Value = 700F;
            // 
            // windSpeedGauge
            // 
            windSpeedGauge.BackColor = SystemColors.GradientInactiveCaption;
            windSpeedGauge.BackgroundImageLayout = ImageLayout.None;
            windSpeedGauge.BaseArcColor = Color.Silver;
            windSpeedGauge.BaseArcRadius = 115;
            windSpeedGauge.BaseArcStart = 135;
            windSpeedGauge.BaseArcSweep = 270;
            windSpeedGauge.BaseArcWidth = 5;
            windSpeedGauge.Center = new Point(140, 140);
            windSpeedGauge.Location = new Point(826, 15);
            windSpeedGauge.Margin = new Padding(0);
            windSpeedGauge.MaxValue = 180F;
            windSpeedGauge.MinValue = 0F;
            windSpeedGauge.Name = "windSpeedGauge";
            windSpeedGauge.NeedleColor1 = AGaugeNeedleColor.Red;
            windSpeedGauge.NeedleColor2 = Color.Gainsboro;
            windSpeedGauge.NeedleRadius = 80;
            windSpeedGauge.NeedleType = NeedleType.Advance;
            windSpeedGauge.NeedleWidth = 2;
            windSpeedGauge.ScaleLinesInterColor = Color.Black;
            windSpeedGauge.ScaleLinesInterInnerRadius = 80;
            windSpeedGauge.ScaleLinesInterOuterRadius = 80;
            windSpeedGauge.ScaleLinesInterWidth = 1;
            windSpeedGauge.ScaleLinesMajorColor = Color.Black;
            windSpeedGauge.ScaleLinesMajorInnerRadius = 70;
            windSpeedGauge.ScaleLinesMajorOuterRadius = 80;
            windSpeedGauge.ScaleLinesMajorStepValue = 20F;
            windSpeedGauge.ScaleLinesMajorWidth = 3;
            windSpeedGauge.ScaleLinesMinorColor = Color.Gray;
            windSpeedGauge.ScaleLinesMinorInnerRadius = 81;
            windSpeedGauge.ScaleLinesMinorOuterRadius = 84;
            windSpeedGauge.ScaleLinesMinorTicks = 10;
            windSpeedGauge.ScaleLinesMinorWidth = 3;
            windSpeedGauge.ScaleNumbersColor = Color.Black;
            windSpeedGauge.ScaleNumbersFormat = "";
            windSpeedGauge.ScaleNumbersRadius = 97;
            windSpeedGauge.ScaleNumbersRotation = 10;
            windSpeedGauge.ScaleNumbersStartScaleLine = 1;
            windSpeedGauge.ScaleNumbersStepScaleLines = 10;
            windSpeedGauge.Size = new Size(265, 239);
            windSpeedGauge.TabIndex = 20;
            windSpeedGauge.Text = "aGauge1";
            windSpeedGauge.Value = 0F;
            // 
            // windSpeedBox
            // 
            windSpeedBox.BorderStyle = BorderStyle.FixedSingle;
            windSpeedBox.Location = new Point(916, 226);
            windSpeedBox.Name = "windSpeedBox";
            windSpeedBox.ReadOnly = true;
            windSpeedBox.Size = new Size(99, 31);
            windSpeedBox.TabIndex = 21;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick_1;
            // 
            // timeBox
            // 
            timeBox.BorderStyle = BorderStyle.FixedSingle;
            timeBox.Location = new Point(1223, 496);
            timeBox.Name = "timeBox";
            timeBox.ReadOnly = true;
            timeBox.Size = new Size(278, 31);
            timeBox.TabIndex = 22;
            // 
            // rainPrecipGauge
            // 
            rainPrecipGauge.BaseArcColor = Color.Silver;
            rainPrecipGauge.BaseArcRadius = 80;
            rainPrecipGauge.BaseArcStart = 135;
            rainPrecipGauge.BaseArcSweep = 270;
            rainPrecipGauge.BaseArcWidth = 5;
            rainPrecipGauge.Center = new Point(130, 120);
            rainPrecipGauge.Location = new Point(528, 240);
            rainPrecipGauge.MaxValue = 100F;
            rainPrecipGauge.MinValue = 0F;
            rainPrecipGauge.Name = "rainPrecipGauge";
            rainPrecipGauge.NeedleColor1 = AGaugeNeedleColor.Red;
            rainPrecipGauge.NeedleColor2 = Color.DimGray;
            rainPrecipGauge.NeedleRadius = 80;
            rainPrecipGauge.NeedleType = NeedleType.Advance;
            rainPrecipGauge.NeedleWidth = 2;
            rainPrecipGauge.ScaleLinesInterColor = Color.Black;
            rainPrecipGauge.ScaleLinesInterInnerRadius = 73;
            rainPrecipGauge.ScaleLinesInterOuterRadius = 80;
            rainPrecipGauge.ScaleLinesInterWidth = 1;
            rainPrecipGauge.ScaleLinesMajorColor = Color.Black;
            rainPrecipGauge.ScaleLinesMajorInnerRadius = 70;
            rainPrecipGauge.ScaleLinesMajorOuterRadius = 80;
            rainPrecipGauge.ScaleLinesMajorStepValue = 10F;
            rainPrecipGauge.ScaleLinesMajorWidth = 2;
            rainPrecipGauge.ScaleLinesMinorColor = Color.Gray;
            rainPrecipGauge.ScaleLinesMinorInnerRadius = 75;
            rainPrecipGauge.ScaleLinesMinorOuterRadius = 80;
            rainPrecipGauge.ScaleLinesMinorTicks = 9;
            rainPrecipGauge.ScaleLinesMinorWidth = 1;
            rainPrecipGauge.ScaleNumbersColor = Color.Black;
            rainPrecipGauge.ScaleNumbersFormat = null;
            rainPrecipGauge.ScaleNumbersRadius = 95;
            rainPrecipGauge.ScaleNumbersRotation = 0;
            rainPrecipGauge.ScaleNumbersStartScaleLine = 0;
            rainPrecipGauge.ScaleNumbersStepScaleLines = 1;
            rainPrecipGauge.Size = new Size(262, 211);
            rainPrecipGauge.TabIndex = 23;
            rainPrecipGauge.Text = "aGauge1";
            rainPrecipGauge.Value = 0F;
            // 
            // rainPrecipBox
            // 
            rainPrecipBox.BorderStyle = BorderStyle.FixedSingle;
            rainPrecipBox.Location = new Point(605, 422);
            rainPrecipBox.Name = "rainPrecipBox";
            rainPrecipBox.ReadOnly = true;
            rainPrecipBox.Size = new Size(101, 31);
            rainPrecipBox.TabIndex = 24;
            // 
            // solarRadiationBox
            // 
            solarRadiationBox.BorderStyle = BorderStyle.FixedSingle;
            solarRadiationBox.Location = new Point(349, 421);
            solarRadiationBox.Name = "solarRadiationBox";
            solarRadiationBox.ReadOnly = true;
            solarRadiationBox.Size = new Size(93, 31);
            solarRadiationBox.TabIndex = 25;
            // 
            // solarRadiationGauge
            // 
            solarRadiationGauge.BaseArcColor = Color.Silver;
            solarRadiationGauge.BaseArcRadius = 80;
            solarRadiationGauge.BaseArcStart = 135;
            solarRadiationGauge.BaseArcSweep = 270;
            solarRadiationGauge.BaseArcWidth = 5;
            solarRadiationGauge.Center = new Point(120, 110);
            solarRadiationGauge.Location = new Point(280, 253);
            solarRadiationGauge.MaxValue = 1300F;
            solarRadiationGauge.MinValue = 0F;
            solarRadiationGauge.Name = "solarRadiationGauge";
            solarRadiationGauge.NeedleColor1 = AGaugeNeedleColor.Red;
            solarRadiationGauge.NeedleColor2 = Color.Red;
            solarRadiationGauge.NeedleRadius = 80;
            solarRadiationGauge.NeedleType = NeedleType.Advance;
            solarRadiationGauge.NeedleWidth = 2;
            solarRadiationGauge.ScaleLinesInterColor = Color.Black;
            solarRadiationGauge.ScaleLinesInterInnerRadius = 73;
            solarRadiationGauge.ScaleLinesInterOuterRadius = 80;
            solarRadiationGauge.ScaleLinesInterWidth = 1;
            solarRadiationGauge.ScaleLinesMajorColor = Color.Black;
            solarRadiationGauge.ScaleLinesMajorInnerRadius = 70;
            solarRadiationGauge.ScaleLinesMajorOuterRadius = 80;
            solarRadiationGauge.ScaleLinesMajorStepValue = 200F;
            solarRadiationGauge.ScaleLinesMajorWidth = 2;
            solarRadiationGauge.ScaleLinesMinorColor = Color.Gray;
            solarRadiationGauge.ScaleLinesMinorInnerRadius = 75;
            solarRadiationGauge.ScaleLinesMinorOuterRadius = 80;
            solarRadiationGauge.ScaleLinesMinorTicks = 9;
            solarRadiationGauge.ScaleLinesMinorWidth = 1;
            solarRadiationGauge.ScaleNumbersColor = Color.Black;
            solarRadiationGauge.ScaleNumbersFormat = null;
            solarRadiationGauge.ScaleNumbersRadius = 100;
            solarRadiationGauge.ScaleNumbersRotation = 0;
            solarRadiationGauge.ScaleNumbersStartScaleLine = 0;
            solarRadiationGauge.ScaleNumbersStepScaleLines = 1;
            solarRadiationGauge.Size = new Size(253, 218);
            solarRadiationGauge.TabIndex = 26;
            solarRadiationGauge.Text = "aGauge1";
            solarRadiationGauge.Value = 0F;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // windGustBox
            // 
            windGustBox.BorderStyle = BorderStyle.FixedSingle;
            windGustBox.Location = new Point(1204, 226);
            windGustBox.Name = "windGustBox";
            windGustBox.ReadOnly = true;
            windGustBox.Size = new Size(99, 31);
            windGustBox.TabIndex = 29;
            // 
            // windGustGuage
            // 
            windGustGuage.BackColor = SystemColors.GradientInactiveCaption;
            windGustGuage.BackgroundImageLayout = ImageLayout.None;
            windGustGuage.BaseArcColor = Color.Silver;
            windGustGuage.BaseArcRadius = 115;
            windGustGuage.BaseArcStart = 135;
            windGustGuage.BaseArcSweep = 270;
            windGustGuage.BaseArcWidth = 5;
            windGustGuage.Center = new Point(140, 140);
            windGustGuage.Location = new Point(1117, 18);
            windGustGuage.Margin = new Padding(0);
            windGustGuage.MaxValue = 180F;
            windGustGuage.MinValue = 0F;
            windGustGuage.Name = "windGustGuage";
            windGustGuage.NeedleColor1 = AGaugeNeedleColor.Red;
            windGustGuage.NeedleColor2 = Color.Gainsboro;
            windGustGuage.NeedleRadius = 80;
            windGustGuage.NeedleType = NeedleType.Advance;
            windGustGuage.NeedleWidth = 2;
            windGustGuage.ScaleLinesInterColor = Color.Black;
            windGustGuage.ScaleLinesInterInnerRadius = 80;
            windGustGuage.ScaleLinesInterOuterRadius = 80;
            windGustGuage.ScaleLinesInterWidth = 1;
            windGustGuage.ScaleLinesMajorColor = Color.Black;
            windGustGuage.ScaleLinesMajorInnerRadius = 70;
            windGustGuage.ScaleLinesMajorOuterRadius = 80;
            windGustGuage.ScaleLinesMajorStepValue = 20F;
            windGustGuage.ScaleLinesMajorWidth = 3;
            windGustGuage.ScaleLinesMinorColor = Color.Gray;
            windGustGuage.ScaleLinesMinorInnerRadius = 81;
            windGustGuage.ScaleLinesMinorOuterRadius = 84;
            windGustGuage.ScaleLinesMinorTicks = 10;
            windGustGuage.ScaleLinesMinorWidth = 3;
            windGustGuage.ScaleNumbersColor = Color.Black;
            windGustGuage.ScaleNumbersFormat = "";
            windGustGuage.ScaleNumbersRadius = 97;
            windGustGuage.ScaleNumbersRotation = 10;
            windGustGuage.ScaleNumbersStartScaleLine = 1;
            windGustGuage.ScaleNumbersStepScaleLines = 10;
            windGustGuage.Size = new Size(265, 239);
            windGustGuage.TabIndex = 28;
            windGustGuage.Text = "aGauge1";
            windGustGuage.Value = 0F;
            // 
            // uvBox
            // 
            uvBox.BorderStyle = BorderStyle.FixedSingle;
            uvBox.Location = new Point(114, 423);
            uvBox.Name = "uvBox";
            uvBox.ReadOnly = true;
            uvBox.Size = new Size(68, 31);
            uvBox.TabIndex = 31;
            // 
            // uvGauge
            // 
            uvGauge.BaseArcColor = Color.Silver;
            uvGauge.BaseArcRadius = 50;
            uvGauge.BaseArcStart = 130;
            uvGauge.BaseArcSweep = 270;
            uvGauge.BaseArcWidth = 5;
            uvGauge.Center = new Point(130, 120);
            uvGauge.Location = new Point(12, 243);
            uvGauge.MaxValue = 16F;
            uvGauge.MinValue = 0F;
            uvGauge.Name = "uvGauge";
            uvGauge.NeedleColor1 = AGaugeNeedleColor.Red;
            uvGauge.NeedleColor2 = Color.DimGray;
            uvGauge.NeedleRadius = 80;
            uvGauge.NeedleType = NeedleType.Advance;
            uvGauge.NeedleWidth = 2;
            uvGauge.ScaleLinesInterColor = Color.Black;
            uvGauge.ScaleLinesInterInnerRadius = 73;
            uvGauge.ScaleLinesInterOuterRadius = 73;
            uvGauge.ScaleLinesInterWidth = 1;
            uvGauge.ScaleLinesMajorColor = Color.Black;
            uvGauge.ScaleLinesMajorInnerRadius = 70;
            uvGauge.ScaleLinesMajorOuterRadius = 80;
            uvGauge.ScaleLinesMajorStepValue = 1F;
            uvGauge.ScaleLinesMajorWidth = 2;
            uvGauge.ScaleLinesMinorColor = Color.Gray;
            uvGauge.ScaleLinesMinorInnerRadius = 75;
            uvGauge.ScaleLinesMinorOuterRadius = 80;
            uvGauge.ScaleLinesMinorTicks = 10;
            uvGauge.ScaleLinesMinorWidth = 1;
            uvGauge.ScaleNumbersColor = Color.Black;
            uvGauge.ScaleNumbersFormat = null;
            uvGauge.ScaleNumbersRadius = 95;
            uvGauge.ScaleNumbersRotation = 0;
            uvGauge.ScaleNumbersStartScaleLine = 1;
            uvGauge.ScaleNumbersStepScaleLines = 1;
            uvGauge.Size = new Size(262, 228);
            uvGauge.TabIndex = 30;
            uvGauge.Text = "aGauge1";
            uvGauge.Value = 0F;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Malgun Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(111, 5);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 32;
            label1.Text = "Temp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Malgun Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(349, 5);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 33;
            label2.Text = "Humidity";
            // 
            // pressureLabel
            // 
            pressureLabel.AutoSize = true;
            pressureLabel.BackColor = Color.Transparent;
            pressureLabel.Font = new Font("Malgun Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pressureLabel.ForeColor = SystemColors.ActiveCaptionText;
            pressureLabel.Location = new Point(605, 5);
            pressureLabel.Name = "pressureLabel";
            pressureLabel.Size = new Size(92, 28);
            pressureLabel.TabIndex = 34;
            pressureLabel.Text = "Pressure";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Malgun Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(910, 5);
            label4.Name = "label4";
            label4.Size = new Size(126, 28);
            label4.TabIndex = 35;
            label4.Text = "Wind speed";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Malgun Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(1204, 5);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 36;
            label5.Text = "Gust speed";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Malgun Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(590, 456);
            label6.Name = "label6";
            label6.Size = new Size(132, 28);
            label6.TabIndex = 37;
            label6.Text = "Precipitation";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Malgun Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(316, 456);
            label7.Name = "label7";
            label7.Size = new Size(151, 28);
            label7.TabIndex = 38;
            label7.Text = "Solar radiation";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Malgun Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(101, 457);
            label8.Name = "label8";
            label8.Size = new Size(99, 28);
            label8.TabIndex = 39;
            label8.Text = "UV index";
            // 
            // windDirectionGauge
            // 
            windDirectionGauge.AccessibleDescription = "";
            windDirectionGauge.AccessibleName = "";
            windDirectionGauge.BackgroundImageLayout = ImageLayout.Center;
            windDirectionGauge.BaseArcColor = Color.Black;
            windDirectionGauge.BaseArcRadius = 80;
            windDirectionGauge.BaseArcStart = 270;
            windDirectionGauge.BaseArcSweep = 360;
            windDirectionGauge.BaseArcWidth = 2;
            windDirectionGauge.Center = new Point(120, 110);
            windDirectionGauge.Location = new Point(999, 278);
            windDirectionGauge.MaxValue = 359F;
            windDirectionGauge.MinValue = 0F;
            windDirectionGauge.Name = "windDirectionGauge";
            windDirectionGauge.NeedleColor1 = AGaugeNeedleColor.Red;
            windDirectionGauge.NeedleColor2 = Color.DodgerBlue;
            windDirectionGauge.NeedleRadius = 80;
            windDirectionGauge.NeedleType = NeedleType.Advance;
            windDirectionGauge.NeedleWidth = 4;
            windDirectionGauge.ScaleLinesInterColor = Color.Black;
            windDirectionGauge.ScaleLinesInterInnerRadius = 73;
            windDirectionGauge.ScaleLinesInterOuterRadius = 80;
            windDirectionGauge.ScaleLinesInterWidth = 1;
            windDirectionGauge.ScaleLinesMajorColor = Color.Black;
            windDirectionGauge.ScaleLinesMajorInnerRadius = 70;
            windDirectionGauge.ScaleLinesMajorOuterRadius = 80;
            windDirectionGauge.ScaleLinesMajorStepValue = 90F;
            windDirectionGauge.ScaleLinesMajorWidth = 2;
            windDirectionGauge.ScaleLinesMinorColor = Color.Black;
            windDirectionGauge.ScaleLinesMinorInnerRadius = 75;
            windDirectionGauge.ScaleLinesMinorOuterRadius = 80;
            windDirectionGauge.ScaleLinesMinorTicks = 9;
            windDirectionGauge.ScaleLinesMinorWidth = 1;
            windDirectionGauge.ScaleNumbersColor = Color.Black;
            windDirectionGauge.ScaleNumbersFormat = "-";
            windDirectionGauge.ScaleNumbersRadius = 95;
            windDirectionGauge.ScaleNumbersRotation = 0;
            windDirectionGauge.ScaleNumbersStartScaleLine = 0;
            windDirectionGauge.ScaleNumbersStepScaleLines = 1;
            windDirectionGauge.Size = new Size(253, 218);
            windDirectionGauge.TabIndex = 40;
            windDirectionGauge.Text = "aGauge1";
            windDirectionGauge.Value = 0F;
            // 
            // windDirectionBox
            // 
            windDirectionBox.BorderStyle = BorderStyle.FixedSingle;
            windDirectionBox.Location = new Point(1100, 496);
            windDirectionBox.Name = "windDirectionBox";
            windDirectionBox.ReadOnly = true;
            windDirectionBox.Size = new Size(46, 31);
            windDirectionBox.TabIndex = 41;
            // 
            // n
            // 
            n.AutoSize = true;
            n.BackColor = Color.Transparent;
            n.ForeColor = SystemColors.Highlight;
            n.Location = new Point(1108, 275);
            n.Name = "n";
            n.Size = new Size(26, 25);
            n.TabIndex = 42;
            n.Text = "N";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(1108, 471);
            label9.Name = "label9";
            label9.Size = new Size(22, 25);
            label9.TabIndex = 43;
            label9.Text = "S";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(1206, 376);
            label10.Name = "label10";
            label10.Size = new Size(21, 25);
            label10.TabIndex = 44;
            label10.Text = "E";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(1007, 376);
            label11.Name = "label11";
            label11.Size = new Size(29, 25);
            label11.TabIndex = 45;
            label11.Text = "W";
            // 
            // rainPrecipitProgressBar
            // 
            rainPrecipitProgressBar.Location = new Point(775, 253);
            rainPrecipitProgressBar.Name = "rainPrecipitProgressBar";
            rainPrecipitProgressBar.Size = new Size(29, 231);
            rainPrecipitProgressBar.Step = 1;
            rainPrecipitProgressBar.TabIndex = 46;
            // 
            // day0PicBox
            // 
            day0PicBox.Location = new Point(-1, 574);
            day0PicBox.Name = "day0PicBox";
            day0PicBox.Size = new Size(217, 131);
            day0PicBox.SizeMode = PictureBoxSizeMode.CenterImage;
            day0PicBox.TabIndex = 47;
            day0PicBox.TabStop = false;
            // 
            // day0textBox
            // 
            day0textBox.BackColor = SystemColors.GradientInactiveCaption;
            day0textBox.BorderStyle = BorderStyle.None;
            day0textBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            day0textBox.Location = new Point(28, 711);
            day0textBox.Multiline = true;
            day0textBox.Name = "day0textBox";
            day0textBox.ReadOnly = true;
            day0textBox.Size = new Size(217, 157);
            day0textBox.TabIndex = 48;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(64, 546);
            label12.Name = "label12";
            label12.Size = new Size(65, 25);
            label12.TabIndex = 49;
            label12.Text = "Today";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(294, 546);
            label13.Name = "label13";
            label13.Size = new Size(87, 25);
            label13.TabIndex = 52;
            label13.Text = "Tomorow";
            // 
            // day1textBox
            // 
            day1textBox.BackColor = SystemColors.GradientInactiveCaption;
            day1textBox.BorderStyle = BorderStyle.None;
            day1textBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            day1textBox.Location = new Point(282, 712);
            day1textBox.Multiline = true;
            day1textBox.Name = "day1textBox";
            day1textBox.ReadOnly = true;
            day1textBox.Size = new Size(217, 157);
            day1textBox.TabIndex = 51;
            // 
            // day1PicBox
            // 
            day1PicBox.Location = new Point(241, 575);
            day1PicBox.Name = "day1PicBox";
            day1PicBox.Size = new Size(217, 131);
            day1PicBox.SizeMode = PictureBoxSizeMode.CenterImage;
            day1PicBox.TabIndex = 50;
            day1PicBox.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(542, 546);
            label14.Name = "label14";
            label14.Size = new Size(82, 25);
            label14.TabIndex = 55;
            label14.Text = "+2 days";
            // 
            // day2textBox
            // 
            day2textBox.BackColor = SystemColors.GradientInactiveCaption;
            day2textBox.BorderStyle = BorderStyle.None;
            day2textBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            day2textBox.Location = new Point(540, 711);
            day2textBox.Multiline = true;
            day2textBox.Name = "day2textBox";
            day2textBox.ReadOnly = true;
            day2textBox.Size = new Size(217, 157);
            day2textBox.TabIndex = 54;
            // 
            // day2PicBox
            // 
            day2PicBox.Location = new Point(489, 574);
            day2PicBox.Name = "day2PicBox";
            day2PicBox.Size = new Size(217, 131);
            day2PicBox.SizeMode = PictureBoxSizeMode.CenterImage;
            day2PicBox.TabIndex = 53;
            day2PicBox.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(789, 546);
            label15.Name = "label15";
            label15.Size = new Size(82, 25);
            label15.TabIndex = 58;
            label15.Text = "+3 days";
            // 
            // day3textBox
            // 
            day3textBox.BackColor = SystemColors.GradientInactiveCaption;
            day3textBox.BorderStyle = BorderStyle.None;
            day3textBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            day3textBox.Location = new Point(787, 711);
            day3textBox.Multiline = true;
            day3textBox.Name = "day3textBox";
            day3textBox.ReadOnly = true;
            day3textBox.Size = new Size(217, 158);
            day3textBox.TabIndex = 57;
            // 
            // day3PicBox
            // 
            day3PicBox.Location = new Point(729, 575);
            day3PicBox.Name = "day3PicBox";
            day3PicBox.Size = new Size(217, 131);
            day3PicBox.SizeMode = PictureBoxSizeMode.CenterImage;
            day3PicBox.TabIndex = 56;
            day3PicBox.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(1033, 546);
            label16.Name = "label16";
            label16.Size = new Size(82, 25);
            label16.TabIndex = 61;
            label16.Text = "+4 days";
            // 
            // day4textBox
            // 
            day4textBox.BackColor = SystemColors.GradientInactiveCaption;
            day4textBox.BorderStyle = BorderStyle.None;
            day4textBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            day4textBox.Location = new Point(1031, 711);
            day4textBox.Multiline = true;
            day4textBox.Name = "day4textBox";
            day4textBox.ReadOnly = true;
            day4textBox.Size = new Size(217, 158);
            day4textBox.TabIndex = 60;
            // 
            // day4PicBox
            // 
            day4PicBox.Location = new Point(970, 575);
            day4PicBox.Name = "day4PicBox";
            day4PicBox.Size = new Size(217, 131);
            day4PicBox.SizeMode = PictureBoxSizeMode.CenterImage;
            day4PicBox.TabIndex = 59;
            day4PicBox.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(1283, 546);
            label17.Name = "label17";
            label17.Size = new Size(82, 25);
            label17.TabIndex = 64;
            label17.Text = "+5 days";
            // 
            // day5textBox
            // 
            day5textBox.BackColor = SystemColors.GradientInactiveCaption;
            day5textBox.BorderStyle = BorderStyle.None;
            day5textBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            day5textBox.Location = new Point(1281, 711);
            day5textBox.Multiline = true;
            day5textBox.Name = "day5textBox";
            day5textBox.ReadOnly = true;
            day5textBox.Size = new Size(217, 157);
            day5textBox.TabIndex = 63;
            // 
            // day5PicBox
            // 
            day5PicBox.Enabled = false;
            day5PicBox.Location = new Point(1227, 575);
            day5PicBox.Name = "day5PicBox";
            day5PicBox.Size = new Size(217, 131);
            day5PicBox.SizeMode = PictureBoxSizeMode.CenterImage;
            day5PicBox.TabIndex = 62;
            day5PicBox.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.ActiveCaptionText;
            label18.Location = new Point(809, 466);
            label18.Name = "label18";
            label18.Size = new Size(113, 25);
            label18.TabIndex = 65;
            label18.Text = "-  0mm Rain";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.ForeColor = SystemColors.ActiveCaptionText;
            label19.Location = new Point(809, 240);
            label19.Name = "label19";
            label19.Size = new Size(93, 25);
            label19.TabIndex = 66;
            label19.Text = "-  100mm";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.ForeColor = SystemColors.ActiveCaptionText;
            label21.Location = new Point(809, 354);
            label21.Name = "label21";
            label21.Size = new Size(83, 25);
            label21.TabIndex = 71;
            label21.Text = "-  50mm";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Malgun Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.ActiveCaptionText;
            label24.Location = new Point(1039, 247);
            label24.Name = "label24";
            label24.Size = new Size(153, 28);
            label24.TabIndex = 72;
            label24.Text = "Wind direction";
            // 
            // pressureTendpictureBox1
            // 
            pressureTendpictureBox1.InitialImage = null;
            pressureTendpictureBox1.Location = new Point(725, 33);
            pressureTendpictureBox1.Name = "pressureTendpictureBox1";
            pressureTendpictureBox1.Size = new Size(93, 63);
            pressureTendpictureBox1.TabIndex = 73;
            pressureTendpictureBox1.TabStop = false;
            // 
            // WeathercheckBox
            // 
            WeathercheckBox.AutoSize = true;
            WeathercheckBox.Checked = true;
            WeathercheckBox.CheckState = CheckState.Checked;
            WeathercheckBox.ForeColor = SystemColors.ActiveCaptionText;
            WeathercheckBox.Location = new Point(1373, 288);
            WeathercheckBox.Name = "WeathercheckBox";
            WeathercheckBox.Size = new Size(106, 29);
            WeathercheckBox.TabIndex = 74;
            WeathercheckBox.Text = "Weather";
            WeathercheckBox.UseVisualStyleBackColor = true;
            WeathercheckBox.CheckedChanged += WeathercheckBox_CheckedChanged;
            // 
            // MaxMincheckBox
            // 
            MaxMincheckBox.AutoSize = true;
            MaxMincheckBox.ForeColor = SystemColors.ActiveCaptionText;
            MaxMincheckBox.Location = new Point(1373, 323);
            MaxMincheckBox.Name = "MaxMincheckBox";
            MaxMincheckBox.Size = new Size(110, 29);
            MaxMincheckBox.TabIndex = 75;
            MaxMincheckBox.Text = "Max/Min";
            MaxMincheckBox.UseVisualStyleBackColor = true;
            MaxMincheckBox.CheckedChanged += MaxMincheckBox_CheckedChanged;
            // 
            // MaxMinTextBox
            // 
            MaxMinTextBox.BackColor = SystemColors.GradientInactiveCaption;
            MaxMinTextBox.BorderStyle = BorderStyle.None;
            MaxMinTextBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaxMinTextBox.Location = new Point(28, 12);
            MaxMinTextBox.Name = "MaxMinTextBox";
            MaxMinTextBox.ReadOnly = true;
            MaxMinTextBox.Size = new Size(494, 496);
            MaxMinTextBox.TabIndex = 76;
            MaxMinTextBox.Text = "";
            MaxMinTextBox.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(809, 411);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 77;
            label3.Text = "-  25mm";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.ForeColor = SystemColors.ActiveCaptionText;
            label25.Location = new Point(809, 296);
            label25.Name = "label25";
            label25.Size = new Size(83, 25);
            label25.TabIndex = 78;
            label25.Text = "-  75mm";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1512, 893);
            Controls.Add(label25);
            Controls.Add(label3);
            Controls.Add(MaxMinTextBox);
            Controls.Add(MaxMincheckBox);
            Controls.Add(WeathercheckBox);
            Controls.Add(pressureTendpictureBox1);
            Controls.Add(label24);
            Controls.Add(label21);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(day5textBox);
            Controls.Add(day5PicBox);
            Controls.Add(label16);
            Controls.Add(day4textBox);
            Controls.Add(day4PicBox);
            Controls.Add(label15);
            Controls.Add(day3textBox);
            Controls.Add(day3PicBox);
            Controls.Add(label14);
            Controls.Add(day2textBox);
            Controls.Add(day2PicBox);
            Controls.Add(label13);
            Controls.Add(day1textBox);
            Controls.Add(day1PicBox);
            Controls.Add(label12);
            Controls.Add(day0textBox);
            Controls.Add(day0PicBox);
            Controls.Add(rainPrecipitProgressBar);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(n);
            Controls.Add(windDirectionBox);
            Controls.Add(windDirectionGauge);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pressureLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(uvBox);
            Controls.Add(uvGauge);
            Controls.Add(windGustBox);
            Controls.Add(windGustGuage);
            Controls.Add(solarRadiationBox);
            Controls.Add(solarRadiationGauge);
            Controls.Add(rainPrecipBox);
            Controls.Add(rainPrecipGauge);
            Controls.Add(timeBox);
            Controls.Add(windSpeedBox);
            Controls.Add(windSpeedGauge);
            Controls.Add(pressureBox);
            Controls.Add(pressureGauge);
            Controls.Add(humidityBox);
            Controls.Add(temperatureBox);
            Controls.Add(humidGuage);
            Controls.Add(temperatureGuage);
            Controls.Add(refreshButton);
            Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Opacity = 0.97D;
            Text = "Weather Plovdiv-Gagarin by IvoVaklinov";
            ((System.ComponentModel.ISupportInitialize)day0PicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)day1PicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)day2PicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)day3PicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)day4PicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)day5PicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pressureTendpictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button refreshButton;
        private TextBox temperatureBox;
        private TextBox humidityBox;
        private AGauge temperatureGuage;
        private AGauge humidGuage;
        private TextBox pressureBox;
        private AGauge pressureGauge;
        private AGauge windSpeedGauge;
        private TextBox windSpeedBox;
        private System.Windows.Forms.Timer timer1;
        private TextBox timeBox;
        private AGauge rainPrecipGauge;
        private TextBox rainPrecipBox;
        private TextBox solarRadiationBox;
        private AGauge solarRadiationGauge;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox windGustBox;
        private AGauge windGustGuage;
        private TextBox uvBox;
        private AGauge uvGauge;
        private Label label1;
        private Label label2;
        private Label pressureLabel;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private AGauge windDirectionGauge;
        private TextBox windDirectionBox;
        private Label n;
        private Label label9;
        private Label label10;
        private Label label11;
        private VerticalProgressBar rainPrecipitProgressBar;
        private PictureBox day0PicBox;
        private TextBox day0textBox;
        private Label label12;
        private Label label13;
        private TextBox day1textBox;
        private PictureBox day1PicBox;
        private Label label14;
        private TextBox day2textBox;
        private PictureBox day2PicBox;
        private Label label15;
        private TextBox day3textBox;
        private PictureBox day3PicBox;
        private Label label16;
        private TextBox day4textBox;
        private PictureBox day4PicBox;
        private Label label17;
        private TextBox day5textBox;
        private PictureBox day5PicBox;
        private Label label18;
        private Label label19;
        private Label label21;
        private Label label24;
        private PictureBox pressureTendpictureBox1;
        private CheckBox WeathercheckBox;
        private CheckBox MaxMincheckBox;
        private RichTextBox MaxMinTextBox;
        private Label label3;
        private Label label25;       
    }
}
