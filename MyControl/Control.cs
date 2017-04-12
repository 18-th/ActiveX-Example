using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;


namespace MyControl
{
    [Guid("06f5489a-f8e5-4b20-b64d-c35475cdad5a")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public class Control
    {
        [ComVisible(true)]
        public String Show()
        {
            return "Did it!";
        }
        public String ShowMore()
        {
            return "More!";
        }
    }
    #region Test Class
    [Guid("F0502AF8-49DF-4D6D-8303-190D015FBEED")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface ILauncher
    {
        void ShowWindow();
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("1A0C0EC8-829B-457F-B5A1-2EF1ED8FB9CD")]//Main GUID
    [ProgId("WinFormActivex.Launcher")]
    [ComDefaultInterface(typeof(ILauncher))]
    public class Launcher : UserControl, ILauncher
    {
        #region [ ILauncher ]

        public void ShowWindow()
        {
            var f = new MainWindow();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Screen.AllScreens[0].Bounds.Location;
            f.WindowState = FormWindowState.Normal;
            f.WindowState = FormWindowState.Maximized;
            f.ShowInTaskbar = false;
            f.Show();
        }

        #endregion

    }

    [Guid("9253F00F-7BD9-4C59-A502-4106FC47C157")]
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

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
            this.FirstPanel = new System.Windows.Forms.Panel();
            this.FirstButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // FirstPanel
            //
            this.FirstPanel.Location = new System.Drawing.Point(40, 20);
            this.FirstPanel.Name = "FirstPanel";
            this.FirstPanel.Size = new System.Drawing.Size(640, 480);
            this.FirstPanel.TabIndex = 0;
            this.FirstPanel.BackColor = Color.Black;
            //
            // FirstButton
            //
            this.FirstButton.Location = new System.Drawing.Point(700, 20);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(100, 200);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "Press X to win!";
            //
            // MainWindow
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.FirstPanel);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FirstPanel;
        private System.Windows.Forms.Button FirstButton;
    }
    #endregion Test Class
}
