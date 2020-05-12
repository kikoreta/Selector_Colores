using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Selector_Colores.Codigo {

    internal static class Funciones {

        public static bool TextoValido(string texto) {

            bool valido = !texto.Contains(".") && !texto.Contains("-");

            return valido;
        }

        public static bool Validaciones(NumericUpDown numeric, TrackBar tbar, Control panel) {
            bool valido = TextoValido($"{numeric.Value}");

            if (!valido) {
                MessageBox.Show("Solo valores entre 0 - 255 sin decimales ni negativos");
                numeric.Text    = "0";
                tbar.Value      = 0;
                panel.BackColor = Color.Black;

                return false;
            }

            int valorR = int.Parse($"{numeric.Value}");

            if (valorR <= 255) return true;

            MessageBox.Show("Solo valores entre 0 - 255");
            numeric.Text    = "0";
            tbar.Value      = 0;
            panel.BackColor = Color.Black;

            return false;

        }

        public static int ValidarCantidad(int cantidadInicial, bool agregar, Keys key) {
            int cantidadChecar;

            switch (Control.ModifierKeys) {
                case Keys.Control:
                    cantidadChecar = 50;

                    break;

                case Keys.Shift:
                    cantidadChecar = 10;

                    break;

                case Keys.Alt:
                    cantidadChecar = 5;

                    break;

                default:
                    cantidadChecar = 1;

                    break;

            }

            return agregar ? ((cantidadInicial + cantidadChecar) <= 255 ? cantidadChecar : 0) : (cantidadInicial - cantidadChecar) >= 0 ? cantidadChecar : 0;
        }

        /// <summary>
        /// Convierte un valor RGB en HLS
        /// </summary>
        /// <param name="r">Red</param>
        /// <param name="g">Green</param>
        /// <param name="b">Blue</param>
        /// <param name="h">Hue</param>
        /// <param name="l">Light</param>
        /// <param name="s">Saturation</param>
        public static void RgbAHls(int r, int g, int b, out double h, out double l, out double s) {

            l = 0;
            h = 0;
            s = 0;
            double doubleR = r / 255.0;
            double doubleG = g / 255.0;
            double doubleB = b / 255.0;

            double max  = Math.Max(doubleR, Math.Max(doubleG, doubleB));
            double min  = Math.Min(doubleR, Math.Min(doubleG, doubleB));
            double diff = max - min;

            l = (max + min) / 2;

            if (!(Math.Abs(diff) > 0.00001)) return;

            s = diff / (l <= 0.5 ? max + min : 2 - max - min);

            double rDist = (max - doubleR) / diff;
            double gDist = (max - doubleG) / diff;
            double bDist = (max - doubleB) / diff;

            h = (doubleR.Equals(max) ? bDist - gDist : doubleG.Equals(max) ? (2 + rDist) - bDist : (4 + gDist) - rDist) * 60;

            h = h < 0 ? h += 360 : h;
        }

        /// <summary>
        /// Convierte un valor HLS a RGB
        /// </summary>
        /// <param name="h"></param>
        /// <param name="l"></param>
        /// <param name="s"></param>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        public static void HlsARgb(double h, double l, double s, out int r, out int g, out int b) {

            double p2      = l <= 0.5 ? l * (1 + s) : (l + s) - (l * s);
            double p1      = (2 * l) - p2;
            double doubleR = s.Equals(0) ? l : QqhARgb(p1, p2, h + 120);
            double doubleG = s.Equals(0) ? l : QqhARgb(p1, p2, h);
            double doubleB = s.Equals(0) ? l : QqhARgb(p1, p2, h - 120);

            r = (int) (doubleR * 255.0);
            g = (int) (doubleG * 255.0);
            b = (int) (doubleB * 255.0);
        }

        private static double QqhARgb(double q1, double q2, double hue) {

            hue = hue > 360 ? hue - 360 : hue + 360;

            if (hue < 60) return q1 + (((q2 - q1) * hue) / 60);
            if (hue < 180) return q2;
            if (hue < 240) return q1 + (((q2 - q1) * (240 - hue)) / 60);

            return q1;
        }

        public static Color TextoArgba(int a = 255, int r = 0, int g = 0, int b = 0) => Color.FromArgb(a, r, g, b);

        public static string ColorATexto(this Color color, bool alfa = false) {
            string colorHex = $"{color.R:X2}{color.G:X2}{color.B:X2}";

            if (alfa) colorHex += $"{color.A:X2}";

            return colorHex;
        }

        public static Color HexAColor(this string hex, bool alfa) {

            try {

                string colorhex = alfa ? hex : $"{hex}FF";

                colorhex = colorhex.Replace("#", "");

                var    a     = 255;
                var    r     = 255;
                var    g     = 255;
                var    b     = 255;
                char[] cargb = colorhex.ToCharArray();

                switch (colorhex.Length) {

                    case 4:

                        r = Int32.Parse($"{cargb[0]}{cargb[0]}", NumberStyles.AllowHexSpecifier);
                        g = Int32.Parse($"{cargb[1]}{cargb[1]}", NumberStyles.AllowHexSpecifier);
                        b = Int32.Parse($"{cargb[2]}{cargb[2]}", NumberStyles.AllowHexSpecifier);
                        a = Int32.Parse($"{cargb[3]}{cargb[3]}", NumberStyles.AllowHexSpecifier);

                        break;

                    case 5:

                        r = Int32.Parse($"{cargb[0]}{cargb[0]}", NumberStyles.AllowHexSpecifier);
                        g = Int32.Parse($"{cargb[1]}{cargb[1]}", NumberStyles.AllowHexSpecifier);
                        b = Int32.Parse($"{cargb[2]}{cargb[2]}", NumberStyles.AllowHexSpecifier);
                        a = Int32.Parse($"{cargb[3]}{cargb[4]}", NumberStyles.AllowHexSpecifier);

                        break;

                    case 8:

                        r = Int32.Parse($"{cargb[0]}{cargb[1]}", NumberStyles.AllowHexSpecifier);
                        g = Int32.Parse($"{cargb[2]}{cargb[3]}", NumberStyles.AllowHexSpecifier);
                        b = Int32.Parse($"{cargb[4]}{cargb[5]}", NumberStyles.AllowHexSpecifier);
                        a = Int32.Parse($"{cargb[6]}{cargb[7]}", NumberStyles.AllowHexSpecifier);

                        break;

                }

                return Color.FromArgb(a, r, g, b);
            }
            catch (Exception) {
                // MessageBox.Show(@"No se encontró un color valido");

                //string test = ex.Message;

                return Color.Black;
            }
        }

        public static void ColoresListView(this ListView lv) {

            foreach (ListViewItem item in lv.Items) {
                string[] cT = item.SubItems[1].Text.Split(',');
                int      r  = Int32.Parse($"{cT[0]}");
                int      g  = Int32.Parse($"{cT[1]}");
                int      b  = Int32.Parse($"{cT[2]}");
                int      a  = Int32.Parse($"{cT[3]}");

                item.SubItems[0].BackColor = TextoArgba(a, r, g, b);
            }
        }

        public static IEnumerable<Color> Degradado(Color inicio, Color fin, int cantidad) {

            int stepA = (fin.A - inicio.A) / (cantidad - 1);
            int stepR = (fin.R - inicio.R) / (cantidad - 1);
            int stepG = (fin.G - inicio.G) / (cantidad - 1);
            int stepB = (fin.B - inicio.B) / (cantidad - 1);

            for (var i = 0; i < cantidad; i++) yield return Color.FromArgb(inicio.A + (stepA * i), inicio.R + (stepR * i), inicio.G + (stepG * i), inicio.B + (stepB * i));
        }

        public static string RgbAHex(this string rgb) {

            string[] cT = rgb.Split(',');
            int      r  = Int32.Parse($"{cT[0]}");
            int      g  = Int32.Parse($"{cT[1]}");
            int      b  = Int32.Parse($"{cT[2]}");
            int      a  = Int32.Parse($"{cT[3]}");

            Color color = TextoArgba(a, r, g, b);

            string hex = color.ColorATexto(true);

            return hex;
        }

        public class CmykColor {

            public float C { get; set; }
            public float M { get; set; }
            public float Y { get; set; }
            public float K { get; set; }

        }

        public static CmykColor ConvertRgbToCmyk(int r, int g, int b) {

            float rf = r / 255F;
            float gf = g / 255F;
            float bf = b / 255F;

            float k = ClampCmyk(1 - Math.Max(Math.Max(rf, gf), bf));
            float c = ClampCmyk((1 - rf - k) / (1 - k));
            float m = ClampCmyk((1 - gf - k) / (1 - k));
            float y = ClampCmyk((1 - bf - k) / (1 - k));

            return new CmykColor() { C = c, K = k, M = m, Y = y };
        }

        private static float ClampCmyk(float value) {
            if ((value < 0) || float.IsNaN(value)) value = 0;

            return value;
        }

    }

}