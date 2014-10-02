namespace TurnItOff.CustomControls
{
    partial class MessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMessage = new System.Windows.Forms.Panel();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelAction = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolsCancellation = new TurnItOff.ClearToolStrip();
            this.toolOk = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.panelMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolsCancellation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.White;
            this.panelMessage.Controls.Add(this.labelAction);
            this.panelMessage.Controls.Add(this.labelQuestion);
            this.panelMessage.Controls.Add(this.pictureBox);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessage.Location = new System.Drawing.Point(0, 0);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(228, 72);
            this.panelMessage.TabIndex = 0;
            // 
            // labelQuestion
            // 
            this.labelQuestion.Location = new System.Drawing.Point(66, 9);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(150, 34);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "{Multiline\r\n     Question}";
            // 
            // labelAction
            // 
            this.labelAction.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAction.Location = new System.Drawing.Point(66, 43);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(150, 20);
            this.labelAction.TabIndex = 1;
            this.labelAction.Text = "{Question}";
            this.labelAction.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::TurnItOff.Properties.Resources.Question;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(48, 48);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // toolsCancellation
            // 
            this.toolsCancellation.BackColor = System.Drawing.Color.White;
            this.toolsCancellation.CanOverflow = false;
            this.toolsCancellation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolsCancellation.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolsCancellation.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsCancellation.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolsCancellation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOk,
            this.toolCancel});
            this.toolsCancellation.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolsCancellation.Location = new System.Drawing.Point(0, 72);
            this.toolsCancellation.Name = "toolsCancellation";
            this.toolsCancellation.Padding = new System.Windows.Forms.Padding(2);
            this.toolsCancellation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolsCancellation.ShowItemToolTips = false;
            this.toolsCancellation.Size = new System.Drawing.Size(228, 46);
            this.toolsCancellation.TabIndex = 2;
            // 
            // toolOk
            // 
            this.toolOk.AutoSize = false;
            this.toolOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOk.Margin = new System.Windows.Forms.Padding(0);
            this.toolOk.Name = "toolOk";
            this.toolOk.Size = new System.Drawing.Size(112, 42);
            this.toolOk.Text = "OK";
            this.toolOk.Click += new System.EventHandler(this.toolOk_Click);
            // 
            // toolCancel
            // 
            this.toolCancel.AutoSize = false;
            this.toolCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Margin = new System.Windows.Forms.Padding(0);
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(112, 42);
            this.toolCancel.Text = "Cancel";
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(228, 118);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.toolsCancellation);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "MessageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MessageForm";
            this.TopMost = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MessageForm_KeyUp);
            this.panelMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolsCancellation.ResumeLayout(false);
            this.toolsCancellation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.PictureBox pictureBox;
        private ClearToolStrip toolsCancellation;
        private System.Windows.Forms.ToolStripButton toolOk;
        private System.Windows.Forms.ToolStripButton toolCancel;
    }
}