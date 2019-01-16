using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauran.views
{
    public partial class SettingsView : Form
    {
        public SettingsView()
        {
            InitializeComponent();
        }

        private void LoadImpuestoConsumo()
        {
            txtImpuestoConsumo.Text = Properties.Settings.Default.ImpuestoConsumo.ToString();
        }

        private void SaveInpuestoConsumo(object sender, EventArgs e)
        {
            try
            {
                decimal impuesto = Convert.ToDecimal(txtImpuestoConsumo.Text);
                Properties.Settings.Default.ImpuestoConsumo = impuesto;//el ambito debe ser de usuario
                Properties.Settings.Default.Save();

               /* Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("ImpuestoConsumo");
                config.AppSettings.Settings.Add("ImpuestoConsumo", impuesto.ToString());
                
                config.Save(ConfigurationSaveMode.Modified);
                */

                MessageBox.Show("se cmabio el porcentaje de impuesto","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("Upss!. Algo ocurrio mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
