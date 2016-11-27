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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUICommande));
            ProgBar.cBlendItems cBlendItems5 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints5 = new ProgBar.cFocalPoints();
            ProgBar.cBlendItems cBlendItems6 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints6 = new ProgBar.cFocalPoints();
            ProgBar.cBlendItems cBlendItems7 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints7 = new ProgBar.cFocalPoints();
            ProgBar.cBlendItems cBlendItems8 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints8 = new ProgBar.cFocalPoints();
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // RightWheels
            // 
            resources.ApplyResources(this.RightWheels, "RightWheels");
            this.RightWheels.Name = "RightWheels";
            // 
            // numericUpDownLeft
            // 
            resources.ApplyResources(this.numericUpDownLeft, "numericUpDownLeft");
            this.numericUpDownLeft.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownLeft.Name = "numericUpDownLeft";
            this.numericUpDownLeft.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownLeft.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDownRight
            // 
            resources.ApplyResources(this.numericUpDownRight, "numericUpDownRight");
            this.numericUpDownRight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRight.Name = "numericUpDownRight";
            this.numericUpDownRight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownRight.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // progressBarLeft
            // 
            resources.ApplyResources(this.progressBarLeft, "progressBarLeft");
            this.progressBarLeft.Name = "progressBarLeft";
            // 
            // progressBarRight
            // 
            resources.ApplyResources(this.progressBarRight, "progressBarRight");
            this.progressBarRight.Name = "progressBarRight";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            resources.ApplyResources(this.menuToolStripMenuItem, "menuToolStripMenuItem");
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.cameraViewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            // 
            // connectionToolStripMenuItem
            // 
            resources.ApplyResources(this.connectionToolStripMenuItem, "connectionToolStripMenuItem");
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // cameraViewToolStripMenuItem
            // 
            resources.ApplyResources(this.cameraViewToolStripMenuItem, "cameraViewToolStripMenuItem");
            this.cameraViewToolStripMenuItem.Name = "cameraViewToolStripMenuItem";
            this.cameraViewToolStripMenuItem.Click += new System.EventHandler(this.cameraViewToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            // 
            // quitterToolStripMenuItem
            // 
            resources.ApplyResources(this.quitterToolStripMenuItem, "quitterToolStripMenuItem");
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // progBarIRFrontLeft
            // 
            resources.ApplyResources(this.progBarIRFrontLeft, "progBarIRFrontLeft");
            cBlendItems5.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.Navy,
        System.Drawing.Color.Blue};
            cBlendItems5.iPoint = new float[] {
        0F,
        1F};
            this.progBarIRFrontLeft.BarColorBlend = cBlendItems5;
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
            cFocalPoints5.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints5.CenterPoint")));
            cFocalPoints5.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints5.FocusScales")));
            this.progBarIRFrontLeft.FocalPoints = cFocalPoints5;
            this.progBarIRFrontLeft.Max = 255;
            this.progBarIRFrontLeft.Name = "progBarIRFrontLeft";
            this.progBarIRFrontLeft.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.progBarIRFrontLeft.Shape = ProgBar.ProgBarPlus.eShape.TriangleDown;
            this.progBarIRFrontLeft.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.progBarIRFrontLeft.Value = 50;
            // 
            // progBarIRFrontRight
            // 
            resources.ApplyResources(this.progBarIRFrontRight, "progBarIRFrontRight");
            cBlendItems6.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.Navy,
        System.Drawing.Color.Blue};
            cBlendItems6.iPoint = new float[] {
        0F,
        1F};
            this.progBarIRFrontRight.BarColorBlend = cBlendItems6;
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
            cFocalPoints6.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints6.CenterPoint")));
            cFocalPoints6.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints6.FocusScales")));
            this.progBarIRFrontRight.FocalPoints = cFocalPoints6;
            this.progBarIRFrontRight.Max = 255;
            this.progBarIRFrontRight.Name = "progBarIRFrontRight";
            this.progBarIRFrontRight.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.progBarIRFrontRight.Shape = ProgBar.ProgBarPlus.eShape.TriangleDown;
            this.progBarIRFrontRight.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.progBarIRFrontRight.Value = 50;
            // 
            // progBarIRBackRight
            // 
            resources.ApplyResources(this.progBarIRBackRight, "progBarIRBackRight");
            cBlendItems7.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.Navy,
        System.Drawing.Color.Blue};
            cBlendItems7.iPoint = new float[] {
        0F,
        1F};
            this.progBarIRBackRight.BarColorBlend = cBlendItems7;
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
            cFocalPoints7.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints7.CenterPoint")));
            cFocalPoints7.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints7.FocusScales")));
            this.progBarIRBackRight.FocalPoints = cFocalPoints7;
            this.progBarIRBackRight.Max = 255;
            this.progBarIRBackRight.Name = "progBarIRBackRight";
            this.progBarIRBackRight.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.progBarIRBackRight.Shape = ProgBar.ProgBarPlus.eShape.TriangleUp;
            this.progBarIRBackRight.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.progBarIRBackRight.Value = 50;
            // 
            // progBarIRBackLeft
            // 
            resources.ApplyResources(this.progBarIRBackLeft, "progBarIRBackLeft");
            cBlendItems8.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.Navy,
        System.Drawing.Color.Blue};
            cBlendItems8.iPoint = new float[] {
        0F,
        1F};
            this.progBarIRBackLeft.BarColorBlend = cBlendItems8;
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
            cFocalPoints8.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints8.CenterPoint")));
            cFocalPoints8.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints8.FocusScales")));
            this.progBarIRBackLeft.FocalPoints = cFocalPoints8;
            this.progBarIRBackLeft.Max = 255;
            this.progBarIRBackLeft.Name = "progBarIRBackLeft";
            this.progBarIRBackLeft.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.progBarIRBackLeft.Shape = ProgBar.ProgBarPlus.eShape.TriangleUp;
            this.progBarIRBackLeft.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.progBarIRBackLeft.Value = 50;
            // 
            // progressBarBatteryLevel
            // 
            resources.ApplyResources(this.progressBarBatteryLevel, "progressBarBatteryLevel");
            this.progressBarBatteryLevel.Maximum = 255;
            this.progressBarBatteryLevel.Name = "progressBarBatteryLevel";
            // 
            // BatteryValue
            // 
            resources.ApplyResources(this.BatteryValue, "BatteryValue");
            this.BatteryValue.Name = "BatteryValue";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.LeftRearward);
            this.groupBox1.Controls.Add(this.LeftForward);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // LeftRearward
            // 
            resources.ApplyResources(this.LeftRearward, "LeftRearward");
            this.LeftRearward.Name = "LeftRearward";
            this.LeftRearward.UseVisualStyleBackColor = true;
            // 
            // LeftForward
            // 
            resources.ApplyResources(this.LeftForward, "LeftForward");
            this.LeftForward.Checked = true;
            this.LeftForward.Name = "LeftForward";
            this.LeftForward.TabStop = true;
            this.LeftForward.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.RightRearward);
            this.groupBox2.Controls.Add(this.RightForward);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // RightRearward
            // 
            resources.ApplyResources(this.RightRearward, "RightRearward");
            this.RightRearward.Name = "RightRearward";
            this.RightRearward.UseVisualStyleBackColor = true;
            // 
            // RightForward
            // 
            resources.ApplyResources(this.RightForward, "RightForward");
            this.RightForward.Checked = true;
            this.RightForward.Name = "RightForward";
            this.RightForward.TabStop = true;
            this.RightForward.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // GUICommande
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

