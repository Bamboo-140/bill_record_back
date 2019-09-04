namespace bill_record
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lab_in = new System.Windows.Forms.Label();
            this.pic_bill = new System.Windows.Forms.PictureBox();
            this.pic_in = new System.Windows.Forms.PictureBox();
            this.pic_out = new System.Windows.Forms.PictureBox();
            this.lab_out = new System.Windows.Forms.Label();
            this.lab_bill = new System.Windows.Forms.Label();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManager = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_out)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.工具TToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.开始ToolStripMenuItem.Text = "开始&S";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 348);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(636, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lab_in
            // 
            this.lab_in.AutoSize = true;
            this.lab_in.Location = new System.Drawing.Point(91, 229);
            this.lab_in.Name = "lab_in";
            this.lab_in.Size = new System.Drawing.Size(29, 12);
            this.lab_in.TabIndex = 4;
            this.lab_in.Text = "入库";
            // 
            // pic_bill
            // 
            this.pic_bill.BackgroundImage = global::bill_record.Properties.Resources.see_no_evil_monkey_128px_1214323_easyicon_net;
            this.pic_bill.Location = new System.Drawing.Point(457, 93);
            this.pic_bill.Name = "pic_bill";
            this.pic_bill.Size = new System.Drawing.Size(121, 119);
            this.pic_bill.TabIndex = 5;
            this.pic_bill.TabStop = false;
            this.pic_bill.Click += new System.EventHandler(this.pic_bill_Click);
            // 
            // pic_in
            // 
            this.pic_in.BackgroundImage = global::bill_record.Properties.Resources.feed_in_128px_1210751_easyicon_net;
            this.pic_in.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_in.InitialImage")));
            this.pic_in.Location = new System.Drawing.Point(40, 91);
            this.pic_in.Name = "pic_in";
            this.pic_in.Size = new System.Drawing.Size(130, 123);
            this.pic_in.TabIndex = 1;
            this.pic_in.TabStop = false;
            this.pic_in.Click += new System.EventHandler(this.pic_in_Click);
            // 
            // pic_out
            // 
            this.pic_out.BackgroundImage = global::bill_record.Properties.Resources.exit_128px_1210133_easyicon_net;
            this.pic_out.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_out.InitialImage")));
            this.pic_out.Location = new System.Drawing.Point(249, 91);
            this.pic_out.Name = "pic_out";
            this.pic_out.Size = new System.Drawing.Size(123, 123);
            this.pic_out.TabIndex = 0;
            this.pic_out.TabStop = false;
            this.pic_out.Click += new System.EventHandler(this.pic_out_Click);
            // 
            // lab_out
            // 
            this.lab_out.AutoSize = true;
            this.lab_out.Location = new System.Drawing.Point(296, 229);
            this.lab_out.Name = "lab_out";
            this.lab_out.Size = new System.Drawing.Size(29, 12);
            this.lab_out.TabIndex = 6;
            this.lab_out.Text = "出库";
            // 
            // lab_bill
            // 
            this.lab_bill.AutoSize = true;
            this.lab_bill.Location = new System.Drawing.Point(503, 229);
            this.lab_bill.Name = "lab_bill";
            this.lab_bill.Size = new System.Drawing.Size(29, 12);
            this.lab_bill.TabIndex = 7;
            this.lab_bill.Text = "账单";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManager});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // userManager
            // 
            this.userManager.Name = "userManager";
            this.userManager.Size = new System.Drawing.Size(152, 22);
            this.userManager.Text = "用户管理(&M)";
            this.userManager.Click += new System.EventHandler(this.userManager_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 370);
            this.Controls.Add(this.lab_bill);
            this.Controls.Add(this.lab_out);
            this.Controls.Add(this.pic_bill);
            this.Controls.Add(this.lab_in);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pic_in);
            this.Controls.Add(this.pic_out);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_out)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_out;
        private System.Windows.Forms.PictureBox pic_in;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lab_in;
        private System.Windows.Forms.PictureBox pic_bill;
        private System.Windows.Forms.Label lab_out;
        private System.Windows.Forms.Label lab_bill;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManager;
    }
}