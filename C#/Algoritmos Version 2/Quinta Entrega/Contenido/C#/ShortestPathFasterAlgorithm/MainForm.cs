using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShortestPathFasterAlgorithm
{
    public partial class MainForm : Form
    {
        private bool generate = true;
        private int n, x, y, x1, y1, x2, y2;
        private Algorithm algo = new Algorithm();
        private Color[] colors =
            {
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Orange,
            Color.Purple,
            Color.Brown,
            Color.Turquoise,
            Color.Violet,
            Color.Tan,
            Color.Plum,
            Color.Teal,
            Color.Yellow
            };
        private List<Edge> E;
        private List<Vertex> V;
        private Random random = new Random();

        private void button1_Click_1(object sender, EventArgs e)
        {
            generate = true;
            button1_Click(sender, e);
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generate = false;

            int sId = (int)numericUpDown2.Value;

            if (sId >= V.Count)
            {
                MessageBox.Show("s must be less than n", "Warning Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int[] d;
            List<Vertex> path = algo.SPFA(V, V[sId], out d);

            if (path == null || path.Count != V.Count)
            {
                MessageBox.Show("No shortest path exists", "Warning Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = string.Empty;
                V = null;
                panel1.Invalidate();
                return;
            }

            textBox1.Text += "Id" + " Cost\r\n";
            textBox1.Text += path[0].Id.ToString().PadLeft(2) + " ";
            textBox1.Text += 0.ToString().PadLeft(3) + "\r\n";

            for (int i = 1; i < path.Count; i++)
            {
                bool marked = false;
                Vertex u = path[i - 1], v = path[i];

                textBox1.Text += v.Id.ToString().PadLeft(2) + " ";

                foreach (Edge edge in u.Edges)
                {
                    if (edge.Lt == u && edge.Rt == v)
                    {
                        marked = true;
                        textBox1.Text += edge.Wt.ToString().PadLeft(3) + "\r\n";
                        break;
                    }

                    else if (edge.Lt == v && edge.Rt == u)
                    {
                        marked = true;
                        textBox1.Text += edge.Wt.ToString().PadLeft(3) + "\r\n";
                        break;
                    }
                }

                if (!marked)
                {
                    MessageBox.Show("No shortest path exists", "Warning Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = string.Empty;
                    V = null;
                    panel1.Invalidate();
                    return;
                }
            }

            V = new List<Vertex>(path);
            panel1.Invalidate();
        }


        public MainForm()
        {
            InitializeComponent();
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (generate)
                GenerateDraw(e.Graphics);

            else
                PathDraw(e.Graphics);
        }

        private void calculateXY(int id)
        {
            int Width = panel1.Width;
            int Height = panel1.Height;

            x = Width / 2 + (int)(Width * Math.Cos(2 * id * Math.PI / n) / 4.0);
            y = Height / 2 + (int)(Width * Math.Sin(2 * id * Math.PI / n) / 4.0);
        }

        private void PathDraw(Graphics g)
        {
            if (V != null)
            {
                GenerateDraw(g);

                int Width = panel1.Width;
                int Height = panel1.Height;
                Pen pen = new Pen(Color.Red);

                n = V.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    Vertex u = V[i], v = V[i + 1];

                    calculateXY(u.Id);
                    x1 = x + (Width / 2) / n / 2;
                    y1 = y + (Width / 2) / n / 2;
                    calculateXY(v.Id);
                    x2 = x + (Width / 2) / n / 2;
                    y2 = y + (Width / 2) / n / 2;
                    g.DrawLine(pen, x1, y1, x2, y2);
                }

                for (int i = 0; i < n; i++)
                {
                    Vertex u = V[i];
                    SolidBrush brush = new SolidBrush(colors[u.Id]);

                    calculateXY(u.Id);
                    g.FillEllipse(brush, x, y, (Width / 2) / n, (Width / 2) / n);
                }
            }
        }

        private void GenerateDraw(Graphics g)
        {
            if (V != null)
            {
                int Width = panel1.Width;
                int Height = panel1.Height;
                Pen pen = new Pen(Color.Black);

                n = V.Count;

                for (int i = 0; i < n; i++)
                {
                    Vertex u = V[i];

                    calculateXY(u.Id);
                    x1 = x + (Width / 2) / n / 2;
                    y1 = y + (Width / 2) / n / 2;

                    if (u.Edges != null)
                    {
                        for (int j = 0; j < u.Edges.Count; j++)
                        {
                            Vertex v = u.Edges[j].Rt;

                            calculateXY(v.Id);
                            x2 = x + (Width / 2) / n / 2;
                            y2 = y + (Width / 2) / n / 2;
                            g.DrawLine(pen, x1, y1, x2, y2);
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    Vertex u = V[i];
                    SolidBrush brush = new SolidBrush(colors[u.Id]);

                    calculateXY(u.Id);
                    g.FillEllipse(brush, x, y, (Width / 2) / n, (Width / 2) / n);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numVers = (int)numericUpDown1.Value;

            E = new List<Edge>();
            V = new List<Vertex>();

            for (int i = 0; i < numVers; i++)
            {
                Vertex v = new Vertex(i);

                v.Edges = new List<Edge>();
                V.Add(v);
            }

            for (int i = 0; i < numVers; i++)
            {
                int numEdges = random.Next(numVers - 1);

                while (numEdges < 2)
                    numEdges = random.Next(numVers - 1);

                Vertex v = V[i];

                for (int j = 0; j < numEdges; j++)
                {
                    int id = random.Next(numVers);
                    int wt = random.Next(100);
                    Edge edge;

                    while (wt < 10)
                        wt = random.Next(100);

                    while (id == v.Id)
                        id = random.Next(numVers);

                    edge = new Edge(v, V[id], wt);

                    if (!edge.InList(E))
                        E.Add(edge);

                    edge = new Edge(V[id], v, wt);

                    if (!edge.InList(E))
                        E.Add(edge);
                }
            }

            for (int i = 0; i < E.Count; i++)
            {
                Vertex u = E[i].Lt, v = E[i].Rt;

                u.Edges.Add(new Edge(u, v, E[i].Wt));
                v.Edges.Add(new Edge(v, u, E[i].Wt));
            }

            for (int i = 0; i < V.Count; i++)
            {
                if (V[i].Edges.Count == 0)
                {
                    MessageBox.Show("Generate a new graph", "Warning Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            textBox1.Text = string.Empty;
            textBox1.Text = "Edges(u, v)\r\n";
            textBox1.Text += " u  v wt\r\n";

            for (int i = 0; i < E.Count; i++)
            {
                textBox1.Text += E[i].Lt.Id.ToString().PadLeft(2) + " ";
                textBox1.Text += E[i].Rt.Id.ToString().PadLeft(2) + " ";
                textBox1.Text += E[i].Wt.ToString().PadLeft(2) + "\r\n";
            }

            panel1.Invalidate();
        }
    }
}