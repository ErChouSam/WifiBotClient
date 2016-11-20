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
            ProgBar.cBlendItems cBlendItems9 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints9 = new ProgBar.cFocalPoints();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUICommande));
            ProgBar.cBlendItems cBlendItems10 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints10 = new ProgBar.cFocalPoints();
            ProgBar.cBlendItems cBlendItems11 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints11 = new ProgBar.cFocalPoints();
            ProgBar.cBlendItems cBlendItems12 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints12 = new ProgBar.cFocalPoints();
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
            this.progBarIRTopLeft = new ProgBar.ProgBarPlus();
            this.progBarIRTopRight = new ProgBar.ProgBarPlus();
            this.progBarIRBotRight = new ProgBar.ProgBarPlus();
            this.progBarIRBotLeft = new ProgBar.ProgBarPlus();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // cameraViewToolStripMenuItem
            // 
            this.cameraViewToolStripMenuItem.Name = "cameraViewToolStripMenuItem";
            this.cameraViewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cameraViewToolStripMenuItem.Text = "Camera View";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // progBarIRTopLeft
            // 
            cBlendItems9.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.Navy,
        System.Drawing.Color.Blue};
            cBlendItems9.iPoint = new float[] {
        0F,
        1F};
            this.progBarIRTopLeft.BarColorBlend = cBlendItems9;
            this.progBarIRTopLeft.BarColorSolid = System.Drawing.Color.Green;
            this.progBarIRTopLeft.BarColorSolidB = System.Drawing.Color.White;
            this.progBarIRTopLeft.BarLengthValue = ((short)(25));
            this.progBarIRTopLeft.BarPadding = new System.Windows.Forms.Padding(0);
            this.progBarIRTopLeft.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.progBarIRTopLeft.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progBarIRTopLeft.BarStyleTexture = null;
            this.progBarIRTopLeft.BorderWidth = ((short)(1));
            this.progBarIRTopLeft.Corners.All = ((short)(0));
            this.progBarIRTopLeft.Corners.LowerLeft = ((short)(0));
            this.progBarIRTopLeft.Corners.LowerRight = ((short)(0));
            this.progBarIRTopLeft.Corners.UpperLeft = ((short)(0));
            this.progBarIRTopLeft.Corners.UpperRight = ((short)(0));
            this.progBarIRTopLeft.CylonInterval = ((short)(1));
            this.progBarIRTopLeft.CylonMove = 5F;
            cFocalPoints9.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints9.CenterPoint")));
            cFocalPoints9.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints9.FocusScales")));
            this.progBarIRTopLeft.FocalPoints = cFocalPoints9;
            this.progBarIRTopLeft.Location = new System.Drawing.Point(61, 319);
            this.progBarIRTopLeft.Name = "progBarIRTopLeft";
            this.progBarIRTopLeft.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.progBarIRTopLeft.Shape = ProgBar.ProgBarPlus.eShape.TriangleDown;
            this.progBarIRTopLeft.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.progBarIRTopLeft.Size = new System.Drawing.Size(151, 67);
            this.progBarIRTopLeft.TabIndex = 9;
            this.progBarIRTopLeft.Value = 50;
            // 
            // progBarIRTopRight
            // 
            cBlendItems10.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.Navy,
        System.Drawing.Color.Blue};
            cBlendItems10.iPoint = new float[] {
        0F,
        1F};
            this.progBarIRTopRight.BarColorBlend = cBlendItems10;
            this.progBarIRTopRight.BarColorSolid = System.Drawing.Color.Green;
            this.progBarIRTopRight.BarColorSolidB = System.Drawing.Color.White;
            this.progBarIRTopRight.BarLengthValue = ((short)(25));
            this.progBarIRTopRight.BarPadding = new System.Windows.Forms.Padding(0);
            this.progBarIRTopRight.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.progBarIRTopRight.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progBarIRTopRight.BarStyleTexture = null;
            this.progBarIRTopRight.BorderWidth = ((short)(1));
            this.progBarIRTopRight.Corners.All = ((short)(0));
            this.progBarIRTopRight.Corners.LowerLeft = ((short)(0));
            this.progBarIRTopRight.Corners.LowerRight = ((short)(0));
            this.progBarIRTopRight.Corners.UpperLeft = ((short)(0));
            this.progBarIRTopRight.Corners.UpperRight = ((short)(0));
            this.progBarIRTopRight.CylonInterval = ((short)(1));
            this.progBarIRTopRight.CylonMove = 5F;
            cFocalPoints10.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints10.CenterPoint")));
            cFocalPoints10.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints10.FocusScales")));
            this.progBarIRTopRight.FocalPoints = cFocalPoints10;
            this.progBarIRTopRight.Location = new System.Drawing.Point(260, 319);
            this.progBarIRTopRight.Name = "progBarIRTopRight";
            this.progBarIRTopRight.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.progBarIRTopRight.Shape = ProgBar.ProgBarPlus.eShape.TriangleDown;
            this.progBarIRTopRight.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.progBarIRTopRight.Size = new System.Drawing.Size(151, 67);
            this.progBarIRTopRight.TabIndex = 8;
            this.progBarIRTopRight.Value = 50;
            // 
            // progBarIRBotRight
            // 
            cBlendItems11.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.Navy,
        System.Drawing.Color.Blue};
            cBlendItems11.iPoint = new float[] {
        0F,
        1F};
            this.progBarIRBotRight.BarColorBlend = cBlendItems11;
            this.progBarIRBotRight.BarColorSolid = System.Drawing.Color.Green;
            this.progBarIRBotRight.BarColorSolidB = System.Drawing.Color.White;
            this.progBarIRBotRight.BarLengthValue = ((short)(25));
            this.progBarIRBotRight.BarPadding = new System.Windows.Forms.Padding(0);
            this.progBarIRBotRight.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.progBarIRBotRight.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progBarIRBotRight.BarStyleTexture = null;
            this.progBarIRBotRight.BorderWidth = ((short)(1));
            this.progBarIRBotRight.Corners.All = ((short)(0));
            this.progBarIRBotRight.Corners.LowerLeft = ((short)(0));
            this.progBarIRBotRight.Corners.LowerRight = ((short)(0));
            this.progBarIRBotRight.Corners.UpperLeft = ((short)(0));
            this.progBarIRBotRight.Corners.UpperRight = ((short)(0));
            this.progBarIRBotRight.CylonInterval = ((short)(1));
            this.progBarIRBotRight.CylonMove = 5F;
            this.progBarIRBotRight.FillDirection = ProgBar.ProgBarPlus.eFillDirection.Down_Left;
            cFocalPoints11.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints11.CenterPoint")));
            cFocalPoints11.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints11.FocusScales")));
            this.progBarIRBotRight.FocalPoints = cFocalPoints11;
            this.progBarIRBotRight.Location = new System.Drawing.Point(260, 474);
            this.progBarIRBotRight.Name = "progBarIRBotRight";
            this.progBarIRBotRight.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.progBarIRBotRight.Shape = ProgBar.ProgBarPlus.eShape.TriangleUp;
            this.progBarIRBotRight.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.progBarIRBotRight.Size = new System.Drawing.Size(151, 67);
            this.progBarIRBotRight.TabIndex = 7;
            this.progBarIRBotRight.Value = 50;
            // 
            // progBarIRBotLeft
            // 
            cBlendItems12.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.Navy,
        System.Drawing.Color.Blue};
            cBlendItems12.iPoint = new float[] {
        0F,
        1F};
            this.progBarIRBotLeft.BarColorBlend = cBlendItems12;
            this.progBarIRBotLeft.BarColorSolid = System.Drawing.Color.Green;
            this.progBarIRBotLeft.BarColorSolidB = System.Drawing.Color.White;
            this.progBarIRBotLeft.BarLengthValue = ((short)(25));
            this.progBarIRBotLeft.BarPadding = new System.Windows.Forms.Padding(0);
            this.progBarIRBotLeft.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.progBarIRBotLeft.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progBarIRBotLeft.BarStyleTexture = null;
            this.progBarIRBotLeft.BorderWidth = ((short)(1));
            this.progBarIRBotLeft.Corners.All = ((short)(0));
            this.progBarIRBotLeft.Corners.LowerLeft = ((short)(0));
            this.progBarIRBotLeft.Corners.LowerRight = ((short)(0));
            this.progBarIRBotLeft.Corners.UpperLeft = ((short)(0));
            this.progBarIRBotLeft.Corners.UpperRight = ((short)(0));
            this.progBarIRBotLeft.CylonInterval = ((short)(1));
            this.progBarIRBotLeft.CylonMove = 5F;
            this.progBarIRBotLeft.FillDirection = ProgBar.ProgBarPlus.eFillDirection.Down_Left;
            cFocalPoints12.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints12.CenterPoint")));
            cFocalPoints12.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints12.FocusScales")));
            this.progBarIRBotLeft.FocalPoints = cFocalPoints12;
            this.progBarIRBotLeft.Location = new System.Drawing.Point(61, 474);
            this.progBarIRBotLeft.Name = "progBarIRBotLeft";
            this.progBarIRBotLeft.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.progBarIRBotLeft.Shape = ProgBar.ProgBarPlus.eShape.TriangleUp;
            this.progBarIRBotLeft.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.progBarIRBotLeft.Size = new System.Drawing.Size(151, 67);
            this.progBarIRBotLeft.TabIndex = 6;
            this.progBarIRBotLeft.Value = 50;
            // 
            // GUICommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 575);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.progBarIRTopLeft);
            this.Controls.Add(this.progBarIRTopRight);
            this.Controls.Add(this.progBarIRBotRight);
            this.Controls.Add(this.progBarIRBotLeft);
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
        private ProgBar.ProgBarPlus progBarIRBotLeft;
        private ProgBar.ProgBarPlus progBarIRBotRight;
        private ProgBar.ProgBarPlus progBarIRTopRight;
        private ProgBar.ProgBarPlus progBarIRTopLeft;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

