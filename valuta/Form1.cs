using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valuta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var client = new System.Net.WebClient();
            System.IO.Stream stream;
            String str;

            stream = client.OpenRead("https://cbr.ru/currency_base/daily/?UniDbQuery.Posted=True&UniDbQuery.To=30.01.2024");
            var reader = new System.IO.StreamReader(stream);
            str = reader.ReadToEnd();

            
            //Возвращаем индекс значения "Название валюты"
            //var i = str.IndexOf("Доллар США");
            //MessageBox.Show(i.ToString());

            //По возвращенному индексу выбираем 40 символов из кода
            //**(40 символов = кол-во элементов кода от названия валюты,
            //**до ее курса, включая тэги)
            //str = str.Substring(i, 40);
            //MessageBox.Show(str);

            //Возвращаем индекс первовстречного символа ">"
            //(последний элемент строки, включающей строковые данные "Название валюты")
            //i = str.IndexOf(">");
            //MessageBox.Show(i.ToString());

            //Переходим на строку, включающую в себя строковые данные "Курс валюты"
            //str = str.Substring(i + 1);
            //MessageBox.Show(str);

            //Возвращвем индекс символа ">" - элемент открытого тега перед "Курс валюты"
            //Выбираем следующие семь символов после данного символа
            //**7 символов - размер числа "Курс валюты"
            //i = str.IndexOf(">");
            //str = str.Substring(i + 1, 7); 
            //MessageBox.Show(str);

            //stream.Close();

            //-----------------------------------------------------------------------------------//

            //double summa = Convert.ToDouble(txtBox_summa.Text.ToString());
            String start_valuta = comBox_startValuta.Text.ToString();
            //string end_valuta = comBox_endValuta.Text.ToString();

            //var search = str.IndexOf(start_valuta.Substring(0, start_valuta.Length - 1));
            MessageBox.Show(start_valuta.Length);
        }
    }
}
