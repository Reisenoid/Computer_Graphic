namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] kv = new int[4, 3]; // ������� ����
        int[,] osi = new int[4, 3]; // ������� ��������� ����
        int[,] matr_sdv = new int[3, 3]; //������� ��������������
        int k, l; // �������� ������� ������

        bool f = true;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Init_kvadrat()
        {
            kv[0, 0] = -50; kv[0, 1] = 0; kv[0, 2] = 1;
            kv[1, 0] = 0; kv[1, 1] = 50; kv[1, 2] = 1;
            kv[2, 0] = 50; kv[2, 1] = 0; kv[2, 2] = 1;
            kv[3, 0] = 0; kv[3, 1] = -50; kv[3, 2] = 1;
        }

        private void Init_matr_preob(int k1, int l1)
        {
            matr_sdv[0, 0] = 1; matr_sdv[0, 1] = 0; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = 0; matr_sdv[1, 1] = 1; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }

        private void Init_osi()
        {
            osi[0, 0] = -200; osi[0, 1] = 0; osi[0, 2] = 1;
            osi[1, 0] = 200; osi[1, 1] = 0; osi[1, 2] = 1;
            osi[2, 0] = 0; osi[2, 1] = 200; osi[2, 2] = 1;
            osi[3, 0] = 0; osi[3, 1] = -200; osi[3, 2] = 1;

        }

        private int[,] Multiply_matr(int[,] a, int[,] b)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            int[,] r = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    r[i, j] = 0;
                    for (int ii = 0; ii < m; ii++)
                    {
                        r[i, j] += a[i, ii] * b[ii, j];
                    }
                }
            }
            return r;
        }

        private void Draw_Kv()
        {

            Init_kvadrat(); //������������� ������� ����
            Init_matr_preob(k, l); //������������� ������� ��������������
            int[,] kv1 = Multiply_matr(kv, matr_sdv); //������������ ������

            Pen myPen = new Pen(Color.Blue, 2);// ���� ����� � ������

            //������� ����� ������ Graphics (����������� ���������) �� pictureBox
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            // ������ 1 ������� ��������
            g.DrawLine(myPen, kv1[0, 0], kv1[0, 1], kv1[1, 0], kv1[1, 1]);
            // ������ 2 ������� ��������
            g.DrawLine(myPen, kv1[1, 0], kv1[1, 1], kv1[2, 0], kv1[2, 1]);
            // ������ 3 ������� ��������
            g.DrawLine(myPen, kv1[2, 0], kv1[2, 1], kv1[3, 0], kv1[3, 1]);
            // ������ 4 ������� ��������
            g.DrawLine(myPen, kv1[3, 0], kv1[3, 1], kv1[0, 0], kv1[0, 1]);
            g.Dispose();// ����������� ��� �������, ��������� � ����������
            myPen.Dispose(); //����������� �������, ��������� � Pen

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //�������� pictureBox
            k = pictureBox1.Width / 2;
            l = pictureBox1.Height / 2;
            //����� ���������� � ��������
            Draw_Kv();
        }

        private void Draw_osi()
        {
            Init_osi();
            Init_matr_preob(k, l);
            int[,] osi1 = Multiply_matr(osi, matr_sdv);
            Pen myPen = new Pen(Color.Red, 1);// ���� ����� � ������
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            // ������ ��� ��
            g.DrawLine(myPen, osi1[0, 0], osi1[0, 1], osi1[1, 0], osi1[1,
            1]);
            // ������ ��� ��
            g.DrawLine(myPen, osi1[2, 0], osi1[2, 1], osi1[3, 0], osi1[3,
            1]);
            g.Dispose();
            myPen.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k = pictureBox1.Width / 2;
            l = pictureBox1.Height / 2;
            Draw_osi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            k += 5; //��������� ���������������� �������� ������� ������
            Draw_Kv(); //����� ����������
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;

            button8.Text = "����";

            if (f == true)
                timer1.Start();

            else
            {
                timer1.Stop();
                button8.Text = "�����";
            }

            f = !f;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            k++;
            Draw_Kv();
            Thread.Sleep(100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            k -= 5; // ����� ����� �� ��� OX (���������� ���������� X)
            Draw_Kv(); // ����������� ��������
        }

        private void button6_Click(object sender, EventArgs e)
        {
            l += 5; // ����� ���� �� ��� OY (���������� ���������� Y)
            Draw_Kv(); // ����������� ��������
        }

        private void button7_Click(object sender, EventArgs e)
        {
            l -= 5; // ����� ����� �� ��� OY (���������� ���������� Y)
            Draw_Kv(); // ����������� ��������
        }
    }
}
