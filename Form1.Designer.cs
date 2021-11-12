namespace MyFirstApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._name = new System.Windows.Forms.Label();
            this._button = new System.Windows.Forms.Button();
            this._arrow = new System.Windows.Forms.PictureBox();
            this._label1 = new System.Windows.Forms.Label();
            this._nuke = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nuke)).BeginInit();
            this.SuspendLayout();
            // 
            // _name
            // 
            this._name.AutoSize = true;
            this._name.Location = new System.Drawing.Point(184, 127);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(0, 15);
            this._name.TabIndex = 0;
            // 
            // _button
            // 
            this._button.Location = new System.Drawing.Point(352, 215);
            this._button.Name = "_button";
            this._button.Size = new System.Drawing.Size(75, 23);
            this._button.TabIndex = 1;
            this._button.Text = "go!";
            this._button.UseVisualStyleBackColor = true;
            this._button.Click += new System.EventHandler(this._button_Click);
            // 
            // _arrow
            // 
            this._arrow.BackColor = System.Drawing.Color.Transparent;
            this._arrow.BackgroundImage = global::MyFirstApp.Properties.Resources.R;
            this._arrow.Location = new System.Drawing.Point(291, 244);
            this._arrow.Name = "_arrow";
            this._arrow.Size = new System.Drawing.Size(195, 194);
            this._arrow.TabIndex = 2;
            this._arrow.TabStop = false;
            // 
            // _label1
            // 
            this._label1.AutoSize = true;
            this._label1.Location = new System.Drawing.Point(352, 172);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(80, 15);
            this._label1.TabIndex = 3;
            this._label1.Text = "DONT PRESS!!";
            // 
            // _nuke
            // 
            this._nuke.Image = global::MyFirstApp.Properties.Resources.nuke;
            this._nuke.InitialImage = global::MyFirstApp.Properties.Resources.nuke_small;
            this._nuke.Location = new System.Drawing.Point(-246, -233);
            this._nuke.Name = "_nuke";
            this._nuke.Size = new System.Drawing.Size(1062, 712);
            this._nuke.TabIndex = 4;
            this._nuke.TabStop = false;
            this._nuke.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._label1);
            this.Controls.Add(this._arrow);
            this.Controls.Add(this._button);
            this.Controls.Add(this._name);
            this.Controls.Add(this._nuke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nuke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _name;
        private Button _button;
        private PictureBox _nuke;
        private PictureBox _arrow;
        private Label _label1;
    }
}