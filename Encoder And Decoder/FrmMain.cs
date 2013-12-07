using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Web;
using System.Text.RegularExpressions;

namespace Encoder_And_Decoder
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            //RadioButton变化

            //Url编码
            rdbEncode.CheckedChanged += UrlRadioButtonChange;
            rdbDecode.CheckedChanged += UrlRadioButtonChange;

            //Unicode编码
            rdb2Unicode.CheckedChanged += UnicodeRadioButtonChange;
            rdb2Chinese.CheckedChanged += UnicodeRadioButtonChange;
            chkKeepSpace.CheckedChanged += UnicodeRadioButtonChange;
        }

        #region Url编码
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DoUrlConvert();
        }

        public void UrlRadioButtonChange(object sender, EventArgs e)
        {
            DoUrlConvert();
        }

        void DoUrlConvert()
        {
            if (rdbEncode.Checked)
            {
                textBox2.Text = HttpUtility.UrlEncode(textBox1.Text);
            }
            else
            {
                textBox2.Text = HttpUtility.UrlDecode(textBox1.Text);
            }
        }
        #endregion

        #region Unicode编码
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DoUnicodeConvert();
        }

        public void UnicodeRadioButtonChange(object sender, EventArgs e)
        {
            DoUnicodeConvert();
        }

        void DoUnicodeConvert()
        {
            if (rdb2Unicode.Checked)
            {
                //转换成unicode
                //char -> num
                StringBuilder sb = new StringBuilder();

                //保留空格 勾上 原文字
                string text = chkKeepSpace.Checked 
                    ? textBox3.Text : textBox3.Text.Trim();
                foreach (char c in text)
                {
                    sb.Append(@"\u"+((int)c).ToString("x4"));
                }
                textBox4.Text = sb.ToString();
            }
            else
            {
                //从Unicode转换
                //num -> char
                textBox4.Text= Regex.Replace(textBox3.Text, @"\\u(\w{4})", (m) => {
                    return ((char)int.Parse(m.Groups[1].Value,System.Globalization.NumberStyles.HexNumber)).ToString();
                });
            }
        }
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 1;
        }
    }
}
