namespace GUIWifiBotCommande
{
    partial class GUICommande
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            ProgBar.cBlendItems cBlendItems13 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints13 = new ProgBar.cFocalPoints();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUICommande));
            ProgBar.cBlendItems cBlendItems14 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints14 = new ProgBar.cFocalPoints();
            ProgBar.cBlendItems cBlendItems15 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints15 = new ProgBar.cFocalPoints();
            ProgBar.cBlendItems cBlendItems16 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints16 = new ProgBar.cFocalPoints();
            this.label1 = new System.Windows.Forms.Label();
            this.RightWheels = new System.Windows.Forms.Label();
            this.numericUpDownLeft = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRight = new System.Windows.Forms.NumericUpDown();
            this.progressBarLeft = new System.Windows.Forms.ProgressBar();
            this.progressBarRight = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progBarIRFrontLeft = new ProgBar.ProgBarPlus();
            this.progBarIRFrontRight = new ProgBar.ProgBarPlus();
            this.progBarIRBackRight = new ProgBar.ProgBarPlus();
            this.progBarIRBackLeft = new ProgBar.ProgBarPlus();
            this.progressBarBatteryLevel = new System.Windows.Forms.ProgressBar();
            this.BatteryValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LeftRearward = new System.Windows.Forms.RadioButton();
            this.LeftForward = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RightRearward = new System.Windows.Forms.RadioButton();
            this.RightForward = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roues Gauche";
            // 
            // RightWheels
            // 
            this.RightWheels.AutoSize = true;
            this.RightWheels.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightWheels.Location = new System.Drawing.Point(274, 43);
            this.RightWheels.Name = "RightWheels";
            this.RightWheels.Size = new System.Drawing.Size(137, 25);
            this.RightWheels.TabIndex = 1;
            this.RightWheels.Text = "Roues Droite";
            // 
            // numericUpDownLeft
            // 
            this.numericUpDownLeft.Location = new System.Drawing.Point(37, 81);
            this.numericUpDownLeft.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownLeft.Name = "numericUpDownLeft";
            this.numericUpDownLeft.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLeft.TabIndex = 2;
            this.numericUpDownLeft.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownLeft.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDownRight
            // 
            this.numericUpDownRight.Location = new System.Drawing.Point(279, 81);
            this.numericUpDownRight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRight.Name = "numericUpDownRight";
            this.numericUpDownRight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRight.TabIndex = 3;
            this.numericUpDownRight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownRight.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // progressBarLeft
            // 
            this.progressBarLeft.Location = new System.Drawing.Point(37, 119);
            this.progressBarLeft.Name = "progressBarLeft";
            this.progressBarLeft.Size = new System.Drawing.Size(120, 23);
            this.progressBarLeft.TabIndex = 4;
            // 
            // progressBarRight
            // 
            this.progressBarRight.Location = new System.Drawing.Point(279, 119);
            this.progressBarRight.Name = "progressBarRight";
            this.progressBarRight.Size = new System.Drawing.Size(120, 23);
            this.progressBarRight.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(455, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.cameraViewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // cameraViewToolStripMenuItem
            // 
            this.cameraViewToolStripMenuItem.Name = "cameraViewToolStripMenuItem";
            this.cameraViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cameraViewToolStripMenuItem.Text = "Camera View";
            this.cameraViewToolStripMenuItem.Click += new System.EventHandler(this.cameraViewToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // progBarIRFrontLeft
            // 
            cBlendItems13.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.Navy,
        System.Drawing.Color.Blue};
            cBlendItems13.iPoint = new float[] {
        0F,
        1F};
            this.progBarIRFrontLeft.BarColorBlend = cBlendItems13;
            this.progBarIRFrontLeft.BarColorSolid = System.Drawing.Color.Green;
            this.progBarIRFrontLeft.BarColorSolidB = System.Drawing.Color.White;
            this.progBarIRFrontLeft.BarLengthValue = ((short)(25));
            this.progBarIRFrontLeft.BarPadding = new System.Windows.Forms.Padding(0);
            this.progBarIRFrontLeft.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.progBarIRFrontLeft.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progBarIRFrontLeft.BarStyleTexture = null;
            this.progBarIRFrontLeft.BorderWidth = ((short)(1));
            this.progBarIRFrontLeft.Corners.All = ((short)(0));
            this.progBarIRFrontLeft.Corners.LowerLeft = ((short)(0));
            this.progBarIRFrontLeft.Corners.LowerRight = ((short)(0));
            this.progBarIRFrontLeft.Corners.UpperLeft = ((short)(0));
            this.progBarIRFrontLeft.Corners.UpperRight = ((short)(0));
            this.progBarIRFrontLeft.CylonInterval = ((short)(1));
            this.progBarIRFrontLeft.CylonMove = 5F;
            cFocalPoints13.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints13.CenterPoint")));
            cFocalPoints13.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints13.FocusScales")));
            this.progBarIRFrontLeft.FocalPoints = cFocalPoints13;
            this.progBarIRFrontLeft.Location = new System.Drawing.Point(61, 319);
            this.progBarIRFrontLeft.Max = 255;
            this.progBarIRFrontLeft.Name = "progBarIRFrontLeft";
            this.progBarIRFrontLeft.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.progBarIRFrontLeft.Shape = ProgBar.ProgBarPlus.eShape.TriangleDown;
            this.progBarIRFrontLeft.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.progBarIRFrontLeft.Size = new System.Drawing.Size(151, 67);
            this.progBarIRFrontLeft.TabIndex = 9;
            this.progBarIRFrontLeft.Value = 50;
            // 
            // progBarIRFrontRight
            // 
            cBlendItems14.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.Navy,
        System.Drawing.Color.Blue};
            cBlendItems14.iPoint = new float[] {
        0F,
        1F};
            this.progBarIRFrontRight.BarColorBlend = cBlendItems14;
            this.progBarIRFrontRight.BarColorSolid = System.Drawing.Color.Green;
            this.progBarIRFrontRight.BarColorSolidB = System.Drawing.Color.White;
            this.progBarIRFrontRight.BarLengthValue = ((short)(25));
            this.progBarIRFrontRight.BarPadding = new System.Windows.Forms.Padding(0);
            this.progBarIRFrontRight.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.progBarIRFrontRight.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progBarIRFrontRight.BarStyleTexture = null;
            this.progBarIRFrontRight.BorderWidth = ((short)(1));
            this.progBarIRFrontRight.Corners.All = ((short)(0));
            this.progBarIRFrontRight.Corners.LowerLeft = ((short)(0));
            this.progBarIRFrontRight.Corners.LowerRight = ((short)(0));
            this.progBarIRFrontRight.Corners.UpperLeft = ((short)(0));
            this.progBarIRFrontRight.Corners.UpperRight = ((short)(0));
            this.progBarIRFrontRight.CylonInterval = ((short)(1));
            this.progBarIRFrontRight.CylonMove = 5F;
            cFocalPoints14.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints14.CenterPoint")));
            cFocalPoints14.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints14.FocusScales")));
            this.progBarIRFrontRight.FocalPoints = cFocalPoints14;
            this.progBarIRFrontRight.Location = new System.Drawing.Point(260, 319);
            this.progBarIRFrontRight.Max = 255;
            this.progBarIRFrontRight.Name = "progBarIRFrontRight";
            this.progBarIRFrontRight.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.progBarIRFrontRight.Shape = ProgBar.ProgBarPlus.eShape.TriangleDown;
            this.progBarIRFrontRight.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.progBarIRFrontRight.Size = new System.Drawing.Size(151, 67);
            this.progBarIRFrontRight.TabIndex = 8;
            this.progBarIRFrontRight.Value = 50;
            // 
            // progBarIRBackRight
            // 
            cBlendItems15.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.Navy,
        System.Drawing.Color.Blue};
            cBlendItems15.iPoint = new float[] {
        0F,
        1F};
            this.progBarIRBackRight.BarColorBlend = cBlendItems15;
            this.progBarIRBackRight.BarColorSolid = System.Drawing.Color.Green;
            this.progBarIRBackRight.BarColorSolidB = System.Drawing.Color.White;
            this.progBarIRBackRight.BarLengthValue = ((short)(25));
            this.progBarIRBackRight.BarPadding = new System.Windows.Forms.Padding(0);
            this.progBarIRBackRight.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.progBarIRBackRight.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progBarIRBackRight.BarStyleTexture = null;
            this.progBarIRBackRight.BorderWidth = ((short)(1));
            this.progBarIRBackRight.Corners.All = ((short)(0));
            this.progBarIRBackRight.Corners.LowerLeft = ((short)(0));
            this.progBarIRBackRight.Corners.LowerRight = ((short)(0));
            this.progBarIRBackRight.Corners.UpperLeft = ((short)(0));
            this.progBarIRBackRight.Corners.UpperRight = ((short)(0));
            this.progBarIRBackRight.CylonInterval = ((short)(1));
            this.progBarIRBackRight.CylonMove = 5F;
            this.progBarIRBackRight.FillDirection = ProgBar.ProgBarPlus.eFillDirection.Down_Left;
            cFocalPoints15.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints15.CenterPoint")));
            cFocalPoints15.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints15.FocusScales")));
            this.progBarIRBackRight.FocalPoints = cFocalPoints15;
            this.progBarIRBackRight.Location = new System.Drawing.Point(260, 474);
            this.progBarIRBackRight.Max = 255;
            this.progBarIRBackRight.Name = "progBarIRBackRight";
            this.progBarIRBackRight.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.progBarIRBackRight.Shape = ProgBar.ProgBarPlus.eShape.TriangleUp;
            this.progBarIRBackRight.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.progBarIRBackRight.Size = new System.Drawing.Size(151, 67);
            this.progBarIRBackRight.TabIndex = 7;
            this.progBarIRBackRight.Value = 50;
            // 
            // progBarIRBackLeft
            // 
            cBlendItems16.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.Navy,
        System.Drawing.Color.Blue};
            cBlendItems16.iPoint = new float[] {
        0F,
        1F};
            this.progBarIRBackLeft.BarColorBlend = cBlendItems16;
            this.progBarIRBackLeft.BarColorSolid = System.Drawing.Color.Green;
            this.progBarIRBackLeft.BarColorSolidB = System.Drawing.Color.White;
            this.progBarIRBackLeft.BarLengthValue = ((short)(25));
            this.progBarIRBackLeft.BarPadding = new System.Windows.Forms.Padding(0);
            this.progBarIRBackLeft.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.progBarIRBackLeft.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progBarIRBackLeft.BarStyleTexture = null;
            this.progBarIRBackLeft.BorderWidth = ((short)(1));
            this.progBarIRBackLeft.Corners.All = ((short)(0));
            this.progBarIRBackLeft.Corners.LowerLeft = ((short)(0));
            this.progBarIRBackLeft.Corners.LowerRight = ((short)(0));
            this.progBarIRBackLeft.Corners.UpperLeft = ((short)(0));
            this.progBarIRBackLeft.Corners.UpperRight = ((short)(0));
            this.progBarIRBackLeft.CylonInterval = ((short)(1));
            this.progBarIRBackLeft.CylonMove = 5F;
            this.progBarIRBackLeft.FillDirection = ProgBar.ProgBarPlus.eFillDirection.Down_Left;
            cFocalPoints16.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints16.CenterPoint")));
            cFocalPoints16.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints16.FocusScales")));
            this.progBarIRBackLeft.FocalPoints = cFocalPoints16;
            this.progBarIRBackLeft.Location = new System.Drawing.Point(61, 474);
            this.progBarIRBackLeft.Max = 255;
            this.progBarIRBackLeft.Name = "progBarIRBackLeft";
            this.progBarIRBackLeft.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.progBarIRBackLeft.Shape = ProgBar.ProgBarPlus.eShape.TriangleUp;
            this.progBarIRBackLeft.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.progBarIRBackLeft.Size = new System.Drawing.Size(151, 67);
            this.progBarIRBackLeft.TabIndex = 6;
            this.progBarIRBackLeft.Value = 50;
            // 
            // progressBarBatteryLevel
            // 
            this.progressBarBatteryLevel.Location = new System.Drawing.Point(321, 553);
            this.progressBarBatteryLevel.Maximum = 255;
            this.progressBarBatteryLevel.Name = "progressBarBatteryLevel";
            this.progressBarBatteryLevel.Size = new System.Drawing.Size(110, 22);
            this.progressBarBatteryLevel.TabIndex = 12;
            // 
            // BatteryValue
            // 
            this.BatteryValue.AutoSize = true;
            this.BatteryValue.Location = new System.Drawing.Point(285, 562);
            this.BatteryValue.Name = "BatteryValue";
            this.BatteryValue.Size = new System.Drawing.Size(21, 13);
            this.BatteryValue.TabIndex = 13;
            this.BatteryValue.Text = "0%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LeftRearward);
            this.groupBox1.Controls.Add(this.LeftForward);
            this.groupBox1.Location = new System.Drawing.Point(37, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 75);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sens";
            // 
            // LeftRearward
            // 
            this.LeftRearward.AutoSize = true;
            this.LeftRearward.Location = new System.Drawing.Point(7, 44);
            this.LeftRearward.Name = "LeftRearward";
            this.LeftRearward.Size = new System.Drawing.Size(55, 17);
            this.LeftRearward.TabIndex = 1;
            this.LeftRearward.Text = "Arrière";
            this.LeftRearward.UseVisualStyleBackColor = true;
            // 
            // LeftForward
            // 
            this.LeftForward.AutoSize = true;
            this.LeftForward.Checked = true;
            this.LeftForward.Location = new System.Drawing.Point(7, 20);
            this.LeftForward.Name = "LeftForward";
            this.LeftForward.Size = new System.Drawing.Size(53, 17);
            this.LeftForward.TabIndex = 0;
            this.LeftForward.TabStop = true;
            this.LeftForward.Text = "Avant";
            this.LeftForward.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RightRearward);
            this.groupBox2.Controls.Add(this.RightForward);
            this.groupBox2.Location = new System.Drawing.Point(279, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 75);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sens";
            // 
            // RightRearward
            // 
            this.RightRearward.AutoSize = true;
            this.RightRearward.Location = new System.Drawing.Point(6, 44);
            this.RightRearward.Name = "RightRearward";
            this.RightRearward.Size = new System.Drawing.Size(55, 17);
            this.RightRearward.TabIndex = 1;
            this.RightRearward.Text = "Arrière";
            this.RightRearward.UseVisualStyleBackColor = true;
            // 
            // RightForward
            // 
            this.RightForward.AutoSize = true;
            this.RightForward.Checked = true;
            this.RightForward.Location = new System.Drawing.Point(6, 21);
            this.RightForward.Name = "RightForward";
            this.RightForward.Size = new System.Drawing.Size(53, 17);
            this.RightForward.TabIndex = 0;
            this.RightForward.TabStop = true;
            this.RightForward.Text = "Avant";
            this.RightForward.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 20);
            this.textBox1.TabIndex = 17;
            // 
            // GUICommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 575);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BatteryValue);
            this.Controls.Add(this.progressBarBatteryLevel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.progBarIRFrontLeft);
            this.Controls.Add(this.progBarIRFrontRight);
            this.Controls.Add(this.progBarIRBackRight);
            this.Controls.Add(this.progBarIRBackLeft);
            this.Controls.Add(this.progressBarRight);
            this.Controls.Add(this.progressBarLeft);
            this.Controls.Add(this.numericUpDownRight);
            this.Controls.Add(this.numericUpDownLeft);
            this.Controls.Add(this.RightWheels);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUICommande";
            this.Text = "GuiCommande";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RightWheels;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownRight;
        private System.Windows.Forms.ProgressBar progressBarLeft;
        private System.Windows.Forms.ProgressBar progressBarRight;
        private ProgBar.ProgBarPlus progBarIRBackLeft;
        private ProgBar.ProgBarPlus progBarIRBackRight;
        private ProgBar.ProgBarPlus progBarIRFrontRight;
        private ProgBar.ProgBarPlus progBarIRFrontLeft;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarBatteryLevel;
        private System.Windows.Forms.Label BatteryValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LeftRearward;
        private System.Windows.Forms.RadioButton LeftForward;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RightRearward;
        private System.Windows.Forms.RadioButton RightForward;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

