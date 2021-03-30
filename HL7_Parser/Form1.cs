using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HL7_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "HL7 Parser";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView_HL7.Nodes.Clear();
            
            HL7.Message m = new HL7.Message(textBox_HL7File.Text);

            PopulatTreeView(ref m);            

            HL7.Segment seg = null;
            
            foreach (TreeNode node in treeView_HL7.Nodes)
            {
                seg = new HL7.Segment(node.Text);

                // I don't have it.
                if (seg.DataElements == null) node.BackColor = Color.Yellow;
            }
        }

        private void PopulatTreeView(ref HL7.Message message)
        {
            HashSet<string> rootNodeList = new HashSet<string>();

            // Build the root nodes.
            foreach (HL7.Segment seg in message.Segments) rootNodeList.Add(seg.SegmentCode);

            // Now add them to the tree view.
            foreach (string s in rootNodeList) treeView_HL7.Nodes.Add(new TreeNode(s));

            // Iterate through the HL7 message segments and
            // add them to their respective root node.
            foreach (HL7.Segment s in message.Segments)
                foreach (TreeNode tn in treeView_HL7.Nodes)
                    if (tn.Text == s.SegmentCode) tn.Nodes.Add(new TreeNode(s.FullSegment));
        }

        private void parseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView_ParseResults.DataSource = null;
            dataGridView_ParseResults.Columns.Clear();
            dataGridView_ParseResults.Refresh();

            // Ensure the proper child node is selected.
            if (treeView_HL7.SelectedNode == null || treeView_HL7.SelectedNode.Parent == null) return;

            var seg = new HL7.Segment(treeView_HL7.SelectedNode.Text);
            
            if (seg == null || seg.DataElements == null) return;

            dataGridView_ParseResults.Columns.Add("Seq", "Seq");
            dataGridView_ParseResults.Columns.Add("Field", "Field");
            dataGridView_ParseResults.Columns.Add("Value", "Value");

            foreach (HL7.DataElement element in seg.DataElements)
            {
                if (seg.SegmentCode == "MSH") element.IndexLocation++;
                dataGridView_ParseResults.Rows.Add(element.IndexLocation, element.ElementCode, element.DataValue);
            }
        }

        private void button_SaveAs_Click(object sender, EventArgs e)
        {
            string hl7File = textBox_HL7File.Text;

            // Read an existing HL7 message.
            HL7.Message m = new HL7.Message(hl7File);
            if (m == null) return;

            m.SetSegmentValue("MSH 15", "A NEW VALUE");
            m.SetSegmentValue("EVN 5.2", "ANOTHER NEW VALUE");

            string newFile = hl7File.Substring(0, hl7File.LastIndexOf("\\") + 1) + "MODIFIED.HL7";
            m.Save(newFile);
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            textBox_HL7File.Text = o.FileName;
        }


       
    }
}