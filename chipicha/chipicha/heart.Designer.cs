namespace chipicha
{
    partial class heart
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
            SuspendLayout();
            // 
            // heart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.heart;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(120, 105);
            DoubleBuffered = true;
            Name = "heart";
            Text = "heart";
            Load += heart_Load;
            DoubleClick += heart_DoubleClick;
            MouseDown += heart_MouseDown;
            MouseMove += heart_MouseMove;
            ResumeLayout(false);
        }

        #endregion
    }
}