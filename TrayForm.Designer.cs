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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLogoff = new System.Windows.Forms.Button();
            this.buttonSuspend = new System.Windows.Forms.Button();
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.buttonReboot = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.buttonReboot, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.buttonShutdown, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonSuspend, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonLogoff, 0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // buttonLogoff
            // 
            resources.ApplyResources(this.buttonLogoff, "buttonLogoff");
            this.buttonLogoff.FlatAppearance.BorderSize = 0;
            this.buttonLogoff.Name = "buttonLogoff";
            this.buttonLogoff.UseVisualStyleBackColor = true;
            // 
            // buttonSuspend
            // 
            resources.ApplyResources(this.buttonSuspend, "buttonSuspend");
            this.buttonSuspend.FlatAppearance.BorderSize = 0;
            this.buttonSuspend.Name = "buttonSuspend";
            this.buttonSuspend.UseVisualStyleBackColor = true;
            // 
            // buttonShutdown
            // 
            resources.ApplyResources(this.buttonShutdown, "buttonShutdown");
            this.buttonShutdown.FlatAppearance.BorderSize = 0;
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.UseVisualStyleBackColor = true;
            // 
            // buttonReboot
            // 
            resources.ApplyResources(this.buttonReboot, "buttonReboot");
            this.buttonReboot.FlatAppearance.BorderSize = 0;
            this.buttonReboot.Name = "buttonReboot";
            this.buttonReboot.UseVisualStyleBackColor = true;
            // 
            // TrayForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrayForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonReboot;
        private System.Windows.Forms.Button buttonShutdown;
        private System.Windows.Forms.Button buttonSuspend;
        private System.Windows.Forms.Button buttonLogoff;
    }
}

