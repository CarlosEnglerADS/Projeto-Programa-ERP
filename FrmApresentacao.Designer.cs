namespace ProgramaErp
{
    partial class FrmApresentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApresentacao));
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(3, 363);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(793, 14);
            progressBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(537, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 258);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(793, 68);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Location = new Point(537, 341);
            label3.Name = "label3";
            label3.Size = new Size(259, 16);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 80);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(528, 277);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // FrmApresentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 389);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmApresentacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmApresentacao";
            Load += FrmApresentacao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
    }
}