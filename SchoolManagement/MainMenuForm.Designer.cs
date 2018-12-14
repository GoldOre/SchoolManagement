namespace SchoolManagement
{
    partial class MainMenuForm
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Primary school teachers");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("High school teachers");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Didactically personal", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Secondary didactically personal");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("No didactically personal");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Primary school");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("High school");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Classes", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.schooL_MNGDataSet1 = new SchoolManagement.BAL.SCHOOL_MNGDataSet();
            this.classesTableAdapter1 = new SchoolManagement.BAL.SCHOOL_MNGDataSetTableAdapters.ClassesTableAdapter();
            this.tableAdapterManager1 = new SchoolManagement.BAL.SCHOOL_MNGDataSetTableAdapters.TableAdapterManager();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schooL_MNGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "primaryteachers";
            treeNode9.Text = "Primary school teachers";
            treeNode10.Name = "highteachers";
            treeNode10.Text = "High school teachers";
            treeNode11.Name = "didpersonal";
            treeNode11.Text = "Didactically personal";
            treeNode12.Name = "2anddidpersonal";
            treeNode12.Text = "Secondary didactically personal";
            treeNode13.Name = "nodidpersonal";
            treeNode13.Text = "No didactically personal";
            treeNode14.Name = "prmschool";
            treeNode14.Text = "Primary school";
            treeNode15.Name = "hgschool";
            treeNode15.Text = "High school";
            treeNode16.Name = "stdclasses";
            treeNode16.Text = "Classes";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(186, 351);
            this.treeView1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(186, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 351);
            this.dataGridView1.TabIndex = 1;
            // 
            // schooL_MNGDataSet1
            // 
            this.schooL_MNGDataSet1.DataSetName = "SCHOOL_MNGDataSet";
            this.schooL_MNGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesTableAdapter1
            // 
            this.classesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClassesTableAdapter = this.classesTableAdapter1;
            this.tableAdapterManager1.ProfessorsTableAdapter = null;
            this.tableAdapterManager1.StudentsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = SchoolManagement.BAL.SCHOOL_MNGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Classes";
            this.bindingSource1.DataSource = this.schooL_MNGDataSet1;
            // 
            // classIdDataGridViewTextBoxColumn
            // 
            this.classIdDataGridViewTextBoxColumn.DataPropertyName = "ClassId";
            this.classIdDataGridViewTextBoxColumn.HeaderText = "ClassId";
            this.classIdDataGridViewTextBoxColumn.Name = "classIdDataGridViewTextBoxColumn";
            this.classIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 351);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Name = "MainMenuForm";
            this.Text = "Grigore Grigoriu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schooL_MNGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BAL.SCHOOL_MNGDataSet schooL_MNGDataSet1;
        private BAL.SCHOOL_MNGDataSetTableAdapters.ClassesTableAdapter classesTableAdapter1;
        private BAL.SCHOOL_MNGDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

