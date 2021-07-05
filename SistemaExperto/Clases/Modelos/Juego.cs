using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaExperto.Clases.Modelos
{
    public class Juego
    {
        private string nombre;
        private double precio;
        private List<string> etiquetas;
        private int puntos;

        public Juego()
        {
            this.nombre = "";
            this.precio = 0;
            this.etiquetas = new List<string>();
            puntos = 0;
        }

        public Juego(string nombre, double precio, List<string> etiquetas)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.etiquetas = new List<string>();
            for (int i = 0; i < etiquetas.Count; i++)
            {
                this.etiquetas.Add(etiquetas[i]);
            }
            puntos = 0;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public double getPrecio()
        {
            return this.precio;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public List<string> getEtiquetas()
        {
            return this.etiquetas;
        }

        public void setEtiquetas(List<string> etiquetas)
        {
            this.etiquetas = new List<string>();
            for(int i = 0; i < etiquetas.Count; i++)
            {
                this.etiquetas.Add(etiquetas[i]);
            }
        }

        public void addEtiqueta(string etiqueta)
        {
            this.etiquetas.Add(etiqueta);
        }

        public void removeEtiqueta(int indice)
        {
            this.etiquetas.RemoveAt(indice);
        }

        public void changeEtiqueta(int indice, string etiqueta)
        {
            this.etiquetas[indice] = etiqueta;
        }

        public void insertEtiqueta(int indice, string etiqueta)
        {
            this.etiquetas.Insert(indice,etiqueta);
        }

        public int getPuntos()
        {
            return this.puntos;
        }

        public void setPuntos(int puntos)
        {
            this.puntos = puntos;
        }

        public void incrementPuntos()
        {
            this.puntos++;
        }

        public void decrementPuntos()
        {
            this.puntos--;
        }
    }
}
