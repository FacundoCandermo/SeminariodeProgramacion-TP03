namespace TP03.Windows
{
    partial class FrmTipoDePagoAE
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
            components = new System.ComponentModel.Container();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            TxtMonto = new TextBox();
            CboTipoDePago = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(51, 196);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(93, 84);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(337, 196);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 84);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 96);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Monto a Ingresar :";
            // 
            // TxtMonto
            // 
            TxtMonto.Location = new Point(119, 93);
            TxtMonto.Name = "TxtMonto";
            TxtMonto.Size = new Size(297, 23);
            TxtMonto.TabIndex = 3;
            // 
            // CboTipoDePago
            // 
            CboTipoDePago.FormattingEnabled = true;
            CboTipoDePago.Location = new Point(119, 48);
            CboTipoDePago.Name = "CboTipoDePago";
            CboTipoDePago.Size = new Size(297, 23);
            CboTipoDePago.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 51);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 6;
            label2.Text = "Tipo de Pago :";
            // 
            // FrmTipoDePagoAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 334);
            Controls.Add(label2);
            Controls.Add(CboTipoDePago);
            Controls.Add(TxtMonto);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Name = "FrmTipoDePagoAE";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
        private TextBox TxtMonto;
        private Label label1;
        private Label label2;
        private ComboBox CboTipoDePago;

    }
}