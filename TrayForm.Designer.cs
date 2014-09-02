namespace TrayShutdownMenu
{
    partial class TrayForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAutorun = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolLogoff = new System.Windows.Forms.ToolStripButton();
            this.toolSleep = new System.Windows.Forms.ToolStripButton();
            this.toolShutdown = new System.Windows.Forms.ToolStripButton();
            this.toolRestart = new System.Windows.Forms.ToolStripButton();
            this.contextMenu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAutorun,
            this.toolStripSeparator,
            this.menuAbout,
            this.menuExit});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.ShowCheckMargin = true;
            this.contextMenu.ShowImageMargin = false;
            this.contextMenu.ShowItemToolTips = false;
            resources.ApplyResources(this.contextMenu, "contextMenu");
            // 
            // menuAutorun
            // 
            this.menuAutorun.CheckOnClick = true;
            this.menuAutorun.Name = "menuAutorun";
            resources.ApplyResources(this.menuAutorun, "menuAutorun");
            this.menuAutorun.CheckedChanged += new System.EventHandler(this.menuAutorun_CheckedChanged);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            resources.ApplyResources(this.menuAbout, "menuAbout");
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            resources.ApplyResources(this.menuExit, "menuExit");
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.CanOverflow = false;
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLogoff,
            this.toolSleep,
            this.toolShutdown,
            this.toolRestart});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip.Name = "toolStrip";
            // 
            // toolLogoff
            // 
            resources.ApplyResources(this.toolLogoff, "toolLogoff");
            this.toolLogoff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLogoff.Image = global::TrayShutdownMenu.Properties.Resources.Logoff;
            this.toolLogoff.Margin = new System.Windows.Forms.Padding(0);
            this.toolLogoff.Name = "toolLogoff";
            this.toolLogoff.Click += new System.EventHandler(this.buttonLogoff_Click);
            // 
            // toolSleep
            // 
            resources.ApplyResources(this.toolSleep, "toolSleep");
            this.toolSleep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSleep.Image = global::TrayShutdownMenu.Properties.Resources.Sleep;
            this.toolSleep.Margin = new System.Windows.Forms.Padding(0);
            this.toolSleep.Name = "toolSleep";
            this.toolSleep.Click += new System.EventHandler(this.buttonSleep_Click);
            // 
            // toolShutdown
            // 
            resources.ApplyResources(this.toolShutdown, "toolShutdown");
            this.toolShutdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolShutdown.Image = global::TrayShutdownMenu.Properties.Resources.Shutdown;
            this.toolShutdown.Margin = new System.Windows.Forms.Padding(0);
            this.toolShutdown.Name = "toolShutdown";
            this.toolShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // toolRestart
            // 
            resources.ApplyResources(this.toolRestart, "toolRestart");
            this.toolRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRestart.Image = global::TrayShutdownMenu.Properties.Resources.Restart;
            this.toolRestart.Margin = new System.Windows.Forms.Padding(0);
            this.toolRestart.Name = "toolRestart";
            this.toolRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // TrayForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrayForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.TrayForm_Deactivate);
            this.contextMenu.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolLogoff;
        private System.Windows.Forms.ToolStripButton toolSleep;
        private System.Windows.Forms.ToolStripButton toolShutdown;
        private System.Windows.Forms.ToolStripButton toolRestart;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuAutorun;
    }
}

