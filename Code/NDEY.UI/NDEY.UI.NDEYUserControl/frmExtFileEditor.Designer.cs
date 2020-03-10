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
            this.ofdDialogs = new System.Windows.Forms.OpenFileDialog();
            this.kryptonPanel25 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel113 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.dpContent = new NDEY.UI.NDEYUserControl.DocumentPasteEditor();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel25)).BeginInit();
            this.kryptonPanel25.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdDialogs
            // 
            this.ofdDialogs.Filter = "PNG文件|*.png";
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
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel10.Controls.Add(this.kryptonPanel25, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.dpContent, 1, 2);
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
            // dpContent
            // 
            this.dpContent.BackColor = System.Drawing.Color.White;
            this.dpContent.DestDocumentPath = null;
            this.dpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpContent.EditorName = null;
            this.dpContent.EmptyTempleteFile = null;
            this.dpContent.Font = new System.Drawing.Font("仿宋", 12F);
            this.dpContent.InfoLabelAutoHeight = true;
            this.dpContent.InfoLabelHeight = 51;
            this.dpContent.InfoLabelText = "";
            this.dpContent.Location = new System.Drawing.Point(54, 64);
            this.dpContent.Margin = new System.Windows.Forms.Padding(4);
            this.dpContent.Name = "dpContent";
            this.dpContent.Size = new System.Drawing.Size(889, 374);
            this.dpContent.TabIndex = 1;
            // 
            // frmExtFileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel10);
            this.Name = "frmExtFileEditor";
            this.Size = new System.Drawing.Size(997, 502);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel25)).EndInit();
            this.kryptonPanel25.ResumeLayout(false);
            this.kryptonPanel25.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdDialogs;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel25;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel113;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private DocumentPasteEditor dpContent;
    }
}