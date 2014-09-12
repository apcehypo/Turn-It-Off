namespace TurnItOff
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
            this.contextMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAutorun = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfirmation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.toolLogoff = new System.Windows.Forms.ToolStripButton();
            this.toolSleep = new System.Windows.Forms.ToolStripButton();
            this.toolShutdown = new System.Windows.Forms.ToolStripButton();
            this.toolRestart = new System.Windows.Forms.ToolStripButton();
            this.panelDelay = new System.Windows.Forms.Panel();
            this.toolsDelay = new System.Windows.Forms.ToolStrip();
            this.toolDelay5m = new System.Windows.Forms.ToolStripButton();
            this.toolDelay15m = new System.Windows.Forms.ToolStripButton();
            this.toolDelay30m = new System.Windows.Forms.ToolStripButton();
            this.toolDelay1h = new System.Windows.Forms.ToolStripButton();
            this.toolDelay2h = new System.Windows.Forms.ToolStripButton();
            this.toolDelay3h = new System.Windows.Forms.ToolStripButton();
            this.toolDelay4h = new System.Windows.Forms.ToolStripButton();
            this.toolDelay5h = new System.Windows.Forms.ToolStripButton();
            this.toolDelay6h = new System.Windows.Forms.ToolStripButton();
            this.toolDelay8h = new System.Windows.Forms.ToolStripButton();
            this.toolDelay12h = new System.Windows.Forms.ToolStripButton();
            this.toolDelayInput = new System.Windows.Forms.ToolStripButton();
            this.panelCancellation = new System.Windows.Forms.Panel();
            this.toolsCancellation = new System.Windows.Forms.ToolStrip();
            this.toolCancelLogoff = new System.Windows.Forms.ToolStripButton();
            this.toolCancelSleep = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolCancelShutdown = new System.Windows.Forms.ToolStripButton();
            this.toolCancelRestart = new System.Windows.Forms.ToolStripButton();
            this.timeoutProgress = new System.Windows.Forms.ToolStripLabel();
            this.timerFade = new System.Windows.Forms.Timer(this.components);
            this.contextMenuTray.SuspendLayout();
            this.tools.SuspendLayout();
            this.panelDelay.SuspendLayout();
            this.toolsDelay.SuspendLayout();
            this.panelCancellation.SuspendLayout();
            this.toolsCancellation.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.ContextMenuStrip = this.contextMenuTray;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuTray
            // 
            this.contextMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAutorun,
            this.menuConfirmation,
            this.toolStripSeparator,
            this.menuAbout,
            this.menuExit});
            this.contextMenuTray.Name = "contextMenu";
            this.contextMenuTray.ShowCheckMargin = true;
            this.contextMenuTray.ShowImageMargin = false;
            this.contextMenuTray.ShowItemToolTips = false;
            resources.ApplyResources(this.contextMenuTray, "contextMenuTray");
            // 
            // menuAutorun
            // 
            this.menuAutorun.CheckOnClick = true;
            this.menuAutorun.Name = "menuAutorun";
            resources.ApplyResources(this.menuAutorun, "menuAutorun");
            this.menuAutorun.CheckedChanged += new System.EventHandler(this.menuAutorun_CheckedChanged);
            // 
            // menuConfirmation
            // 
            this.menuConfirmation.Checked = true;
            this.menuConfirmation.CheckOnClick = true;
            this.menuConfirmation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuConfirmation.Name = "menuConfirmation";
            resources.ApplyResources(this.menuConfirmation, "menuConfirmation");
            this.menuConfirmation.CheckedChanged += new System.EventHandler(this.menuConfirmation_CheckedChanged);
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
            // tools
            // 
            this.tools.BackColor = System.Drawing.Color.White;
            this.tools.CanOverflow = false;
            resources.ApplyResources(this.tools, "tools");
            this.tools.GripMargin = new System.Windows.Forms.Padding(0);
            this.tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tools.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLogoff,
            this.toolSleep,
            this.toolShutdown,
            this.toolRestart});
            this.tools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tools.Name = "tools";
            // 
            // toolLogoff
            // 
            resources.ApplyResources(this.toolLogoff, "toolLogoff");
            this.toolLogoff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLogoff.Image = global::TurnItOff.Properties.Resources.Logoff;
            this.toolLogoff.Margin = new System.Windows.Forms.Padding(0);
            this.toolLogoff.Name = "toolLogoff";
            this.toolLogoff.Tag = "Logoff";
            this.toolLogoff.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolButtons_MouseUp);
            // 
            // toolSleep
            // 
            resources.ApplyResources(this.toolSleep, "toolSleep");
            this.toolSleep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSleep.Image = global::TurnItOff.Properties.Resources.Sleep;
            this.toolSleep.Margin = new System.Windows.Forms.Padding(0);
            this.toolSleep.Name = "toolSleep";
            this.toolSleep.Tag = "Sleep";
            this.toolSleep.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolButtons_MouseUp);
            // 
            // toolShutdown
            // 
            resources.ApplyResources(this.toolShutdown, "toolShutdown");
            this.toolShutdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolShutdown.Image = global::TurnItOff.Properties.Resources.Shutdown;
            this.toolShutdown.Margin = new System.Windows.Forms.Padding(0);
            this.toolShutdown.Name = "toolShutdown";
            this.toolShutdown.Tag = "Shutdown";
            this.toolShutdown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolButtons_MouseUp);
            // 
            // toolRestart
            // 
            resources.ApplyResources(this.toolRestart, "toolRestart");
            this.toolRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRestart.Image = global::TurnItOff.Properties.Resources.Restart;
            this.toolRestart.Margin = new System.Windows.Forms.Padding(0);
            this.toolRestart.Name = "toolRestart";
            this.toolRestart.Tag = "Restart";
            this.toolRestart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolButtons_MouseUp);
            // 
            // panelDelay
            // 
            this.panelDelay.Controls.Add(this.toolsDelay);
            resources.ApplyResources(this.panelDelay, "panelDelay");
            this.panelDelay.Name = "panelDelay";
            // 
            // toolsDelay
            // 
            this.toolsDelay.BackColor = System.Drawing.Color.White;
            this.toolsDelay.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsDelay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDelay5m,
            this.toolDelay15m,
            this.toolDelay30m,
            this.toolDelay1h,
            this.toolDelay2h,
            this.toolDelay3h,
            this.toolDelay4h,
            this.toolDelay5h,
            this.toolDelay6h,
            this.toolDelay8h,
            this.toolDelay12h,
            this.toolDelayInput});
            this.toolsDelay.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            resources.ApplyResources(this.toolsDelay, "toolsDelay");
            this.toolsDelay.Name = "toolsDelay";
            this.toolsDelay.ShowItemToolTips = false;
            // 
            // toolDelay5m
            // 
            resources.ApplyResources(this.toolDelay5m, "toolDelay5m");
            this.toolDelay5m.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDelay5m.Margin = new System.Windows.Forms.Padding(0);
            this.toolDelay5m.Name = "toolDelay5m";
            this.toolDelay5m.Tag = "5";
            this.toolDelay5m.Click += new System.EventHandler(this.toolDelay_Click);
            // 
            // toolDelay15m
            // 
            resources.ApplyResources(this.toolDelay15m, "toolDelay15m");
            this.toolDelay15m.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDelay15m.Margin = new System.Windows.Forms.Padding(0);
            this.toolDelay15m.Name = "toolDelay15m";
            this.toolDelay15m.Tag = "15";
            this.toolDelay15m.Click += new System.EventHandler(this.toolDelay_Click);
            // 
            // toolDelay30m
            // 
            resources.ApplyResources(this.toolDelay30m, "toolDelay30m");
            this.toolDelay30m.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDelay30m.Margin = new System.Windows.Forms.Padding(0);
            this.toolDelay30m.Name = "toolDelay30m";
            this.toolDelay30m.Tag = "30";
            this.toolDelay30m.Click += new System.EventHandler(this.toolDelay_Click);
            // 
            // toolDelay1h
            // 
            resources.ApplyResources(this.toolDelay1h, "toolDelay1h");
            this.toolDelay1h.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDelay1h.Margin = new System.Windows.Forms.Padding(0);
            this.toolDelay1h.Name = "toolDelay1h";
            this.toolDelay1h.Tag = "60";
            this.toolDelay1h.Click += new System.EventHandler(this.toolDelay_Click);
            // 
            // toolDelay2h
            // 
            resources.ApplyResources(this.toolDelay2h, "toolDelay2h");
            this.toolDelay2h.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDelay2h.Margin = new System.Windows.Forms.Padding(0);
            this.toolDelay2h.Name = "toolDelay2h";
            this.toolDelay2h.Tag = "120";
            this.toolDelay2h.Click += new System.EventHandler(this.toolDelay_Click);
            // 
            // toolDelay3h
            // 
            resources.ApplyResources(this.toolDelay3h, "toolDelay3h");
            this.toolDelay3h.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDelay3h.Margin = new System.Windows.Forms.Padding(0);
            this.toolDelay3h.Name = "toolDelay3h";
            this.toolDelay3h.Tag = "180";
            this.toolDelay3h.Click += new System.EventHandler(this.toolDelay_Click);
            // 
            // toolDelay4h
            // 
            resources.ApplyResources(this.toolDelay4h, "toolDelay4h");
            this.toolDelay4h.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDelay4h.Margin = new System.Windows.Forms.Padding(0);
            this.toolDelay4h.Name = "toolDelay4h";
            this.toolDelay4h.Tag = "240";
            this.toolDelay4h.Click += new System.EventHandler(this.toolDelay_Click);
            // 
            // toolDelay5h
            // 
            resources.ApplyResources(this.toolDelay5h, "toolDelay5h");
            this.toolDelay5h.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDelay5h.Margin = new System.Windows.Forms.Padding(0);
            this.toolDelay5h.Name = "toolDelay5h";
            this.toolDelay5h.Tag = "300";
            this.toolDelay5h.Click += new System.EventHandler(this.toolDelay_Click);
            // 
            // toolDelay6h
            // 
            resources.ApplyResources(this.toolDelay6h, "toolDelay6h");
            this.toolDelay6h.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDelay6h.Margin = new System.Windows.Forms.Padding(0);
            this.toolDelay6h.Name = "toolDelay6h";
            this.toolDelay6h.Tag = "360";
            this.toolDelay6h.Click += new System.EventHandler(this.toolDelay_Click);
            // 
            // toolDelay8h
            // 
            resources.ApplyResources(this.toolDelay8h, "toolDelay8h");
            this.toolDelay8h.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDelay8h.Margin = new System.Windows.Forms.Padding(0);
            this.toolDelay8h.Name = "toolDelay8h";
            this.toolDelay8h.Tag = "480";
            this.toolDelay8h.Click += new System.EventHandler(this.toolDelay_Click);
            // 
            // toolDelay12h
            // 
            resources.ApplyResources(this.toolDelay12h, "toolDelay12h");
            this.toolDelay12h.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDelay12h.Margin = new System.Windows.Forms.Padding(0);
            this.toolDelay12h.Name = "toolDelay12h";
            this.toolDelay12h.Tag = "720";
            this.toolDelay12h.Click += new System.EventHandler(this.toolDelay_Click);
            // 
            // toolDelayInput
            // 
            resources.ApplyResources(this.toolDelayInput, "toolDelayInput");
            this.toolDelayInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDelayInput.Margin = new System.Windows.Forms.Padding(0);
            this.toolDelayInput.Name = "toolDelayInput";
            this.toolDelayInput.Tag = "";
            // 
            // panelCancellation
            // 
            this.panelCancellation.Controls.Add(this.toolsCancellation);
            resources.ApplyResources(this.panelCancellation, "panelCancellation");
            this.panelCancellation.Name = "panelCancellation";
            // 
            // toolsCancellation
            // 
            this.toolsCancellation.BackColor = System.Drawing.Color.White;
            this.toolsCancellation.CanOverflow = false;
            resources.ApplyResources(this.toolsCancellation, "toolsCancellation");
            this.toolsCancellation.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolsCancellation.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsCancellation.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolsCancellation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCancelLogoff,
            this.toolCancelSleep,
            this.toolCancel,
            this.toolCancelShutdown,
            this.toolCancelRestart,
            this.timeoutProgress});
            this.toolsCancellation.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolsCancellation.Name = "toolsCancellation";
            this.toolsCancellation.ShowItemToolTips = false;
            // 
            // toolCancelLogoff
            // 
            resources.ApplyResources(this.toolCancelLogoff, "toolCancelLogoff");
            this.toolCancelLogoff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCancelLogoff.Image = global::TurnItOff.Properties.Resources.Logoff;
            this.toolCancelLogoff.Margin = new System.Windows.Forms.Padding(0);
            this.toolCancelLogoff.Name = "toolCancelLogoff";
            this.toolCancelLogoff.Tag = "Logoff";
            // 
            // toolCancelSleep
            // 
            resources.ApplyResources(this.toolCancelSleep, "toolCancelSleep");
            this.toolCancelSleep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCancelSleep.Image = global::TurnItOff.Properties.Resources.Sleep;
            this.toolCancelSleep.Margin = new System.Windows.Forms.Padding(0);
            this.toolCancelSleep.Name = "toolCancelSleep";
            this.toolCancelSleep.Tag = "Sleep";
            // 
            // toolCancel
            // 
            resources.ApplyResources(this.toolCancel, "toolCancel");
            this.toolCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolCancel.Margin = new System.Windows.Forms.Padding(0);
            this.toolCancel.Name = "toolCancel";
            // 
            // toolCancelShutdown
            // 
            resources.ApplyResources(this.toolCancelShutdown, "toolCancelShutdown");
            this.toolCancelShutdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCancelShutdown.Image = global::TurnItOff.Properties.Resources.Shutdown;
            this.toolCancelShutdown.Margin = new System.Windows.Forms.Padding(0);
            this.toolCancelShutdown.Name = "toolCancelShutdown";
            this.toolCancelShutdown.Tag = "Shutdown";
            // 
            // toolCancelRestart
            // 
            resources.ApplyResources(this.toolCancelRestart, "toolCancelRestart");
            this.toolCancelRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCancelRestart.Image = global::TurnItOff.Properties.Resources.Restart;
            this.toolCancelRestart.Margin = new System.Windows.Forms.Padding(0);
            this.toolCancelRestart.Name = "toolCancelRestart";
            this.toolCancelRestart.Tag = "Restart";
            // 
            // timeoutProgress
            // 
            resources.ApplyResources(this.timeoutProgress, "timeoutProgress");
            this.timeoutProgress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.timeoutProgress.Margin = new System.Windows.Forms.Padding(0);
            this.timeoutProgress.Name = "timeoutProgress";
            // 
            // TrayForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.panelCancellation);
            this.Controls.Add(this.panelDelay);
            this.Controls.Add(this.tools);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrayForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.TrayForm_Deactivate);
            this.contextMenuTray.ResumeLayout(false);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.panelDelay.ResumeLayout(false);
            this.panelDelay.PerformLayout();
            this.toolsDelay.ResumeLayout(false);
            this.toolsDelay.PerformLayout();
            this.panelCancellation.ResumeLayout(false);
            this.panelCancellation.PerformLayout();
            this.toolsCancellation.ResumeLayout(false);
            this.toolsCancellation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuTray;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripButton toolLogoff;
        private System.Windows.Forms.ToolStripButton toolSleep;
        private System.Windows.Forms.ToolStripButton toolShutdown;
        private System.Windows.Forms.ToolStripButton toolRestart;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuAutorun;
        private System.Windows.Forms.Panel panelDelay;
        private System.Windows.Forms.ToolStrip toolsDelay;
        private System.Windows.Forms.ToolStripButton toolDelay5m;
        private System.Windows.Forms.ToolStripButton toolDelay15m;
        private System.Windows.Forms.ToolStripButton toolDelay30m;
        private System.Windows.Forms.ToolStripButton toolDelay1h;
        private System.Windows.Forms.ToolStripButton toolDelay2h;
        private System.Windows.Forms.ToolStripButton toolDelay3h;
        private System.Windows.Forms.ToolStripButton toolDelay4h;
        private System.Windows.Forms.ToolStripButton toolDelay5h;
        private System.Windows.Forms.ToolStripButton toolDelay6h;
        private System.Windows.Forms.ToolStripButton toolDelayInput;
        private System.Windows.Forms.ToolStripButton toolDelay8h;
        private System.Windows.Forms.ToolStripButton toolDelay12h;
        private System.Windows.Forms.Panel panelCancellation;
        private System.Windows.Forms.Timer timerFade;
        private System.Windows.Forms.ToolStrip toolsCancellation;
        private System.Windows.Forms.ToolStripButton toolCancelLogoff;
        private System.Windows.Forms.ToolStripButton toolCancelSleep;
        private System.Windows.Forms.ToolStripButton toolCancelShutdown;
        private System.Windows.Forms.ToolStripButton toolCancelRestart;
        private System.Windows.Forms.ToolStripButton toolCancel;
        private System.Windows.Forms.ToolStripLabel timeoutProgress;
        private System.Windows.Forms.ToolStripMenuItem menuConfirmation;
    }
}

