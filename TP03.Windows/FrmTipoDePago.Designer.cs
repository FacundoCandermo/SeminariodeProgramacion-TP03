namespace TP03.Windows
{
    partial class FrmTipoDePago
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
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            TsbNuevo = new ToolStripButton();
            TsbEliminar = new ToolStripButton();
            TsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsbSalir = new ToolStripButton();
            panel2 = new Panel();
            dgvdatos = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColTipoDePago = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdatos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 528);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 100);
            panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbNuevo, TsbEliminar, TsbEditar, toolStripSeparator1, TsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(610, 62);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // TsbNuevo
            // 
            TsbNuevo.Image = Properties.Resources.Nuevo;
            TsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            TsbNuevo.ImageTransparentColor = Color.Magenta;
            TsbNuevo.Name = "TsbNuevo";
            TsbNuevo.Size = new Size(53, 59);
            TsbNuevo.Text = "Agregar";
            TsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbNuevo.Click += TsbNuevo_Click;
            // 
            // TsbEliminar
            // 
            TsbEliminar.Image = Properties.Resources.Delete;
            TsbEliminar.ImageScaling = ToolStripItemImageScaling.None;
            TsbEliminar.ImageTransparentColor = Color.Magenta;
            TsbEliminar.Name = "TsbEliminar";
            TsbEliminar.Size = new Size(54, 59);
            TsbEliminar.Text = "Eliminar";
            TsbEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbEliminar.Click += TsbEliminar_Click;
            // 
            // TsbEditar
            // 
            TsbEditar.Image = Properties.Resources.Edit;
            TsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            TsbEditar.ImageTransparentColor = Color.Magenta;
            TsbEditar.Name = "TsbEditar";
            TsbEditar.Size = new Size(44, 59);
            TsbEditar.Text = "Editar";
            TsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbEditar.Click += TsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // TsbSalir
            // 
            TsbSalir.Image = Properties.Resources.Close;
            TsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            TsbSalir.ImageTransparentColor = Color.Magenta;
            TsbSalir.Name = "TsbSalir";
            TsbSalir.Size = new Size(44, 59);
            TsbSalir.Text = "Salir";
            TsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbSalir.Click += TsbSalir_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvdatos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 466);
            panel2.TabIndex = 2;
            // 
            // dgvdatos
            // 
            dgvdatos.AllowUserToAddRows = false;
            dgvdatos.AllowUserToDeleteRows = false;
            dgvdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdatos.Columns.AddRange(new DataGridViewColumn[] { ColID, ColTipoDePago });
            dgvdatos.Dock = DockStyle.Fill;
            dgvdatos.Location = new Point(0, 0);
            dgvdatos.Name = "dgvdatos";
            dgvdatos.ReadOnly = true;
            dgvdatos.Size = new Size(610, 466);
            dgvdatos.TabIndex = 0;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Visible = false;
            // 
            // ColTipoDePago
            // 
            ColTipoDePago.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTipoDePago.HeaderText = "Tipo De Pago";
            ColTipoDePago.Name = "ColTipoDePago";
            ColTipoDePago.ReadOnly = true;
            // 
            // FrmTipoDePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 628);
            Controls.Add(panel2);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Name = "FrmTipoDePago";
            Text = "FrmTipoDePago";
            Load += FrmTipoDePago_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // The issue is that 'FrmTiposDePago' is being used as an event handler, but it is a type, not a method.  
        // To fix this, you need to replace 'FrmTiposDePago' with a valid method that matches the event handler signature.  
        // Assuming you want to handle the Load event, you can create a method named 'FrmTiposDePago_Load' and use it.  



        #endregion

        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton TsbNuevo;
        private ToolStripButton TsbEliminar;
        private ToolStripButton TsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton TsbSalir;
        private Panel panel2;
        private DataGridView dgvdatos;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColTipoDePago;
    }
}