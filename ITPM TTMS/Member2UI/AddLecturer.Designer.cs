
namespace ITPM_TTMS.Member2UI
{
    partial class AddLecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLecturer));
            System.Windows.Forms.Label employeeIdLabel;
            System.Windows.Forms.Label lecturerNameLabel;
            System.Windows.Forms.Label facultyLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label centerLabel;
            System.Windows.Forms.Label buildingLabel;
            System.Windows.Forms.Label levelLabel;
            System.Windows.Forms.Label rankLabel;
            this.modelDataSet = new ITPM_TTMS.ModelDataSet();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturerTableAdapter = new ITPM_TTMS.ModelDataSetTableAdapters.LecturerTableAdapter();
            this.tableAdapterManager = new ITPM_TTMS.ModelDataSetTableAdapters.TableAdapterManager();
            this.lecturerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lecturerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.lecturerNameTextBox = new System.Windows.Forms.TextBox();
            this.facultyComboBox = new System.Windows.Forms.ComboBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.centerComboBox = new System.Windows.Forms.ComboBox();
            this.buildingComboBox = new System.Windows.Forms.ComboBox();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.rankTextBox = new System.Windows.Forms.TextBox();
            this.btnGenerateRank = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            employeeIdLabel = new System.Windows.Forms.Label();
            lecturerNameLabel = new System.Windows.Forms.Label();
            facultyLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            centerLabel = new System.Windows.Forms.Label();
            buildingLabel = new System.Windows.Forms.Label();
            levelLabel = new System.Windows.Forms.Label();
            rankLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingNavigator)).BeginInit();
            this.lecturerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "Lecturer";
            this.lecturerBindingSource.DataSource = this.modelDataSet;
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LecturerTableAdapter = this.lecturerTableAdapter;
            this.tableAdapterManager.UpdateOrder = ITPM_TTMS.ModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lecturerBindingNavigator
            // 
            this.lecturerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lecturerBindingNavigator.BindingSource = this.lecturerBindingSource;
            this.lecturerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lecturerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lecturerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lecturerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.lecturerBindingNavigatorSaveItem});
            this.lecturerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lecturerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lecturerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lecturerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lecturerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lecturerBindingNavigator.Name = "lecturerBindingNavigator";
            this.lecturerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lecturerBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.lecturerBindingNavigator.TabIndex = 0;
            this.lecturerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // lecturerBindingNavigatorSaveItem
            // 
            this.lecturerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lecturerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lecturerBindingNavigatorSaveItem.Image")));
            this.lecturerBindingNavigatorSaveItem.Name = "lecturerBindingNavigatorSaveItem";
            this.lecturerBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.lecturerBindingNavigatorSaveItem.Text = "Save Data";
            this.lecturerBindingNavigatorSaveItem.Click += new System.EventHandler(this.lecturerBindingNavigatorSaveItem_Click);
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeIdLabel.Location = new System.Drawing.Point(26, 152);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new System.Drawing.Size(103, 20);
            employeeIdLabel.TabIndex = 1;
            employeeIdLabel.Text = "employee Id:";
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerBindingSource, "employeeId", true));
            this.employeeIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdTextBox.Location = new System.Drawing.Point(162, 145);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(216, 27);
            this.employeeIdTextBox.TabIndex = 2;
            // 
            // lecturerNameLabel
            // 
            lecturerNameLabel.AutoSize = true;
            lecturerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lecturerNameLabel.Location = new System.Drawing.Point(26, 198);
            lecturerNameLabel.Name = "lecturerNameLabel";
            lecturerNameLabel.Size = new System.Drawing.Size(120, 20);
            lecturerNameLabel.TabIndex = 3;
            lecturerNameLabel.Text = "lecturer Name:";
            // 
            // lecturerNameTextBox
            // 
            this.lecturerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerBindingSource, "lecturerName", true));
            this.lecturerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerNameTextBox.Location = new System.Drawing.Point(162, 191);
            this.lecturerNameTextBox.Name = "lecturerNameTextBox";
            this.lecturerNameTextBox.Size = new System.Drawing.Size(216, 27);
            this.lecturerNameTextBox.TabIndex = 4;
            // 
            // facultyLabel
            // 
            facultyLabel.AutoSize = true;
            facultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            facultyLabel.Location = new System.Drawing.Point(26, 244);
            facultyLabel.Name = "facultyLabel";
            facultyLabel.Size = new System.Drawing.Size(63, 20);
            facultyLabel.TabIndex = 5;
            facultyLabel.Text = "faculty:";
            // 
            // facultyComboBox
            // 
            this.facultyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerBindingSource, "faculty", true));
            this.facultyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyComboBox.FormattingEnabled = true;
            this.facultyComboBox.Location = new System.Drawing.Point(162, 237);
            this.facultyComboBox.Name = "facultyComboBox";
            this.facultyComboBox.Size = new System.Drawing.Size(216, 28);
            this.facultyComboBox.TabIndex = 6;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentLabel.Location = new System.Drawing.Point(26, 290);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(98, 20);
            departmentLabel.TabIndex = 7;
            departmentLabel.Text = "department:";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerBindingSource, "department", true));
            this.departmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(162, 283);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(216, 28);
            this.departmentComboBox.TabIndex = 8;
            // 
            // centerLabel
            // 
            centerLabel.AutoSize = true;
            centerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            centerLabel.Location = new System.Drawing.Point(433, 148);
            centerLabel.Name = "centerLabel";
            centerLabel.Size = new System.Drawing.Size(61, 20);
            centerLabel.TabIndex = 9;
            centerLabel.Text = "center:";
            // 
            // centerComboBox
            // 
            this.centerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerBindingSource, "center", true));
            this.centerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerComboBox.FormattingEnabled = true;
            this.centerComboBox.Location = new System.Drawing.Point(521, 145);
            this.centerComboBox.Name = "centerComboBox";
            this.centerComboBox.Size = new System.Drawing.Size(230, 28);
            this.centerComboBox.TabIndex = 10;
            // 
            // buildingLabel
            // 
            buildingLabel.AutoSize = true;
            buildingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buildingLabel.Location = new System.Drawing.Point(433, 193);
            buildingLabel.Name = "buildingLabel";
            buildingLabel.Size = new System.Drawing.Size(71, 20);
            buildingLabel.TabIndex = 11;
            buildingLabel.Text = "building:";
            // 
            // buildingComboBox
            // 
            this.buildingComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerBindingSource, "building", true));
            this.buildingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingComboBox.FormattingEnabled = true;
            this.buildingComboBox.Location = new System.Drawing.Point(521, 190);
            this.buildingComboBox.Name = "buildingComboBox";
            this.buildingComboBox.Size = new System.Drawing.Size(230, 28);
            this.buildingComboBox.TabIndex = 12;
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            levelLabel.Location = new System.Drawing.Point(433, 239);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(48, 20);
            levelLabel.TabIndex = 13;
            levelLabel.Text = "level:";
            // 
            // levelComboBox
            // 
            this.levelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerBindingSource, "level", true));
            this.levelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Location = new System.Drawing.Point(521, 236);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(116, 28);
            this.levelComboBox.TabIndex = 14;
            // 
            // rankLabel
            // 
            rankLabel.AutoSize = true;
            rankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rankLabel.Location = new System.Drawing.Point(433, 286);
            rankLabel.Name = "rankLabel";
            rankLabel.Size = new System.Drawing.Size(46, 20);
            rankLabel.TabIndex = 15;
            rankLabel.Text = "rank:";
            // 
            // rankTextBox
            // 
            this.rankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerBindingSource, "rank", true));
            this.rankTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankTextBox.Location = new System.Drawing.Point(521, 283);
            this.rankTextBox.Name = "rankTextBox";
            this.rankTextBox.Size = new System.Drawing.Size(116, 27);
            this.rankTextBox.TabIndex = 16;
            // 
            // btnGenerateRank
            // 
            this.btnGenerateRank.Location = new System.Drawing.Point(651, 276);
            this.btnGenerateRank.Name = "btnGenerateRank";
            this.btnGenerateRank.Size = new System.Drawing.Size(101, 42);
            this.btnGenerateRank.TabIndex = 17;
            this.btnGenerateRank.Text = "Generate Rank";
            this.btnGenerateRank.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(536, 396);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 42);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(666, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 42);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // AddLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerateRank);
            this.Controls.Add(employeeIdLabel);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(lecturerNameLabel);
            this.Controls.Add(this.lecturerNameTextBox);
            this.Controls.Add(facultyLabel);
            this.Controls.Add(this.facultyComboBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(centerLabel);
            this.Controls.Add(this.centerComboBox);
            this.Controls.Add(buildingLabel);
            this.Controls.Add(this.buildingComboBox);
            this.Controls.Add(levelLabel);
            this.Controls.Add(this.levelComboBox);
            this.Controls.Add(rankLabel);
            this.Controls.Add(this.rankTextBox);
            this.Controls.Add(this.lecturerBindingNavigator);
            this.Name = "AddLecturer";
            this.Text = "AddLecturer";
            this.Load += new System.EventHandler(this.AddLecturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingNavigator)).EndInit();
            this.lecturerBindingNavigator.ResumeLayout(false);
            this.lecturerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private ModelDataSetTableAdapters.LecturerTableAdapter lecturerTableAdapter;
        private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lecturerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton lecturerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.TextBox lecturerNameTextBox;
        private System.Windows.Forms.ComboBox facultyComboBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.ComboBox centerComboBox;
        private System.Windows.Forms.ComboBox buildingComboBox;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.TextBox rankTextBox;
        private System.Windows.Forms.Button btnGenerateRank;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}