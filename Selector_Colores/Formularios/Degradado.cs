using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Selector_Colores.Codigo;

namespace Selector_Colores.Formularios {

    internal sealed partial class Degradado : Form {

        public Degradado() => InitializeComponent();

        private void BtnDegradado_Click(object sender, EventArgs e) {
            try {

                if (string.IsNullOrWhiteSpace(TbColorInicial.Text)) {
                    MessageBox.Show(@"Ingrese color Inicial");

                    return;
                }

                if (string.IsNullOrWhiteSpace(TbColorFinal.Text)) {
                    MessageBox.Show(@"Ingrese color Final");

                    return;
                }

                if (int.Parse($"{NumCantidadColores.Value}") < 0) {
                    MessageBox.Show(@"Ingrese una cantidad mayor a 0");

                    return;
                }

                string txtInicial = TbColorInicial.Text.Replace("#", "").Trim();
                string txtFinal   = TbColorFinal.Text.Replace("#", "").Trim();

                bool alfaCi = (txtInicial.Length >= 8) || (txtInicial.Length == 4);
                bool alfaCf = (txtFinal.Length >= 8) || (txtFinal.Length == 4);

                Color cinicial = TbColorInicial.Text.HexAColor(alfaCi);
                Color cfinal   = TbColorFinal.Text.HexAColor(alfaCf);
                int   cantidad = int.Parse($"{NumCantidadColores.Value}") + 2;

                IEnumerable<Color> degradado = Funciones.Degradado(cinicial, cfinal, cantidad);

                LvColores.Items.Clear();

                foreach (Color color in degradado) {
                    string hex  = color.ColorATexto(true);
                    string rgba = $"{color.R},{color.G},{color.B},{color.A}";

                    var colorLista = new ListViewItem("");
                    colorLista.SubItems.Add(rgba);
                    colorLista.SubItems.Add(hex);
                    colorLista.UseItemStyleForSubItems = false;
                    LvColores.Items.Add(colorLista);
                }

                LvColores.ColoresListView();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnAgregar_Click(object sender, EventArgs e) {
            try {
                if (Owner == null) return;

                var listViewColores = (Owner as Principal).Controls["LisVieColores"] as ListView;

                foreach (ListViewItem item in LvColores.SelectedItems) {
                    string rgba = item.SubItems[1].Text;
                    string hex  = item.SubItems[2].Text;

                    var colorLista = new ListViewItem("");
                    colorLista.SubItems.Add(rgba);
                    colorLista.SubItems.Add(hex);
                    colorLista.UseItemStyleForSubItems = false;
                    listViewColores.Items.Add(colorLista);

                }

                listViewColores.ColoresListView();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void TbColorInicial_DoubleClick(object sender, EventArgs e) {
            if (Owner == null) return;

            var listViewColores = (Owner as Principal).Controls["LisVieColores"] as ListView;

            if (listViewColores.SelectedItems.Count == 0) return;

            string colorRgb = listViewColores.SelectedItems[0].SubItems[1].Text;
            TbColorInicial.Text = colorRgb.RgbAHex();
        }

        private void TbColorFinal_DoubleClick(object sender, EventArgs e) {
            if (Owner == null) return;

            var listViewColores = (Owner as Principal).Controls["LisVieColores"] as ListView;

            if (listViewColores.SelectedItems.Count == 0) return;

            string colorRgb = listViewColores.SelectedItems[0].SubItems[1].Text;
            TbColorFinal.Text = colorRgb.RgbAHex();
        }

        private void LvColores_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e) => e.DrawDefault = true;

        private void LvColores_DrawSubItem(object sender, DrawListViewSubItemEventArgs e) {
            e.DrawBackground();
            e.DrawText();

            int index = e.ItemIndex;

            if (LvColores.SelectedItems.Count <= 0) return;

            if (!LvColores.Items[index].Selected) return;

            Rectangle bounds = e.Bounds;
            bounds.Inflate(-1, -1);

            ControlPaint.DrawBorder(e.Graphics, bounds, Color.Black, 1, ButtonBorderStyle.Solid, Color.Black, 1, ButtonBorderStyle.Solid, Color.Black, 1, ButtonBorderStyle.Solid, Color.Black, 1, ButtonBorderStyle.Solid);

        }

    }

}