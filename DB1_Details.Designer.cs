namespace ADONETPROJ
{
    partial class DB1_Details
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
            this.button2 = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbtables = new System.Windows.Forms.ComboBox();
            this.bACKTOMAINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPPLICATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.sEARCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rETRIEVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dETAILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSERTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btndisplay
            // 
            this.btndisplay.BackColor = System.Drawing.Color.Khaki;
            this.btndisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.Location = new System.Drawing.Point(449, 124);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(146, 45);
            this.btndisplay.TabIndex = 20;
            this.btndisplay.Text = "DISPLAY";
            this.btndisplay.UseVisualStyleBackColor = false;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // cbtables
            // 
            this.cbtables.FormattingEnabled = true;
            this.cbtables.Location = new System.Drawing.Point(226, 138);
            this.cbtables.Name = "cbtables";
            this.cbtables.Size = new System.Drawing.Size(153, 24);
            this.cbtables.TabIndex = 18;
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
            // aPPLICATIONToolStripMenuItem
            // 
            this.aPPLICATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem,
            this.bACKTOMAINToolStripMenuItem});
            this.aPPLICATIONToolStripMenuItem.Name = "aPPLICATIONToolStripMenuItem";
            this.aPPLICATIONToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.aPPLICATIONToolStripMenuItem.Text = "APPLICATION";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(390, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 54);
            this.button1.TabIndex = 21;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sEARCHToolStripMenuItem
            // 
            this.sEARCHToolStripMenuItem.Name = "sEARCHToolStripMenuItem";
            this.sEARCHToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.sEARCHToolStripMenuItem.Text = "SEARCH";
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
            // dETAILSToolStripMenuItem
            // 
            this.dETAILSToolStripMenuItem.Name = "dETAILSToolStripMenuItem";
            this.dETAILSToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.dETAILSToolStripMenuItem.Text = "DETAILS";
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
            this.menuStrip1.Size = new System.Drawing.Size(1015, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "DATABASE DETAILS";
            // 
            // DB1_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 625);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbtables);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "DB1_Details";
            this.Text = "DB1_Details";
            this.Load += new System.EventHandler(this.DB1_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbtables;
        private System.Windows.Forms.ToolStripMenuItem bACKTOMAINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPPLICATIONToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem sEARCHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETRIEVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dETAILSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSERTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFYToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
    }
}