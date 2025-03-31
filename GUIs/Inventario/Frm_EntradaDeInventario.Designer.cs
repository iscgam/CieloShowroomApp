namespace CieloShowroom.GUIs.Inventario
{
    partial class Frm_EntradaDeInventario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txbExcelPath = new TextBox();
            groupBoxExcel = new GroupBox();
            btnConsultar = new Button();
            btnExaminar = new Button();
            label2 = new Label();
            groupBoxContenido = new GroupBox();
            dgvExcel = new DataGridView();
            ofdExcel = new OpenFileDialog();
            groupBoxExcel.SuspendLayout();
            groupBoxContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExcel).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 0);
            label1.Name = "label1";
            label1.Size = new Size(527, 53);
            label1.TabIndex = 0;
            label1.Text = "Entrada de Inventario";
            // 
            // txbExcelPath
            // 
            txbExcelPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbExcelPath.BorderStyle = BorderStyle.FixedSingle;
            txbExcelPath.Font = new Font("Segoe UI", 12F);
            txbExcelPath.Location = new Point(158, 40);
            txbExcelPath.Name = "txbExcelPath";
            txbExcelPath.ReadOnly = true;
            txbExcelPath.Size = new Size(667, 34);
            txbExcelPath.TabIndex = 1;
            // 
            // groupBoxExcel
            // 
            groupBoxExcel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxExcel.Controls.Add(btnConsultar);
            groupBoxExcel.Controls.Add(btnExaminar);
            groupBoxExcel.Controls.Add(label2);
            groupBoxExcel.Controls.Add(txbExcelPath);
            groupBoxExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxExcel.Location = new Point(23, 56);
            groupBoxExcel.Name = "groupBoxExcel";
            groupBoxExcel.Size = new Size(952, 137);
            groupBoxExcel.TabIndex = 2;
            groupBoxExcel.TabStop = false;
            groupBoxExcel.Text = "Carga masiva";
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Bottom;
            btnConsultar.Font = new Font("Segoe UI", 12F);
            btnConsultar.Location = new Point(419, 85);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(115, 40);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnExaminar
            // 
            btnExaminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExaminar.Font = new Font("Segoe UI", 12F);
            btnExaminar.Location = new Point(831, 36);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(115, 40);
            btnExaminar.TabIndex = 3;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(143, 28);
            label2.TabIndex = 2;
            label2.Text = "Cargar archivo:";
            // 
            // groupBoxContenido
            // 
            groupBoxContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxContenido.Controls.Add(dgvExcel);
            groupBoxContenido.Location = new Point(23, 199);
            groupBoxContenido.Name = "groupBoxContenido";
            groupBoxContenido.Size = new Size(952, 222);
            groupBoxContenido.TabIndex = 3;
            groupBoxContenido.TabStop = false;
            groupBoxContenido.Text = "Vista Preliminar";
            // 
            // dgvExcel
            // 
            dgvExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExcel.Dock = DockStyle.Fill;
            dgvExcel.Location = new Point(3, 30);
            dgvExcel.Name = "dgvExcel";
            dgvExcel.RowHeadersWidth = 51;
            dgvExcel.Size = new Size(946, 189);
            dgvExcel.TabIndex = 0;
            // 
            // ofdExcel
            // 
            ofdExcel.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            // 
            // Frm_EntradaDeInventario
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(groupBoxContenido);
            Controls.Add(groupBoxExcel);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Frm_EntradaDeInventario";
            Size = new Size(998, 507);
            groupBoxExcel.ResumeLayout(false);
            groupBoxExcel.PerformLayout();
            groupBoxContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExcel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbExcelPath;
        private GroupBox groupBoxExcel;
        private Button btnExaminar;
        private Label label2;
        private Button btnConsultar;
        private GroupBox groupBoxContenido;
        private DataGridView dgvExcel;
        private OpenFileDialog ofdExcel;
    }
}
