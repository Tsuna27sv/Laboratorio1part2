using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertidorLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Crear un programa que permita convertir de libras a kilogramos, viceversa, de gramos a libras,
        //viceversa y de onzas a libras y viceversa. Para realizar este ejercicio debe
        //crear una biblioteca de clases, en dicha biblioteca debe crear una clase principal
        //desde donde van a heredar las clases que se usarán para calcular las conversiones.
        //Puede utilizar Tab Control o múltiples formularios para resolver el ejercicio.
   
        //Aqui como podemos observar unas variables y podes hacer la converciones
        private void btn_kg_lb_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tb_kg_lb.Text, out double kilogramos))
            {
                //aqui ingreso los datos de la formula para hacer la conversion 
                double libras = kilogramos * 2.2;
                //aqui muestro el mensajes del resultado del boton
                MessageBox.Show($"{kilogramos} kilogramos = {libras} libras", "Resultado");
            }
            else
            {
                //aqui se crea para que niegue el ingreso de un dato no valido
                MessageBox.Show("Ingreso un valor invalido!", "Error");
            }
        }

        private void btn_lb_kg_Click(object sender, EventArgs e)
        {
            //aqui ingreso los datos de la formula para hacer la conversion
            if (double.TryParse(tb_kg_lb.Text, out double libras))
            {
                double kilogramos = libras / 2.2;
                MessageBox.Show($"{libras} libras = {kilogramos} kilogramos", "Resultado");
            }
            else
            {
                MessageBox.Show("Ingreso un valor invalido!", "Error");
            }
        }

        private void btn_lb_g_Click(object sender, EventArgs e)
        {

            if (double.TryParse(tb_lb_g.Text, out double libras))
            {
                //aqui ingreso los datos de la formula para hacer la conversion
                double gramos = libras * 453.6;
                MessageBox.Show($"{libras} libras = {gramos} gramos", "Resultado de conversion");
            }
            else
            {
                MessageBox.Show("Ingreso un valor invalido!", "Error");
            }
        }

        private void btn_g_lb_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tb_lb_g.Text, out double gramos))
            {
                //aqui ingreso los datos de la formula para hacer la conversion
                double libras = gramos / 453.6;
                MessageBox.Show($"{gramos} gramos = {libras} libras", "Resultado de conversion");
            }
            else
            {
                MessageBox.Show("Ingreso un valor invalido!", "Error");
            }
        }

        private void btn_oz_lb_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tb_lb_oz.Text, out double onzas))
            {
                //aqui ingreso los datos de la formula para hacer la conversion
                double libras = onzas / 16.0;
                MessageBox.Show($"{onzas} onzas = {libras} libras", "Resultado");
            }
            else
            {
                MessageBox.Show("Ingreso un valor invalido!", "Error");
            }
        }

        private void btn_lb_oz_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tb_lb_oz.Text, out double libras))
            {
                //aqui ingreso los datos de la formula para hacer la conversion
                double onza = libras * 16.0;
                MessageBox.Show($"{libras} libras = {onza} onzas", "Resultado");
            }
            else
            {
                MessageBox.Show("Ingreso un valor invalido!", "Error");
            }
        }
    }
}