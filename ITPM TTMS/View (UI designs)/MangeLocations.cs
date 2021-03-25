using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPM_TTMS.View__UI_designs_
{
    public partial class MangeLocations : Form
    {
        public MangeLocations()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.managelocationstextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.locationlist = new System.Windows.Forms.TabPage();
            this.addlocations = new System.Windows.Forms.TabPage();
            this.updtelocations = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuildingNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addlocationstextBox = new System.Windows.Forms.TextBox();
            this.bntextBox = new System.Windows.Forms.TextBox();
            this.rntextBox = new System.Windows.Forms.TextBox();
            this.rttextBox = new System.Windows.Forms.TextBox();
            this.cptextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.addbutton = new System.Windows.Forms.Button();
            this.clearbutton1 = new System.Windows.Forms.Button();
            this.clearbutton2 = new System.Windows.Forms.Button();
            this.deleteandupdatetextBox = new System.Windows.Forms.TextBox();
            this.selectbuildingnamecombo = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.bntextBox2 = new System.Windows.Forms.TextBox();
            this.rntextBox2 = new System.Windows.Forms.TextBox();
            this.rttextBox2 = new System.Windows.Forms.TextBox();
            this.cptextBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.searchbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.locationlist.SuspendLayout();
            this.addlocations.SuspendLayout();
            this.updtelocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // managelocationstextBox
            // 
            this.managelocationstextBox.Location = new System.Drawing.Point(330, 54);
            this.managelocationstextBox.Multiline = true;
            this.managelocationstextBox.Name = "managelocationstextBox";
            this.managelocationstextBox.Size = new System.Drawing.Size(192, 24);
            this.managelocationstextBox.TabIndex = 1;
            this.managelocationstextBox.Text = "Manage Locations";
            this.managelocationstextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.locationlist);
            this.tabControl1.Controls.Add(this.addlocations);
            this.tabControl1.Controls.Add(this.updtelocations);
            this.tabControl1.Location = new System.Drawing.Point(72, 123);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 282);
            this.tabControl1.TabIndex = 2;
            // 
            // locationlist
            // 
            this.locationlist.Controls.Add(this.dataGridView1);
            this.locationlist.Location = new System.Drawing.Point(4, 22);
            this.locationlist.Name = "locationlist";
            this.locationlist.Padding = new System.Windows.Forms.Padding(3);
            this.locationlist.Size = new System.Drawing.Size(504, 256);
            this.locationlist.TabIndex = 0;
            this.locationlist.Text = "Location List";
            this.locationlist.UseVisualStyleBackColor = true;
            // 
            // addlocations
            // 
            this.addlocations.Controls.Add(this.clearbutton1);
            this.addlocations.Controls.Add(this.addbutton);
            this.addlocations.Controls.Add(this.numericUpDown1);
            this.addlocations.Controls.Add(this.comboBox3);
            this.addlocations.Controls.Add(this.comboBox2);
            this.addlocations.Controls.Add(this.comboBox1);
            this.addlocations.Controls.Add(this.cptextBox);
            this.addlocations.Controls.Add(this.rttextBox);
            this.addlocations.Controls.Add(this.rntextBox);
            this.addlocations.Controls.Add(this.bntextBox);
            this.addlocations.Controls.Add(this.addlocationstextBox);
            this.addlocations.Location = new System.Drawing.Point(4, 22);
            this.addlocations.Name = "addlocations";
            this.addlocations.Padding = new System.Windows.Forms.Padding(3);
            this.addlocations.Size = new System.Drawing.Size(504, 256);
            this.addlocations.TabIndex = 1;
            this.addlocations.Text = "Add Locations";
            this.addlocations.UseVisualStyleBackColor = true;
            // 
            // updtelocations
            // 
            this.updtelocations.Controls.Add(this.deletebutton);
            this.updtelocations.Controls.Add(this.updatebutton);
            this.updtelocations.Controls.Add(this.searchbutton);
            this.updtelocations.Controls.Add(this.numericUpDown2);
            this.updtelocations.Controls.Add(this.cptextBox2);
            this.updtelocations.Controls.Add(this.rttextBox2);
            this.updtelocations.Controls.Add(this.rntextBox2);
            this.updtelocations.Controls.Add(this.bntextBox2);
            this.updtelocations.Controls.Add(this.comboBox6);
            this.updtelocations.Controls.Add(this.comboBox5);
            this.updtelocations.Controls.Add(this.selectbuildingnamecombo);
            this.updtelocations.Controls.Add(this.deleteandupdatetextBox);
            this.updtelocations.Controls.Add(this.clearbutton2);
            this.updtelocations.Location = new System.Drawing.Point(4, 22);
            this.updtelocations.Name = "updtelocations";
            this.updtelocations.Padding = new System.Windows.Forms.Padding(3);
            this.updtelocations.Size = new System.Drawing.Size(504, 256);
            this.updtelocations.TabIndex = 2;
            this.updtelocations.Text = "Update and Delete Locations";
            this.updtelocations.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.BuildingNameColumn,
            this.RoomNameColumn,
            this.RoomTypeColumn,
            this.CapacityColumn});
            this.dataGridView1.Location = new System.Drawing.Point(35, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            // 
            // BuildingNameColumn
            // 
            this.BuildingNameColumn.HeaderText = "Building Name";
            this.BuildingNameColumn.Name = "BuildingNameColumn";
            // 
            // RoomNameColumn
            // 
            this.RoomNameColumn.HeaderText = "Room Name";
            this.RoomNameColumn.Name = "RoomNameColumn";
            this.RoomNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // RoomTypeColumn
            // 
            this.RoomTypeColumn.HeaderText = "Room Type";
            this.RoomTypeColumn.Name = "RoomTypeColumn";
            // 
            // CapacityColumn
            // 
            this.CapacityColumn.HeaderText = "Capacity";
            this.CapacityColumn.Name = "CapacityColumn";
            this.CapacityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CapacityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // addlocationstextBox
            // 
            this.addlocationstextBox.Location = new System.Drawing.Point(237, 23);
            this.addlocationstextBox.Name = "addlocationstextBox";
            this.addlocationstextBox.Size = new System.Drawing.Size(100, 20);
            this.addlocationstextBox.TabIndex = 0;
            this.addlocationstextBox.Text = "Add Locations";
            this.addlocationstextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bntextBox
            // 
            this.bntextBox.Location = new System.Drawing.Point(31, 65);
            this.bntextBox.Name = "bntextBox";
            this.bntextBox.Size = new System.Drawing.Size(100, 20);
            this.bntextBox.TabIndex = 1;
            this.bntextBox.Text = "Building Name";
            this.bntextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rntextBox
            // 
            this.rntextBox.Location = new System.Drawing.Point(31, 115);
            this.rntextBox.Name = "rntextBox";
            this.rntextBox.Size = new System.Drawing.Size(100, 20);
            this.rntextBox.TabIndex = 2;
            this.rntextBox.Text = "Room Name";
            this.rntextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rttextBox
            // 
            this.rttextBox.Location = new System.Drawing.Point(31, 160);
            this.rttextBox.Name = "rttextBox";
            this.rttextBox.Size = new System.Drawing.Size(100, 20);
            this.rttextBox.TabIndex = 3;
            this.rttextBox.Text = "Room Type";
            this.rttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cptextBox
            // 
            this.cptextBox.Location = new System.Drawing.Point(31, 205);
            this.cptextBox.Name = "cptextBox";
            this.cptextBox.Size = new System.Drawing.Size(100, 20);
            this.cptextBox.TabIndex = 4;
            this.cptextBox.Text = "Capacity";
            this.cptextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Select Building Name";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(216, 114);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "Select Room Name";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(216, 160);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(133, 21);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.Text = "Select Room Type";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(216, 205);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(133, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(395, 93);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 9;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            // 
            // clearbutton1
            // 
            this.clearbutton1.Location = new System.Drawing.Point(395, 157);
            this.clearbutton1.Name = "clearbutton1";
            this.clearbutton1.Size = new System.Drawing.Size(75, 23);
            this.clearbutton1.TabIndex = 10;
            this.clearbutton1.Text = "Clear";
            this.clearbutton1.UseVisualStyleBackColor = true;
            // 
            // clearbutton2
            // 
            this.clearbutton2.Location = new System.Drawing.Point(397, 215);
            this.clearbutton2.Name = "clearbutton2";
            this.clearbutton2.Size = new System.Drawing.Size(75, 23);
            this.clearbutton2.TabIndex = 2;
            this.clearbutton2.Text = "Clear";
            this.clearbutton2.UseVisualStyleBackColor = true;
            // 
            // deleteandupdatetextBox
            // 
            this.deleteandupdatetextBox.Location = new System.Drawing.Point(255, 18);
            this.deleteandupdatetextBox.Name = "deleteandupdatetextBox";
            this.deleteandupdatetextBox.Size = new System.Drawing.Size(162, 20);
            this.deleteandupdatetextBox.TabIndex = 3;
            this.deleteandupdatetextBox.Text = "Update and Delete Locations";
            this.deleteandupdatetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectbuildingnamecombo
            // 
            this.selectbuildingnamecombo.FormattingEnabled = true;
            this.selectbuildingnamecombo.Location = new System.Drawing.Point(174, 57);
            this.selectbuildingnamecombo.Name = "selectbuildingnamecombo";
            this.selectbuildingnamecombo.Size = new System.Drawing.Size(121, 21);
            this.selectbuildingnamecombo.TabIndex = 4;
            this.selectbuildingnamecombo.Text = "Select Building Name";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(174, 106);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 5;
            this.comboBox5.Text = "Select Room Name";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(174, 162);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 6;
            this.comboBox6.Text = "Select Room Type";
            // 
            // bntextBox2
            // 
            this.bntextBox2.Location = new System.Drawing.Point(19, 57);
            this.bntextBox2.Name = "bntextBox2";
            this.bntextBox2.Size = new System.Drawing.Size(121, 20);
            this.bntextBox2.TabIndex = 8;
            this.bntextBox2.Text = "Building Name";
            this.bntextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rntextBox2
            // 
            this.rntextBox2.Location = new System.Drawing.Point(19, 107);
            this.rntextBox2.Name = "rntextBox2";
            this.rntextBox2.Size = new System.Drawing.Size(121, 20);
            this.rntextBox2.TabIndex = 9;
            this.rntextBox2.Text = "Room Name";
            this.rntextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rttextBox2
            // 
            this.rttextBox2.Location = new System.Drawing.Point(19, 160);
            this.rttextBox2.Name = "rttextBox2";
            this.rttextBox2.Size = new System.Drawing.Size(121, 20);
            this.rttextBox2.TabIndex = 10;
            this.rttextBox2.Text = "Room Type";
            this.rttextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cptextBox2
            // 
            this.cptextBox2.Location = new System.Drawing.Point(19, 215);
            this.cptextBox2.Name = "cptextBox2";
            this.cptextBox2.Size = new System.Drawing.Size(121, 20);
            this.cptextBox2.TabIndex = 11;
            this.cptextBox2.Text = "Capacity";
            this.cptextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(175, 215);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 12;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(397, 57);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 13;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(397, 104);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 14;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(397, 160);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 15;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            // 
            // MangeLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.managelocationstextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MangeLocations";
            this.Text = "ManageLocations";
            this.tabControl1.ResumeLayout(false);
            this.locationlist.ResumeLayout(false);
            this.addlocations.ResumeLayout(false);
            this.addlocations.PerformLayout();
            this.updtelocations.ResumeLayout(false);
            this.updtelocations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private TextBox managelocationstextBox;
        private TabControl tabControl1;
        private TabPage locationlist;
        private DataGridView dataGridView1;
        private TabPage addlocations;
        private TabPage updtelocations;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn BuildingNameColumn;
        private DataGridViewTextBoxColumn RoomNameColumn;
        private DataGridViewTextBoxColumn RoomTypeColumn;
        private DataGridViewTextBoxColumn CapacityColumn;
        private Button clearbutton1;
        private Button addbutton;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox cptextBox;
        private TextBox rttextBox;
        private TextBox rntextBox;
        private TextBox bntextBox;
        private TextBox addlocationstextBox;
        private TextBox deleteandupdatetextBox;
        private Button clearbutton2;
        private IContainer components;
        private Button updatebutton;
        private Button searchbutton;
        private NumericUpDown numericUpDown2;
        private TextBox cptextBox2;
        private TextBox rttextBox2;
        private TextBox rntextBox2;
        private TextBox bntextBox2;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private ComboBox selectbuildingnamecombo;
        private Button deletebutton;
    }
}
