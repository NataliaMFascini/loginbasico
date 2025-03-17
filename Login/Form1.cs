using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {

        //declaração de uma lista de usuários

        List<Usuario> usuarios = new List<Usuario>();

        public Form1()
        {
            InitializeComponent();

            //adicionar usuarios na lista

            usuarios.Add(new Usuario() 
            { 
                Email = "paulo.bolo@email.com",
                Senha = "bolosdeMorango" 
            });
            usuarios.Add(new Usuario()
            {
                Email = "pedro.lucas@email.com",
                Senha = "PedroP"
            });
            usuarios.Add(new Usuario()
            {
                Email = "palmerense.mundial@email.com",
                Senha = "mundialsera"
            });
            usuarios.Add(new Usuario()
            {
                Email = "teste",
                Senha = "123"
            });
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            lblResultado.Show();
            lblNovoUsuario.Hide();
            string usuarioBuscado = txtLoginUser.Text;
            string senha = txtLoginSenha.Text;

            bool autenticado = false;

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                lblResultado.Text = "Usuário é obrigatório.";
                lblResultado.ForeColor = Color.Red;
                txtLoginUser.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(senha))
            {
                lblResultado.Text = "Senha é obrigatória.";
                lblResultado.ForeColor = Color.Red;
                txtLoginSenha.Focus();
                return;
            }

            if (!autenticado)
            {
                lblResultado.Text = "Informação incorreta!";
                lblResultado.ForeColor = Color.Red;
            }

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Email == usuarioBuscado && usuarios[i].Senha == senha)
                {
                    autenticado = true;
                }
            }

            lblResultado.Text = "Autenticado com sucesso! （＾∀＾●）";
            lblResultado.ForeColor = Color.Green;

            txtLoginUser.Clear();
            txtLoginSenha.Clear();
            txtLoginUser.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            lblResultado.Hide();
            lblNovoUsuario.Show();

            string usuarioCadastrado = txtNUser.Text;
            string senha = txtNSenha.Text;

            bool cadastrar = true;

            if (string.IsNullOrWhiteSpace(usuarioCadastrado))
            {
                lblNovoUsuario.Text = "Usuário é obrigatório.";
                lblNovoUsuario.ForeColor = Color.Red;
                txtNUser.Focus();
                cadastrar = false;
                return;
            }
            if (string.IsNullOrWhiteSpace(senha))
            {
                lblNovoUsuario.Text = "Senha é obrigatório.";
                lblNovoUsuario.ForeColor = Color.Red;
                txtNSenha.Focus();
                cadastrar = false;
                return;
            }

            for(int i = 0; i < usuarios.Count; i++)
            {
                if(usuarios[i].Email == usuarioCadastrado)
                {
                    lblNovoUsuario.Text = "Usuário indisponível.";
                    lblNovoUsuario.ForeColor = Color.Red;
                    txtNUser.Focus();
                    cadastrar = false;
                    return;
                }
            }

            if (cadastrar)
            {
                usuarios.Add(new Usuario()
                {
                    Email = usuarioCadastrado,
                    Senha = senha
                });

                lblNovoUsuario.Text = "Cadastrado o(*°▽°*)o";
                lblNovoUsuario.ForeColor = Color.Green;
                txtNUser.Clear();
                txtNSenha.Clear();
            }
        }
    }
}
