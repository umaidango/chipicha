﻿namespace chipicha
{
    partial class ichigo
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
            // ichigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ichigo_icons;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(169, 244);
            DoubleBuffered = true;
            Name = "ichigo";
            Text = "ichigo";
            Load += ichigo_Load;
            Click += ichigo_Click;
            MouseDoubleClick += mouse_potipoti;
            MouseDown += window_MouseDown;
            MouseMove += window_MouseMove;
            ResumeLayout(false);
        }

        #endregion
    }
}