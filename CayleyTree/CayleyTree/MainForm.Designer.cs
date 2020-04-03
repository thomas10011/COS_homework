namespace CayleyTree
{
    partial class MainForm
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LenLabel = new System.Windows.Forms.Label();
            this.RightThLabel = new System.Windows.Forms.Label();
            this.LeftTHLabel = new System.Windows.Forms.Label();
            this.RightPeerLabel = new System.Windows.Forms.Label();
            this.LeftPeerLabel = new System.Windows.Forms.Label();
            this.LeftPeerTrackBar = new System.Windows.Forms.TrackBar();
            this.RightPeerTrackBar = new System.Windows.Forms.TrackBar();
            this.RightThTrackBar = new System.Windows.Forms.TrackBar();
            this.LeftThTrackBar = new System.Windows.Forms.TrackBar();
            this.DeepLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Clean = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.GraphicsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PenColorComboBoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPeerTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPeerTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightThTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftThTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.label5);
            this.ContentPanel.Controls.Add(this.PenColorComboBoc);
            this.ContentPanel.Controls.Add(this.label4);
            this.ContentPanel.Controls.Add(this.label3);
            this.ContentPanel.Controls.Add(this.label2);
            this.ContentPanel.Controls.Add(this.label1);
            this.ContentPanel.Controls.Add(this.textBox2);
            this.ContentPanel.Controls.Add(this.LenLabel);
            this.ContentPanel.Controls.Add(this.RightThLabel);
            this.ContentPanel.Controls.Add(this.LeftTHLabel);
            this.ContentPanel.Controls.Add(this.RightPeerLabel);
            this.ContentPanel.Controls.Add(this.LeftPeerLabel);
            this.ContentPanel.Controls.Add(this.LeftPeerTrackBar);
            this.ContentPanel.Controls.Add(this.RightPeerTrackBar);
            this.ContentPanel.Controls.Add(this.RightThTrackBar);
            this.ContentPanel.Controls.Add(this.LeftThTrackBar);
            this.ContentPanel.Controls.Add(this.DeepLabel);
            this.ContentPanel.Controls.Add(this.textBox1);
            this.ContentPanel.Controls.Add(this.Clean);
            this.ContentPanel.Controls.Add(this.DrawButton);
            this.ContentPanel.Controls.Add(this.GraphicsPanel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(784, 621);
            this.ContentPanel.TabIndex = 0;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(630, 317);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 21);
            this.textBox2.TabIndex = 14;
            // 
            // LenLabel
            // 
            this.LenLabel.AutoSize = true;
            this.LenLabel.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LenLabel.Location = new System.Drawing.Point(627, 298);
            this.LenLabel.Name = "LenLabel";
            this.LenLabel.Size = new System.Drawing.Size(64, 16);
            this.LenLabel.TabIndex = 13;
            this.LenLabel.Text = "主干长度";
            // 
            // RightThLabel
            // 
            this.RightThLabel.AutoSize = true;
            this.RightThLabel.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RightThLabel.Location = new System.Drawing.Point(640, 549);
            this.RightThLabel.Name = "RightThLabel";
            this.RightThLabel.Size = new System.Drawing.Size(78, 16);
            this.RightThLabel.TabIndex = 12;
            this.RightThLabel.Text = "右分支角度";
            // 
            // LeftTHLabel
            // 
            this.LeftTHLabel.AutoSize = true;
            this.LeftTHLabel.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LeftTHLabel.Location = new System.Drawing.Point(640, 486);
            this.LeftTHLabel.Name = "LeftTHLabel";
            this.LeftTHLabel.Size = new System.Drawing.Size(78, 16);
            this.LeftTHLabel.TabIndex = 11;
            this.LeftTHLabel.Text = "左分支角度";
            // 
            // RightPeerLabel
            // 
            this.RightPeerLabel.AutoSize = true;
            this.RightPeerLabel.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RightPeerLabel.Location = new System.Drawing.Point(642, 419);
            this.RightPeerLabel.Name = "RightPeerLabel";
            this.RightPeerLabel.Size = new System.Drawing.Size(92, 16);
            this.RightPeerLabel.TabIndex = 10;
            this.RightPeerLabel.Text = "右分支长度比";
            // 
            // LeftPeerLabel
            // 
            this.LeftPeerLabel.AutoSize = true;
            this.LeftPeerLabel.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LeftPeerLabel.Location = new System.Drawing.Point(642, 356);
            this.LeftPeerLabel.Name = "LeftPeerLabel";
            this.LeftPeerLabel.Size = new System.Drawing.Size(92, 16);
            this.LeftPeerLabel.TabIndex = 9;
            this.LeftPeerLabel.Text = "左分支长度比";
            // 
            // LeftPeerTrackBar
            // 
            this.LeftPeerTrackBar.Location = new System.Drawing.Point(630, 375);
            this.LeftPeerTrackBar.Maximum = 100;
            this.LeftPeerTrackBar.Name = "LeftPeerTrackBar";
            this.LeftPeerTrackBar.Size = new System.Drawing.Size(104, 45);
            this.LeftPeerTrackBar.TabIndex = 8;
            this.LeftPeerTrackBar.TabStop = false;
            this.LeftPeerTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.LeftPeerTrackBar.Scroll += new System.EventHandler(this.LeftPeerTrackBar_Scroll);
            // 
            // RightPeerTrackBar
            // 
            this.RightPeerTrackBar.Location = new System.Drawing.Point(630, 438);
            this.RightPeerTrackBar.Maximum = 100;
            this.RightPeerTrackBar.Name = "RightPeerTrackBar";
            this.RightPeerTrackBar.Size = new System.Drawing.Size(104, 45);
            this.RightPeerTrackBar.TabIndex = 7;
            this.RightPeerTrackBar.TabStop = false;
            this.RightPeerTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RightPeerTrackBar.Scroll += new System.EventHandler(this.RightPeerTrackBar_Scroll);
            // 
            // RightThTrackBar
            // 
            this.RightThTrackBar.AutoSize = false;
            this.RightThTrackBar.Location = new System.Drawing.Point(630, 564);
            this.RightThTrackBar.Maximum = 360;
            this.RightThTrackBar.Name = "RightThTrackBar";
            this.RightThTrackBar.Size = new System.Drawing.Size(104, 45);
            this.RightThTrackBar.TabIndex = 6;
            this.RightThTrackBar.TabStop = false;
            this.RightThTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RightThTrackBar.Scroll += new System.EventHandler(this.RightThTrackBar_Scroll);
            // 
            // LeftThTrackBar
            // 
            this.LeftThTrackBar.AutoSize = false;
            this.LeftThTrackBar.Location = new System.Drawing.Point(630, 501);
            this.LeftThTrackBar.Maximum = 360;
            this.LeftThTrackBar.Name = "LeftThTrackBar";
            this.LeftThTrackBar.Size = new System.Drawing.Size(104, 45);
            this.LeftThTrackBar.TabIndex = 5;
            this.LeftThTrackBar.TabStop = false;
            this.LeftThTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.LeftThTrackBar.Scroll += new System.EventHandler(this.LeftThTrackBar_Scroll);
            // 
            // DeepLabel
            // 
            this.DeepLabel.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeepLabel.Location = new System.Drawing.Point(627, 233);
            this.DeepLabel.Name = "DeepLabel";
            this.DeepLabel.Size = new System.Drawing.Size(64, 21);
            this.DeepLabel.TabIndex = 4;
            this.DeepLabel.Text = "递归深度";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(630, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 21);
            this.textBox1.TabIndex = 3;
            // 
            // Clean
            // 
            this.Clean.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clean.Location = new System.Drawing.Point(630, 113);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(100, 30);
            this.Clean.TabIndex = 2;
            this.Clean.Text = "Clean";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawButton.Location = new System.Drawing.Point(630, 53);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(100, 30);
            this.DrawButton.TabIndex = 1;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // GraphicsPanel
            // 
            this.GraphicsPanel.BackColor = System.Drawing.Color.White;
            this.GraphicsPanel.Location = new System.Drawing.Point(0, 0);
            this.GraphicsPanel.Name = "GraphicsPanel";
            this.GraphicsPanel.Size = new System.Drawing.Size(596, 621);
            this.GraphicsPanel.TabIndex = 0;
            this.GraphicsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(731, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(731, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(731, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(731, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "0";
            // 
            // PenColorComboBoc
            // 
            this.PenColorComboBoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PenColorComboBoc.FormattingEnabled = true;
            this.PenColorComboBoc.Items.AddRange(new object[] {
            "白色",
            "棕色",
            "黄色",
            "绿色",
            "蓝色",
            "黑色",
            "红色"});
            this.PenColorComboBoc.Location = new System.Drawing.Point(630, 188);
            this.PenColorComboBoc.Name = "PenColorComboBoc";
            this.PenColorComboBoc.Size = new System.Drawing.Size(121, 20);
            this.PenColorComboBoc.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(627, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "画笔颜色";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 621);
            this.Controls.Add(this.ContentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPeerTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPeerTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightThTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftThTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel GraphicsPanel;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Label DeepLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LenLabel;
        private System.Windows.Forms.Label RightThLabel;
        private System.Windows.Forms.Label LeftTHLabel;
        private System.Windows.Forms.Label RightPeerLabel;
        private System.Windows.Forms.TrackBar LeftPeerTrackBar;
        private System.Windows.Forms.TrackBar RightPeerTrackBar;
        private System.Windows.Forms.TrackBar RightThTrackBar;
        private System.Windows.Forms.TrackBar LeftThTrackBar;
        private System.Windows.Forms.Label LeftPeerLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PenColorComboBoc;
    }
}

