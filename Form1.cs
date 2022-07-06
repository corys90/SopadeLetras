using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SopaDeLetras
{
    public partial class Form1 : Form
    {
        List<string> matrix;

        public Form1()
        {
            InitializeComponent();
        }

        public int[] izqArr(int lon)
        {

            if (lon > nUDNoFilas.Value)
            {
                return (new int[] { -1, -1 });
            }

            if (lon > nUDNoColumnas.Value)
            {
                return (new int[] { -1, -1 });
            }

            for (int f = 0; f < nUDNoFilas.Value; f++)
            {
                for(int c = 0; c < nUDNoColumnas.Value; c++)
                {
                    string cad = "";
                    if ((f - (lon - 1)) < 0)
                    {
                        //
                    }
                    else
                    {
                        if ((c - (lon - 1)) < 0)
                        {
                            //
                        }
                        else
                        {
                            for (int d = 0; d < lon; d++)
                            {
                                cad += dgvSopaLetras.Rows[f - d].Cells[c - d].Value.ToString();
                            }

                            //las siguientes tres lineas son para invertir la palabra buscada
                            char[] arrayPalabra = cad.ToCharArray();
                            Array.Reverse(arrayPalabra);
                            string reverseWord = new string(arrayPalabra);

                            if (cad == txtPalabra.Text)
                            {
                                for (int d = 0; d < lon; d++)
                                {
                                    dgvSopaLetras.Rows[f - d].Cells[c - d].Style.BackColor = Color.GreenYellow;
                                }

                                return (new int[] {f, c, 0 });
                            }
                            if (reverseWord == txtPalabra.Text)
                            {
                                for (int d = 0; d < lon; d++)
                                {
                                    dgvSopaLetras.Rows[f - d].Cells[c - d].Style.BackColor = Color.GreenYellow;
                                }
                                return (new int[] { f, c, 0 });
                            }

                        }
                    }
                }
            }

            return (new int[] { -1, -1 });
        }

        public int[] izqAba(int lon)
        {
            if (lon > nUDNoFilas.Value)
            {
                return (new int[] { -1, -1 });
            }

            if (lon > nUDNoColumnas.Value)
            {
                return (new int[] { -1, -1 });
            }

            for (int f = 0; f < nUDNoFilas.Value; f++)
            {
                for (int c = 0; c < nUDNoColumnas.Value; c++)
                {
                    string cad = "";
                    if ((f + lon) > nUDNoFilas.Value)
                    {
                        //
                    }
                    else
                    {
                        if ((c - (lon - 1)) < 0)
                        {
                            //
                        }
                        else
                        {
                            for (int d = 0; d < lon; d++)
                            {
                                cad += dgvSopaLetras.Rows[f + d].Cells[c - d].Value.ToString();
                            }

                            //las siguientes tres lineas son para invertir la palabra buscada
                            char[] arrayPalabra = cad.ToCharArray();
                            Array.Reverse(arrayPalabra);
                            string reverseWord = new string(arrayPalabra);

                            if (cad == txtPalabra.Text)
                            {
                                for (int d = 0; d < lon; d++)
                                {
                                    dgvSopaLetras.Rows[f + d].Cells[c - d].Style.BackColor = Color.GreenYellow;
                                }
                                return (new int[] { c, f });
                            }
                            if (reverseWord == txtPalabra.Text)
                            {
                                for (int d = 0; d < lon; d++)
                                {
                                    dgvSopaLetras.Rows[f + d].Cells[c - d].Style.BackColor = Color.GreenYellow;
                                }
                                return (new int[] { c, f });
                            }
                        }
                    }
                }
            }

            return (new int[] { -1, -1 });
        }

        public int[] derArr(int lon)
        {
            if (lon > nUDNoFilas.Value)
            {
                return (new int[] { -1, -1 });
            }

            if (lon > nUDNoColumnas.Value)
            {
                return (new int[] { -1, -1 });
            }

            for (int f = 0; f < nUDNoFilas.Value; f++)
            {
                for (int c = 0; c < nUDNoColumnas.Value; c++)
                {
                    string cad = "";
                    if ((f - lon) < 0)
                    {
                        //
                    }
                    else
                    {
                        if ((c + lon) > nUDNoColumnas.Value)
                        {
                            //
                        }
                        else
                        {
                            for (int d = 0; d < lon; d++)
                            {
                                cad += dgvSopaLetras.Rows[f - d].Cells[c + d].Value.ToString();
                            }

                            //las siguientes tres lineas son para invertir la palabra buscada
                            char[] arrayPalabra = cad.ToCharArray();
                            Array.Reverse(arrayPalabra);
                            string reverseWord = new string(arrayPalabra);

                            if (cad == txtPalabra.Text)
                            {
                                for (int d = 0; d < lon; d++)
                                {
                                    dgvSopaLetras.Rows[f - d].Cells[c + d].Style.BackColor = Color.GreenYellow;
                                }
                                return (new int[] { c, f });
                            }
                            if (reverseWord == txtPalabra.Text)
                            {
                                for (int d = 0; d < lon; d++)
                                {
                                    dgvSopaLetras.Rows[f - d].Cells[c + d].Style.BackColor = Color.GreenYellow;
                                }
                                return (new int[] { c, f });
                            }

                        }
                    }
                }
            }

            return (new int[] { -1, -1 });
        }

        public int[] derAba(int lon)
        {
            if (lon > nUDNoFilas.Value)
            {
                return (new int[] { -1, -1 });
            }

            if (lon > nUDNoColumnas.Value)
            {
                return (new int[] { -1, -1 });
            }

            for (int f = 0; f < nUDNoFilas.Value; f++)
            {
                for (int c = 0; c < nUDNoColumnas.Value; c++)
                {
                    string cad = "";
                    if ((f + lon) > nUDNoFilas.Value)
                    {
                        //
                    }
                    else
                    {
                        if ((c + lon) > nUDNoColumnas.Value)
                        {
                            //
                        }
                        else
                        {
                            for (int d = 0; d < lon; d++)
                            {
                                cad += dgvSopaLetras.Rows[f + d].Cells[c + d].Value.ToString();
                            }

                            //las siguientes tres lineas son para invertir la palabra buscada
                            char[] arrayPalabra = cad.ToCharArray();
                            Array.Reverse(arrayPalabra);
                            string reverseWord = new string(arrayPalabra);

                            if (cad == txtPalabra.Text)
                            {
                                for (int d = 0; d < lon; d++)
                                {
                                    dgvSopaLetras.Rows[f + d].Cells[c + d].Style.BackColor = Color.GreenYellow;
                                }
                                return (new int[] { c, f });
                            }
                            if (reverseWord == txtPalabra.Text)
                            {
                                for (int d = 0; d < lon; d++)
                                {
                                    dgvSopaLetras.Rows[f + d].Cells[c + d].Style.BackColor = Color.GreenYellow;
                                }
                                return (new int[] { c, f });
                            }

                        }
                    }
                }
            }

            return (new int[] { -1, -1 });
        }

        public List<string> transponeMatrix(DataGridView dgv)
        {
            List<string> palabras = new List<string>();

            string[,] matTx = new string[(int)nUDNoColumnas.Value, (int)nUDNoFilas.Value];  

            for (int f = 0; f < nUDNoFilas.Value; f++)
            {
                for (int c = 0; c < nUDNoColumnas.Value; c++)
                {
                    string cade = (string) dgvSopaLetras.Rows[f].Cells[c].Value;
                    matTx[c, f] = cade;
                }
            }
            //Convierte matrix en una lista de palabras
            for (int c = 0; c < nUDNoColumnas.Value; c++)
            {
                string cad = "";

                for (int f = 0; f < nUDNoFilas.Value; f++)
                {
                    cad += matTx[c, f];
                }
                palabras.Add(cad);
            }

            return (palabras);
        }

        public List<string> convGridToLista(DataGridView dgv)
        {

            List<string> palabras = new List<string>();

            for (int f = 0; f < nUDNoFilas.Value; f++)
            {

                string cad = "";

                for (int c = 0; c < nUDNoColumnas.Value; c++)
                {
                    cad += dgvSopaLetras.Rows[f].Cells[c].Value;
                }
                 palabras.Add(cad);
            }

            return (palabras);

        }

        public int[] buscarPalabraIzqDer(string palabra, List<string> sopaletras)
        {
            //las siguientes tres lineas son para invertir la palabra buscada
            char[] arrayPalabra = palabra.ToCharArray();
            Array.Reverse(arrayPalabra);
            string reverseWord = new string(arrayPalabra);

            int cf = -1;
            int[] pos = new int[2] {0,0};
            // Proceso que busca una palabra en orden de lectura normal de izq a der
            foreach(string cad in sopaletras)
            {
                cf++;
                pos[1] = cad.IndexOf(palabra);
                if (pos[1] >= 0)
                {
                    pos[0] = cf;
                    return (pos);

                } else 
                {
                    pos[1] = cad.IndexOf(reverseWord);
                    if (pos[1] >= 0)
                    {
                        pos[0] = cf;
                        return (pos);
                    }
                }
            }

            return (new int[2] { -1, -1});
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvSopaLetras.Columns.Clear();
            dgvSopaLetras.Rows.Clear();

            if (nUDNoFilas.Value < 1)
            {
                MessageBox.Show("El número de filas no puede ser un valor inferior a 0. Verifiquelo!");
                return;
            }
            if (nUDNoColumnas.Value < 1)
            {
                MessageBox.Show("El número de Columnas no puede ser un valor inferior a 0. Verifiquelo!");
                return;
            }

            int sizeCol = (int) ((dgvSopaLetras.Size.Width - 15) / nUDNoColumnas.Value);
            int sizeRw = (int)((dgvSopaLetras.Size.Height - 15) / nUDNoFilas.Value);

            dgvSopaLetras.ColumnHeadersVisible = false;
            dgvSopaLetras.RowHeadersVisible = false;


            for (int i = 0; i < nUDNoColumnas.Value; i++)
            {
                dgvSopaLetras.Columns.Add("char", "");
                dgvSopaLetras.Columns[i].Width = sizeCol;
                dgvSopaLetras.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSopaLetras.Columns[i].DefaultCellStyle.Font = new Font("Arial", sizeCol/3, FontStyle.Bold);
            }
            for (int i = 0; i < nUDNoFilas.Value; i++)
            {
                dgvSopaLetras.Rows.Add("", "");
                dgvSopaLetras.Rows[i].Height = sizeRw;
                dgvSopaLetras.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void btnRestablece_Click(object sender, EventArgs e)
        {
            nUDNoFilas.Value = 0;
            nUDNoColumnas.Value = 0;

            dgvSopaLetras.Columns.Clear();
            dgvSopaLetras.Rows.Clear();
        }

        public void pintarWordHorz(int[] coord, int lengWord)
        {
            int f = coord[0];
            for (int c = coord[1]; c < (lengWord + coord[1]); c++)
            {
                dgvSopaLetras.Rows[f].Cells[c].Style.BackColor = Color.GreenYellow;
            }
        }

        public void pintarWordVert(int[] coord, int lengWord)
        {
            int f = coord[0];
            for (int c = coord[1]; c < (lengWord + coord[1]); c++)
            {
                dgvSopaLetras.Rows[c].Cells[f].Style.BackColor = Color.GreenYellow;
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            txtPalabra.Text = txtPalabra.Text.Trim().ToUpper();

            if (txtPalabra.Text == "")
            {
                MessageBox.Show("No es un palabra válida! " + dgvSopaLetras.Rows[0].Cells[0].Value);
                return;
            }

            if ((txtPalabra.Text.Length > nUDNoFilas.Value) || (txtPalabra.Text.Length > nUDNoColumnas.Value))
            {
                MessageBox.Show("Palabra no encontrada ", "Busqueda");
                return;
            }

            //Restablece el color de las celdas de la grilla
            for (int f = 0; f < dgvSopaLetras.RowCount; f++)
            {
                for (int c = 0; c < dgvSopaLetras.ColumnCount; c++)
                {
                    dgvSopaLetras.Rows[f].Cells[c].Style.BackColor = Color.White;
                }
            }

            //proceso que busca la palabra horizontal
            matrix = convGridToLista(dgvSopaLetras);
            int[] palIzaDer = buscarPalabraIzqDer(txtPalabra.Text, matrix);
            if (palIzaDer[0] >= 0)
            {
                Console.WriteLine("Palabra buscada: {0}, {1} encontrada en la fila {2}, col {3} ",
                txtPalabra.Text, (palIzaDer[0] != -1 ? "" : " no "),
                    (palIzaDer[0] != -1 ? ("" + palIzaDer[0]) : ""),
                    (palIzaDer[1] != -1 ? ("" + palIzaDer[1]) : ""));

                pintarWordHorz(palIzaDer, txtPalabra.Text.Length);

            }
            else
            {
                //proceso que busca la palabra vertical
                List<string> palabras = transponeMatrix(dgvSopaLetras);
                palIzaDer = buscarPalabraIzqDer(txtPalabra.Text, palabras);
                if (palIzaDer[0] >= 0)
                {
                    Console.WriteLine("Palabra buscada: {0}, {1} encontrada en la fila {3}, col {2} ",
                    txtPalabra.Text, (palIzaDer[0] != -1 ? "" : " no "),
                        (palIzaDer[0] != -1 ? ("" + palIzaDer[0]) : ""),
                        (palIzaDer[1] != -1 ? ("" + palIzaDer[1]) : ""));

                    pintarWordVert(palIzaDer, txtPalabra.Text.Length);
                }
                else
                {
                    //proceso que busca la palabra en las diagonales
                    int[] pos = izqArr(txtPalabra.Text.Length);
                    if (pos[0] >= 0) 
                    {
                        //
                    }
                    else
                    {
                        pos = izqAba(txtPalabra.Text.Length);
                        if (pos[0] >= 0)
                        {
                            //
                        }
                        else
                        {
                            pos = derArr(txtPalabra.Text.Length);
                            if (pos[0] >= 0)
                            {
                                //
                            }
                            else
                            {
                                pos = derAba(txtPalabra.Text.Length);
                                if (pos[0] >= 0)
                                {
                                    //
                                }
                                else
                                {
                                    MessageBox.Show("Palabra buscada no encontrada!", "Busqueda");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void dgvSopaLetras_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string cad = ((string)dgvSopaLetras.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).ToUpper().Trim();
            if (cad != "")
            {
                dgvSopaLetras.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 
                    ((string)dgvSopaLetras.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).ToUpper().Trim().Substring(0, 1);
            }

        }
    }
}
