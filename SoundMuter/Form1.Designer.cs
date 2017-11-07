namespace SoundMuter
{
    partial class Form1
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
            this.muteSound = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // muteSound
            // 
            this.muteSound.Appearance = System.Windows.Forms.Appearance.Button;
            this.muteSound.AutoSize = true;
            this.muteSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.muteSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muteSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.muteSound.Location = new System.Drawing.Point(0, 0);
            this.muteSound.Name = "muteSound";
            this.muteSound.Size = new System.Drawing.Size(368, 165);
            this.muteSound.TabIndex = 0;
            this.muteSound.Text = "Mute Sound";
            this.muteSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.muteSound.UseVisualStyleBackColor = true;
            this.muteSound.CheckedChanged += new System.EventHandler(this.muteSound_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 165);
            this.Controls.Add(this.muteSound);
            this.Name = "Form1";
            this.Text = "SoundMuter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox muteSound;
    }
}

