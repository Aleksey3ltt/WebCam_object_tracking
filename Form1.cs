using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WebCam_object_tracking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox2.SelectedIndex = 2; comboBox2.Enabled = false;
            comboBox3.SelectedIndex = 2; comboBox3.Enabled = false;
            InitializeDataGridView();
            trackBar1.Enabled = false; trackBar1.Value = 10;
            trackBar2.Enabled = false; trackBar2.Value = 70;
            trackBar3.Enabled = false; trackBar3.Value = 5;
            trackBar4.Enabled = false; trackBar4.Value = 88;
            trackBar5.Enabled = false; trackBar5.Value = 70;
            textBox1.Enabled = false;  textBox1.Text = "0.1";
            textBox2.Enabled = false;  textBox2.Text = "0.70";
            textBox3.Enabled = false;  textBox3.Text = "0.05";
            textBox4.Enabled = false;  textBox4.Text = "0.88";
            textBox5.Enabled = false;  textBox5.Text = "0.7";

            minVal1 = Convert.ToDouble(trackBar1.Value) / 100;
            maxVal1 = Convert.ToDouble(trackBar2.Value) / 100;
            minVal2 = Convert.ToDouble(trackBar3.Value) / 100;
            maxVal2 = Convert.ToDouble(trackBar4.Value) / 100;
            maxValValid = Convert.ToDouble(trackBar5.Value) / 100;
        }

        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice videoSource;
        Rectangle rectMouse;    
        Rectangle rect;

        Point locationXY;
        Point locationX1Y1;

        bool mouseDown = false;
        Bitmap bitmapSampleFirst;
        Bitmap bitmapSample;
        Bitmap img;
        private bool button2WasClicked = false;
        //private bool button3WasClicked = false;

        int frameCount = 0;
        int count = 0;
        int countX;
        int numberCount;
        double fps=0;

        double minVal1;             //first template matching - minimum element values
        double maxVal1;             //first template matching -  maximum element values
        double minVal2;             //second template matching - minimum element values
        double maxVal2;             //second template matching -  maximum element values
        double maxValValid;         //second template matching - validation
        double maxValFirst0=0;      //second template matching - validation
        double maxValSecond = 0.0;  //second template matching -  maximum element values and their positions.

        Queue<int> myQueueCount;
        Queue<int> myQueueX;
        Queue<int> myQueueY;
        Queue<int> myQueueCountOK;
        Queue<int> myQueueXOK;
        Queue<int> myQueueYOK;

        //array coordinates - all (red cross)
        int[] arrayCount; 
        int[] arrayX; 
        int[] arrayY;
        //array coordinates - success (green cross)
        int[] arrayCountOK; 
        int[] arrayXOK;
        int[] arrayYOK;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (button2WasClicked == false)
            {
                mouseDown = true;
                locationXY = e.Location;
                button2.Enabled = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                locationX1Y1 = e.Location;
                mouseDown = false;
                button2.Enabled = true;
                pictureBox2.Image = bitmapSampleFirst;
                pictureBox3.Image = null;
                label3.Enabled = false;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                textBox1.Enabled = true; trackBar1.Enabled = true;
                textBox2.Enabled = true; trackBar2.Enabled = true;
                textBox3.Enabled = true; trackBar3.Enabled = true;
                textBox4.Enabled = true; trackBar4.Enabled = true;
                textBox5.Enabled = true; trackBar5.Enabled = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                locationX1Y1 = e.Location;
                Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 4);
            if (button2WasClicked == false)
            {
               e.Graphics.DrawRectangle(pen, GetRect());
            }
        }

        private Rectangle GetRect()
        {
            rectMouse = new Rectangle();
            rectMouse.X = Math.Min(locationXY.X, locationX1Y1.X);
            rectMouse.Y = Math.Min(locationXY.Y, locationX1Y1.Y);
            rectMouse.Width = Math.Abs(locationXY.X - locationX1Y1.X);
            rectMouse.Height = Math.Abs(locationXY.Y - locationX1Y1.Y);
            return rectMouse;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = 25;
            dataGridView1.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Arial", 8, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevices)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(CaptureDevices[comboBox1.SelectedIndex].MonikerString);
            videoSource.NewFrame += videoSource_NewFrame;
            videoSource.Start();
            label3.Enabled = true;
        }

        private void videoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            img = (Bitmap)eventArgs.Frame.Clone();
            if (rectMouse.Width>0 & rectMouse.Height>0)
            {
                var cloned = new Bitmap(img).Clone(rectMouse, img.PixelFormat);
                bitmapSampleFirst = new Bitmap(cloned, new Size(rectMouse.Width, rectMouse.Height));
                cloned.Dispose();
            }
            if (button2WasClicked == false)
                pictureBox1.Image = img;
            else
            {
                Image<Bgr, byte> source = img.ToImage<Bgr, byte>();
                var template = new Bitmap(pictureBox2.Image).ToImage<Bgr, byte>();
                
                //first template
                double minValFirst = 0.0;
                double maxValFirst = 0.0;
                Point minLocFirst = new Point();
                Point maxLocFirst = new Point();

                //template express validation
                double minValFirst0 = 0.0;
                Point minLocFirst0 = new Point();
                Point maxLocFirst0 = new Point();
                
                var watch = System.Diagnostics.Stopwatch.StartNew();
                
                if (frameCount == count)
                {
                    count += 1;

                    //first template matching
                    Mat imgOutFirst = new Mat();
                    CvInvoke.MatchTemplate(source, template, imgOutFirst, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);
                    CvInvoke.MinMaxLoc(imgOutFirst, ref minValFirst, ref maxValFirst, ref minLocFirst, ref maxLocFirst);
                    rect = new Rectangle(maxLocFirst, template.Size);
                    int centerX = rect.X + rect.Width / 2;
                    int centerY = rect.Y + rect.Height / 2;
                    string coordRect = "(" + centerX + ", " + centerY + ")";

                    CvInvoke.PutText(source, "Count:        " + Convert.ToString(count), new Point(10, 15), FontFace.HersheySimplex, 0.4, new MCvScalar(255, 0, 0));
                    CvInvoke.PutText(source, "FPS:          " + Convert.ToString(fps), new Point(10, 30), FontFace.HersheySimplex, 0.4, new MCvScalar(255, 0, 0));
                    CvInvoke.PutText(source, "Coord:        " + coordRect, new Point(10, 45), FontFace.HersheySimplex, 0.4, new MCvScalar(255, 0, 0));
                    CvInvoke.PutText(source, "MaxVal1:      " + Convert.ToString(Math.Round(maxValFirst, 3)), new Point(10, 60), FontFace.HersheySimplex, 0.4, new MCvScalar(255, 0, 0));
                    CvInvoke.PutText(source, "MaxVal2:      " + Convert.ToString(Math.Round(maxValSecond, 3)), new Point(10, 75), FontFace.HersheySimplex, 0.4, new MCvScalar(255, 0, 0));
                    CvInvoke.PutText(source, "MaxValid:     " + Convert.ToString(Math.Round(maxValFirst0, 3)), new Point(10, 90), FontFace.HersheySimplex, 0.4, new MCvScalar(255, 0, 0));
                    CvInvoke.DrawMarker(source, new Point(centerX, centerY), new MCvScalar(0, 0, 255), MarkerTypes.Diamond);

                    myQueueCount.Enqueue(count);
                    myQueueX.Enqueue(centerX);
                    myQueueY.Enqueue(centerY);

                    if (count > numberCount)
                    {
                        myQueueCount.Dequeue();
                        myQueueX.Dequeue();
                        myQueueY.Dequeue();

                        arrayCount = myQueueCount.ToArray();
                        arrayX = myQueueX.ToArray();
                        arrayY = myQueueY.ToArray();
                    }
                    else 
                    {
                        arrayCount = myQueueCount.ToArray();
                        arrayX = myQueueX.ToArray();
                        arrayY = myQueueY.ToArray();
                    }
                    for (int i = 0; i < arrayCount.Length; i++ )
                    {
                        CvInvoke.DrawMarker(source, new Point(arrayX[i], arrayY[i]), new MCvScalar(0, 0, 255), MarkerTypes.Cross, 4, 1);
                    }

                    //second & express template matching
                    if (frameCount%countX == 1)
                    {
                        var cloned = new Bitmap(img).Clone(rect, img.PixelFormat);
                        Bitmap bitmapSampleSecond = new Bitmap(cloned, new Size(rect.Width, rect.Height));
                        cloned.Dispose();
                        pictureBox3.Image = bitmapSampleSecond;
                        var template2 = new Bitmap(bitmapSampleSecond).ToImage<Bgr, byte>();
                        Image<Bgr, byte> templateExp = bitmapSample.ToImage<Bgr, byte>();
                        Mat imgOutSecond= new Mat();
                        Mat imgOutExp = new Mat();

                        double minValSecond = 0.0;
                        //double maxValSecond = 0.0;
                        Point minLocSecond = new Point();
                        Point maxLocSecond = new Point();
 
                        CvInvoke.MatchTemplate(source, template2, imgOutSecond, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);
                        CvInvoke.MinMaxLoc(imgOutSecond, ref minValSecond, ref maxValSecond, ref minLocSecond, ref maxLocSecond);
                        CvInvoke.MatchTemplate(template2, templateExp, imgOutExp, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);
                        CvInvoke.MinMaxLoc(imgOutExp, ref minValFirst0, ref maxValFirst0, ref minLocFirst0, ref maxLocFirst0);

                        Rectangle rectSecond = new Rectangle(maxLocSecond, template2.Size);
                        if (maxLocSecond==maxLocFirst & minValSecond <= minVal2 & maxValSecond >= maxVal2 & maxValFirst0>=maxValValid)
                            {
                            CvInvoke.Rectangle(source, rectSecond, new MCvScalar(255, 0, 255), 10);
                            pictureBox1.Image = source.AsBitmap();
                            pictureBox2.Image = template2.AsBitmap();
                        }
                        else
                        {
                            pictureBox2.Image = bitmapSample;
                        }
                    }

                    //first template matching - success (green cross)
                    if (minValFirst <= minVal1 & maxValFirst >= maxVal1 & maxValFirst0 >= maxValValid)
                    {
                        CvInvoke.Rectangle(source, rect, new MCvScalar(0, 255, 0), 3);
                        CvInvoke.DrawMarker(source, new Point(centerX, centerY), new MCvScalar(0, 255, 0), MarkerTypes.Diamond);
                        pictureBox1.Image = source.AsBitmap();
                        myQueueCountOK.Enqueue(count);
                        myQueueXOK.Enqueue(centerX);
                        myQueueYOK.Enqueue(centerY);

                        if (myQueueCountOK.Count > numberCount)
                        {
                            myQueueCountOK.Dequeue();
                            myQueueXOK.Dequeue();
                            myQueueYOK.Dequeue();

                            arrayCountOK = myQueueCountOK.ToArray();
                            arrayXOK = myQueueXOK.ToArray();
                            arrayYOK = myQueueYOK.ToArray();
                        }
                        else
                        {
                            arrayCountOK = myQueueCountOK.ToArray();
                            arrayXOK = myQueueXOK.ToArray();
                            arrayYOK = myQueueYOK.ToArray();
                        }
                        for (int i = 0; i < arrayCountOK.Length; i++)
                        {
                            CvInvoke.DrawMarker(source, new Point(arrayXOK[i], arrayYOK[i]), new MCvScalar(0, 255, 0), MarkerTypes.Cross, 4, 1);
                        }
                        GetSource(arrayCountOK, arrayXOK, arrayYOK);
                    }
                    else
                    {
                        pictureBox1.Image = source.AsBitmap();
                        pictureBox2.Image = bitmapSample;
                    }
                    watch.Stop();
                    fps = Math.Round(1/watch.Elapsed.TotalSeconds, 2);
                }
                frameCount++;
            }
        }

        private void GetSource(int[] arrayCount, int[] arrayX, int[] arrayY)
        {
            Array.Reverse(arrayCount);
            Array.Reverse(arrayX);
            Array.Reverse(arrayY);

            for (int i = 0; i < arrayCount.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = arrayCount[i];
                dataGridView1.Rows[i].Cells[1].Value = arrayX[i];
                dataGridView1.Rows[i].Cells[2].Value = arrayY[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2WasClicked = true;
            button3.Enabled = true;
            button2.Enabled = false;
            bitmapSample= new Bitmap(pictureBox2.Image);

            myQueueCount = new Queue<int>();
            myQueueX = new Queue<int>();
            myQueueY = new Queue<int>();

            myQueueCountOK = new Queue<int>();
            myQueueXOK = new Queue<int>();
            myQueueYOK = new Queue<int>();

            count = 0;
            frameCount = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2WasClicked = false;
            //button3WasClicked = true;
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
            button3.Enabled = false;
            button2.Enabled = true;
            label3.Enabled = true;
            myQueueCount.Clear();
            myQueueX.Clear();
            myQueueY.Clear();
            myQueueCountOK.Clear();
            myQueueXOK.Clear();
            myQueueYOK.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCount = comboBox2.SelectedItem.ToString();
            countX = Convert.ToInt32(selectedCount);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var value = Convert.ToDouble(trackBar1.Value) /100;
            textBox1.Text = Convert.ToString(value);
            minVal1 = Convert.ToDouble(value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            var value = Convert.ToDouble(trackBar2.Value) / 100;
            textBox2.Text = Convert.ToString(value);
            maxVal1 = Convert.ToDouble(value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            var value = Convert.ToDouble(trackBar3.Value) / 100;
            textBox3.Text = Convert.ToString(value);
            minVal2 = Convert.ToDouble(value);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            var value = Convert.ToDouble(trackBar4.Value) / 100;
            textBox4.Text = Convert.ToString(value);
            maxVal2 = Convert.ToDouble(value);
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            var value = Convert.ToDouble(trackBar5.Value) / 100;
            textBox5.Text = Convert.ToString(value);
            maxValValid = Convert.ToDouble(value);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCount = comboBox3.SelectedItem.ToString();
            numberCount = Convert.ToInt32(selectedCount);
        }
    }
}