
namespace PortfolioQ6CSVReaderClient
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
            this.groupBoxCSV = new System.Windows.Forms.GroupBox();
            this.buttonSaveCSV = new System.Windows.Forms.Button();
            this.buttonSendCSV = new System.Windows.Forms.Button();
            this.textBoxCSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.textBoxPipeName = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSendM = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxCSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCSV
            // 
            this.groupBoxCSV.Controls.Add(this.buttonSaveCSV);
            this.groupBoxCSV.Controls.Add(this.buttonSendCSV);
            this.groupBoxCSV.Controls.Add(this.textBoxCSV);
            this.groupBoxCSV.Location = new System.Drawing.Point(317, 329);
            this.groupBoxCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCSV.Name = "groupBoxCSV";
            this.groupBoxCSV.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCSV.Size = new System.Drawing.Size(253, 125);
            this.groupBoxCSV.TabIndex = 15;
            this.groupBoxCSV.TabStop = false;
            this.groupBoxCSV.Text = "CSV Handler";
            // 
            // buttonSaveCSV
            // 
            this.buttonSaveCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSaveCSV.Location = new System.Drawing.Point(132, 61);
            this.buttonSaveCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveCSV.Name = "buttonSaveCSV";
            this.buttonSaveCSV.Size = new System.Drawing.Size(113, 56);
            this.buttonSaveCSV.TabIndex = 3;
            this.buttonSaveCSV.Text = "Save CSV";
            this.buttonSaveCSV.UseVisualStyleBackColor = false;
            this.buttonSaveCSV.Click += new System.EventHandler(this.buttonSaveCSV_Click);
            // 
            // buttonSendCSV
            // 
            this.buttonSendCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSendCSV.Location = new System.Drawing.Point(12, 61);
            this.buttonSendCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSendCSV.Name = "buttonSendCSV";
            this.buttonSendCSV.Size = new System.Drawing.Size(112, 56);
            this.buttonSendCSV.TabIndex = 1;
            this.buttonSendCSV.Text = "Send CSV";
            this.buttonSendCSV.UseVisualStyleBackColor = false;
            this.buttonSendCSV.Click += new System.EventHandler(this.buttonSendCSV_Click);
            // 
            // textBoxCSV
            // 
            this.textBoxCSV.Location = new System.Drawing.Point(12, 27);
            this.textBoxCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCSV.Name = "textBoxCSV";
            this.textBoxCSV.ReadOnly = true;
            this.textBoxCSV.Size = new System.Drawing.Size(233, 22);
            this.textBoxCSV.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pipe Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, -14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "CSV Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Messages";
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(13, 305);
            this.textBoxMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ReadOnly = true;
            this.textBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessages.Size = new System.Drawing.Size(295, 249);
            this.textBoxMessages.TabIndex = 11;
            // 
            // textBoxPipeName
            // 
            this.textBoxPipeName.Location = new System.Drawing.Point(316, 305);
            this.textBoxPipeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPipeName.Name = "textBoxPipeName";
            this.textBoxPipeName.Size = new System.Drawing.Size(254, 22);
            this.textBoxPipeName.TabIndex = 10;
            this.textBoxPipeName.Text = "\\\\.\\pipe\\jworkspipe";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 15);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(557, 249);
            this.dataGridView.TabIndex = 9;
            // 
            // buttonSendM
            // 
            this.buttonSendM.BackColor = System.Drawing.Color.Red;
            this.buttonSendM.Location = new System.Drawing.Point(316, 510);
            this.buttonSendM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSendM.Name = "buttonSendM";
            this.buttonSendM.Size = new System.Drawing.Size(254, 44);
            this.buttonSendM.TabIndex = 17;
            this.buttonSendM.Text = "SEND Message";
            this.buttonSendM.UseVisualStyleBackColor = false;
            this.buttonSendM.Click += new System.EventHandler(this.buttonSendM_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(317, 462);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(253, 40);
            this.textBoxSend.TabIndex = 16;
            this.textBoxSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSend_KeyDown);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 569);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(586, 26);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(49, 20);
            this.statusLabel.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 595);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBoxCSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.textBoxPipeName);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonSendM);
            this.Controls.Add(this.textBoxSend);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "CSV Reader - Client";
            this.groupBoxCSV.ResumeLayout(false);
            this.groupBoxCSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCSV;
        private System.Windows.Forms.Button buttonSaveCSV;
        private System.Windows.Forms.Button buttonSendCSV;
        private System.Windows.Forms.TextBox textBoxCSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.TextBox textBoxPipeName;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonSendM;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

