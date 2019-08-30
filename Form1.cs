﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DXApplication1.Vistas;
using DXApplication1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeView(UserControl control)
        {
            if (this.panelControl1.Controls.Count > 0)
            {
                this.panelControl1.Controls.RemoveAt(0);
            }

            control.Dock = DockStyle.Fill;
            this.panelControl1.Controls.Add(control);
            this.panelControl1.Tag = control;
            control.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            accordionControlElement1.Expanded = false;
            accordionControlElement7.Expanded = false;
            accordionControlElement2.Expanded = false;
            accordionControlElement5.Expanded = false;
            accordionControlElement6.Expanded = false;

            connect();
        }

        private void connect()
        {
            var db = DB.Instance();
            db.DatabaseName = "encuesta";

            if (!db.IsConnect())
            {
                this.Close();
            }
            db.Close();
        }

        private void AccordionControlElement9_Click(object sender, EventArgs e)
        {
            ChangeView(new question1());
        }

        private void AccordionControlElement18_Click(object sender, EventArgs e)
        {
            ChangeView(new question2());
        }

        private void AccordionControlElement19_Click(object sender, EventArgs e)
        {
            ChangeView(new question3());
        }

        private void AccordionControlElement20_Click(object sender, EventArgs e)
        {
            ChangeView(new question4());
        }

        private void AccordionControlElement21_Click(object sender, EventArgs e)
        {
            ChangeView(new question5());
        }

        private void AccordionControlElement22_Click(object sender, EventArgs e)
        {
            ChangeView(new question6());
        }

        private void AccordionControlElement39_Click(object sender, EventArgs e)
        {
            ChangeView(new question7());
        }

        private void AccordionControlElement40_Click(object sender, EventArgs e)
        {
            ChangeView(new question8());
        }

        private void AccordionControlElement41_Click(object sender, EventArgs e)
        {
            ChangeView(new question9());
        }

        private void AccordionControlElement42_Click(object sender, EventArgs e)
        {
            ChangeView(new question_10());
        }

        private void AccordionControlElement43_Click(object sender, EventArgs e)
        {
            ChangeView(new question_11());
        }

        private void AccordionControlElement50_Click(object sender, EventArgs e)
        {
            ChangeView(new question_12());
        }

        private void AccordionControlElement51_Click(object sender, EventArgs e)
        {
            ChangeView(new question_13());
        }

        private void AccordionControlElement52_Click(object sender, EventArgs e)
        {
            ChangeView(new question_14());
        }

        private void AccordionControlElement53_Click(object sender, EventArgs e)
        {
            ChangeView(new question_15());
        }

        private void AccordionControlElement54_Click(object sender, EventArgs e)
        {
            ChangeView(new question_16());
        }

        private void AccordionControlElement55_Click(object sender, EventArgs e)
        {
            ChangeView(new question_17());
        }
    }
}
