namespace Databox.Libs.eBayAIR
{
    partial class ucExtSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsSett = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.Token = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsSett)).BeginInit();
            this.SuspendLayout();
            // 
            // bsSett
            // 
            this.bsSett.DataSource = typeof(Databox.Libs.eBayAIR.ExtSettings);
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(47, 65);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(418, 21);
            this.textBoxToken.TabIndex = 0;
            this.textBoxToken.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Token
            // 
            this.Token.AutoSize = true;
            this.Token.Location = new System.Drawing.Point(44, 40);
            this.Token.Name = "Token";
            this.Token.Size = new System.Drawing.Size(67, 13);
            this.Token.TabIndex = 1;
            this.Token.Text = "eBay Token:";
            // 
            // ucExtSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Token);
            this.Controls.Add(this.textBoxToken);
            this.Name = "ucExtSettings";
            this.Size = new System.Drawing.Size(703, 425);
            this.Load += new System.EventHandler(this.ucExtSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsSett)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsSett;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label Token;
    }
}
