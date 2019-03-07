namespace NDEY.UI.NDEYUserControl
{
    partial class frmExtFileEditor
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnnext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel25 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel113 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hSkinTableLayoutPanel1 = new NDEY.UI.HSkinTableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExtFileLabel = new System.Windows.Forms.Label();
            this.btnupload = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ofdDialogs = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel25)).BeginInit();
            this.kryptonPanel25.SuspendLayout();
            this.hSkinTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tableLayoutPanel10.Controls.Add(this.kryptonPanel25, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.hSkinTableLayoutPanel1, 1, 2);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 5;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(997, 502);
            this.tableLayoutPanel10.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnnext, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnsave, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 445);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 34);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(794, 3);
            this.btnnext.Name = "btnnext";
            this.btnnext.TabIndex = 1;
            this.btnnext.Values.Text = "下一页";
            this.btnnext.Visible = false;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(691, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.TabIndex = 0;
            this.btnsave.Values.Text = "保存";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // kryptonPanel25
            // 
            this.kryptonPanel25.Controls.Add(this.kryptonLabel113);
            this.kryptonPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel25.Location = new System.Drawing.Point(50, 20);
            this.kryptonPanel25.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel25.Name = "kryptonPanel25";
            this.kryptonPanel25.Size = new System.Drawing.Size(897, 40);
            this.kryptonPanel25.TabIndex = 0;
            // 
            // kryptonLabel113
            // 
            this.kryptonLabel113.Location = new System.Drawing.Point(3, 10);
            this.kryptonLabel113.Name = "kryptonLabel113";
            this.kryptonLabel113.Size = new System.Drawing.Size(463, 27);
            this.kryptonLabel113.StateCommon.LongText.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel113.StateCommon.ShortText.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel113.TabIndex = 0;
            this.kryptonLabel113.Values.Text = "请依托单位提供与项目密级相应的保密资质复印件。";
            // 
            // hSkinTableLayoutPanel1
            // 
            this.hSkinTableLayoutPanel1.BorderColor = System.Drawing.Color.Black;
            this.hSkinTableLayoutPanel1.ColumnCount = 3;
            this.hSkinTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.hSkinTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.hSkinTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.hSkinTableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.hSkinTableLayoutPanel1.Controls.Add(this.lblExtFileLabel, 1, 0);
            this.hSkinTableLayoutPanel1.Controls.Add(this.btnupload, 2, 0);
            this.hSkinTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hSkinTableLayoutPanel1.Location = new System.Drawing.Point(50, 66);
            this.hSkinTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.hSkinTableLayoutPanel1.Name = "hSkinTableLayoutPanel1";
            this.hSkinTableLayoutPanel1.RowCount = 1;
            this.hSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.hSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.hSkinTableLayoutPanel1.Size = new System.Drawing.Size(897, 32);
            this.hSkinTableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "附件";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExtFileLabel
            // 
            this.lblExtFileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExtFileLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExtFileLabel.Location = new System.Drawing.Point(122, 2);
            this.lblExtFileLabel.Margin = new System.Windows.Forms.Padding(2);
            this.lblExtFileLabel.Name = "lblExtFileLabel";
            this.lblExtFileLabel.Size = new System.Drawing.Size(623, 28);
            this.lblExtFileLabel.TabIndex = 1;
            this.lblExtFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(750, 3);
            this.btnupload.Name = "btnupload";
            this.btnupload.TabIndex = 2;
            this.btnupload.Values.Text = "上传";
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // ofdDialogs
            // 
            this.ofdDialogs.Filter = "PNG文件|*.png";
            // 
            // frmExtFileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel10);
            this.Name = "frmExtFileEditor";
            this.Size = new System.Drawing.Size(997, 502);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel25)).EndInit();
            this.kryptonPanel25.ResumeLayout(false);
            this.kryptonPanel25.PerformLayout();
            this.hSkinTableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnnext;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnsave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnupload;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel25;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel113;
        private HSkinTableLayoutPanel hSkinTableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExtFileLabel;
        private System.Windows.Forms.OpenFileDialog ofdDialogs;
    }
}