namespace ITE1112_activity_2
{
  partial class Main
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
      lblSubject1 = new Label();
      lblSubject2 = new Label();
      lblAverage = new Label();
      txtSubject1 = new TextBox();
      txtSubject2 = new TextBox();
      txtAverage = new TextBox();
      btnSubmit = new Button();
      lblGrade = new Label();
      txtGrade = new TextBox();
      SuspendLayout();
      // 
      // lblSubject1
      // 
      lblSubject1.AutoSize = true;
      lblSubject1.Location = new Point(31, 45);
      lblSubject1.Margin = new Padding(6, 0, 6, 0);
      lblSubject1.Name = "lblSubject1";
      lblSubject1.Size = new Size(104, 30);
      lblSubject1.TabIndex = 0;
      lblSubject1.Text = "Subject 1";
      // 
      // lblSubject2
      // 
      lblSubject2.AutoSize = true;
      lblSubject2.Location = new Point(31, 110);
      lblSubject2.Margin = new Padding(6, 0, 6, 0);
      lblSubject2.Name = "lblSubject2";
      lblSubject2.Size = new Size(104, 30);
      lblSubject2.TabIndex = 1;
      lblSubject2.Text = "Subject 2";
      // 
      // lblAverage
      // 
      lblAverage.AutoSize = true;
      lblAverage.Location = new Point(31, 170);
      lblAverage.Margin = new Padding(6, 0, 6, 0);
      lblAverage.Name = "lblAverage";
      lblAverage.Size = new Size(93, 30);
      lblAverage.TabIndex = 2;
      lblAverage.Text = "Average";
      // 
      // txtSubject1
      // 
      txtSubject1.Location = new Point(168, 45);
      txtSubject1.Name = "txtSubject1";
      txtSubject1.Size = new Size(275, 35);
      txtSubject1.TabIndex = 3;
      // 
      // txtSubject2
      // 
      txtSubject2.Location = new Point(168, 110);
      txtSubject2.Name = "txtSubject2";
      txtSubject2.Size = new Size(275, 35);
      txtSubject2.TabIndex = 4;
      // 
      // txtAverage
      // 
      txtAverage.Location = new Point(168, 170);
      txtAverage.Name = "txtAverage";
      txtAverage.Size = new Size(275, 35);
      txtAverage.TabIndex = 5;
      // 
      // btnSubmit
      // 
      btnSubmit.Location = new Point(168, 288);
      btnSubmit.Name = "btnSubmit";
      btnSubmit.Size = new Size(275, 38);
      btnSubmit.TabIndex = 6;
      btnSubmit.Text = "Submit";
      btnSubmit.UseVisualStyleBackColor = true;
      btnSubmit.Click += btnSubmit_Click;
      // 
      // lblGrade
      // 
      lblGrade.AutoSize = true;
      lblGrade.Location = new Point(31, 230);
      lblGrade.Margin = new Padding(6, 0, 6, 0);
      lblGrade.Name = "lblGrade";
      lblGrade.Size = new Size(71, 30);
      lblGrade.TabIndex = 7;
      lblGrade.Text = "Grade";
      // 
      // txtGrade
      // 
      txtGrade.Location = new Point(168, 230);
      txtGrade.Name = "txtGrade";
      txtGrade.Size = new Size(275, 35);
      txtGrade.TabIndex = 8;
      // 
      // Main
      // 
      AutoScaleDimensions = new SizeF(13F, 30F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(514, 358);
      Controls.Add(txtGrade);
      Controls.Add(lblGrade);
      Controls.Add(btnSubmit);
      Controls.Add(txtAverage);
      Controls.Add(txtSubject2);
      Controls.Add(txtSubject1);
      Controls.Add(lblAverage);
      Controls.Add(lblSubject2);
      Controls.Add(lblSubject1);
      Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
      Margin = new Padding(6);
      Name = "Main";
      Text = "Main";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblSubject1;
    private Label lblSubject2;
    private Label lblAverage;
    private TextBox txtSubject1;
    private TextBox txtSubject2;
    private TextBox txtAverage;
    private Button btnSubmit;
    private Label lblGrade;
    private TextBox txtGrade;
  }
}