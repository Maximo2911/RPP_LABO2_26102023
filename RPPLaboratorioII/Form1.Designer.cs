namespace RPPLaboratorioII
{
    partial class FrmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            lstVehiculos = new ListBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            btnFabricar = new Button();
            btnEliminar = new Button();
            pcbFabrica = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).BeginInit();
            SuspendLayout();
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(39, 30);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(449, 364);
            lstVehiculos.TabIndex = 0;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(587, 30);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(97, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo de Vehiculo:";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Auto", "Moto", "Camioneta" });
            cmbTipo.Location = new Point(573, 59);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(144, 23);
            cmbTipo.TabIndex = 2;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(587, 279);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(112, 37);
            btnFabricar.TabIndex = 3;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(587, 336);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 58);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pcbFabrica
            // 
            pcbFabrica.Image = (Image)resources.GetObject("pcbFabrica.Image");
            pcbFabrica.InitialImage = (Image)resources.GetObject("pcbFabrica.InitialImage");
            pcbFabrica.Location = new Point(573, 117);
            pcbFabrica.Name = "pcbFabrica";
            pcbFabrica.Size = new Size(151, 136);
            pcbFabrica.SizeMode = PictureBoxSizeMode.Zoom;
            pcbFabrica.TabIndex = 5;
            pcbFabrica.TabStop = false;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pcbFabrica);
            Controls.Add(btnEliminar);
            Controls.Add(btnFabricar);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(lstVehiculos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fabrica de Vehiculos";
            Load += FrmView_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVehiculos;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private Button btnFabricar;
        private Button btnEliminar;
        private PictureBox pcbFabrica;
    }
}