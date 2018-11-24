namespace HolaGitHub
{
    partial class frmLoading
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
            this.components = new System.ComponentModel.Container();
            this.pbCat = new System.Windows.Forms.PictureBox();
            this.pbCircle = new System.Windows.Forms.PictureBox();
            this.BarLoading = new System.Windows.Forms.ProgressBar();
            this.lblPorciento = new System.Windows.Forms.Label();
            this.timerBar = new System.Windows.Forms.Timer(this.components);
            this.lblLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCat
            // 
            this.pbCat.BackColor = System.Drawing.Color.Black;
            this.pbCat.Image = global::HolaGitHub.Properties.Resources.Octocat_github_1;
            this.pbCat.Location = new System.Drawing.Point(171, 45);
            this.pbCat.Name = "pbCat";
            this.pbCat.Size = new System.Drawing.Size(126, 124);
            this.pbCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCat.TabIndex = 1;
            this.pbCat.TabStop = false;
            // 
            // pbCircle
            // 
            this.pbCircle.BackColor = System.Drawing.Color.White;
            this.pbCircle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCircle.Image = global::HolaGitHub.Properties.Resources.circ;
            this.pbCircle.Location = new System.Drawing.Point(0, 0);
            this.pbCircle.Name = "pbCircle";
            this.pbCircle.Size = new System.Drawing.Size(474, 351);
            this.pbCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCircle.TabIndex = 0;
            this.pbCircle.TabStop = false;
            // 
            // BarLoading
            // 
            this.BarLoading.Location = new System.Drawing.Point(117, 230);
            this.BarLoading.Name = "BarLoading";
            this.BarLoading.Size = new System.Drawing.Size(243, 23);
            this.BarLoading.TabIndex = 2;
            // 
            // lblPorciento
            // 
            this.lblPorciento.AutoSize = true;
            this.lblPorciento.BackColor = System.Drawing.Color.Black;
            this.lblPorciento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorciento.ForeColor = System.Drawing.Color.White;
            this.lblPorciento.Location = new System.Drawing.Point(209, 265);
            this.lblPorciento.Name = "lblPorciento";
            this.lblPorciento.Size = new System.Drawing.Size(54, 32);
            this.lblPorciento.TabIndex = 3;
            this.lblPorciento.Text = "0%";
            // 
            // timerBar
            // 
            this.timerBar.Tick += new System.EventHandler(this.timerBar_Tick);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Black;
            this.lblLoading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(179, 183);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(128, 32);
            this.lblLoading.TabIndex = 4;
            this.lblLoading.Text = "Loading.";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 351);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblPorciento);
            this.Controls.Add(this.BarLoading);
            this.Controls.Add(this.pbCat);
            this.Controls.Add(this.pbCircle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.TransparencyKey = System.Drawing.Color.Gray;
            ((System.ComponentModel.ISupportInitialize)(this.pbCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCircle;
        private System.Windows.Forms.PictureBox pbCat;
        private System.Windows.Forms.ProgressBar BarLoading;
        private System.Windows.Forms.Label lblPorciento;
        private System.Windows.Forms.Timer timerBar;
        private System.Windows.Forms.Label lblLoading;
    }
}