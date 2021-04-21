using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Form1 : Form {

        string expresion = "0";
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void boton5_Click(object sender, EventArgs e) {
            if (expresion == "0")
                expresion = "";
            expresion += "5";
            textBox1.Text = expresion;
        }

        private void boton9_Click(object sender, EventArgs e) {
            if (expresion == "0")
                expresion = "";
            expresion += "9";
            textBox1.Text = expresion;
        }

        private void boton7_Click(object sender, EventArgs e) {
            if (expresion == "0")
                expresion = "";
            expresion += "7";
            textBox1.Text = expresion;
        }

        private void boton8_Click(object sender, EventArgs e) {
            if (expresion == "0")
                expresion = "";
            expresion += "8";
            textBox1.Text = expresion;
        }

        private void botonDel_Click(object sender, EventArgs e) {
            if (expresion == "error" || expresion == "Infinito") {
                expresion = "0";
            } else {
                string s = textBox1.Text;
                string r = "";
                for (int i = 0; i < s.Length - 1; ++i)
                    r += s[i];
                expresion = r;
                if (expresion == "")
                    expresion = "0";
            }
            textBox1.Text = expresion;
        }

        private void boton4_Click(object sender, EventArgs e) {
            if (expresion == "0")
                expresion = "";
            expresion += "4";
            textBox1.Text = expresion;
        }

        private void boton6_Click(object sender, EventArgs e) {
            if (expresion == "0")
                expresion = "";
            expresion += "6";
            textBox1.Text = expresion;
        }

        private void botonMultiplicar_Click(object sender, EventArgs e) {
            expresion += "*";
            textBox1.Text = expresion;
        }

        private void botonDividir_Click(object sender, EventArgs e) {
            expresion += "/";
            textBox1.Text = expresion;
        }

        private void boton1_Click(object sender, EventArgs e) {
            if (expresion == "0")
                expresion = "";
            expresion += "1";
            textBox1.Text = expresion;
        }

        private void boton2_Click(object sender, EventArgs e) {
            if (expresion == "0")
                expresion = "";
            expresion += "2";
            textBox1.Text = expresion;
        }

        private void boton3_Click(object sender, EventArgs e) {
            if (expresion == "0")
                expresion = "";
            expresion += "3";
            textBox1.Text = expresion;
        }

        private void botonSumar_Click(object sender, EventArgs e) {
            expresion += "+";
            textBox1.Text = expresion;
        }

        private void botonRestar_Click(object sender, EventArgs e) {
            expresion += "-";
            textBox1.Text = expresion;
        }

        private void botonAc_Click(object sender, EventArgs e) {
            expresion = "0";
            textBox1.Text = expresion;
        }

        private void botonAbrirParentesis_Click(object sender, EventArgs e) {
            if (expresion == "0")
                expresion = "";
            expresion += "(";
            textBox1.Text = expresion;
        }

        private void botonCerrarParentesis_Click(object sender, EventArgs e) {
            if (expresion == "0")
                expresion = "";
            expresion += ")";
            textBox1.Text = expresion;
        }
        private void boton0_Click(object sender, EventArgs e) {
            if (expresion == "0")
                expresion = "";
            expresion += "0";
            textBox1.Text = expresion;
        }
        private void botonPunto_Click(object sender, EventArgs e) {
            expresion += ".";
            textBox1.Text = expresion;
        }
        private void botonIgual_Click(object sender, EventArgs e) {
            EvaluarOpe.Evaluador c = new EvaluarOpe.Evaluador(expresion);
            try {
                double r = c.F();
                string total = r+"";
                textBox1.Text = total;
                expresion = total;
            } catch (Exception error) {
                expresion = "Syntax Error";
                textBox1.Text = expresion;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
