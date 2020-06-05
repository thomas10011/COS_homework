namespace WindowsFormsApp1
{
    partial class MainWindow
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolBar = new System.Windows.Forms.Panel();
            this.DataContainer = new System.Windows.Forms.SplitContainer();
            this.OrderSoureceBinding = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataContainer)).BeginInit();
            this.DataContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSoureceBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(1025, 82);
            this.ToolBar.TabIndex = 0;
            // 
            // DataContainer
            // 
            this.DataContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataContainer.Location = new System.Drawing.Point(0, 82);
            this.DataContainer.Name = "DataContainer";
            this.DataContainer.Size = new System.Drawing.Size(1025, 487);
            this.DataContainer.SplitterDistance = 341;
            this.DataContainer.TabIndex = 1;
            // 
            // OrderSoureceBinding
            // 
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 569);
            this.Controls.Add(this.DataContainer);
            this.Controls.Add(this.ToolBar);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.DataContainer)).EndInit();
            this.DataContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderSoureceBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolBar;
        private System.Windows.Forms.SplitContainer DataContainer;
        private System.Windows.Forms.BindingSource OrderSoureceBinding;
    }
}

