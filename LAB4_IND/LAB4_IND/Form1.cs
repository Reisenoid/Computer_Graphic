namespace LAB4_IND
{
    public partial class Form1 : Form
    {
        private double scale = 20;
        private double offsetX = 0; 
        private double offsetY = 0; 
        private double[,] currentTransformation = IdentityMatrix();

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearDrawing()
        {
            pictureBox1.Image = null;
            pictureBox1.Refresh();
        }

        private static double[,] IdentityMatrix()
        {
            return new double[,]
            {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawSurface();
        }

        private IEnumerable<double[]> GeneratePoints()
        {
            double step = 0.1;
            for (double x = -10; x <= 10; x += step)
            {
                for (double y = -10; y <= 10; y += step)
                {
                    double z = Math.Pow(Math.Sin(x), 2) + Math.Cos(y);
                    yield return new double[] { x, y, z, 1 };
                }
            }
        }

        private void DrawSurface()
        {
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            Bitmap bmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                foreach (var originalPoint in GeneratePoints())
                {
                    double[] transformedPoint = new double[4];
                    for (int i = 0; i < 4; i++)
                    {
                        transformedPoint[i] = 0;
                        for (int j = 0; j < 4; j++)
                        {
                            transformedPoint[i] += currentTransformation[i, j] * originalPoint[j];
                        }
                    }

                    
                    double screenX = width / 2 + (transformedPoint[0] + offsetX) * scale;
                    double screenY = height / 2 - (transformedPoint[1] + offsetY) * scale;

                    if (screenX >= 0 && screenX < width && screenY >= 0 && screenY < height)
                    {
                        bmp.SetPixel((int)screenX, (int)screenY, Color.Blue);
                    }
                }
            }

            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double angle))
            {
                MessageBox.Show("Введите угол поворота (число)");
                return;
            }

            double angleRad = angle * Math.PI / 180;
            double cosA = Math.Cos(angleRad);
            double sinA = Math.Sin(angleRad);

            double[,] rotationMatrix = GetRotationMatrix(cosA, sinA);
            currentTransformation = MatrixMultiply(currentTransformation, rotationMatrix);

            DrawSurface();
        }

        private double[,] GetRotationMatrix(double cosA, double sinA)
        {
            if (radioButton1.Checked) // Вокруг оси X
            {
                return new double[,]
                {
                    { 1, 0, 0, 0 },
                    { 0, cosA, sinA, 0 },
                    { 0, -sinA, cosA, 0 },
                    { 0, 0, 0, 1 }
                };
            }
            else if (radioButton2.Checked) // Вокруг оси Y
            {
                return new double[,]
                {
                    { cosA, 0, -sinA, 0 },
                    { 0, 1, 0, 0 },
                    { sinA, 0, cosA, 0 },
                    { 0, 0, 0, 1 }
                };
            }
            else // Вокруг оси Z
            {
                return new double[,]
                {
                    { cosA, sinA, 0, 0 },
                    { -sinA, cosA, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 }
                };
            }
        }

        private double[,] MatrixMultiply(double[,] a, double[,] b)
        {
            double[,] result = new double[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return result;
        }

        private void button3_Click_1(object sender, EventArgs e) // очистка
        {
            ClearDrawing();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out double scaleFactor) || scaleFactor <= 0)
            {
                MessageBox.Show("Введите число больше 0");
                return;
            }

            double[,] scaleMatrix = new double[,]
            {
                { scaleFactor, 0, 0, 0 },
                { 0, scaleFactor, 0, 0 },
                { 0, 0, scaleFactor, 0 },
                { 0, 0, 0, 1 }
            };

            currentTransformation = MatrixMultiply(currentTransformation, scaleMatrix);
            DrawSurface();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            offsetY += 0.5; // Движение вверх
            DrawSurface();
        }

        private void button6_Click(object sender, EventArgs e) // Движение вниз
        {
            offsetY -= 0.5; 
            DrawSurface();
        }

        private void button7_Click(object sender, EventArgs e) // Движение вправо
        {
            offsetX += 0.5; 
            DrawSurface();
        }

        private void button8_Click(object sender, EventArgs e) // Движение влево
        {
            offsetX -= 0.5; 
            DrawSurface();
        }
    }
}