﻿
namespace LlamaUtilities.LlamaUtilities
{
    partial class Utilities
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRetainers = new System.Windows.Forms.TabPage();
            this.btnRetainers = new System.Windows.Forms.Button();
            this.pgRetainers = new System.Windows.Forms.PropertyGrid();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnHuntStart = new System.Windows.Forms.Button();
            this.pgHunts = new System.Windows.Forms.PropertyGrid();
            this.tabMateria = new System.Windows.Forms.TabPage();
            this.tabControlMateria = new System.Windows.Forms.TabControl();
            this.tabPageRemove = new System.Windows.Forms.TabPage();
            this.groupBoxRemoveFilter = new System.Windows.Forms.GroupBox();
            this.filterCb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveMateria = new System.Windows.Forms.Button();
            this.materiaListBox = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.itemCb = new System.Windows.Forms.ComboBox();
            this.tabAffix = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAffix = new System.Windows.Forms.Button();
            this.MateriaCb5 = new System.Windows.Forms.ComboBox();
            this.MateriaCb4 = new System.Windows.Forms.ComboBox();
            this.MateriaCb3 = new System.Windows.Forms.ComboBox();
            this.MateriaCb2 = new System.Windows.Forms.ComboBox();
            this.MateriaCb1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.affixCb = new System.Windows.Forms.ComboBox();
            this.bindingSourceAffix = new System.Windows.Forms.BindingSource(this.components);
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.lblDesynth = new System.Windows.Forms.Label();
            this.pgInventory = new System.Windows.Forms.PropertyGrid();
            this.btnDesynth = new System.Windows.Forms.Button();
            this.btnCoffers = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnReduce = new System.Windows.Forms.Button();
            this.tabCustom = new System.Windows.Forms.TabPage();
            this.btnCustomDeliveries = new System.Windows.Forms.Button();
            this.pgCustomDeliveries = new System.Windows.Forms.PropertyGrid();
            this.tabGC = new System.Windows.Forms.TabPage();
            this.btnGcTurin = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabHousing = new System.Windows.Forms.TabPage();
            this.btnHousing = new System.Windows.Forms.Button();
            this.tabFC = new System.Windows.Forms.TabPage();
            this.btnFCWorkshop = new System.Windows.Forms.Button();
            this.bindingSourceInventory = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceInventoryMateria = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabRetainers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabMateria.SuspendLayout();
            this.tabControlMateria.SuspendLayout();
            this.tabPageRemove.SuspendLayout();
            this.groupBoxRemoveFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabAffix.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.bindingSourceAffix)).BeginInit();
            this.tabInventory.SuspendLayout();
            this.tabCustom.SuspendLayout();
            this.tabGC.SuspendLayout();
            this.tabHousing.SuspendLayout();
            this.tabFC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.bindingSourceInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.bindingSourceInventoryMateria)).BeginInit();
            this.SuspendLayout();
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabRetainers);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabMateria);
            this.tabControl1.Controls.Add(this.tabInventory);
            this.tabControl1.Controls.Add(this.tabCustom);
            this.tabControl1.Controls.Add(this.tabGC);
            this.tabControl1.Controls.Add(this.tabHousing);
            this.tabControl1.Controls.Add(this.tabFC);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 385);
            this.tabControl1.TabIndex = 0;
            //
            // tabRetainers
            //
            this.tabRetainers.Controls.Add(this.btnRetainers);
            this.tabRetainers.Controls.Add(this.pgRetainers);
            this.tabRetainers.Location = new System.Drawing.Point(4, 22);
            this.tabRetainers.Name = "tabRetainers";
            this.tabRetainers.Size = new System.Drawing.Size(511, 359);
            this.tabRetainers.TabIndex = 7;
            this.tabRetainers.Text = "Retainers";
            this.tabRetainers.UseVisualStyleBackColor = true;
            //
            // btnRetainers
            //
            this.btnRetainers.Location = new System.Drawing.Point(283, 318);
            this.btnRetainers.Name = "btnRetainers";
            this.btnRetainers.Size = new System.Drawing.Size(94, 23);
            this.btnRetainers.TabIndex = 1;
            this.btnRetainers.Text = "Start";
            this.btnRetainers.UseVisualStyleBackColor = true;
            this.btnRetainers.Click += new System.EventHandler(this.btnRetainers_Click);
            //
            // pgRetainers
            //
            this.pgRetainers.Location = new System.Drawing.Point(8, 3);
            this.pgRetainers.Name = "pgRetainers";
            this.pgRetainers.Size = new System.Drawing.Size(369, 185);
            this.pgRetainers.TabIndex = 0;
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.btnHuntStart);
            this.tabPage1.Controls.Add(this.pgHunts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(511, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daily Hunts";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // btnHuntStart
            //
            this.btnHuntStart.Location = new System.Drawing.Point(265, 321);
            this.btnHuntStart.Name = "btnHuntStart";
            this.btnHuntStart.Size = new System.Drawing.Size(95, 25);
            this.btnHuntStart.TabIndex = 1;
            this.btnHuntStart.Text = "Start";
            this.btnHuntStart.UseVisualStyleBackColor = true;
            this.btnHuntStart.Click += new System.EventHandler(this.btnHuntStart_Click);
            //
            // pgHunts
            //
            this.pgHunts.Location = new System.Drawing.Point(9, 12);
            this.pgHunts.Name = "pgHunts";
            this.pgHunts.Size = new System.Drawing.Size(352, 238);
            this.pgHunts.TabIndex = 0;
            //
            // tabMateria
            //
            this.tabMateria.Controls.Add(this.tabControlMateria);
            this.tabMateria.Location = new System.Drawing.Point(4, 22);
            this.tabMateria.Name = "tabMateria";
            this.tabMateria.Padding = new System.Windows.Forms.Padding(3);
            this.tabMateria.Size = new System.Drawing.Size(511, 359);
            this.tabMateria.TabIndex = 1;
            this.tabMateria.Text = "Materia";
            this.tabMateria.UseVisualStyleBackColor = true;
            //
            // tabControlMateria
            //
            this.tabControlMateria.Controls.Add(this.tabPageRemove);
            this.tabControlMateria.Controls.Add(this.tabAffix);
            this.tabControlMateria.Location = new System.Drawing.Point(8, 6);
            this.tabControlMateria.Name = "tabControlMateria";
            this.tabControlMateria.SelectedIndex = 0;
            this.tabControlMateria.Size = new System.Drawing.Size(497, 345);
            this.tabControlMateria.TabIndex = 1;
            //
            // tabPageRemove
            //
            this.tabPageRemove.Controls.Add(this.groupBoxRemoveFilter);
            this.tabPageRemove.Controls.Add(this.groupBox1);
            this.tabPageRemove.Location = new System.Drawing.Point(4, 22);
            this.tabPageRemove.Name = "tabPageRemove";
            this.tabPageRemove.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRemove.Size = new System.Drawing.Size(489, 319);
            this.tabPageRemove.TabIndex = 0;
            this.tabPageRemove.Text = "Remove";
            this.tabPageRemove.UseVisualStyleBackColor = true;
            this.tabPageRemove.Click += new System.EventHandler(this.tabPageRemove_Click);
            //
            // groupBoxRemoveFilter
            //
            this.groupBoxRemoveFilter.Controls.Add(this.filterCb);
            this.groupBoxRemoveFilter.Location = new System.Drawing.Point(346, 6);
            this.groupBoxRemoveFilter.Name = "groupBoxRemoveFilter";
            this.groupBoxRemoveFilter.Size = new System.Drawing.Size(137, 263);
            this.groupBoxRemoveFilter.TabIndex = 1;
            this.groupBoxRemoveFilter.TabStop = false;
            this.groupBoxRemoveFilter.Text = "Inventory Filter";
            //
            // filterCb
            //
            this.filterCb.FormattingEnabled = true;
            this.filterCb.Location = new System.Drawing.Point(6, 19);
            this.filterCb.Name = "filterCb";
            this.filterCb.Size = new System.Drawing.Size(125, 21);
            this.filterCb.TabIndex = 0;
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.btnRemoveMateria);
            this.groupBox1.Controls.Add(this.materiaListBox);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.itemCb);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remove Materia";
            //
            // btnRemoveMateria
            //
            this.btnRemoveMateria.Location = new System.Drawing.Point(9, 185);
            this.btnRemoveMateria.Name = "btnRemoveMateria";
            this.btnRemoveMateria.Size = new System.Drawing.Size(142, 25);
            this.btnRemoveMateria.TabIndex = 3;
            this.btnRemoveMateria.Text = "Remove All Materia";
            this.btnRemoveMateria.UseVisualStyleBackColor = true;
            this.btnRemoveMateria.Click += new System.EventHandler(this.btnRemoveMateria_Click);
            //
            // materiaListBox
            //
            this.materiaListBox.FormattingEnabled = true;
            this.materiaListBox.Location = new System.Drawing.Point(9, 45);
            this.materiaListBox.Name = "materiaListBox";
            this.materiaListBox.Size = new System.Drawing.Size(297, 134);
            this.materiaListBox.TabIndex = 2;
            //
            // btnRefresh
            //
            this.btnRefresh.Location = new System.Drawing.Point(229, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(78, 21);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // itemCb
            //
            this.itemCb.FormattingEnabled = true;
            this.itemCb.Location = new System.Drawing.Point(9, 17);
            this.itemCb.Name = "itemCb";
            this.itemCb.Size = new System.Drawing.Size(209, 21);
            this.itemCb.TabIndex = 0;
            //
            // tabAffix
            //
            this.tabAffix.Controls.Add(this.groupBox2);
            this.tabAffix.Location = new System.Drawing.Point(4, 22);
            this.tabAffix.Name = "tabAffix";
            this.tabAffix.Padding = new System.Windows.Forms.Padding(3);
            this.tabAffix.Size = new System.Drawing.Size(489, 319);
            this.tabAffix.TabIndex = 1;
            this.tabAffix.Text = "Affix";
            this.tabAffix.UseVisualStyleBackColor = true;
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.buttonAffix);
            this.groupBox2.Controls.Add(this.MateriaCb5);
            this.groupBox2.Controls.Add(this.MateriaCb4);
            this.groupBox2.Controls.Add(this.MateriaCb3);
            this.groupBox2.Controls.Add(this.MateriaCb2);
            this.groupBox2.Controls.Add(this.MateriaCb1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.affixCb);
            this.groupBox2.Location = new System.Drawing.Point(8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 285);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Affix";
            //
            // buttonAffix
            //
            this.buttonAffix.Location = new System.Drawing.Point(183, 191);
            this.buttonAffix.Name = "buttonAffix";
            this.buttonAffix.Size = new System.Drawing.Size(120, 23);
            this.buttonAffix.TabIndex = 7;
            this.buttonAffix.Text = "Affix";
            this.buttonAffix.UseVisualStyleBackColor = true;
            this.buttonAffix.Click += new System.EventHandler(this.buttonAffix_Click);
            //
            // MateriaCb5
            //
            this.MateriaCb5.FormattingEnabled = true;
            this.MateriaCb5.Location = new System.Drawing.Point(12, 164);
            this.MateriaCb5.Name = "MateriaCb5";
            this.MateriaCb5.Size = new System.Drawing.Size(291, 21);
            this.MateriaCb5.TabIndex = 6;
            //
            // MateriaCb4
            //
            this.MateriaCb4.FormattingEnabled = true;
            this.MateriaCb4.Location = new System.Drawing.Point(12, 137);
            this.MateriaCb4.Name = "MateriaCb4";
            this.MateriaCb4.Size = new System.Drawing.Size(291, 21);
            this.MateriaCb4.TabIndex = 5;
            //
            // MateriaCb3
            //
            this.MateriaCb3.FormattingEnabled = true;
            this.MateriaCb3.Location = new System.Drawing.Point(12, 110);
            this.MateriaCb3.Name = "MateriaCb3";
            this.MateriaCb3.Size = new System.Drawing.Size(291, 21);
            this.MateriaCb3.TabIndex = 4;
            //
            // MateriaCb2
            //
            this.MateriaCb2.FormattingEnabled = true;
            this.MateriaCb2.Location = new System.Drawing.Point(12, 83);
            this.MateriaCb2.Name = "MateriaCb2";
            this.MateriaCb2.Size = new System.Drawing.Size(291, 21);
            this.MateriaCb2.TabIndex = 3;
            //
            // MateriaCb1
            //
            this.MateriaCb1.FormattingEnabled = true;
            this.MateriaCb1.Location = new System.Drawing.Point(12, 56);
            this.MateriaCb1.Name = "MateriaCb1";
            this.MateriaCb1.Size = new System.Drawing.Size(291, 21);
            this.MateriaCb1.TabIndex = 2;
            //
            // button3
            //
            this.button3.Location = new System.Drawing.Point(233, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // affixCb
            //
            this.affixCb.DataSource = this.bindingSourceAffix;
            this.affixCb.FormattingEnabled = true;
            this.affixCb.Location = new System.Drawing.Point(12, 21);
            this.affixCb.Name = "affixCb";
            this.affixCb.Size = new System.Drawing.Size(215, 21);
            this.affixCb.TabIndex = 0;
            this.affixCb.SelectedIndexChanged += new System.EventHandler(this.affixCb_SelectedIndexChanged);
            //
            // tabInventory
            //
            this.tabInventory.Controls.Add(this.lblDesynth);
            this.tabInventory.Controls.Add(this.pgInventory);
            this.tabInventory.Controls.Add(this.btnDesynth);
            this.tabInventory.Controls.Add(this.btnCoffers);
            this.tabInventory.Controls.Add(this.btnExtract);
            this.tabInventory.Controls.Add(this.btnReduce);
            this.tabInventory.Location = new System.Drawing.Point(4, 22);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Size = new System.Drawing.Size(511, 359);
            this.tabInventory.TabIndex = 2;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            //
            // lblDesynth
            //
            this.lblDesynth.AutoSize = true;
            this.lblDesynth.Location = new System.Drawing.Point(136, 234);
            this.lblDesynth.Name = "lblDesynth";
            this.lblDesynth.Size = new System.Drawing.Size(198, 13);
            this.lblDesynth.TabIndex = 5;
            this.lblDesynth.Text = "<- Desynth all trust gear and possibly fish";
            //
            // pgInventory
            //
            this.pgInventory.Location = new System.Drawing.Point(131, 14);
            this.pgInventory.Name = "pgInventory";
            this.pgInventory.Size = new System.Drawing.Size(372, 199);
            this.pgInventory.TabIndex = 4;
            //
            // btnDesynth
            //
            this.btnDesynth.Location = new System.Drawing.Point(8, 228);
            this.btnDesynth.Name = "btnDesynth";
            this.btnDesynth.Size = new System.Drawing.Size(122, 24);
            this.btnDesynth.TabIndex = 3;
            this.btnDesynth.Text = "Desynth";
            this.btnDesynth.UseVisualStyleBackColor = true;
            this.btnDesynth.Click += new System.EventHandler(this.btnDesynth_Click);
            //
            // btnCoffers
            //
            this.btnCoffers.Location = new System.Drawing.Point(3, 74);
            this.btnCoffers.Name = "btnCoffers";
            this.btnCoffers.Size = new System.Drawing.Size(122, 24);
            this.btnCoffers.TabIndex = 2;
            this.btnCoffers.Text = "Open All Coffers";
            this.btnCoffers.UseVisualStyleBackColor = true;
            this.btnCoffers.Click += new System.EventHandler(this.btnCoffers_Click);
            //
            // btnExtract
            //
            this.btnExtract.Location = new System.Drawing.Point(3, 44);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(122, 24);
            this.btnExtract.TabIndex = 1;
            this.btnExtract.Text = "Extract Materia";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            //
            // btnReduce
            //
            this.btnReduce.Location = new System.Drawing.Point(3, 14);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(122, 24);
            this.btnReduce.TabIndex = 0;
            this.btnReduce.Text = "Reduce All";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            //
            // tabCustom
            //
            this.tabCustom.Controls.Add(this.btnCustomDeliveries);
            this.tabCustom.Controls.Add(this.pgCustomDeliveries);
            this.tabCustom.Location = new System.Drawing.Point(4, 22);
            this.tabCustom.Name = "tabCustom";
            this.tabCustom.Size = new System.Drawing.Size(511, 359);
            this.tabCustom.TabIndex = 3;
            this.tabCustom.Text = "Custom Deliveries";
            this.tabCustom.UseVisualStyleBackColor = true;
            //
            // btnCustomDeliveries
            //
            this.btnCustomDeliveries.Location = new System.Drawing.Point(296, 328);
            this.btnCustomDeliveries.Name = "btnCustomDeliveries";
            this.btnCustomDeliveries.Size = new System.Drawing.Size(75, 23);
            this.btnCustomDeliveries.TabIndex = 1;
            this.btnCustomDeliveries.Text = "Start";
            this.btnCustomDeliveries.UseVisualStyleBackColor = true;
            this.btnCustomDeliveries.Click += new System.EventHandler(this.btnCustomDeliveries_Click);
            //
            // pgCustomDeliveries
            //
            this.pgCustomDeliveries.Location = new System.Drawing.Point(3, 3);
            this.pgCustomDeliveries.Name = "pgCustomDeliveries";
            this.pgCustomDeliveries.Size = new System.Drawing.Size(373, 220);
            this.pgCustomDeliveries.TabIndex = 0;
            //
            // tabGC
            //
            this.tabGC.Controls.Add(this.btnGcTurin);
            this.tabGC.Controls.Add(this.propertyGrid1);
            this.tabGC.Location = new System.Drawing.Point(4, 22);
            this.tabGC.Name = "tabGC";
            this.tabGC.Size = new System.Drawing.Size(511, 359);
            this.tabGC.TabIndex = 4;
            this.tabGC.Text = "Gc Turnin";
            this.tabGC.UseVisualStyleBackColor = true;
            //
            // btnGcTurin
            //
            this.btnGcTurin.Location = new System.Drawing.Point(288, 328);
            this.btnGcTurin.Name = "btnGcTurin";
            this.btnGcTurin.Size = new System.Drawing.Size(88, 23);
            this.btnGcTurin.TabIndex = 1;
            this.btnGcTurin.Text = "Start";
            this.btnGcTurin.UseVisualStyleBackColor = true;
            this.btnGcTurin.Click += new System.EventHandler(this.btnGcTurin_Click);
            //
            // propertyGrid1
            //
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(373, 219);
            this.propertyGrid1.TabIndex = 0;
            //
            // tabHousing
            //
            this.tabHousing.Controls.Add(this.btnHousing);
            this.tabHousing.Location = new System.Drawing.Point(4, 22);
            this.tabHousing.Name = "tabHousing";
            this.tabHousing.Padding = new System.Windows.Forms.Padding(3);
            this.tabHousing.Size = new System.Drawing.Size(511, 359);
            this.tabHousing.TabIndex = 5;
            this.tabHousing.Text = "Housing";
            this.tabHousing.UseVisualStyleBackColor = true;
            //
            // btnHousing
            //
            this.btnHousing.Location = new System.Drawing.Point(276, 307);
            this.btnHousing.Name = "btnHousing";
            this.btnHousing.Size = new System.Drawing.Size(95, 23);
            this.btnHousing.TabIndex = 0;
            this.btnHousing.Text = "Start";
            this.btnHousing.UseVisualStyleBackColor = true;
            this.btnHousing.Click += new System.EventHandler(this.btnHousing_Click);
            //
            // tabFC
            //
            this.tabFC.Controls.Add(this.btnFCWorkshop);
            this.tabFC.Location = new System.Drawing.Point(4, 22);
            this.tabFC.Name = "tabFC";
            this.tabFC.Size = new System.Drawing.Size(511, 359);
            this.tabFC.TabIndex = 6;
            this.tabFC.Text = "FCWorkshop";
            this.tabFC.UseVisualStyleBackColor = true;
            //
            // btnFCWorkshop
            //
            this.btnFCWorkshop.Location = new System.Drawing.Point(280, 327);
            this.btnFCWorkshop.Name = "btnFCWorkshop";
            this.btnFCWorkshop.Size = new System.Drawing.Size(84, 24);
            this.btnFCWorkshop.TabIndex = 0;
            this.btnFCWorkshop.Text = "Start";
            this.btnFCWorkshop.UseVisualStyleBackColor = true;
            this.btnFCWorkshop.Click += new System.EventHandler(this.btnFCWorkshop_Click);
            //
            // bindingSourceInventory
            //
            this.bindingSourceInventory.CurrentChanged += new System.EventHandler(this.bindingSourceInventory_CurrentChanged);
            //
            // Utilities
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 385);
            this.Controls.Add(this.tabControl1);
            this.Name = "Utilities";
            this.Text = "Utilities";
            this.Load += new System.EventHandler(this.Utilities_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabRetainers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabMateria.ResumeLayout(false);
            this.tabControlMateria.ResumeLayout(false);
            this.tabPageRemove.ResumeLayout(false);
            this.groupBoxRemoveFilter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabAffix.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.bindingSourceAffix)).EndInit();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            this.tabCustom.ResumeLayout(false);
            this.tabGC.ResumeLayout(false);
            this.tabHousing.ResumeLayout(false);
            this.tabFC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.bindingSourceInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.bindingSourceInventoryMateria)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox filterCb;

        private System.Windows.Forms.GroupBox groupBoxRemoveFilter;

        private System.Windows.Forms.Button buttonAffix;

        private System.Windows.Forms.BindingSource bindingSourceInventoryMateria;

        private System.Windows.Forms.ComboBox MateriaCb1;
        private System.Windows.Forms.ComboBox MateriaCb2;
        private System.Windows.Forms.ComboBox MateriaCb3;
        private System.Windows.Forms.ComboBox MateriaCb4;
        private System.Windows.Forms.ComboBox MateriaCb5;

        private System.Windows.Forms.ComboBox affixCb;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.TabPage tabAffix;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.TabControl tabControlMateria;


        private System.Windows.Forms.PropertyGrid pgHunts;
        private System.Windows.Forms.Button btnHuntStart;

        private System.Windows.Forms.BindingSource bindingSourceInventory;

        private System.Windows.Forms.BindingSource bindingSourceAffix;

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabMateria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox itemCb;
        private System.Windows.Forms.ListBox materiaListBox;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemoveMateria;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnCoffers;
        private System.Windows.Forms.TabPage tabCustom;
        private System.Windows.Forms.TabPage tabGC;
        private System.Windows.Forms.TabPage tabHousing;
        private System.Windows.Forms.TabPage tabPageRemove;

        private System.Windows.Forms.PropertyGrid pgCustomDeliveries;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btnCustomDeliveries;
        private System.Windows.Forms.Button btnGcTurin;
        private System.Windows.Forms.Button btnHousing;
        private System.Windows.Forms.TabPage tabRetainers;
        private System.Windows.Forms.Button btnRetainers;
        private System.Windows.Forms.PropertyGrid pgRetainers;
        private System.Windows.Forms.TabPage tabFC;
        private System.Windows.Forms.Button btnFCWorkshop;
        private System.Windows.Forms.Label lblDesynth;
        private System.Windows.Forms.PropertyGrid pgInventory;
        private System.Windows.Forms.Button btnDesynth;
    }
}