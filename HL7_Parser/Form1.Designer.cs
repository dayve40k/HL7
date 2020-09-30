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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView_HL7 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip_Parse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.parseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_ParseResults = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_ParseComponent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parseComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_CodeDescription = new System.Windows.Forms.TextBox();
            this.dataGridView_Components = new System.Windows.Forms.DataGridView();
            this.textBox_HL7File = new System.Windows.Forms.TextBox();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.contextMenuStrip_Parse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ParseResults)).BeginInit();
            this.contextMenuStrip_ParseComponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Components)).BeginInit();
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
            this.treeView_HL7.ContextMenuStrip = this.contextMenuStrip_Parse;
            this.treeView_HL7.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView_HL7.Location = new System.Drawing.Point(12, 80);
            this.treeView_HL7.Name = "treeView_HL7";
            this.treeView_HL7.Size = new System.Drawing.Size(786, 461);
            this.treeView_HL7.TabIndex = 2;
            this.treeView_HL7.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_HL7_AfterSelect);
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
            this.dataGridView_ParseResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ParseResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_ParseResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_ParseResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_ParseResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_ParseResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ParseResults.ContextMenuStrip = this.contextMenuStrip_ParseComponent;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ParseResults.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ParseResults.Location = new System.Drawing.Point(804, 80);
            this.dataGridView_ParseResults.MultiSelect = false;
            this.dataGridView_ParseResults.Name = "dataGridView_ParseResults";
            this.dataGridView_ParseResults.ReadOnly = true;
            this.dataGridView_ParseResults.RowHeadersVisible = false;
            this.dataGridView_ParseResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ParseResults.Size = new System.Drawing.Size(468, 461);
            this.dataGridView_ParseResults.TabIndex = 4;
            // 
            // contextMenuStrip_ParseComponent
            // 
            this.contextMenuStrip_ParseComponent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyValueToolStripMenuItem,
            this.parseComponentsToolStripMenuItem});
            this.contextMenuStrip_ParseComponent.Name = "contextMenuStrip_ParseComponent";
            this.contextMenuStrip_ParseComponent.Size = new System.Drawing.Size(175, 48);
            // 
            // copyValueToolStripMenuItem
            // 
            this.copyValueToolStripMenuItem.Name = "copyValueToolStripMenuItem";
            this.copyValueToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.copyValueToolStripMenuItem.Text = "Copy Value";
            this.copyValueToolStripMenuItem.Click += new System.EventHandler(this.copyValueToolStripMenuItem_Click);
            // 
            // parseComponentsToolStripMenuItem
            // 
            this.parseComponentsToolStripMenuItem.Name = "parseComponentsToolStripMenuItem";
            this.parseComponentsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.parseComponentsToolStripMenuItem.Text = "Parse Components";
            this.parseComponentsToolStripMenuItem.Click += new System.EventHandler(this.parseComponentsToolStripMenuItem_Click);
            // 
            // textBox_CodeDescription
            // 
            this.textBox_CodeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_CodeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CodeDescription.Location = new System.Drawing.Point(12, 547);
            this.textBox_CodeDescription.Multiline = true;
            this.textBox_CodeDescription.Name = "textBox_CodeDescription";
            this.textBox_CodeDescription.ReadOnly = true;
            this.textBox_CodeDescription.Size = new System.Drawing.Size(786, 142);
            this.textBox_CodeDescription.TabIndex = 6;
            // 
            // dataGridView_Components
            // 
            this.dataGridView_Components.AllowUserToAddRows = false;
            this.dataGridView_Components.AllowUserToDeleteRows = false;
            this.dataGridView_Components.AllowUserToOrderColumns = true;
            this.dataGridView_Components.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Components.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Components.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Components.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Components.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Components.Location = new System.Drawing.Point(804, 547);
            this.dataGridView_Components.MultiSelect = false;
            this.dataGridView_Components.Name = "dataGridView_Components";
            this.dataGridView_Components.ReadOnly = true;
            this.dataGridView_Components.RowHeadersVisible = false;
            this.dataGridView_Components.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Components.Size = new System.Drawing.Size(468, 142);
            this.dataGridView_Components.TabIndex = 10;
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
            this.button_OpenFile.Text = "Change HL7 File";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.textBox_HL7File);
            this.Controls.Add(this.dataGridView_Components);
            this.Controls.Add(this.textBox_CodeDescription);
            this.Controls.Add(this.dataGridView_ParseResults);
            this.Controls.Add(this.treeView_HL7);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip_Parse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ParseResults)).EndInit();
            this.contextMenuStrip_ParseComponent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Components)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView_HL7;
        private System.Windows.Forms.DataGridView dataGridView_ParseResults;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Parse;
        private System.Windows.Forms.ToolStripMenuItem parseToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_CodeDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ParseComponent;
        private System.Windows.Forms.ToolStripMenuItem copyValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parseComponentsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_Components;
        private System.Windows.Forms.TextBox textBox_HL7File;
        private System.Windows.Forms.Button button_OpenFile;
    }
}

