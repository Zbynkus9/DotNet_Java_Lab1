namespace GUIApp
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
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            label4 = new Label();
            resultTxt = new TextBox();
            runBTN = new Button();
            capacityTxt = new TextBox();
            label3 = new Label();
            seedTxt = new TextBox();
            label2 = new Label();
            numOfItemsTxt = new TextBox();
            label1 = new Label();
            label5 = new Label();
            itemsTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(itemsTxt);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 349;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(resultTxt);
            panel1.Controls.Add(runBTN);
            panel1.Controls.Add(capacityTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(seedTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(numOfItemsTxt);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 450);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(275, 266);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Result";
            // 
            // resultTxt
            // 
            resultTxt.BackColor = SystemColors.Window;
            resultTxt.Location = new Point(12, 289);
            resultTxt.Multiline = true;
            resultTxt.Name = "resultTxt";
            resultTxt.ReadOnly = true;
            resultTxt.Size = new Size(320, 149);
            resultTxt.TabIndex = 7;
            // 
            // runBTN
            // 
            runBTN.Location = new Point(12, 224);
            runBTN.Name = "runBTN";
            runBTN.Size = new Size(94, 29);
            runBTN.TabIndex = 6;
            runBTN.Text = "Run";
            runBTN.UseVisualStyleBackColor = true;
            runBTN.Click += runBTN_Click;
            // 
            // capacityTxt
            // 
            capacityTxt.Location = new Point(12, 168);
            capacityTxt.Name = "capacityTxt";
            capacityTxt.Size = new Size(125, 27);
            capacityTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 15, 0, 0);
            label3.Size = new Size(66, 35);
            label3.TabIndex = 4;
            label3.Text = "Capacity";
            // 
            // seedTxt
            // 
            seedTxt.Location = new Point(12, 100);
            seedTxt.Name = "seedTxt";
            seedTxt.Size = new Size(125, 27);
            seedTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 15, 0, 0);
            label2.Size = new Size(42, 35);
            label2.TabIndex = 2;
            label2.Text = "Seed";
            // 
            // numOfItemsTxt
            // 
            numOfItemsTxt.Location = new Point(12, 32);
            numOfItemsTxt.Name = "numOfItemsTxt";
            numOfItemsTxt.Size = new Size(125, 27);
            numOfItemsTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Number of items";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(385, 9);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 1;
            label5.Text = "Items";
            // 
            // itemsTxt
            // 
            itemsTxt.BackColor = SystemColors.Window;
            itemsTxt.Dock = DockStyle.Bottom;
            itemsTxt.Location = new Point(0, 49);
            itemsTxt.Margin = new Padding(3, 20, 20, 20);
            itemsTxt.Multiline = true;
            itemsTxt.Name = "itemsTxt";
            itemsTxt.ReadOnly = true;
            itemsTxt.Size = new Size(447, 401);
            itemsTxt.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Button runBTN;
        private TextBox capacityTxt;
        private Label label3;
        private TextBox seedTxt;
        private Label label2;
        private TextBox numOfItemsTxt;
        private Label label1;
        private Label label4;
        private TextBox resultTxt;
        private Label label5;
        private TextBox itemsTxt;
    }
}
