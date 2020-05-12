using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Selector_Colores.Codigo;

namespace Selector_Colores.Formularios {

    internal sealed partial class Principal : Form {

        public Principal() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) { }

        private void TimControl_Tick(object sender, EventArgs e) {
            try { ColorActual(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #region Funciones

        private Color ColorActual() {

            #region R

            int valorR = int.Parse($"{NumR.Value}");

            TrBarR.Value = valorR;

            PnlR.BackColor = Funciones.TextoArgba(r: valorR);

            NumR.Text = $@"{valorR}";

            #endregion

            #region G

            int valorG = int.Parse(string.IsNullOrWhiteSpace(NumG.Text) ? "0" : NumG.Text);

            TrBarG.Value = valorG;

            PnlG.BackColor = Funciones.TextoArgba(g: valorG);

            NumG.Text = $@"{valorG}";

            #endregion

            #region B

            int valorB = int.Parse(string.IsNullOrWhiteSpace(NumB.Text) ? "0" : NumB.Text);

            TrBarB.Value = valorB;

            PnlB.BackColor = Funciones.TextoArgba(b: valorB);

            NumB.Text = $@"{valorB}";

            #endregion

            #region A

            int valorA = int.Parse(string.IsNullOrWhiteSpace(NumA.Text) ? "0" : NumA.Text);

            TrBarA.Value = valorA;

            PnlA.BackColor = Funciones.TextoArgba(valorA);

            NumA.Text = $@"{valorA}";

            #endregion

            Color color = Funciones.TextoArgba(valorA, valorR, valorG, valorB);

            PnlColor.BackColor = color;

            bool focus = TbRGB.Focused || TbRGBA.Focused;

            if (focus) return color;

            TbRGB.Text  = color.ColorATexto();
            TbRGBA.Text = color.ColorATexto(true);

            return color;
        }

        #endregion

        #region R

        private void NumR_ValueChanged(object sender, EventArgs e) {
            try {
                if (!Funciones.Validaciones(NumR, TrBarR, PnlR)) return;

                int valorR = int.Parse($"{NumR.Value}");

                TrBarR.Value = valorR;

                PnlR.BackColor = Funciones.TextoArgba(r: valorR);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TrBarR_Scroll(object sender, EventArgs e) {
            try {
                int valorR = TrBarR.Value;

                NumR.Value = valorR;

                PnlR.BackColor = Funciones.TextoArgba(r: valorR);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnMasR_Click(object sender, EventArgs e) {
            try {
                int valorR = int.Parse(NumR.Text);

                NumR.Value = valorR + Funciones.ValidarCantidad(valorR, true, ModifierKeys);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnMenR_Click(object sender, EventArgs e) {
            try {
                int valorR = int.Parse(NumR.Text);

                NumR.Value = valorR - Funciones.ValidarCantidad(valorR, false, ModifierKeys);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion

        #region G

        private void NumG_ValueChanged(object sender, EventArgs e) {
            try {
                if (!Funciones.Validaciones(NumG, TrBarG, PnlG)) return;

                int valorG = int.Parse(string.IsNullOrWhiteSpace(NumG.Text) ? "0" : NumG.Text);

                TrBarG.Value = valorG;

                PnlG.BackColor = Funciones.TextoArgba(g: valorG);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TrBarG_Scroll(object sender, EventArgs e) {
            try {
                int valorG = TrBarG.Value;

                NumG.Value = valorG;

                PnlG.BackColor = Funciones.TextoArgba(g: valorG);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnMasG_Click(object sender, EventArgs e) {
            try {
                int valorG = int.Parse(NumG.Text);

                NumG.Value = valorG + Funciones.ValidarCantidad(valorG, true, ModifierKeys);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnMenG_Click(object sender, EventArgs e) {
            try {
                int valorG = int.Parse(NumG.Text);

                NumG.Value = valorG - Funciones.ValidarCantidad(valorG, false, ModifierKeys);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion

        #region B

        private void NumB_ValueChanged(object sender, EventArgs e) {
            try {
                if (!Funciones.Validaciones(NumB, TrBarB, PnlB)) return;

                int valorB = int.Parse(string.IsNullOrWhiteSpace(NumB.Text) ? "0" : NumB.Text);

                TrBarB.Value = valorB;

                PnlB.BackColor = Funciones.TextoArgba(b: valorB);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TrBarB_Scroll(object sender, EventArgs e) {
            try {
                int valorB = TrBarB.Value;

                NumB.Value = valorB;

                PnlB.BackColor = Funciones.TextoArgba(b: valorB);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnMasB_Click(object sender, EventArgs e) {
            try {
                int valorB = int.Parse(NumB.Text);

                NumB.Value = valorB + Funciones.ValidarCantidad(valorB, true, ModifierKeys);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnMenB_Click(object sender, EventArgs e) {
            try {
                int valorB = int.Parse(NumB.Text);

                NumB.Value = valorB - Funciones.ValidarCantidad(valorB, false, ModifierKeys);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        #endregion

        #region A

        private void NumA_ValueChanged(object sender, EventArgs e) {
            try {
                if (!Funciones.Validaciones(NumA, TrBarA, PnlA)) return;

                int valorA = int.Parse(string.IsNullOrWhiteSpace(NumA.Text) ? "0" : NumA.Text);

                TrBarA.Value = valorA;

                PnlA.BackColor = Funciones.TextoArgba(valorA);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TrBarA_Scroll(object sender, EventArgs e) {
            try {
                int valorA = TrBarA.Value;

                NumA.Value = valorA;

                PnlA.BackColor = Funciones.TextoArgba(valorA);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnMasA_Click(object sender, EventArgs e) {
            try {
                int valorA = int.Parse(NumA.Text);

                NumA.Value = valorA + Funciones.ValidarCantidad(valorA, true, ModifierKeys);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnMenA_Click(object sender, EventArgs e) {
            try {
                int valorA = int.Parse(NumA.Text);

                NumA.Value = valorA - Funciones.ValidarCantidad(valorA, false, ModifierKeys);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion

        private void BtnAñadir_Click(object sender, EventArgs e) {
            string rgba = $"{NumR.Value},{NumG.Value},{NumB.Value},{NumA.Value}";

            var colorLista = new ListViewItem("");
            colorLista.SubItems.Add(rgba);
            colorLista.SubItems.Add(TbRGBA.Text);
            colorLista.UseItemStyleForSubItems = false;
            LisVieColores.Items.Add(colorLista);
            LisVieColores.ColoresListView();
        }

        private void LisVieColores_SelectedIndexChanged(object sender, EventArgs e) {

            if (LisVieColores.SelectedItems.Count <= 0) return;

            int index = LisVieColores.Items.IndexOf(LisVieColores.SelectedItems[0]);

            string[] cT = LisVieColores.Items[index].SubItems[1].Text.Split(',');
            int      r  = int.Parse($"{cT[0]}");
            int      g  = int.Parse($"{cT[1]}");
            int      b  = int.Parse($"{cT[2]}");
            int      a  = int.Parse($"{cT[3]}");

            NumR.Value = r;
            NumG.Value = g;
            NumB.Value = b;
            NumA.Value = a;
        }

        private void BtnEliminar_Click(object sender, EventArgs e) {
            if (LisVieColores.SelectedItems.Count <= 0) return;

            int index = LisVieColores.Items.IndexOf(LisVieColores.SelectedItems[0]);

            LisVieColores.Items[index].Remove();
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {

            var dialogo = new SaveFileDialog { Filter = "Text File (*.Txt)|*.txt" };

            if (dialogo.ShowDialog() != DialogResult.OK) return;

            string ruta = dialogo.FileName;

            string contenido = LisVieColores.Items.Cast<ListViewItem>().Aggregate("", (current, item) => current + $"{item.SubItems[1].Text}|{item.SubItems[2].Text}{Environment.NewLine}");

            var file = new StreamWriter(ruta);

            file.Write(contenido);
            file.Flush();
            file.Close();

        }

        private void BtnCargar_Click(object sender, EventArgs e) {
            var dialogo = new OpenFileDialog { Filter = "Text File (*.Txt)|*.txt" };

            if (dialogo.ShowDialog() != DialogResult.OK) return;

            LisVieColores.Items.Clear();
            string[] contenido = File.ReadAllLines(dialogo.FileName);

            foreach (string s in contenido) {

                string[] codigo = s.Split('|');
                string   rgba   = codigo[0];
                string   hex;

                if (codigo.Length == 2) { hex = codigo[1]; }
                else {
                    string[] cT = rgba.Split(',');
                    int      r  = int.Parse($"{cT[0]}");
                    int      g  = int.Parse($"{cT[1]}");
                    int      b  = int.Parse($"{cT[2]}");
                    int      a  = int.Parse($"{cT[3]}");

                    Color color = Funciones.TextoArgba(a, r, g, b);

                    hex = color.ColorATexto();

                }

                var colorLista = new ListViewItem("");
                colorLista.SubItems.Add(rgba);
                colorLista.SubItems.Add(hex);
                colorLista.UseItemStyleForSubItems = false;
                LisVieColores.Items.Add(colorLista);
            }

            LisVieColores.ColoresListView();

        }

        private void TbRGB_TextChanged(object sender, EventArgs e) {
            string hex      = TbRGB.Text.Replace("#", "").Trim();
            int    longitud = hex.Length;

            if (longitud < 3) return;

            if ((longitud > 3) && (longitud < 6)) return;

            Color color = hex.HexAColor(false);

            //if (color == Color.Black) LblR.Focus();

            NumR.Value = color.R;
            NumG.Value = color.G;
            NumB.Value = color.B;
            NumA.Value = color.A;
        }

        private void BtnDegradado_Click(object sender, EventArgs e) {
            var degradado = new Degradado { Owner = this };

            degradado.Show();
        }

        private void ActualizarToolStripMenuItem_Click(object sender, EventArgs e) => Actualizacion.ActualizarSincronizarInfo();

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void TbRGBA_TextChanged(object sender, EventArgs e) {
            string hex      = TbRGBA.Text.Replace("#", "").Trim();
            int    longitud = hex.Length;

            if (longitud < 4) return;

            if ((longitud > 4) && (longitud < 8)) return;

            Color color = hex.HexAColor(true);

            //if (color == Color.Black) LblR.Focus();

            NumR.Value = color.R;
            NumG.Value = color.G;
            NumB.Value = color.B;
            NumA.Value = color.A;
        }

        private void TbRGBA_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            Color color = ColorActual();

            TbRGB.Text  = color.ColorATexto();
            TbRGBA.Text = color.ColorATexto(true);
        }

        private void TbRGB_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            Color color = ColorActual();

            TbRGB.Text  = color.ColorATexto();
            TbRGBA.Text = color.ColorATexto(true);
        }

        private void LisVieColores_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e) => e.DrawDefault = true;

        private void LisVieColores_DrawSubItem(object sender, DrawListViewSubItemEventArgs e) {

            e.DrawBackground();
            e.DrawText();

            int index = e.ItemIndex;

            if (LisVieColores.SelectedItems.Count <= 0) return;

            if (!LisVieColores.Items[index].Selected) return;

            Rectangle bounds = e.Bounds;
            bounds.Inflate(-1, -1);

            ControlPaint.DrawBorder(e.Graphics, bounds, Color.Black, 1, ButtonBorderStyle.Solid, Color.Black, 1, ButtonBorderStyle.Solid, Color.Black, 1, ButtonBorderStyle.Solid, Color.Black, 1, ButtonBorderStyle.Solid);
        }

        private void LisVieColores_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Delete) return;

            if (LisVieColores.SelectedItems.Count <= 0) return;

            int index = LisVieColores.Items.IndexOf(LisVieColores.SelectedItems[0]);

            LisVieColores.Items[index].Remove();

        }

        private void GimpToolStripMenuItem_Click(object sender, EventArgs e) {
            var dialogo = new SaveFileDialog { Filter = @"Gimp Palette (*.gpl)|*.gpl" };

            if (dialogo.ShowDialog() != DialogResult.OK) return;

            string ruta = dialogo.FileName;

            string contenido = $"GIMP Palette {Environment.NewLine}";

            contenido = (from ListViewItem item in LisVieColores.Items select item.SubItems[1].Text.Split(',')).Aggregate(contenido, (current, color) => current + $"{color[0]} {color[1]} {color[2]}{Environment.NewLine}");

            var file = new StreamWriter(ruta);

            file.Write(contenido);
            file.Flush();
            file.Close();
        }

        private void BtnSubir_Click(object sender, EventArgs e) => MoverItem(true);

        private void MoverItem(bool arriba) {
            if (LisVieColores.SelectedItems.Count <= 0) return;

            int index  = LisVieColores.Items.IndexOf(LisVieColores.SelectedItems[0]);
            int nIndex = arriba ? index - 1 : index + 1;

            if ((index == 0) && arriba) return;

            if (nIndex >= LisVieColores.Items.Count) return;

            var old = LisVieColores.Items[index].Clone() as ListViewItem;

            LisVieColores.Items.RemoveAt(index);
            LisVieColores.Items.Insert(nIndex, old);
            LisVieColores.Items[nIndex].Selected = true;
            LisVieColores.Select();
        }

        private void BtnBajar_Click(object sender, EventArgs e) => MoverItem(false);

    }

}