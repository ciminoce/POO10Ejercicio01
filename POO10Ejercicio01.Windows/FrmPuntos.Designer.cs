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
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OrdenarToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.FiltrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ActualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CuerpoPanel = new System.Windows.Forms.Panel();
            this.PuntosDataGridView = new System.Windows.Forms.DataGridView();
            this.colX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InferiorPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.CuerpoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PuntosDataGridView)).BeginInit();
            this.InferiorPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.EditarToolStripButton,
            this.toolStripSeparator2,
            this.OrdenarToolStripDropDownButton,
            this.FiltrarToolStripButton,
            this.ActualizarToolStripButton,
            this.toolStripSeparator1,
            this.SalirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoToolStripButton.Image")));
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 59);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarToolStripButton.Image")));
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(43, 59);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditarToolStripButton.Image")));
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(41, 59);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 62);
            // 
            // OrdenarToolStripDropDownButton
            // 
            this.OrdenarToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("OrdenarToolStripDropDownButton.Image")));
            this.OrdenarToolStripDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdenarToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarToolStripDropDownButton.Name = "OrdenarToolStripDropDownButton";
            this.OrdenarToolStripDropDownButton.Size = new System.Drawing.Size(63, 59);
            this.OrdenarToolStripDropDownButton.Text = "Ordenar";
            this.OrdenarToolStripDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FiltrarToolStripButton
            // 
            this.FiltrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FiltrarToolStripButton.Image")));
            this.FiltrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripButton.Name = "FiltrarToolStripButton";
            this.FiltrarToolStripButton.Size = new System.Drawing.Size(41, 59);
            this.FiltrarToolStripButton.Text = "Filtrar";
            this.FiltrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ActualizarToolStripButton
            // 
            this.ActualizarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ActualizarToolStripButton.Image")));
            this.ActualizarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarToolStripButton.Name = "ActualizarToolStripButton";
            this.ActualizarToolStripButton.Size = new System.Drawing.Size(63, 59);
            this.ActualizarToolStripButton.Text = "Actualizar";
            this.ActualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SalirToolStripButton.Image")));
            this.SalirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(40, 59);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // CuerpoPanel
            // 
            this.CuerpoPanel.Controls.Add(this.PuntosDataGridView);
            this.CuerpoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CuerpoPanel.Location = new System.Drawing.Point(0, 62);
            this.CuerpoPanel.Name = "CuerpoPanel";
            this.CuerpoPanel.Size = new System.Drawing.Size(800, 388);
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
            this.PuntosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PuntosDataGridView.Size = new System.Drawing.Size(800, 388);
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
            this.InferiorPanel.Controls.Add(this.groupBox1);
            this.InferiorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InferiorPanel.Location = new System.Drawing.Point(0, 350);
            this.InferiorPanel.Name = "InferiorPanel";
            this.InferiorPanel.Size = new System.Drawing.Size(800, 100);
            this.InferiorPanel.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CantidadTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Cantidad de Registros ";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Enabled = false;
            this.CantidadTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CantidadTextBox.Location = new System.Drawing.Point(6, 23);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(188, 23);
            this.CantidadTextBox.TabIndex = 0;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Puntos";
            this.Load += new System.EventHandler(this.FrmPuntos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.CuerpoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PuntosDataGridView)).EndInit();
            this.InferiorPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton OrdenarToolStripDropDownButton;
        private System.Windows.Forms.ToolStripButton FiltrarToolStripButton;
        private System.Windows.Forms.ToolStripButton ActualizarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CantidadTextBox;
    }
}

