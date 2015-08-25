namespace TestConverter
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
      this.convertBtn = new System.Windows.Forms.Button();
      this.convertRtb = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // convertBtn
      // 
      this.convertBtn.Location = new System.Drawing.Point(230, 467);
      this.convertBtn.Name = "convertBtn";
      this.convertBtn.Size = new System.Drawing.Size(75, 23);
      this.convertBtn.TabIndex = 1;
      this.convertBtn.Text = "&Convert";
      this.convertBtn.UseVisualStyleBackColor = true;
      this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
      // 
      // convertRtb
      // 
      this.convertRtb.Location = new System.Drawing.Point(12, 12);
      this.convertRtb.Name = "convertRtb";
      this.convertRtb.Size = new System.Drawing.Size(522, 449);
      this.convertRtb.TabIndex = 0;
      this.convertRtb.Text = "";
      // 
      // Form1
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
      this.ClientSize = new System.Drawing.Size(546, 502);
      this.Controls.Add(this.convertRtb);
      this.Controls.Add(this.convertBtn);
      this.Name = "Form1";
      this.Text = "Text Converter";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button convertBtn;
    private System.Windows.Forms.RichTextBox convertRtb;
  }
}

