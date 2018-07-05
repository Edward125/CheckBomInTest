namespace CheckBomInTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadboard = new System.Windows.Forms.Button();
            this.lstBoards = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBoard = new System.Windows.Forms.CheckBox();
            this.chkTestorder = new System.Windows.Forms.CheckBox();
            this.chkTestplan = new System.Windows.Forms.CheckBox();
            this.chkBoardxy = new System.Windows.Forms.CheckBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnBatchCompare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSingleBom = new System.Windows.Forms.TextBox();
            this.txtBOmFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProgramFolder = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadboard);
            this.groupBox1.Controls.Add(this.lstBoards);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCompare);
            this.groupBox1.Controls.Add(this.btnBatchCompare);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSingleBom);
            this.groupBox1.Controls.Add(this.txtBOmFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProgramFolder);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnLoadboard
            // 
            this.btnLoadboard.Location = new System.Drawing.Point(499, 33);
            this.btnLoadboard.Name = "btnLoadboard";
            this.btnLoadboard.Size = new System.Drawing.Size(104, 30);
            this.btnLoadboard.TabIndex = 13;
            this.btnLoadboard.Text = "Load Board";
            this.btnLoadboard.UseVisualStyleBackColor = true;
            this.btnLoadboard.Click += new System.EventHandler(this.btnLoadboard_Click);
            // 
            // lstBoards
            // 
            this.lstBoards.FormattingEnabled = true;
            this.lstBoards.ItemHeight = 14;
            this.lstBoards.Location = new System.Drawing.Point(373, 21);
            this.lstBoards.Name = "lstBoards";
            this.lstBoards.Size = new System.Drawing.Size(120, 130);
            this.lstBoards.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBoard);
            this.groupBox2.Controls.Add(this.chkTestorder);
            this.groupBox2.Controls.Add(this.chkTestplan);
            this.groupBox2.Controls.Add(this.chkBoardxy);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(9, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // chkBoard
            // 
            this.chkBoard.AutoSize = true;
            this.chkBoard.Location = new System.Drawing.Point(192, 21);
            this.chkBoard.Name = "chkBoard";
            this.chkBoard.Size = new System.Drawing.Size(58, 18);
            this.chkBoard.TabIndex = 3;
            this.chkBoard.Text = "Board";
            this.chkBoard.UseVisualStyleBackColor = true;
            // 
            // chkTestorder
            // 
            this.chkTestorder.AutoSize = true;
            this.chkTestorder.Location = new System.Drawing.Point(19, 21);
            this.chkTestorder.Name = "chkTestorder";
            this.chkTestorder.Size = new System.Drawing.Size(77, 18);
            this.chkTestorder.TabIndex = 1;
            this.chkTestorder.Text = "Testorder";
            this.chkTestorder.UseVisualStyleBackColor = true;
            // 
            // chkTestplan
            // 
            this.chkTestplan.AutoSize = true;
            this.chkTestplan.Location = new System.Drawing.Point(110, 21);
            this.chkTestplan.Name = "chkTestplan";
            this.chkTestplan.Size = new System.Drawing.Size(73, 18);
            this.chkTestplan.TabIndex = 2;
            this.chkTestplan.Text = "Testplan";
            this.chkTestplan.UseVisualStyleBackColor = true;
            // 
            // chkBoardxy
            // 
            this.chkBoardxy.AutoSize = true;
            this.chkBoardxy.Location = new System.Drawing.Point(268, 21);
            this.chkBoardxy.Name = "chkBoardxy";
            this.chkBoardxy.Size = new System.Drawing.Size(74, 18);
            this.chkBoardxy.TabIndex = 9;
            this.chkBoardxy.Text = "Board_xy";
            this.chkBoardxy.UseVisualStyleBackColor = true;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(499, 105);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(104, 30);
            this.btnCompare.TabIndex = 11;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnBatchCompare
            // 
            this.btnBatchCompare.Location = new System.Drawing.Point(499, 69);
            this.btnBatchCompare.Name = "btnBatchCompare";
            this.btnBatchCompare.Size = new System.Drawing.Size(104, 30);
            this.btnBatchCompare.TabIndex = 10;
            this.btnBatchCompare.Text = "Batch Compare";
            this.btnBatchCompare.UseVisualStyleBackColor = true;
            this.btnBatchCompare.Click += new System.EventHandler(this.btnBatchCompare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Single Bom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bom Folder";
            // 
            // txtSingleBom
            // 
            this.txtSingleBom.Location = new System.Drawing.Point(101, 77);
            this.txtSingleBom.Name = "txtSingleBom";
            this.txtSingleBom.Size = new System.Drawing.Size(264, 22);
            this.txtSingleBom.TabIndex = 6;
            this.txtSingleBom.DoubleClick += new System.EventHandler(this.txtSingleBom_DoubleClick);
            // 
            // txtBOmFolder
            // 
            this.txtBOmFolder.Location = new System.Drawing.Point(101, 49);
            this.txtBOmFolder.Name = "txtBOmFolder";
            this.txtBOmFolder.Size = new System.Drawing.Size(264, 22);
            this.txtBOmFolder.TabIndex = 5;
            this.txtBOmFolder.DoubleClick += new System.EventHandler(this.txtBOmFolder_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Program Folder";
            // 
            // txtProgramFolder
            // 
            this.txtProgramFolder.Location = new System.Drawing.Point(101, 21);
            this.txtProgramFolder.Name = "txtProgramFolder";
            this.txtProgramFolder.Size = new System.Drawing.Size(264, 22);
            this.txtProgramFolder.TabIndex = 0;
            this.txtProgramFolder.DoubleClick += new System.EventHandler(this.txtProgramFolder_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 510);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProgramFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSingleBom;
        private System.Windows.Forms.TextBox txtBOmFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBoard;
        private System.Windows.Forms.CheckBox chkTestplan;
        private System.Windows.Forms.CheckBox chkTestorder;
        private System.Windows.Forms.CheckBox chkBoardxy;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnBatchCompare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoadboard;
        private System.Windows.Forms.ListBox lstBoards;
    }
}

