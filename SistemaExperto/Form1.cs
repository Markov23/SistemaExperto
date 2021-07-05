using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prolog;
using SistemaExperto.Clases.Modelos;

namespace SistemaExperto
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        DataRow row;
        Juego juego = new Juego();
        List<Juego> juegos = new List<Juego>();
        List<Juego> resultados = new List<Juego>();
        List<string> etiquetas = new List<string>();

        public Form1()
        {
            InitializeComponent();

            var prolog = new PrologEngine(persistentCommandHistory: false);

            string filename = @"Videogames_List.pl";

            string query = @"filtro(E,J,P).";

            var solutions = prolog.GetAllSolutions(filename,query);

            string nombreJuego = "";

            for(int i = 0; i < solutions.Count; i++)
            {
                if (i == 0)
                {
                    nombreJuego = solutions[i][1].Value.Replace("'","");

                    juego.setNombre(solutions[i][1].Value.Replace("'",""));
                    juego.setPrecio(Int32.Parse(solutions[i][2].Value));

                    juego.addEtiqueta(solutions[i][0].Value.Replace("'",""));
                    etiquetas.Add(solutions[i][0].Value.Replace("'", ""));
                }
                else
                {
                    if (nombreJuego.Equals(solutions[i][1].Value.Replace("'", "")))
                    {
                        juego.addEtiqueta(solutions[i][0].Value.Replace("'", ""));
                        etiquetas.Add(solutions[i][0].Value.Replace("'", ""));
                    }
                    else
                    {
                        juegos.Add(juego);
                        juego = new Juego();
                        nombreJuego = solutions[i][1].Value.Replace("'", "");
                        juego.setNombre(solutions[i][1].Value.Replace("'", ""));
                        juego.setPrecio(Int32.Parse(solutions[i][2].Value));

                        juego.addEtiqueta(solutions[i][0].Value.Replace("'", ""));
                        etiquetas.Add(solutions[i][0].Value.Replace("'", ""));
                    }
                }
            }

            dt.Columns.Add("Juego");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Puntos");

            tablaJuegos.DataSource = dt;

            foreach (DataGridViewColumn columna in tablaJuegos.Columns)
            {
                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for(int i = 0; i < etiquetas.Count - 1; i++)
            {
                for(int j = i + 1; j < etiquetas.Count; j++)
                {
                    if (etiquetas[i].Equals(etiquetas[j]))
                    {
                        etiquetas.RemoveAt(j);
                        j--;
                    }
                }
            }

            for(int i = 0; i < etiquetas.Count; i++)
            {
                cbEtiqueta1.Items.Add(etiquetas[i]);
                cbEtiqueta2.Items.Add(etiquetas[i]);
                cbEtiqueta3.Items.Add(etiquetas[i]);
            }

            cbEtiqueta1.SelectedIndex = 0;
            cbEtiqueta2.SelectedIndex = 0;
            cbEtiqueta3.SelectedIndex = 0;

            juegos = juegos.OrderBy(o => o.getNombre()).ToList();

            for(int i = 0; i < juegos.Count; i++)
            {
                resultados.Add(juegos[i]);
            }

            llenarTabla(resultados);
            lbEtiquetas.Items.Clear();

            if (tablaJuegos.SelectedRows.Count > 0)
            {
                labelNombre.Text = "Nombre: " + resultados[tablaJuegos.CurrentRow.Index].getNombre();

                lbEtiquetas.Items.Clear();

                for (int i = 0; i < resultados[tablaJuegos.CurrentRow.Index].getEtiquetas().Count; i++)
                {
                    lbEtiquetas.Items.Add(resultados[tablaJuegos.CurrentRow.Index].getEtiquetas()[i]);
                }
            }
        }

        public void llenarTabla(List<Juego> registros)
        {
            dt.Rows.Clear();

            for (int i = 0; i < registros.Count; i++)
            {
                row = dt.NewRow();

                row["Juego"] = registros[i].getNombre();
                row["Precio"] = "$" + registros[i].getPrecio();
                row["Puntos"] = registros[i].getPuntos();

                dt.Rows.Add(row);
            }
        }

        private void checkEtiqueta2_CheckedChanged(object sender, EventArgs e)
        {
            cbEtiqueta2.Enabled = checkEtiqueta2.Checked;

            if(checkEtiqueta2.Checked == false)
            {
                checkEtiqueta3.Checked = false;
                cbEtiqueta3.Enabled = false;
            }
        }

        private void checkEtiqueta3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEtiqueta2.Checked == true)
            {
                cbEtiqueta3.Enabled = checkEtiqueta3.Checked;
            }
            else
            {
                checkEtiqueta3.Checked = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            bool repetido = false;
            labelNombre.Text = "Nombre:";
            lbEtiquetas.Items.Clear();
            resultados.Clear();

            for (int i = 0; i < juegos.Count; i++)
            {
                juegos[i].setPuntos(0);
            }

            if(cbEtiqueta2.Enabled == false && cbEtiqueta3.Enabled == false)
            {
                for(int i = 0; i < juegos.Count; i++)
                {
                    for(int j = 0; j < juegos[i].getEtiquetas().Count; j++)
                    {
                        if(juegos[i].getEtiquetas()[j].Equals(cbEtiqueta1.SelectedItem))
                        {
                            juegos[i].incrementPuntos();
                            encontrado = true;
                        }
                    }
                }
            }
            else if(cbEtiqueta2.Enabled == true && cbEtiqueta3.Enabled == false)
            {
                if(cbEtiqueta1.SelectedItem.Equals(cbEtiqueta2.SelectedItem))
                {
                    MessageBox.Show("Para mejores resultados, por favor seleccione etiquetas distintas");
                    repetido = true;
                }
                else
                {
                    for (int i = 0; i < juegos.Count; i++)
                    {
                        for (int j = 0; j < juegos[i].getEtiquetas().Count; j++)
                        {
                            if (juegos[i].getEtiquetas()[j].Equals(cbEtiqueta1.SelectedItem))
                            {
                                juegos[i].incrementPuntos();
                                encontrado = true;
                            }

                            if (juegos[i].getEtiquetas()[j].Equals(cbEtiqueta2.SelectedItem))
                            {
                                juegos[i].incrementPuntos();
                                encontrado = true;
                            }
                        }
                    }
                }
            }
            else if(cbEtiqueta2.Enabled == true && cbEtiqueta3.Enabled == true)
            {
                if(cbEtiqueta1.SelectedItem.Equals(cbEtiqueta2.SelectedItem) || cbEtiqueta1.SelectedItem.Equals(cbEtiqueta3.SelectedItem) || cbEtiqueta2.SelectedItem.Equals(cbEtiqueta3.SelectedItem))
                {
                    MessageBox.Show("Para mejores resultados, por favor seleccione etiquetas distintas");
                    repetido = true;
                }
                else
                {
                    for (int i = 0; i < juegos.Count; i++)
                    {
                        for (int j = 0; j < juegos[i].getEtiquetas().Count; j++)
                        {
                            if (juegos[i].getEtiquetas()[j].Equals(cbEtiqueta1.SelectedItem))
                            {
                                juegos[i].incrementPuntos();
                                encontrado = true;
                            }

                            if (juegos[i].getEtiquetas()[j].Equals(cbEtiqueta2.SelectedItem))
                            {
                                juegos[i].incrementPuntos();
                                encontrado = true;
                            }

                            if (juegos[i].getEtiquetas()[j].Equals(cbEtiqueta3.SelectedItem))
                            {
                                juegos[i].incrementPuntos();
                                encontrado = true;
                            }
                        }
                    }
                }
            }

            if (encontrado == true)
            {
                for (int i = 0; i < juegos.Count; i++)
                {
                    if (juegos[i].getPuntos() > 0)
                    {
                        resultados.Add(juegos[i]);
                    }
                }

                resultados = resultados.OrderBy(o => o.getPuntos()).ToList();

                resultados.Reverse();

                llenarTabla(resultados);

                if (tablaJuegos.SelectedRows.Count > 0)
                {
                    labelNombre.Text = "Nombre: " + resultados[tablaJuegos.CurrentRow.Index].getNombre();

                    lbEtiquetas.Items.Clear();

                    for (int i = 0; i < resultados[tablaJuegos.CurrentRow.Index].getEtiquetas().Count; i++)
                    {
                        lbEtiquetas.Items.Add(resultados[tablaJuegos.CurrentRow.Index].getEtiquetas()[i]);
                    }
                }
            }
            else if(repetido == false)
            {
                dt.Rows.Clear();
                MessageBox.Show("No se encontraron resultado");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < juegos.Count; i++)
            {
                juegos[i].setPuntos(0);
            }

            llenarTabla(juegos);
            labelNombre.Text = "Nombre:";
            lbEtiquetas.Items.Clear();
            cbEtiqueta1.SelectedIndex = 0;
            cbEtiqueta2.SelectedIndex = 0;
            cbEtiqueta3.SelectedIndex = 0;

            if (tablaJuegos.SelectedRows.Count > 0)
            {
                labelNombre.Text = "Nombre: " + resultados[tablaJuegos.CurrentRow.Index].getNombre();

                lbEtiquetas.Items.Clear();

                for (int i = 0; i < resultados[tablaJuegos.CurrentRow.Index].getEtiquetas().Count; i++)
                {
                    lbEtiquetas.Items.Add(resultados[tablaJuegos.CurrentRow.Index].getEtiquetas()[i]);
                }
            }
        }

        private void tablaJuegos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelNombre.Text = "Nombre: " + resultados[tablaJuegos.CurrentRow.Index].getNombre();

            lbEtiquetas.Items.Clear();

            for(int i = 0; i < resultados[tablaJuegos.CurrentRow.Index].getEtiquetas().Count; i++)
            {
                lbEtiquetas.Items.Add(resultados[tablaJuegos.CurrentRow.Index].getEtiquetas()[i]);
            }
        }
    }
}
