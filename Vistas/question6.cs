﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using DXApplication1.Classes;
using DXApplication1.Classes.Charts;
using DevExpress.XtraCharts;

namespace DXApplication1.Vistas
{
    public partial class question6 : UserControl
    {
        public question6() //Ciudad
        {
            InitializeComponent();
        }

        private void Question6_Load(object sender, EventArgs e)
        {
            var dbConnection = DB.Instance();
            dbConnection.DatabaseName = "respuestas";
            if (!dbConnection.IsConnect())
                MessageBox.Show("Hay un error con la base de Datos", "Información");

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT vi_ciudad.valor, COUNT( * ) as cantidad FROM respuestas INNER JOIN vi_ciudad ON respuestas.VI = vi_ciudad.clave GROUP BY VI", dbConnection.Connection);
            DataTable table = new DataTable();
            adapter.Fill(dataSet1);

            table = dataSet1.Tables[0];

            List<Questions> list = Convertions.ConvertoToList(table);

            chartControl1.Series[0].DataSource = list;
            chartControl1.Series[0].ArgumentDataMember = "valor";
            chartControl1.Series[0].ValueDataMembers.AddRange(new string[] { "cantidad" });

            chartControl1.Series[0].Label.TextPattern = "{V}";
            chartControl1.Series[0].LegendTextPattern = "{A}";
        }

        
    }
}
