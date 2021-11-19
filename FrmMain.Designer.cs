namespace Navegador819
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnForward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.loader = new Bunifu.UI.WinForms.BunifuLoader();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.iconSecurity = new System.Windows.Forms.PictureBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSecurity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.bunifuPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnForward
            // 
            this.btnForward.ActiveImage = null;
            this.btnForward.AllowAnimations = true;
            this.btnForward.AllowBuffering = false;
            this.btnForward.AllowToggling = false;
            this.btnForward.AllowZooming = true;
            this.btnForward.AllowZoomingOnFocus = false;
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnForward.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnForward.ErrorImage")));
            this.btnForward.FadeWhenInactive = false;
            this.btnForward.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageActive = null;
            this.btnForward.ImageLocation = null;
            this.btnForward.ImageMargin = 10;
            this.btnForward.ImageSize = new System.Drawing.Size(25, 25);
            this.btnForward.ImageZoomSize = new System.Drawing.Size(35, 35);
            this.btnForward.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnForward.InitialImage")));
            this.btnForward.Location = new System.Drawing.Point(52, 10);
            this.btnForward.Name = "btnForward";
            this.btnForward.Rotation = 0;
            this.btnForward.ShowActiveImage = true;
            this.btnForward.ShowCursorChanges = true;
            this.btnForward.ShowImageBorders = true;
            this.btnForward.ShowSizeMarkers = false;
            this.btnForward.Size = new System.Drawing.Size(35, 35);
            this.btnForward.TabIndex = 2;
            this.btnForward.ToolTipText = "";
            this.btnForward.WaitOnLoad = false;
            this.btnForward.Zoom = 10;
            this.btnForward.ZoomSpeed = 10;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.ActiveImage = null;
            this.btnBack.AllowAnimations = true;
            this.btnBack.AllowBuffering = false;
            this.btnBack.AllowToggling = false;
            this.btnBack.AllowZooming = true;
            this.btnBack.AllowZoomingOnFocus = false;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBack.ErrorImage")));
            this.btnBack.FadeWhenInactive = false;
            this.btnBack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.ImageLocation = null;
            this.btnBack.ImageMargin = 10;
            this.btnBack.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBack.ImageZoomSize = new System.Drawing.Size(35, 35);
            this.btnBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBack.InitialImage")));
            this.btnBack.Location = new System.Drawing.Point(9, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 0;
            this.btnBack.ShowActiveImage = true;
            this.btnBack.ShowCursorChanges = true;
            this.btnBack.ShowImageBorders = true;
            this.btnBack.ShowSizeMarkers = false;
            this.btnBack.Size = new System.Drawing.Size(35, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.ToolTipText = "";
            this.btnBack.WaitOnLoad = false;
            this.btnBack.Zoom = 10;
            this.btnBack.ZoomSpeed = 10;
            this.btnBack.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveImage = null;
            this.btnRefresh.AllowAnimations = true;
            this.btnRefresh.AllowBuffering = false;
            this.btnRefresh.AllowToggling = false;
            this.btnRefresh.AllowZooming = true;
            this.btnRefresh.AllowZoomingOnFocus = false;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ErrorImage")));
            this.btnRefresh.FadeWhenInactive = false;
            this.btnRefresh.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.ImageLocation = null;
            this.btnRefresh.ImageMargin = 10;
            this.btnRefresh.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRefresh.ImageZoomSize = new System.Drawing.Size(35, 35);
            this.btnRefresh.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.InitialImage")));
            this.btnRefresh.Location = new System.Drawing.Point(95, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Rotation = 0;
            this.btnRefresh.ShowActiveImage = true;
            this.btnRefresh.ShowCursorChanges = true;
            this.btnRefresh.ShowImageBorders = true;
            this.btnRefresh.ShowSizeMarkers = false;
            this.btnRefresh.Size = new System.Drawing.Size(35, 35);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.ToolTipText = "";
            this.btnRefresh.WaitOnLoad = false;
            this.btnRefresh.Zoom = 10;
            this.btnRefresh.ZoomSpeed = 10;
            this.btnRefresh.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.loader);
            this.bunifuPanel1.Controls.Add(this.txtURL);
            this.bunifuPanel1.Controls.Add(this.iconSecurity);
            this.bunifuPanel1.Location = new System.Drawing.Point(132, 15);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(850, 29);
            this.bunifuPanel1.TabIndex = 0;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // loader
            // 
            this.loader.AllowStylePresets = true;
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.loader.Color = System.Drawing.Color.Gray;
            this.loader.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.loader.Customization = "";
            this.loader.DashWidth = 0.5F;
            this.loader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loader.Image = null;
            this.loader.Location = new System.Drawing.Point(13, 3);
            this.loader.Name = "loader";
            this.loader.NoRounding = false;
            this.loader.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.loader.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.loader.ShowText = false;
            this.loader.Size = new System.Drawing.Size(22, 23);
            this.loader.Speed = 7;
            this.loader.TabIndex = 2;
            this.loader.Text = "bunifuLoader1";
            this.loader.TextPadding = new System.Windows.Forms.Padding(0);
            this.loader.Thickness = 3;
            this.loader.Transparent = true;
            this.loader.Visible = false;
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtURL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.ForeColor = System.Drawing.Color.Black;
            this.txtURL.Location = new System.Drawing.Point(42, 5);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(793, 18);
            this.txtURL.TabIndex = 1;
            this.txtURL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyUp);
            // 
            // iconSecurity
            // 
            this.iconSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconSecurity.Image = ((System.Drawing.Image)(resources.GetObject("iconSecurity.Image")));
            this.iconSecurity.Location = new System.Drawing.Point(13, 5);
            this.iconSecurity.Name = "iconSecurity";
            this.iconSecurity.Size = new System.Drawing.Size(20, 20);
            this.iconSecurity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconSecurity.TabIndex = 0;
            this.iconSecurity.TabStop = false;
            this.iconSecurity.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 56);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(994, 572);
            this.pnlBody.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "protect.png");
            this.imageList1.Images.SetKeyName(1, "unlock.png");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 628);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSecurity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBody;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.PictureBox iconSecurity;
        private Bunifu.UI.WinForms.BunifuImageButton btnRefresh;
        private Bunifu.UI.WinForms.BunifuImageButton btnForward;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
        private Bunifu.UI.WinForms.BunifuLoader loader;
        private System.Windows.Forms.ImageList imageList1;
    }
}

