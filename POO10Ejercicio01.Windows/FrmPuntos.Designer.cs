namespace POO10Ejercicio01.Windows
{
    partial class FrmPuntos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuntos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CuerpoPanel = new System.Windows.Forms.Panel();
            this.PuntosDataGridView = new System.Windows.Forms.DataGridView();
            this.colX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InferiorPanel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.CuerpoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PuntosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SalirToolStripButton.Image")));
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(33, 35);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // CuerpoPanel
            // 
            this.CuerpoPanel.Controls.Add(this.PuntosDataGridView);
            this.CuerpoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CuerpoPanel.Location = new System.Drawing.Point(0, 38);
            this.CuerpoPanel.Name = "CuerpoPanel";
            this.CuerpoPanel.Size = new System.Drawing.Size(800, 412);
            this.CuerpoPanel.TabIndex = 1;
            // 
            // PuntosDataGridView
            // 
            this.PuntosDataGridView.AllowUserToAddRows = false;
            this.PuntosDataGridView.AllowUserToDeleteRows = false;
            this.PuntosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PuntosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colX,
            this.colY});
            this.PuntosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PuntosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.PuntosDataGridView.Name = "PuntosDataGridView";
            this.PuntosDataGridView.ReadOnly = true;
            this.PuntosDataGridView.Size = new System.Drawing.Size(800, 412);
            this.PuntosDataGridView.TabIndex = 0;
            this.PuntosDataGridView.Text = "dataGridView1";
            // 
            // colX
            // 
            this.colX.HeaderText = "X";
            this.colX.Name = "colX";
            this.colX.ReadOnly = true;
            // 
            // colY
            // 
            this.colY.HeaderText = "Y";
            this.colY.Name = "colY";
            this.colY.ReadOnly = true;
            // 
            // InferiorPanel
            // 
            this.InferiorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InferiorPanel.Location = new System.Drawing.Point(0, 350);
            this.InferiorPanel.Name = "InferiorPanel";
            this.InferiorPanel.Size = new System.Drawing.Size(800, 100);
            this.InferiorPanel.TabIndex = 2;
            // 
            // FrmPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InferiorPanel);
            this.Controls.Add(this.CuerpoPanel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPuntos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPuntos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.CuerpoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PuntosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel CuerpoPanel;
        private System.Windows.Forms.DataGridView PuntosDataGridView;
        private System.Windows.Forms.Panel InferiorPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colY;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
    }
}

