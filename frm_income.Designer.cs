namespace bill_record
{
    partial class frm_income
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
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.chk_date = new System.Windows.Forms.CheckBox();
            this.chk_valid = new System.Windows.Forms.CheckBox();
            this.txt_amountBegin = new System.Windows.Forms.TextBox();
            this.txt_amountEnd = new System.Windows.Forms.TextBox();
            this.cmb_source = new System.Windows.Forms.ComboBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_reject = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_income_view = new System.Windows.Forms.DataGridView();
            this.incserialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incsourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incvalidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.incpublicDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bds_income_view = new System.Windows.Forms.BindingSource(this.components);
            this.xsd_income_view = new bill_record.xsd_income_view();
            this.btn_query = new System.Windows.Forms.Button();
            this.lab_serial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_amount = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_only_public = new System.Windows.Forms.CheckBox();
            this.btn_export2Excel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_income_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_income_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xsd_income_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_serial
            // 
            this.txt_serial.Location = new System.Drawing.Point(50, 47);
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.Size = new System.Drawing.Size(100, 21);
            this.txt_serial.TabIndex = 0;
            // 
            // dtp_begin
            // 
            this.dtp_begin.Location = new System.Drawing.Point(72, 75);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(111, 21);
            this.dtp_begin.TabIndex = 2;
            this.dtp_begin.ValueChanged += new System.EventHandler(this.dtp_begin_ValueChanged);
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(189, 75);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(111, 21);
            this.dtp_end.TabIndex = 3;
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_end_ValueChanged);
            // 
            // chk_date
            // 
            this.chk_date.AutoSize = true;
            this.chk_date.Location = new System.Drawing.Point(12, 77);
            this.chk_date.Name = "chk_date";
            this.chk_date.Size = new System.Drawing.Size(60, 16);
            this.chk_date.TabIndex = 4;
            this.chk_date.Text = "按日期";
            this.chk_date.UseVisualStyleBackColor = true;
            // 
            // chk_valid
            // 
            this.chk_valid.AutoSize = true;
            this.chk_valid.Location = new System.Drawing.Point(306, 77);
            this.chk_valid.Name = "chk_valid";
            this.chk_valid.Size = new System.Drawing.Size(72, 16);
            this.chk_valid.TabIndex = 5;
            this.chk_valid.Text = "查询所有";
            this.chk_valid.UseVisualStyleBackColor = true;
            // 
            // txt_amountBegin
            // 
            this.txt_amountBegin.Location = new System.Drawing.Point(338, 47);
            this.txt_amountBegin.Name = "txt_amountBegin";
            this.txt_amountBegin.Size = new System.Drawing.Size(65, 21);
            this.txt_amountBegin.TabIndex = 6;
            this.txt_amountBegin.TextChanged += new System.EventHandler(this.txt_amountBegin_TextChanged);
            this.txt_amountBegin.Validated += new System.EventHandler(this.txt_amountBegin_Validated);
            // 
            // txt_amountEnd
            // 
            this.txt_amountEnd.Location = new System.Drawing.Point(409, 47);
            this.txt_amountEnd.Name = "txt_amountEnd";
            this.txt_amountEnd.Size = new System.Drawing.Size(65, 21);
            this.txt_amountEnd.TabIndex = 7;
            this.txt_amountEnd.Validating += new System.ComponentModel.CancelEventHandler(this.txt_amountEnd_Validating);
            // 
            // cmb_source
            // 
            this.cmb_source.FormattingEnabled = true;
            this.cmb_source.Location = new System.Drawing.Point(189, 47);
            this.cmb_source.Name = "cmb_source";
            this.cmb_source.Size = new System.Drawing.Size(94, 20);
            this.cmb_source.TabIndex = 8;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(12, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(58, 23);
            this.btn_new.TabIndex = 9;
            this.btn_new.Text = "新建";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(76, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(58, 23);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "编辑";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_reject
            // 
            this.btn_reject.Location = new System.Drawing.Point(144, 12);
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.Size = new System.Drawing.Size(58, 23);
            this.btn_reject.TabIndex = 11;
            this.btn_reject.Text = "撤销";
            this.btn_reject.UseVisualStyleBackColor = true;
            this.btn_reject.Click += new System.EventHandler(this.btn_reject_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(208, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(58, 23);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(272, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(58, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_income_view
            // 
            this.dgv_income_view.AllowUserToAddRows = false;
            this.dgv_income_view.AllowUserToDeleteRows = false;
            this.dgv_income_view.AutoGenerateColumns = false;
            this.dgv_income_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_income_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incserialDataGridViewTextBoxColumn,
            this.incdateDataGridViewTextBoxColumn,
            this.incsourceDataGridViewTextBoxColumn,
            this.incamountDataGridViewTextBoxColumn,
            this.incvalidDataGridViewCheckBoxColumn,
            this.incpublicDataGridViewCheckBoxColumn});
            this.dgv_income_view.DataSource = this.bds_income_view;
            this.dgv_income_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_income_view.Location = new System.Drawing.Point(0, 0);
            this.dgv_income_view.Name = "dgv_income_view";
            this.dgv_income_view.ReadOnly = true;
            this.dgv_income_view.RowTemplate.Height = 23;
            this.dgv_income_view.Size = new System.Drawing.Size(698, 213);
            this.dgv_income_view.TabIndex = 18;
            this.dgv_income_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_income_view_CellClick);
            this.dgv_income_view.CurrentCellChanged += new System.EventHandler(this.dgv_income_view_CurrentCellChanged);
            this.dgv_income_view.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv_income_view_Scroll);
            // 
            // incserialDataGridViewTextBoxColumn
            // 
            this.incserialDataGridViewTextBoxColumn.DataPropertyName = "inc_serial";
            this.incserialDataGridViewTextBoxColumn.HeaderText = "inc_serial";
            this.incserialDataGridViewTextBoxColumn.Name = "incserialDataGridViewTextBoxColumn";
            this.incserialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incdateDataGridViewTextBoxColumn
            // 
            this.incdateDataGridViewTextBoxColumn.DataPropertyName = "inc_date";
            this.incdateDataGridViewTextBoxColumn.HeaderText = "inc_date";
            this.incdateDataGridViewTextBoxColumn.Name = "incdateDataGridViewTextBoxColumn";
            this.incdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incsourceDataGridViewTextBoxColumn
            // 
            this.incsourceDataGridViewTextBoxColumn.DataPropertyName = "inc_source";
            this.incsourceDataGridViewTextBoxColumn.HeaderText = "inc_source";
            this.incsourceDataGridViewTextBoxColumn.Name = "incsourceDataGridViewTextBoxColumn";
            this.incsourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incamountDataGridViewTextBoxColumn
            // 
            this.incamountDataGridViewTextBoxColumn.DataPropertyName = "inc_amount";
            this.incamountDataGridViewTextBoxColumn.HeaderText = "inc_amount";
            this.incamountDataGridViewTextBoxColumn.Name = "incamountDataGridViewTextBoxColumn";
            this.incamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incvalidDataGridViewCheckBoxColumn
            // 
            this.incvalidDataGridViewCheckBoxColumn.DataPropertyName = "inc_valid";
            this.incvalidDataGridViewCheckBoxColumn.HeaderText = "inc_valid";
            this.incvalidDataGridViewCheckBoxColumn.Name = "incvalidDataGridViewCheckBoxColumn";
            this.incvalidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // incpublicDataGridViewCheckBoxColumn
            // 
            this.incpublicDataGridViewCheckBoxColumn.DataPropertyName = "inc_public";
            this.incpublicDataGridViewCheckBoxColumn.HeaderText = "inc_public";
            this.incpublicDataGridViewCheckBoxColumn.Name = "incpublicDataGridViewCheckBoxColumn";
            this.incpublicDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bds_income_view
            // 
            this.bds_income_view.DataMember = "tbl_income";
            this.bds_income_view.DataSource = this.xsd_income_view;
            // 
            // xsd_income_view
            // 
            this.xsd_income_view.DataSetName = "xsd_income_view";
            this.xsd_income_view.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(425, 74);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(49, 23);
            this.btn_query.TabIndex = 19;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // lab_serial
            // 
            this.lab_serial.AutoSize = true;
            this.lab_serial.Location = new System.Drawing.Point(12, 51);
            this.lab_serial.Name = "lab_serial";
            this.lab_serial.Size = new System.Drawing.Size(29, 12);
            this.lab_serial.TabIndex = 20;
            this.lab_serial.Text = "序号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "来源";
            // 
            // lab_amount
            // 
            this.lab_amount.AutoSize = true;
            this.lab_amount.Location = new System.Drawing.Point(303, 51);
            this.lab_amount.Name = "lab_amount";
            this.lab_amount.Size = new System.Drawing.Size(29, 12);
            this.lab_amount.TabIndex = 22;
            this.lab_amount.Text = "金额";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_only_public);
            this.panel1.Controls.Add(this.btn_export2Excel);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.lab_amount);
            this.panel1.Controls.Add(this.txt_serial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtp_begin);
            this.panel1.Controls.Add(this.lab_serial);
            this.panel1.Controls.Add(this.dtp_end);
            this.panel1.Controls.Add(this.btn_query);
            this.panel1.Controls.Add(this.chk_date);
            this.panel1.Controls.Add(this.chk_valid);
            this.panel1.Controls.Add(this.txt_amountBegin);
            this.panel1.Controls.Add(this.txt_amountEnd);
            this.panel1.Controls.Add(this.cmb_source);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_reject);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 117);
            this.panel1.TabIndex = 23;
            // 
            // chk_only_public
            // 
            this.chk_only_public.AutoSize = true;
            this.chk_only_public.Checked = true;
            this.chk_only_public.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_only_public.Location = new System.Drawing.Point(376, 77);
            this.chk_only_public.Name = "chk_only_public";
            this.chk_only_public.Size = new System.Drawing.Size(48, 16);
            this.chk_only_public.TabIndex = 24;
            this.chk_only_public.Text = "公款";
            this.chk_only_public.UseVisualStyleBackColor = true;
            // 
            // btn_export2Excel
            // 
            this.btn_export2Excel.Location = new System.Drawing.Point(338, 12);
            this.btn_export2Excel.Name = "btn_export2Excel";
            this.btn_export2Excel.Size = new System.Drawing.Size(75, 23);
            this.btn_export2Excel.TabIndex = 23;
            this.btn_export2Excel.Text = "导出Excel";
            this.btn_export2Excel.UseVisualStyleBackColor = true;
            this.btn_export2Excel.Click += new System.EventHandler(this.btn_export2Excel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_income_view);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 213);
            this.panel2.TabIndex = 24;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(698, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frm_income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 352);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_income";
            this.Text = "收入查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_income_FormClosing);
            this.Load += new System.EventHandler(this.frm_income_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_income_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_income_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xsd_income_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_serial;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.CheckBox chk_date;
        private System.Windows.Forms.CheckBox chk_valid;
        private System.Windows.Forms.TextBox txt_amountBegin;
        private System.Windows.Forms.TextBox txt_amountEnd;
        private System.Windows.Forms.ComboBox cmb_source;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_reject;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_income_view;
        private System.Windows.Forms.BindingSource bds_income_view;
        private xsd_income_view xsd_income_view;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Label lab_serial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_amount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_export2Excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn incserialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incsourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn incvalidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn incpublicDataGridViewCheckBoxColumn;
        private System.Windows.Forms.CheckBox chk_only_public;
    }
}