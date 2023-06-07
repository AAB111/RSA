using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMilleraRabina;

namespace rsa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<char> characters = new List<char> { '#',',', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                '8', '9', '0' };

        private BigInteger Calculate_e(BigInteger m)
        {
            BigInteger e = m-1;

            for (BigInteger i = 2; i <= m; i++)
                if (BigInteger.GreatestCommonDivisor(m, e) == 1)
                    break;
                else
                {
                    e--;
                    i = 1;
                }

            return e;
        }
        private List<string> RSA_Endoce(string s, BigInteger e, BigInteger n)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = characters.IndexOf(s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.ModPow(bi,e,n);

                result.Add(bi.ToString());
            }

            return result;
        }
        private string RSA_Dedoce(List<string> input, BigInteger d, BigInteger n)
        {
            string result = "";

            BigInteger bi;
            foreach (string item in input)
            {
                bi = BigInteger.Parse(item);
                bi = BigInteger.ModPow(bi,d,n);
                int index = Convert.ToInt32(bi.ToString());

                result += characters[index].ToString();
            }

            return result;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (textbox_p.Text.Length > 0 && textbox_q.Text.Length > 0)
            {
                BigInteger p = BigInteger.Parse(textbox_p.Text);
                BigInteger q = BigInteger.Parse(textbox_q.Text);
                if (Class1.MillerRabinTest(p, 10) && Class1.MillerRabinTest(q, 10))
                {
                    string s = in_encrypt_textbox.Text;

                    BigInteger n = p * q;
                    BigInteger fi = (p - 1) * (q - 1);
                    string res = string.Empty;
                    BigInteger d = 0;
                    await Task.Run(() =>
                    {
                        BigInteger e_ = Calculate_e(fi);
                        d = Invmod(e_, fi);

                        var res_array = RSA_Endoce(s.ToUpper(), e_, n);
                        res = string.Join(" ", res_array);
                    });
                    textbox_d.Text = d.ToString();
                    textbox_n.Text = n.ToString();
                    in_decrypt_textbox.Text = res;
                    out_encrypt_textbox.Text = res;
                }
                else
                {
                    MessageBox.Show("p,q должны быть простыми");
                }
            }

        }
        private (BigInteger, BigInteger, BigInteger) GCD(BigInteger a, BigInteger b)
        {
            if (a == 0)
                return (b, 0, 1);
            (BigInteger gcd, BigInteger x, BigInteger y) = GCD(b % a, a);
            return (gcd, y - (b / a) * x, x);
        }
        private BigInteger Invmod(BigInteger a, BigInteger m)
        {
            if (a < 0)
                a *= -1;
            if (m < 0)
                m *= -1;
            (BigInteger g, BigInteger x, BigInteger y) = GCD(a, m);
            return g > 1 ? 0 : Mod(x, m);
        }
        public BigInteger Mod(BigInteger a, BigInteger m)
        {
            if (m < 0)
                m *= -1;
            return (a % m + m) % m;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (textbox_d.Text.Length > 0 && textbox_n.Text.Length > 0)
            {
                try
                {
                    BigInteger d = BigInteger.Parse(textbox_d.Text);
                    BigInteger n = BigInteger.Parse(textbox_n.Text);
                    var input = in_decrypt_textbox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    string res = string.Empty;
                    await Task.Run(() =>
                    {
                        res = RSA_Dedoce(input, d, n);
                    });
                    out_decrypt_textbox.Text = res;
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно дешифровать");
                }
            }
        }
    }
}
