﻿namespace Serialization;

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
        buttonJSON = new Button();
        label1 = new Label();
        button1 = new Button();
        SuspendLayout();
        // 
        // buttonJSON
        // 
        buttonJSON.Location = new Point(12, 77);
        buttonJSON.Name = "buttonJSON";
        buttonJSON.Size = new Size(151, 23);
        buttonJSON.TabIndex = 0;
        buttonJSON.Text = "JSON";
        buttonJSON.UseVisualStyleBackColor = true;
        buttonJSON.Click += buttonJSON_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(151, 15);
        label1.TabIndex = 1;
        label1.Text = "Serialization / Desrialization";
        // 
        // button1
        // 
        button1.Location = new Point(12, 106);
        button1.Name = "button1";
        button1.Size = new Size(151, 23);
        button1.TabIndex = 2;
        button1.Text = "XML";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(897, 532);
        Controls.Add(button1);
        Controls.Add(label1);
        Controls.Add(buttonJSON);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonJSON;
    private Label label1;
    private Button button1;
}
