namespace bill_record
{
    partial class frm_expend
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
            this.txt_serial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.txt_amountBegin = new System.Windows.Forms.TextBox();
            this.txt_amountEnd = new System.Windows.Forms.TextBox();
            this.cmb_itemtype = new System.Windows.Forms.ComboBox();
            this.chk_valid = new System.Windows.Forms.CheckBox();
            this.chk_date = new System.Windows.Forms.CheckBox();
            this.btn_Query = new System.Windows.Forms.Button();
            this.dgv_expend_view = new System.Windows.Forms.DataGridView();
            this.expserialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exptypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exppriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exppublicDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.expvalidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.exp_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds_expend_view = new System.Windows.Forms.BindingSource(this.components);
            this.xsd_expend_view = new bill_record.xsd_expend_view();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_reject = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_only_public = new System.Windows.Forms.CheckBox();
            this.btn_export2Excel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expend_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_expend_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xsd_expend_view)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_serial
            // 
            this.txt_serial.Location = new System.Drawing.Point(85, 47);
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.Size = new System.Drawing.Size(119, 21);
            this.txt_serial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用途";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "序   号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "金额";
            // 
            // dtp_begin
            // 
            this.dtp_begin.Enabled = false;
            this.dtp_begin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_begin.Location = new System.Drawing.Point(85, 74);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(119, 21);
            this.dtp_begin.TabIndex = 5;
            this.dtp_begin.ValueChanged += new System.EventHandler(this.dtp_dateBegin_ValueChanged);
            // 
            // dtp_end
            // 
            this.dtp_end.Enabled = false;
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(210, 74);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(120, 21);
            this.dtp_end.TabIndex = 6;
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_dateEnd_ValueChanged);
            // 
            // txt_amountBegin
            // 
            this.txt_amountBegin.Location = new System.Drawing.Point(381, 46);
            this.txt_amountBegin.Name = "txt_amountBegin";
            this.txt_amountBegin.Size = new System.Drawing.Size(59, 21);
            this.txt_amountBegin.TabIndex = 7;
            this.txt_amountBegin.TextChanged += new System.EventHandler(this.txt_amountBegin_TextChanged);
            this.txt_amountBegin.Validating += new System.ComponentModel.CancelEventHandler(this.txt_amountBegin_Validating);
            // 
            // txt_amountEnd
            // 
            this.txt_amountEnd.Location = new System.Drawing.Point(446, 46);
            this.txt_amountEnd.Name = "txt_amountEnd";
            this.txt_amountEnd.Size = new System.Drawing.Size(59, 21);
            this.txt_amountEnd.TabIndex = 8;
            this.txt_amountEnd.TextChanged += new System.EventHandler(this.txt_amountEnd_TextChanged);
            this.txt_amountEnd.Validating += new System.ComponentModel.CancelEventHandler(this.txt_amountEnd_Validating);
            // 
            // cmb_itemtype
            // 
            this.cmb_itemtype.FormattingEnabled = true;
            this.cmb_itemtype.Location = new System.Drawing.Point(245, 47);
            this.cmb_itemtype.Name = "cmb_itemtype";
            this.cmb_itemtype.Size = new System.Drawing.Size(85, 20);
            this.cmb_itemtype.TabIndex = 9;
            // 
            // chk_valid
            // 
            this.chk_valid.AutoSize = true;
            this.chk_valid.Location = new System.Drawing.Point(348, 76);
            this.chk_valid.Name = "chk_valid";
            this.chk_valid.Size = new System.Drawing.Size(72, 16);
            this.chk_valid.TabIndex = 10;
            this.chk_valid.Text = "查询所有";
            this.chk_valid.UseVisualStyleBackColor = true;
            // 
            // chk_date
            // 
            this.chk_date.AutoSize = true;
            this.chk_date.Location = new System.Drawing.Point(22, 76);
            this.chk_date.Name = "chk_date";
            this.chk_date.Size = new System.Drawing.Size(60, 16);
            this.chk_date.TabIndex = 11;
            this.chk_date.Text = "按日期";
            this.chk_date.UseVisualStyleBackColor = true;
            this.chk_date.CheckedChanged += new System.EventHandler(this.chk_date_CheckedChanged);
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(461, 72);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(44, 22);
            this.btn_Query.TabIndex = 12;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // dgv_expend_view
            // 
            this.dgv_expend_view.AllowUserToAddRows = false;
            this.dgv_expend_view.AutoGenerateColumns = false;
            this.dgv_expend_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_expend_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expserialDataGridViewTextBoxColumn,
            this.expdateDataGridViewTextBoxColumn,
            this.exptypeDataGridViewTextBoxColumn,
            this.expitemDataGridViewTextBoxColumn,
            this.expcountDataGridViewTextBoxColumn,
            this.exppriceDataGridViewTextBoxColumn,
            this.explevelDataGridViewTextBoxColumn,
            this.exppublicDataGridViewCheckBoxColumn,
            this.expvalidDataGridViewCheckBoxColumn,
            this.exp_note});
            this.dgv_expend_view.DataSource = this.bds_expend_view;
            this.dgv_expend_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_expend_view.Location = new System.Drawing.Point(0, 0);
            this.dgv_expend_view.Name = "dgv_expend_view";
            this.dgv_expend_view.ReadOnly = true;
            this.dgv_expend_view.RowTemplate.Height = 23;
            this.dgv_expend_view.Size = new System.Drawing.Size(772, 279);
            this.dgv_expend_view.TabIndex = 13;
            this.dgv_expend_view.CurrentCellChanged += new System.EventHandler(this.dgv_expend_view_CurrentCellChanged);
            // 
            // expserialDataGridViewTextBoxColumn
            // 
            this.expserialDataGridViewTextBoxColumn.DataPropertyName = "exp_serial";
            this.expserialDataGridViewTextBoxColumn.HeaderText = "exp_serial";
            this.expserialDataGridViewTextBoxColumn.Name = "expserialDataGridViewTextBoxColumn";
            this.expserialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expdateDataGridViewTextBoxColumn
            // 
            this.expdateDataGridViewTextBoxColumn.DataPropertyName = "exp_date";
            this.expdateDataGridViewTextBoxColumn.HeaderText = "exp_date";
            this.expdateDataGridViewTextBoxColumn.Name = "expdateDataGridViewTextBoxColumn";
            this.expdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exptypeDataGridViewTextBoxColumn
            // 
            this.exptypeDataGridViewTextBoxColumn.DataPropertyName = "exp_type";
            this.exptypeDataGridViewTextBoxColumn.HeaderText = "exp_type";
            this.exptypeDataGridViewTextBoxColumn.Name = "exptypeDataGridViewTextBoxColumn";
            this.exptypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expitemDataGridViewTextBoxColumn
            // 
            this.expitemDataGridViewTextBoxColumn.DataPropertyName = "exp_item";
            this.expitemDataGridViewTextBoxColumn.HeaderText = "exp_item";
            this.expitemDataGridViewTextBoxColumn.Name = "expitemDataGridViewTextBoxColumn";
            this.expitemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expcountDataGridViewTextBoxColumn
            // 
            this.expcountDataGridViewTextBoxColumn.DataPropertyName = "exp_count";
            this.expcountDataGridViewTextBoxColumn.HeaderText = "exp_count";
            this.expcountDataGridViewTextBoxColumn.Name = "expcountDataGridViewTextBoxColumn";
            this.expcountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exppriceDataGridViewTextBoxColumn
            // 
            this.exppriceDataGridViewTextBoxColumn.DataPropertyName = "exp_price";
            this.exppriceDataGridViewTextBoxColumn.HeaderText = "exp_price";
            this.exppriceDataGridViewTextBoxColumn.Name = "exppriceDataGridViewTextBoxColumn";
            this.exppriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // explevelDataGridViewTextBoxColumn
            // 
            this.explevelDataGridViewTextBoxColumn.DataPropertyName = "exp_level";
            this.explevelDataGridViewTextBoxColumn.HeaderText = "exp_level";
            this.explevelDataGridViewTextBoxColumn.Name = "explevelDataGridViewTextBoxColumn";
            this.explevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exppublicDataGridViewCheckBoxColumn
            // 
            this.exppublicDataGridViewCheckBoxColumn.DataPropertyName = "exp_public";
            this.exppublicDataGridViewCheckBoxColumn.HeaderText = "exp_public";
            this.exppublicDataGridViewCheckBoxColumn.Name = "exppublicDataGridViewCheckBoxColumn";
            this.exppublicDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // expvalidDataGridViewCheckBoxColumn
            // 
            this.expvalidDataGridViewCheckBoxColumn.DataPropertyName = "exp_valid";
            this.expvalidDataGridViewCheckBoxColumn.HeaderText = "exp_valid";
            this.expvalidDataGridViewCheckBoxColumn.Name = "expvalidDataGridViewCheckBoxColumn";
            this.expvalidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // exp_note
            // 
            this.exp_note.DataPropertyName = "exp_note";
            this.exp_note.HeaderText = "exp_note";
            this.exp_note.Name = "exp_note";
            this.exp_note.ReadOnly = true;
            // 
            // bds_expend_view
            // 
            this.bds_expend_view.DataMember = "tbl_expend";
            this.bds_expend_view.DataSource = this.xsd_expend_view;
            // 
            // xsd_expend_view
            // 
            this.xsd_expend_view.DataSetName = "xsd_expend_view";
            this.xsd_expend_view.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(83, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(67, 23);
            this.btn_edit.TabIndex = 18;
            this.btn_edit.Text = "编辑";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_reject
            // 
            this.btn_reject.Location = new System.Drawing.Point(225, 12);
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.Size = new System.Drawing.Size(67, 23);
            this.btn_reject.TabIndex = 19;
            this.btn_reject.Text = "撤销";
            this.btn_reject.UseVisualStyleBackColor = true;
            this.btn_reject.Click += new System.EventHandler(this.btn_reject_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(12, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(67, 23);
            this.btn_new.TabIndex = 20;
            this.btn_new.Text = "新建";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(154, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(67, 23);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(298, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(67, 23);
            this.btn_save.TabIndex = 22;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Query);
            this.panel1.Controls.Add(this.chk_only_public);
            this.panel1.Controls.Add(this.btn_export2Excel);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.txt_serial);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_reject);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.dtp_end);
            this.panel1.Controls.Add(this.txt_amountBegin);
            this.panel1.Controls.Add(this.txt_amountEnd);
            this.panel1.Controls.Add(this.cmb_itemtype);
            this.panel1.Controls.Add(this.chk_valid);
            this.panel1.Controls.Add(this.chk_date);
            this.panel1.Controls.Add(this.dtp_begin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 105);
            this.panel1.TabIndex = 23;
            // 
            // chk_only_public
            // 
            this.chk_only_public.AutoSize = true;
            this.chk_only_public.Checked = true;
            this.chk_only_public.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_only_public.Location = new System.Drawing.Point(417, 76);
            this.chk_only_public.Name = "chk_only_public";
            this.chk_only_public.Size = new System.Drawing.Size(48, 16);
            this.chk_only_public.TabIndex = 24;
            this.chk_only_public.Text = "公款";
            this.chk_only_public.UseVisualStyleBackColor = true;
            // 
            // btn_export2Excel
            // 
            this.btn_export2Excel.Location = new System.Drawing.Point(381, 12);
            this.btn_export2Excel.Name = "btn_export2Excel";
            this.btn_export2Excel.Size = new System.Drawing.Size(70, 23);
            this.btn_export2Excel.TabIndex = 23;
            this.btn_export2Excel.Text = "导出Excel";
            this.btn_export2Excel.UseVisualStyleBackColor = true;
            this.btn_export2Excel.Click += new System.EventHandler(this.btn_export2Excel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(772, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_expend_view);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 279);
            this.panel2.TabIndex = 25;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_expend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 406);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_expend";
            this.Text = "支出录入查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_expend_FormClosing);
            this.Load += new System.EventHandler(this.frm_expend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expend_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_expend_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xsd_expend_view)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_serial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.TextBox txt_amountBegin;
        private System.Windows.Forms.TextBox txt_amountEnd;
        private System.Windows.Forms.ComboBox cmb_itemtype;
        private System.Windows.Forms.CheckBox chk_valid;
        private System.Windows.Forms.CheckBox chk_date;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.DataGridView dgv_expend_view;
        private System.Windows.Forms.BindingSource bds_expend_view;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_reject;
        private xsd_expend_view xsd_expend_view;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_export2Excel;
        private System.Windows.Forms.CheckBox chk_only_public;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expserialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exptypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exppriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn explevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exppublicDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn expvalidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp_note;
    }
}