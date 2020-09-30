using System;
using System.Collections.Generic;
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
            if (textBox_HL7File.Text == "" || !File.Exists(textBox_HL7File.Text)) return;
            treeView_HL7.Nodes.Clear();      
            HL7.Message m = new HL7.Message(textBox_HL7File.Text);     
            PopulatTreeView(ref m);
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
            dataGridView_Components.DataSource = null;
            dataGridView_Components.Columns.Clear();
            dataGridView_Components.Refresh();

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

        private void treeView_HL7_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var seg = new HL7.Segment(treeView_HL7.SelectedNode.Text);
            if (seg == null) return;
            textBox_CodeDescription.Text = seg.CodeDescription;
        }

        private void copyValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_ParseResults.SelectedRows.Count == 0) return;

            Clipboard.SetText(dataGridView_ParseResults.SelectedRows[0].Cells["Value"].Value.ToString());
        }

        private void parseComponentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView_Components.DataSource = null;
            dataGridView_Components.Columns.Clear();
            dataGridView_Components.Refresh();

            // Ensure the proper child node is selected.
            if (treeView_HL7.SelectedNode == null || treeView_HL7.SelectedNode.Parent == null) return;

            var seg = new HL7.Segment(treeView_HL7.SelectedNode.Text);

            if (seg == null || seg.DataElements == null) return;

            dataGridView_Components.Columns.Add("Seq", "Seq");
            dataGridView_Components.Columns.Add("Field", "Field");
            dataGridView_Components.Columns.Add("Value", "Value");

            // Find the element within the segment, so that we may populate the components.
            var element = seg.DataElements.Find(x => x.ElementCode == dataGridView_ParseResults.SelectedRows[0].Cells["Field"].Value.ToString());

            if (element == null || element.Components == null || element.Components.Count == 0) return;

            var componentList = HL7.Component.PopulateComponents(element);

            foreach (HL7.Component component in componentList)
                dataGridView_Components.Rows.Add(component.IndexLocation, component.ComponentCode, component.DataValue);
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            textBox_HL7File.Text = o.FileName;
        }
    }
}