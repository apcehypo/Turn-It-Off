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
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLogoff = new System.Windows.Forms.Button();
            this.buttonSuspend = new System.Windows.Forms.Button();
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.buttonReboot = new System.Windows.Forms.Button();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.contextMenu.Name = "contextMenu";
            resources.ApplyResources(this.contextMenu, "contextMenu");
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            resources.ApplyResources(this.menuExit, "menuExit");
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // buttonLogoff
            // 
            resources.ApplyResources(this.buttonLogoff, "buttonLogoff");
            this.buttonLogoff.FlatAppearance.BorderSize = 0;
            this.buttonLogoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonLogoff.Image = global::TrayShutdownMenu.Properties.Resources.Logout;
            this.buttonLogoff.Name = "buttonLogoff";
            this.buttonLogoff.UseVisualStyleBackColor = false;
            this.buttonLogoff.Click += new System.EventHandler(this.buttonLogoff_Click);
            // 
            // buttonSuspend
            // 
            resources.ApplyResources(this.buttonSuspend, "buttonSuspend");
            this.buttonSuspend.FlatAppearance.BorderSize = 0;
            this.buttonSuspend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonSuspend.Image = global::TrayShutdownMenu.Properties.Resources.Sleep;
            this.buttonSuspend.Name = "buttonSuspend";
            this.buttonSuspend.UseVisualStyleBackColor = false;
            this.buttonSuspend.Click += new System.EventHandler(this.buttonSuspend_Click);
            // 
            // buttonShutdown
            // 
            resources.ApplyResources(this.buttonShutdown, "buttonShutdown");
            this.buttonShutdown.FlatAppearance.BorderSize = 0;
            this.buttonShutdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonShutdown.Image = global::TrayShutdownMenu.Properties.Resources.Shutdown;
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.UseVisualStyleBackColor = false;
            this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // buttonReboot
            // 
            resources.ApplyResources(this.buttonReboot, "buttonReboot");
            this.buttonReboot.FlatAppearance.BorderSize = 0;
            this.buttonReboot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonReboot.Image = global::TrayShutdownMenu.Properties.Resources.Restart;
            this.buttonReboot.Name = "buttonReboot";
            this.buttonReboot.UseVisualStyleBackColor = false;
            this.buttonReboot.Click += new System.EventHandler(this.buttonReboot_Click);
            // 
            // TrayForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.buttonReboot);
            this.Controls.Add(this.buttonShutdown);
            this.Controls.Add(this.buttonSuspend);
            this.Controls.Add(this.buttonLogoff);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrayForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.TrayForm_Deactivate);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button buttonLogoff;
        private System.Windows.Forms.Button buttonSuspend;
        private System.Windows.Forms.Button buttonShutdown;
        private System.Windows.Forms.Button buttonReboot;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
    }
}

