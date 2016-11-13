﻿using System;
using System.Windows.Forms;
using Logic;
using Logic.Criptographys;

namespace Encryptor.Views.criptografias
{
    public partial class SimetricasFrm : Form
    {
        public SimetricasFrm()
        {
            InitializeComponent();
        }
        private string _type;
        private File _input;
        private File _output;

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFile();
        }

        public void Criptografar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_type))
            {
                MessageBox.Show(@"Selecione qual é a simetrica !"); return;
            }
            if (string.IsNullOrEmpty(_input?.Content))
            {
                MessageBox.Show(@"Abra o arquivo antes de encriptar !"); return;
            }
            if (string.IsNullOrEmpty(passwordBox.Text))
            {
                MessageBox.Show(@"Digite uma senha antes de encrptar !"); return;
            }

            Encrypt();
        }

        public void Descriptografar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_type))
            {
                MessageBox.Show(@"Selecione qual é a simetrica !"); return;
            }
            if (string.IsNullOrEmpty(_input?.Content))
            {
                MessageBox.Show(@"Abra o arquivo que vai encriptar !"); return;
            }
            if (_input.Content.Length % 2 != 0)
            {
                MessageBox.Show(@"O arquivo a ser decriptado é invalido !"); return;
            }
            if (passwordBox.Text.Length != 16 && passwordBox.Text.Length != 24 && passwordBox.Text.Length != 32)
            {
                MessageBox.Show(@"A Senha deve ter 16, 24 ou 36 caracteres !"); return;
            }

            Decrypt();
        }

        private void Salvar(object sender, EventArgs e)
        {
            if (_input == null)
            {
                MessageBox.Show(@"Abra o arquivo que vai encriptar !"); return;
            }
            if (_output == null)
            {
                MessageBox.Show(@"Realize uma acão antes de salvar !"); return;
            }

            SaveFile();
        }

        private void Limpar(object sender, EventArgs e)
        {
            _type = null;
            _input = null;
            passwordBox.Text = "";
            rRINJDAEL.Checked = false;
            outputLbl.Text = string.Empty;
            visibiladadeBtn.Checked = false;
        }

        private void OpenFile()
        {
            using (var dialog = new OpenFileDialog
            {
                Title = @"Selecione o arquivo a ser Encryptado!",
                Filter = @"AllFiles |*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            })
            {
                _input = dialog.ShowDialog() == DialogResult.Cancel ? null : new File(dialog.FileName);

                if (_input == null) return;

                outputLbl.Text = _input.Read();
            }
        }

        private void Encrypt()
        {
            _output = _input;
            _output.Password = passwordBox.Text;
            switch (_type)
            {
                case "RIJNDAEL":
                    _output.Content = Simetricas.Encript.Rijndael(_input.Read(),_output.Password);
                    break;
            }

            outputLbl.Text = _output.Content;
        }

        private void Decrypt()
        {
            _output = _input;
            _output.Password = passwordBox.Text;
            switch (_type)
            {
                case "RIJNDAEL":
                    _output.Content = Simetricas.Decript.Rijndael(_input.Read(), _output.Password);
                    break;
            }

            outputLbl.Text = _output.Content;
        }

        private void SaveFile()
        {
            using (var dialog = new SaveFileDialog()
            {
                Title = @"Onde deseja salvar o arquivo!",
                Filter = @"Encryptor |*.crp",
                FileName = _input.Name
            })
            {
                if (dialog.ShowDialog() == DialogResult.Cancel) return;
                _output.Save();
                MessageBox.Show(@"Arquivo salvo com sucesso !");
            }
        }

        private void ChangeSelect(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;
            _type = ((RadioButton)sender).Text;
        }

        private void GeneratePassword(object sender, EventArgs e)
        {
            visibiladadeBtn.Checked = true;
            switch (((Button)sender).Text)
            {
                case "16":
                    passwordBox.Text = Guid.NewGuid().ToString().Replace(@"-", "").ToUpper().Substring(0,16);
                        break;
                case "24":
                    passwordBox.Text = Guid.NewGuid().ToString().Replace(@"-", "").ToUpper().Substring(0, 24);
                    break;
                case "32":
                    passwordBox.Text = Guid.NewGuid().ToString().Replace(@"-", "").ToUpper().Substring(0, 32);
                    break;
            }
        }

        private void ChangeVisibility(object sender, EventArgs e)
        {
            if (visibiladadeBtn.Checked)
            {
                passwordBox.UseSystemPasswordChar = false;
                visibiladadeBtn.Text = @"o";
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
                visibiladadeBtn.Text = @"-";
            }
        }
    }
}
