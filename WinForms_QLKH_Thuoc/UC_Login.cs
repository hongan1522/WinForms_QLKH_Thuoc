﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using WebAPI_QLKH.Services;
using WebAPI_QLKH.Models;
using WinFormsApp;
using System.Globalization;
using UnidecodeSharpFork;

namespace FormQLKH
{
    public partial class UC_Login : UserControl
    {
        private readonly TaiKhoanService tKService;
        private event EventHandler SuccessEvent;
        public UC_Login()
        {
            InitializeComponent();

            tKService = new TaiKhoanService("https://localhost:7195");

        }
        protected virtual void OnSuccessEvent()
        {
            SuccessEvent?.Invoke(this, EventArgs.Empty);
        }
            private void UC_Login_Load(object sender, EventArgs e)
        {
            MakeRoundedButton(btnLogin, 20);
        }
        private void MakeRoundedButton(Button button, int radius)
        {
            GraphicsPath buttonPath = new GraphicsPath();
            buttonPath.AddArc(0, 0, radius * 2, radius * 2, 180, 90); //Góc trên cùng bên trái
            buttonPath.AddArc(button.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90); //Góc trên cùng bên phải
            buttonPath.AddArc(button.Width - radius * 2, button.Height - radius * 2, radius * 2, radius * 2, 0, 90); //Góc dưới cùng bên phải
            buttonPath.AddArc(0, button.Height - radius * 2, radius * 2, radius * 2, 90, 90); //Góc dưới cùng bên trái
            buttonPath.CloseAllFigures();

            button.Region = new Region(buttonPath);
        }
        private void txtLogin_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || !char.IsLetterOrDigit(e.KeyChar) || IsSpecialCharacter(e.KeyChar))
            {
                if (!IsSpecialKey(e) && e.KeyChar != '\b' && e.KeyChar != '\t')
                {
                    e.Handled = true;
                }
            }
        }
        private bool IsSpecialKey(KeyPressEventArgs e)
        {
            return e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Tab ||
                   Control.ModifierKeys == Keys.Shift || Console.CapsLock;
        }
        private bool IsSpecialCharacter(char character)
        {
            string specialCharacters = "!@#$%^&*()_-+=<>?/{}[]\\|";

            return specialCharacters.Contains(character);
        }
        private void txtLogin_UserName_TextChanged(object sender, EventArgs e)
        {
            string text = txtLogin_UserName.Text;

            string unaccentedText = text.Unidecode();

            if (unaccentedText != text)
            {
                txtLogin_UserName.Text = unaccentedText;

                txtLogin_UserName.SelectionStart = txtLogin_UserName.Text.Length;
            }
        }

        private bool isPasswordVisible = false;
        private void pcbEye_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            pcbEye.Image = isPasswordVisible ? Properties.Resources.close : Properties.Resources.open;

            txtLogin_Password.UseSystemPasswordChar = !isPasswordVisible;
        }
        private void txtLogin_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
        private string BamPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtLogin_UserName.Text.Trim();
                string password = BamPassword(txtLogin_Password.Text.Trim());

                if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
                {
                    List<TaiKhoan> danhSachTaiKhoan = tKService.LayDSTaiKhoan();

                    TaiKhoan taiKhoan = danhSachTaiKhoan.FirstOrDefault(tk => tk.UserName == userName);

                    if (taiKhoan != null)
                    {
                        if (taiKhoan.Password == password)
                        {
                            MessageBox.Show("Đăng nhập thành công!");
                            OnSuccessEvent();

                            Frm_QuanLy quanLyForm = new Frm_QuanLy();

                            Form parentForm = this.FindForm();
                            if (parentForm is FrmLogin frmLogin)
                            {
                                frmLogin.Hide();
                            }

                            quanLyForm.Show();


                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không đúng!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên người dùng không tồn tại!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên người dùng và mật khẩu.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
