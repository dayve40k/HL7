namespace HL7_Parser
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView_HL7 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip_Parse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.parseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_ParseResults = new System.Windows.Forms.DataGridView();
            this.button_SaveAs = new System.Windows.Forms.Button();
            this.textBox_HL7File = new System.Windows.Forms.TextBox();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.contextMenuStrip_Parse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ParseResults)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Test Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView_HL7
            // 
            this.treeView_HL7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView_HL7.ContextMenuStrip = this.contextMenuStrip_Parse;
            this.treeView_HL7.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView_HL7.Location = new System.Drawing.Point(12, 80);
            this.treeView_HL7.Name = "treeView_HL7";
            this.treeView_HL7.Size = new System.Drawing.Size(786, 735);
            this.treeView_HL7.TabIndex = 2;
            // 
            // contextMenuStrip_Parse
            // 
            this.contextMenuStrip_Parse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parseToolStripMenuItem});
            this.contextMenuStrip_Parse.Name = "contextMenuStrip_Parse";
            this.contextMenuStrip_Parse.Size = new System.Drawing.Size(103, 26);
            // 
            // parseToolStripMenuItem
            // 
            this.parseToolStripMenuItem.Name = "parseToolStripMenuItem";
            this.parseToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.parseToolStripMenuItem.Text = "Parse";
            this.parseToolStripMenuItem.Click += new System.EventHandler(this.parseToolStripMenuItem_Click);
            // 
            // dataGridView_ParseResults
            // 
            this.dataGridView_ParseResults.AllowUserToAddRows = false;
            this.dataGridView_ParseResults.AllowUserToDeleteRows = false;
            this.dataGridView_ParseResults.AllowUserToOrderColumns = true;
            this.dataGridView_ParseResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ParseResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_ParseResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_ParseResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_ParseResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_ParseResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ParseResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ParseResults.Location = new System.Drawing.Point(804, 80);
            this.dataGridView_ParseResults.MultiSelect = false;
            this.dataGridView_ParseResults.Name = "dataGridView_ParseResults";
            this.dataGridView_ParseResults.ReadOnly = true;
            this.dataGridView_ParseResults.RowHeadersVisible = false;
            this.dataGridView_ParseResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ParseResults.Size = new System.Drawing.Size(608, 735);
            this.dataGridView_ParseResults.TabIndex = 4;
            // 
            // button_SaveAs
            // 
            this.button_SaveAs.Location = new System.Drawing.Point(184, 38);
            this.button_SaveAs.Name = "button_SaveAs";
            this.button_SaveAs.Size = new System.Drawing.Size(80, 36);
            this.button_SaveAs.TabIndex = 8;
            this.button_SaveAs.Text = "Save As";
            this.button_SaveAs.UseVisualStyleBackColor = true;
            this.button_SaveAs.Click += new System.EventHandler(this.button_SaveAs_Click);
            // 
            // textBox_HL7File
            // 
            this.textBox_HL7File.Location = new System.Drawing.Point(12, 12);
            this.textBox_HL7File.Name = "textBox_HL7File";
            this.textBox_HL7File.Size = new System.Drawing.Size(673, 20);
            this.textBox_HL7File.TabIndex = 11;
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(12, 38);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(80, 36);
            this.button_OpenFile.TabIndex = 12;
            this.button_OpenFile.Text = "Select HL7 File";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 827);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.textBox_HL7File);
            this.Controls.Add(this.button_SaveAs);
            this.Controls.Add(this.dataGridView_ParseResults);
            this.Controls.Add(this.treeView_HL7);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip_Parse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ParseResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView_HL7;
        private System.Windows.Forms.DataGridView dataGridView_ParseResults;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Parse;
        private System.Windows.Forms.ToolStripMenuItem parseToolStripMenuItem;
        private System.Windows.Forms.Button button_SaveAs;
        private System.Windows.Forms.TextBox textBox_HL7File;
        private System.Windows.Forms.Button button_OpenFile;
    }
}

