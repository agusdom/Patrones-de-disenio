﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mediator
{
    public partial class Form1 : Form
    {
        Chat _chat;
        Usuario u1;
        Usuario u2;

        public Form1()
        {
            InitializeComponent();
            _chat = new Chatroom();
            u1 = new Usuario1("Usuario 1");
            u2 = new Usuario2("Usuario 2");

            _chat.Registrar(u1);
            _chat.Registrar(u2);
        }

        private void EnviarUser1_Click(object sender, EventArgs e)
        {
            _chat.Enviar(this.textBox1.Text, u2, u1);
            MostrarMensajes();
            MostrarMensajesU2();
        }

        private void EnviarUser2_Click(object sender, EventArgs e)
        {
            _chat.Enviar(this.textBox5.Text,u1,u2);
            MostrarMensajes();
            MostrarMensajesU1();
        }

        void MostrarMensajesU1()
        {
            this.lstMensajesU1.DataSource = null;
            this.lstMensajesU1.DataSource = u1.Mensajes;
        }

        void MostrarMensajesU2()
        {
            this.lstMensajesU2.DataSource = null;
            this.lstMensajesU2.DataSource = u2.Mensajes;
        }

        void MostrarMensajes()
        {
            this.lstRoom.DataSource = null;
            this.lstRoom.DataSource = _chat.Mensajes;
        }
    }
}
