namespace CieloShowroom.GUIs.Inventario
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            btnEntradaInventario = new Button();
            btnInventarioActual = new Button();
            panelResponse = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlueViolet;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnEntradaInventario);
            panel1.Controls.Add(btnInventarioActual);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 553);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(0, 281);
            button3.Name = "button3";
            button3.Size = new Size(303, 50);
            button3.TabIndex = 3;
            button3.Text = "Salida de Inventario";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnEntradaInventario
            // 
            btnEntradaInventario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEntradaInventario.Font = new Font("Segoe UI", 12F);
            btnEntradaInventario.Location = new Point(0, 225);
            btnEntradaInventario.Name = "btnEntradaInventario";
            btnEntradaInventario.Size = new Size(303, 50);
            btnEntradaInventario.TabIndex = 2;
            btnEntradaInventario.Text = "Entrada de Inventario";
            btnEntradaInventario.UseVisualStyleBackColor = true;
            btnEntradaInventario.Click += btnEntradaInventario_Click;
            // 
            // btnInventarioActual
            // 
            btnInventarioActual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnInventarioActual.Font = new Font("Segoe UI", 12F);
            btnInventarioActual.Location = new Point(0, 169);
            btnInventarioActual.Name = "btnInventarioActual";
            btnInventarioActual.Size = new Size(303, 50);
            btnInventarioActual.TabIndex = 1;
            btnInventarioActual.Text = "Inventario Actual";
            btnInventarioActual.UseVisualStyleBackColor = true;
            btnInventarioActual.Click += btnInventarioActual_Click;
            // 
            // panelResponse
            // 
            panelResponse.Dock = DockStyle.Fill;
            panelResponse.Location = new Point(303, 0);
            panelResponse.Name = "panelResponse";
            panelResponse.Size = new Size(679, 553);
            panelResponse.TabIndex = 1;
            // 
            // FrmInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(panelResponse);
            Controls.Add(panel1);
            Name = "FrmInventario";
            Text = "Cielo Showroom";
            Load += FrmInventario_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button btnEntradaInventario;
        private Button btnInventarioActual;
        private Panel panelResponse;
        private PictureBox pictureBox1;
    }
}