namespace Email;

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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        textBoxTo = new TextBox();
        textBoxSubject = new TextBox();
        textBoxBody = new TextBox();
        buttonSend = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(47, 42);
        label1.Name = "label1";
        label1.Size = new Size(22, 15);
        label1.TabIndex = 1;
        label1.Text = "To:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(47, 71);
        label2.Name = "label2";
        label2.Size = new Size(49, 15);
        label2.TabIndex = 2;
        label2.Text = "Subject:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(47, 100);
        label3.Name = "label3";
        label3.Size = new Size(34, 15);
        label3.TabIndex = 3;
        label3.Text = "Body";
        // 
        // textBoxTo
        // 
        textBoxTo.Location = new Point(142, 39);
        textBoxTo.Name = "textBoxTo";
        textBoxTo.Size = new Size(380, 23);
        textBoxTo.TabIndex = 4;
        // 
        // textBoxSubject
        // 
        textBoxSubject.Location = new Point(142, 68);
        textBoxSubject.Name = "textBoxSubject";
        textBoxSubject.Size = new Size(380, 23);
        textBoxSubject.TabIndex = 5;
        // 
        // textBoxBody
        // 
        textBoxBody.Location = new Point(142, 97);
        textBoxBody.Multiline = true;
        textBoxBody.Name = "textBoxBody";
        textBoxBody.Size = new Size(380, 175);
        textBoxBody.TabIndex = 6;
        // 
        // buttonSend
        // 
        buttonSend.Location = new Point(447, 278);
        buttonSend.Name = "buttonSend";
        buttonSend.Size = new Size(75, 23);
        buttonSend.TabIndex = 7;
        buttonSend.Text = "Send";
        buttonSend.UseVisualStyleBackColor = true;
        buttonSend.Click += buttonSend_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(649, 392);
        Controls.Add(buttonSend);
        Controls.Add(textBoxBody);
        Controls.Add(textBoxSubject);
        Controls.Add(textBoxTo);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBoxTo;
    private TextBox textBoxSubject;
    private TextBox textBoxBody;
    private Button buttonSend;
}
