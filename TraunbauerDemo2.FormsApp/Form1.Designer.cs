namespace TraunbauerDemo2.FormsApp
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
      this.btnStart = new System.Windows.Forms.Button();
      this.pnlMain = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // btnStart
      // 
      this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnStart.Location = new System.Drawing.Point(713, 415);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.TabIndex = 0;
      this.btnStart.Text = "&Start";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
      
      // 
      // pnlMain
      // 
      this.pnlMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.pnlMain.Location = new System.Drawing.Point(60, 50);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new System.Drawing.Size(663, 307);
      this.pnlMain.TabIndex = 1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.pnlMain);
      this.Controls.Add(this.btnStart);
      this.Name = "Form1";
      this.Text = "frmMain";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Panel pnlMain;
  }
}

