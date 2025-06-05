using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPRTestNew
{
    public partial class Form2 : Form
    {
        int count = Form1.question;

        int quection_count;
        int correct_answers;
        int wrong_answers;

        string[] array;

        int correct_answers_numbers;
        int selected_response;

        System.IO.StreamReader Read = null;

        public Form2()
        {
            InitializeComponent();
        }
        void Start()
        {
            var encoding = System.Text.Encoding.GetEncoding(65001);
            //if (count == 7)
            //{
            //    try
            //    {
            //        Read = new System.IO.StreamReader
            //            (System.IO.Directory.GetCurrentDirectory() + @"\t.txt", encoding);

            //        this.Text = Read.ReadLine();

            //        quection_count = 0;
            //        correct_answers = 0;
            //        wrong_answers = 0;

            //        array = new String[21];
            //    }

            //    catch (Exception)
            //    {

            //        MessageBox.Show("Ошибка1");
            //    }
            //}
            //if (count == 8)
            //{
            //    try
            //    {
            //        Read = new System.IO.StreamReader
            //            (System.IO.Directory.GetCurrentDirectory() + @"\t2.txt", encoding);

            //        this.Text = Read.ReadLine();
            //        quection_count = 0;
            //        correct_answers = 0;
            //        wrong_answers = 0;
            //        array = new String[21];
            //    }

            //    catch (Exception)
            //    {

            //        MessageBox.Show("Ошибка1");
            //    }
            //}
            //if (count == 9)
            //{
            //    try
            //    {
            //        Read = new System.IO.StreamReader
            //            (System.IO.Directory.GetCurrentDirectory() + @"\t3.txt", encoding);

            //        this.Text = Read.ReadLine();
            //        quection_count = 0;
            //        correct_answers = 0;
            //        wrong_answers = 0;
            //        array = new String[21];
            //    }

            //    catch (Exception)
            //    {

            //        MessageBox.Show("Ошибка1");
            //    }
            //}
            //if (count == 10)
            //{
            //    try
            //    {
            //        Read = new System.IO.StreamReader
            //            (System.IO.Directory.GetCurrentDirectory() + @"\t4.txt", encoding);

            //        this.Text = Read.ReadLine();
            //        quection_count = 0;
            //        correct_answers = 0;
            //        wrong_answers = 0;
            //        array = new String[21];
            //    }

            //    catch (Exception)
            //    {

            //        MessageBox.Show("Ошибка1");
            //    }
            //}
            if (count == 11)
            {
                //try
                //{
                //    //Read = new System.IO.StreamReader
                //    //    (System.IO.Directory.GetCurrentDirectory() + @"\t5.txt", encoding);
                //    string filePath = Path.Combine("text", "t5.txt");

                //    string fileContent = File.ReadAllText(filePath, encoding);
                //    //this.Text = Read.ReadLine();
                //    //quection_count = 0;
                //    //correct_answers = 0;
                //    //wrong_answers = 0;
                //    //array = new String[21];
                //    string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);
                //    using (Read = new System.IO.StreamReader(fullPath, encoding))
                //    {
                //        this.Text = Read.ReadLine();
                //        quection_count = 0;
                //        correct_answers = 0;
                //        wrong_answers = 0;
                //        array = new string[21];
                //    }
                //}

                //catch (Exception)
                //{

                //    MessageBox.Show("Ошибка1");
                //}
              /*  System.IO.StreamReader Read = null;*/ // Declare Read here to make it accessible in Questionssss and close it correctly
                try
                {
                    string filePath = Path.Combine("text", "t5.txt");
                    string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);

                    if (!File.Exists(fullPath))
                    {
                        MessageBox.Show("Файл t5.txt не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }


                    Read = new System.IO.StreamReader(fullPath, encoding); 
                    this.Text = Read.ReadLine(); 
                    quection_count = 0;
                    correct_answers = 0;
                    wrong_answers = 0;
                    array = new string[21];

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.ToString());
                }
               
            }


            Questionssss();
        }
        void Questionssss()
        {
            //label1.Text = Convert.ToString(Read.ReadLine());

            //radioButton1.Text = Read.ReadLine();
            //radioButton2.Text = Read.ReadLine();
            //radioButton3.Text = Read.ReadLine();
            //radioButton4.Text = Read.ReadLine();

            //correct_answers_numbers = int.Parse( Read.ReadLine() );

            //radioButton1.Checked = false;
            //radioButton2.Checked = false;
            //radioButton3.Checked = false;
            //radioButton4.Checked = false;

            //button2.Enabled = false;

            //quection_count=quection_count+1;
            //if (Read.EndOfStream == true) button2.Text = "Завершить";
            try
            {
                if (Read == null)  // Проверяем, был ли StreamReader успешно создан
                {
                    MessageBox.Show("Ошибка: Не удалось загрузить вопросы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //  Возможно, нужно добавить логику завершения работы викторины или перезагрузки.
                    return;
                }

                label1.Text = Read.ReadLine();

                radioButton1.Text = Read.ReadLine();
                radioButton2.Text = Read.ReadLine();
                radioButton3.Text = Read.ReadLine();
                radioButton4.Text = Read.ReadLine();

                correct_answers_numbers = int.Parse(Read.ReadLine());

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

                button2.Enabled = false;

                quection_count = quection_count + 1;
                if (Read.EndOfStream)
                {
                    button2.Text = "Завершить";
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении вопроса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Console.WriteLine(ex.ToString());
                button2.Enabled = false; 
            }
            
        }
        void Sost(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.Focus();
            RadioButton p = (RadioButton)sender;
            var t = p.Name;
            selected_response = int.Parse(t.Substring(11));
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }   
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selected_response==correct_answers_numbers)
            {
                correct_answers++;
            }
            if(selected_response!=correct_answers) 
            { 
                wrong_answers++;

                array[wrong_answers] = label1.Text;
            }
            if(button2.Text == "Начать заного")
            {
                button2.Text = "След. вопрос";

                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                Start();
                return;
            }
            if (button2.Text == "Завершить")
            {
                Read.Close();

                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;

                label1.Text = String.Format("Тестирование завершено.\n" +
                    "Правильных ответов: {0} из {1}.\n" +
                    "Набранные баллы: {2:F2}.", correct_answers,
                    quection_count, (correct_answers * 5.0F) / quection_count);

                button2.Text = "Начать заного";

                

                if (wrong_answers != 0)
                {
                    MessageBox.Show("Тестирование завершено");
                }
            }
                if (button2.Text == "След. вопрос")
                {
                    Questionssss();
                }
        }

        private void Form2_Load(object sender, EventArgs e)
        { 
            button1.Text = "Выйти";
            button2.Text = "След. вопрос";

            radioButton1.CheckedChanged += new EventHandler(Sost);
            radioButton2.CheckedChanged += new EventHandler(Sost);
            radioButton3.CheckedChanged += new EventHandler(Sost);
            radioButton4.CheckedChanged += new EventHandler(Sost);

            Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
