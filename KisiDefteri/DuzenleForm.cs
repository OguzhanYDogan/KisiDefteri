﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiDefteri
{
    public partial class DuzenleForm : Form
    {
        private readonly Kisi _kisi;

        public DuzenleForm(Kisi kisi)
        {
            _kisi = kisi;
            InitializeComponent();
            txtAd.Text = kisi.Ad;
            txtSoyad.Text = kisi.Soyad;
        }

        public void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            if (ad == "" || soyad == "")
            {
                MessageBox.Show("Ad ve Soyad zorunlu!");
                return;
            }
            _kisi.Ad = ad;
            _kisi.Soyad = soyad;
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
