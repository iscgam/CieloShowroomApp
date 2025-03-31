using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace CieloShowroom.GUIs.Inventario
{
    public partial class Frm_EntradaDeInventario : UserControl
    {
        private string stringPath = string.Empty;

        public Frm_EntradaDeInventario()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            ofdExcel.ShowDialog();
            txbExcelPath.Text = ofdExcel.FileName;
            stringPath = txbExcelPath.Text;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Consultar()
        {
            if (stringPath != string.Empty)
            {
                using (var stream = File.Open(stringPath, FileMode.Open, FileAccess.Read))
                {
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                    using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = false,
                            }
                        });

                        dgvExcel.DataSource = dataSet.Tables[0];                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
                    }
                }
                dgvExcel.Columns[0].HeaderText = "A";
                dgvExcel.Columns[1].HeaderText = "B";
                dgvExcel.Columns[2].HeaderText = "C";

                dgvExcel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvExcel.AutoResizeColumns();
                dgvExcel.ReadOnly = true;
            }
        }
    }
}
