﻿using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube
{
    public partial class FormViajes : Form
    {
        Pasajero passenger;
        Queue<Viajes> queueViajes;
        public FormViajes(Pasajero passenger, Queue<Viajes> queueTravels)
        {
            InitializeComponent();
            this.passenger = passenger;
            queueViajes = queueTravels;
        }
        private void FormViajes_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = $"${passenger.MySube.Balance}";
            dataGridViajes.Parent = panel1;
            DataTable dt = new DataTable();
            dt.Columns.Add("FECHA", typeof(DateTime));
            dt.Columns.Add("Linea", typeof(string));
            dt.Columns.Add("Transporte", typeof(ETransporte));
            dt.Columns.Add("Kilometros", typeof(int));
            dt.Columns.Add("Costo del boleto", typeof(float));
            foreach (Viajes viajes in queueViajes)
            {
                dt.Rows.Add(viajes.Date, viajes.LineasTransporte, viajes.TipoTransporte, viajes.Kilometres, "-" + viajes.TicketCost);
            }

            dataGridViajes.DataSource = dt;
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
