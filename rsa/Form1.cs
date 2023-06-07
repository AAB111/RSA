using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMilleraRabina;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] characters = new char[] { '#', 'A', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 
                                                'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                '8', '9', '0' };

        private bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
        private long Calculate_e(long m)
        {
            long e = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (e % i == 0)) //если имеют общие делители
                {
                    e--;
                    i = 1;
                }

            return e;
        }
        private List<string> RSA_Endoce(string s, long e, long n)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }
        private string RSA_Dedoce(List<string> input, long d, long n)
        {
            string result = "";

            BigInteger bi;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                int index = Convert.ToInt32(bi.ToString());

                result += characters[index].ToString();
            }

            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textbox_p.Text.Length >0 && textbox_q.Text.Length > 0)
            {
                long p = Convert.ToInt64(textbox_p.Text);
                long q = Convert.ToInt64(textbox_q.Text);
                if(Class1.IsSimple(p,(long)Math.Truncate(Math.Log(p))) && Class1.IsSimple(q, (long)Math.Truncate(Math.Log(q))))
                {
                    string s = in_encrypt_textbox.Text;

                    long n = p * q;
                    long fi = (p-1) * (q-1);
                    long e_ = Calculate_e(fi);
                    long d = Calculate_d(e_, fi);

                    var res = RSA_Endoce(s.ToUpper(), e_, n);
                    textbox_d.Text = d.ToString();
                    textbox_n.Text = n.ToString();
                    string res_str = string.Join(" ", res);
                    in_decrypt_textbox.Text = res_str;
                    out_encrypt_textbox.Text = res_str;
                }
                else
                {
                    MessageBox.Show("p, q должны быть простыми");
                }
            }
            else
            {
                MessageBox.Show("Введите числа");
            }

        }
        private long Calculate_d(long e, long m)
        {
            long d = 10;

            while (true)
            {
                if ((d * e) % m == 1)
                    break;
                else
                    d++;
            }
            return d;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textbox_d.Text.Length > 0 && textbox_n.Text.Length > 0)
            {
                try
                {
                    long d = long.Parse(textbox_d.Text);
                    long n = long.Parse(textbox_n.Text);
                    var input = in_decrypt_textbox.Text.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToList();
                    string res = RSA_Dedoce(input,d,n);
                    out_decrypt_textBox.Text = res;
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно дешифровать");
                }
            }
        }
    }
}
