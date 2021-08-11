namespace ADONETPROJ
{
    partial class SearchStaff
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
            this.btnback = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.NumericUpDown();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bACKTOMAINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aPPLICATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dETAILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rETRIEVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEARCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSERTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.txtid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.RosyBrown;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(344, 440);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(108, 39);
            this.btnback.TabIndex = 22;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(276, 105);
            this.txtid.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(129, 22);
            this.txtid.TabIndex = 20;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.MediumPurple;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(507, 88);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(142, 57);
            this.btnsubmit.TabIndex = 19;
            this.btnsubmit.Text = "SEARCH";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "SEARCH ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "SEARCH FORM";
            // 
            // bACKTOMAINToolStripMenuItem
            // 
            this.bACKTOMAINToolStripMenuItem.Name = "bACKTOMAINToolStripMenuItem";
            this.bACKTOMAINToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.bACKTOMAINToolStripMenuItem.Text = "MAIN PAGE";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.eXITToolStripMenuItem.Text = "EXIT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 176);
            this.dataGridView1.TabIndex = 21;
            // 
            // aPPLICATIONToolStripMenuItem
            // 
            this.aPPLICATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem,
            this.bACKTOMAINToolStripMenuItem});
            this.aPPLICATIONToolStripMenuItem.Name = "aPPLICATIONToolStripMenuItem";
            this.aPPLICATIONToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.aPPLICATIONToolStripMenuItem.Text = "APPLICATION";
            // 
            // dETAILSToolStripMenuItem
            // 
            this.dETAILSToolStripMenuItem.Name = "dETAILSToolStripMenuItem";
            this.dETAILSToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.dETAILSToolStripMenuItem.Text = "DETAILS";
            // 
            // rETRIEVEToolStripMenuItem
            // 
            this.rETRIEVEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dETAILSToolStripMenuItem,
            this.sEARCHToolStripMenuItem});
            this.rETRIEVEToolStripMenuItem.Name = "rETRIEVEToolStripMenuItem";
            this.rETRIEVEToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.rETRIEVEToolStripMenuItem.Text = "RETRIEVE";
            // 
            // sEARCHToolStripMenuItem
            // 
            this.sEARCHToolStripMenuItem.Name = "sEARCHToolStripMenuItem";
            this.sEARCHToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.sEARCHToolStripMenuItem.Text = "SEARCH";
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            // 
            // uPDATEToolStripMenuItem
            // 
            this.uPDATEToolStripMenuItem.Name = "uPDATEToolStripMenuItem";
            this.uPDATEToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.uPDATEToolStripMenuItem.Text = "UPDATE";
            // 
            // iNSERTToolStripMenuItem
            // 
            this.iNSERTToolStripMenuItem.Name = "iNSERTToolStripMenuItem";
            this.iNSERTToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.iNSERTToolStripMenuItem.Text = "INSERT";
            // 
            // mODIFYToolStripMenuItem
            // 
            this.mODIFYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNSERTToolStripMenuItem,
            this.uPDATEToolStripMenuItem,
            this.dELETEToolStripMenuItem});
            this.mODIFYToolStripMenuItem.Name = "mODIFYToolStripMenuItem";
            this.mODIFYToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.mODIFYToolStripMenuItem.Text = "MODIFY";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mODIFYToolStripMenuItem,
            this.rETRIEVEToolStripMenuItem,
            this.aPPLICATIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SearchStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 539);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SearchStaff";
            this.Text = "SearchStaff";
            this.Load += new System.EventHandler(this.SearchStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.NumericUpDown txtid;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem bACKTOMAINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem aPPLICATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dETAILSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETRIEVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEARCHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSERTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFYToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}