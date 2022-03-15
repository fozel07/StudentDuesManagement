
namespace DuesManagement
{
    partial class MainPage
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
            this.StudenInfoBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudenInfoBTN
            // 
            this.StudenInfoBTN.BackColor = System.Drawing.Color.Transparent;
            this.StudenInfoBTN.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudenInfoBTN.Location = new System.Drawing.Point(106, 59);
            this.StudenInfoBTN.Name = "StudenInfoBTN";
            this.StudenInfoBTN.Size = new System.Drawing.Size(174, 58);
            this.StudenInfoBTN.TabIndex = 1;
            this.StudenInfoBTN.Text = "Öğrenci Bilgileri";
            this.StudenInfoBTN.UseVisualStyleBackColor = false;
            this.StudenInfoBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(106, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aylık Aidat İzleme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ExitBTN
            // 
            this.ExitBTN.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitBTN.Location = new System.Drawing.Point(106, 186);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(174, 58);
            this.ExitBTN.TabIndex = 3;
            this.ExitBTN.Text = "Uygulamadan çık";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 304);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StudenInfoBTN);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StudenInfoBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitBTN;
    }
}