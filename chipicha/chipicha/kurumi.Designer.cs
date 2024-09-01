namespace chipicha
{
    partial class kurumi
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
            // kurumi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.kurumi1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(177, 272);
            DoubleBuffered = true;
            Name = "kurumi";
            Text = "kurumi";
            Load += kurumi_Load;
            MouseDoubleClick += mouse_potipoti;
            MouseDown += window_MouseDown;
            MouseMove += window_MouseMove;
            ResumeLayout(false);
        }

        #endregion
    }
}