using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaos_game
{
    public partial class Form1 : Form
    {
        Point[] points;
        PointF offset;
        PointF pos;
        Bitmap img;
        RectangleF areaToDraw;
        bool mousePressed;
        float scale;
        const float factor = 1.2f;

        private Point[] GetPoints(int n, Point[] initPoints, Point startPoint, int a = 1, int b = 1, int c = 1)
        {
            // P(A) = a / (a + b + c), P(B) = b / (a + b + c), P(c) = c / (a + b + c)

            Point[] pts = new Point[n + initPoints.Length + 1];
            for (int i = 0; i < initPoints.Length; i++)
                pts[i] = initPoints[i];
            pts[initPoints.Length] = startPoint;

            Point[] init = new Point[a + b + c];
            for (int i = 0; i < a; i++)
                init[i] = initPoints[0];
            for (int i = a; i < a + b; i++)
                init[i] = initPoints[1];
            for (int i = a + b; i < a + b + c; i++)
                init[i] = initPoints[2];

            Random rand = new Random();

            for (int i = initPoints.Length + 1; i < n; i++) {
                Point p = init[rand.Next() % init.Length];
                Point m = new Point((p.X + pts[i-1].X) / 2, (p.Y + pts[i-1].Y) / 2);
                pts[i] = m;
            }

            return pts;
        }

        public Form1()
        {
            InitializeComponent();

            pos = new PointF(0f, 0f);
            mousePressed = false;
            scale = 1f;
            posA.Text = "0, 0";
            posB.Text = "500, 0";
            posC.Text = "0, 500";
            posX_0.Text = "0, 0";
            iterations.Text = "100000";

            TrackBar[] tb = new TrackBar[]{ cntA, cntB, cntC };
            foreach (var t in tb) {
                t.Minimum = 1;
                t.Maximum = 50;
                t.Value = 1;
            }

            probs.Text = string.Format("Probability of A = {0:f}, B = {1:f}, C = {2:f}.", 1.0/3.0, 1.0/3.0, 1.0/3.0);

            points = GetPoints(100000, new Point[]{ new Point(0, 0), new Point(500, 0), new Point(0, 500) }, new Point(0, 0), cntA.Value, cntB.Value, cntC.Value);
            DrawPoints();

            mainCanvas.BackColor = Color.White;
            mainCanvas.Paint += DrawImage;
            mainCanvas.MouseWheel += ChangeScale;

            mainCanvas.MouseDown += StartDrag;
            mainCanvas.MouseMove += Drag;
            mainCanvas.MouseUp += EndDrag;

            mainCanvas.Select();
        }
        
        private void StartDrag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                pos = e.Location;
                mousePressed = true;
            }
        }

        private void Drag(object sender, MouseEventArgs e)
        {
            if (mousePressed) {
                float dx = (e.Location.X - pos.X) * scale * scale;
                float dy = (e.Location.Y - pos.Y) * scale * scale;

                offset.X -= dx;
                offset.Y -= dy;

                areaToDraw.X = offset.X / scale;
                areaToDraw.Y = img.Height - img.Height*scale + offset.Y / scale;

                pos = e.Location;

                mainCanvas.Refresh();
            }
        }

        private void EndDrag(object sender, MouseEventArgs e)
        {
            if (mousePressed) {
                float dx = (e.Location.X - pos.X) * scale * scale;
                float dy = (e.Location.Y - pos.Y) * scale * scale;

                offset.X -= dx;
                offset.Y -= dy;

                areaToDraw.X = offset.X / scale;
                areaToDraw.Y = img.Height - img.Height*scale + offset.Y / scale;

                pos = e.Location;

                mousePressed = false;
                mainCanvas.Refresh();
            }
        }

        private void ChangeScale(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                scale /= factor;
            else if (e.Delta < 0)
                scale *= factor;

            areaToDraw = new RectangleF(0, img.Height - img.Height*scale, img.Width*scale, img.Height*scale);

            areaToDraw.X = offset.X / scale;
            areaToDraw.Y = img.Height - img.Height*scale + offset.Y / scale;
            mainCanvas.Invalidate();
        }

        private void DrawImage(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            g.DrawImage(
                img,
                new RectangleF(new PointF(0f, 0f), mainCanvas.Size),
                areaToDraw,
                GraphicsUnit.Pixel
                );
        }

        private void DrawPoints()
        {
            img = new Bitmap(mainCanvas.Width, mainCanvas.Height);
            scale = 1f;
            areaToDraw = new RectangleF(0, img.Height - img.Height*scale, img.Width*scale, img.Height*scale);
            offset = new Point(0, 0);

            var g = Graphics.FromImage(img);
            Pen pen = new Pen(Color.Blue, 1);
            
            foreach (Point p in points) 
                g.DrawRectangle(pen, p.X, mainCanvas.Height - p.Y, 1, 1);

            //mainCanvas.Image = img;
        }
        
        private void draw_Click(object sender, EventArgs e)
        {
            TextBox[] txts = new TextBox[]{ posA, posB, posC, posX_0 };

            try {
                Point[] startPts = new Point[4];
                for (int i = 0; i < 4; i++) {
                    string[] s = txts[i].Text.Split(new char[]{ ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    startPts[i] = new Point(int.Parse(s[0]), int.Parse(s[1]));
                }

                int iterCnt = int.Parse(iterations.Text);

                int a = cntA.Value;
                int b = cntB.Value;
                int c = cntC.Value;
                int sum = a + b + c;

                probs.Text = string.Format("Probability of A = {0:f}, B = {1:f}, C = {2:f}.", 1.0*a/sum, 1.0*b/sum, 1.0*c/sum);

                points = GetPoints(iterCnt, new Point[]{ startPts[0], startPts[1], startPts[2] }, startPts[3], cntA.Value, cntB.Value, cntC.Value);
                DrawPoints();

                mainCanvas.Select();
                mainCanvas.Invalidate();
            } catch (Exception) {
                MessageBox.Show("Enter correct integer positions of A, B, C, X_0 and count of iterations.");

                posA.Text = "0, 0";
                posB.Text = "500, 0";
                posC.Text = "0, 500";
                posX_0.Text = "0, 0";
                iterations.Text = "100000";
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(mainCanvas.Height, mainCanvas.Width);

            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "jpeg|*.jpg|bmp|*.bmp|gif|*.gif|png|*.png";
            svd.Title = "Save an image";
            svd.ShowDialog();

            if (!string.IsNullOrEmpty(svd.FileName)) {
                mainCanvas.DrawToBitmap(bmp, mainCanvas.Bounds);
                bmp.Save(svd.FileName);
            }

            mainCanvas.Select();
        }

        private void mainCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                for (int i = 0; i < points.Length; i++) {
                    points[i].X *= 2;
                    points[i].Y *= 2;
                }
                mainCanvas.Invalidate();
            } else if (e.Button == MouseButtons.Right) {
                for (int i = 0; i < points.Length; i++) {
                    points[i].X /= 2;
                    points[i].Y /= 2;
                }
                mainCanvas.Invalidate();
            }
        }
    }
}
