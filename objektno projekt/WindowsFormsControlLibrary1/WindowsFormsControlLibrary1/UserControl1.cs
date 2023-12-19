﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1 : UserControl
    {
        int broj_labela = 5;
        int broj_botuna = 2 * 5;
        int broj_NOR = 100;
        int broj_NAND = 100;
        private Label[] labele;
        private DraggableLabel[] nor;
        private DraggableLabel[] nand;
        private Button[] botuni_X;
        private Button[] botuni_ON;
        private Button[] botuni_boja;
        private CircularLabel[] lights;
        Color[] colors = new Color[5];
        int number_of_lights = 5;
        int trenutni_br = 1;
        int trenutni_br_nili = 0;
        int trenutni_br_ni = 0;
        private Point offset;
        private int cp_counter = 0;
        private bool isDrawing = false;
        private List<List<Point>> allLines = new List<List<Point>>();
        private List<Point> currentLine = new List<Point>();
        private Pen linePen = new Pen(Color.Black, 3);
        private List<Color> lineColors = new List<Color>();
        int yvalue = 0;
        private DraggableLabel[] podrjesenja_labele;
        private int[] podrjesenja_izlazi;
        int broj_vrata = 0;


        public UserControl1()
        {
            InitializeComponent();
            this.MouseDown += MainForm_MouseDown;
            this.MouseMove += MainForm_MouseMove;
            this.MouseUp += MainForm_MouseUp;
            this.Paint += MainForm_Paint;
            colors[0] = Color.Black;
            colors[1] = Color.Red;
            colors[2] = Color.Blue;
            colors[3] = Color.Yellow;
            colors[4] = Color.Purple;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        { 
            broj_varijabli.Text = trenutni_br.ToString();
            inicijalizacija_labela();
            inicijalizacija_botuna_X();
            inicijalizacija_botuna_ON();
            postavljanje_NOR();
            postavljanje_NAND();
            labela_svijetlo(number_of_lights);
            inicijalizacija_botuna_boja();
            for (int i = 0; i < 5; i++)
            {
                botuni_ON[i].Click += botuni_ON_click;
            }
            for (int i = 0; i < trenutni_br_ni; i++)
            {
                nor[i].MouseDown += LabelMouseDown;
                nor[i].MouseMove += LabelMouseMove;
            }
            for (int i = 0; i < trenutni_br_nili; i++)
            {
                nand[i].MouseDown += LabelMouseDown;
                nand[i].MouseMove += LabelMouseMove;
            }
        }

        private void labela_svijetlo(int number_of_lights)
        {
            lights = new CircularLabel[number_of_lights];

            for (int i = 0; i < number_of_lights; i++)
            {
                lights[i] = new CircularLabel();
                lights[i].Location = new Point(598 - i * 30, 405);
                lights[i].BringToFront();
                lights[i].BackColor = Color.Red;
                this.Controls.Add(lights[i]);
                this.Controls.SetChildIndex(lights[i], 0);//postavlja svijetla ispred drugih labela(send to front)
            }
        }

        private void inicijalizacija_botuna_X()
        {
            botuni_X = new Button[broj_botuna];
            int br_X = 0;
            for (int i = 0; i < broj_botuna; i++)
            {
                botuni_X[i] = new Button();
                if (i % 2 == 0)
                {
                    botuni_X[i].Text = "X" + br_X;
                    br_X++;
                }
                else
                {
                    botuni_X[i].Text = "!X" + (br_X - 1);
                }
                botuni_X[i].Location = new System.Drawing.Point(50, 18 + i / 2 * 20 + i * 25);
                botuni_X[i].Visible = false;
                botuni_X[i].Font = new System.Drawing.Font(botuni_X[i].Font.FontFamily, 8, System.Drawing.FontStyle.Bold);
                botuni_X[i].Size = new Size(30, 30);
                botuni_X[i].TextAlign = ContentAlignment.MiddleCenter;
                botuni_X[i].BackColor = Color.LightBlue;
                this.Controls.Add(botuni_X[i]);
            }
            botuni_X[0].Visible = true;
            botuni_X[1].Visible = true;
        }

        private void inicijalizacija_botuna_ON()
        {
            botuni_ON = new Button[5];
            for (int i = 0; i < 5; i++)
            {
                botuni_ON[i] = new Button();
                botuni_ON[i].Location = new System.Drawing.Point(590 - i * 30, 420);
                botuni_ON[i].Visible = true;
                botuni_ON[i].Font = new System.Drawing.Font(botuni_ON[i].Font.FontFamily, 8, System.Drawing.FontStyle.Bold);
                botuni_ON[i].Size = new Size(25, 20);
                botuni_ON[i].TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(botuni_ON[i]);
                this.Controls.SetChildIndex(botuni_ON[i], 0);
            }
        }

        private void inicijalizacija_botuna_boja()
        {
            botuni_boja = new Button[5];
            for (int i = 0; i < 5; i++)
            {
                botuni_boja[i] = new Button();
                botuni_boja[i].Location = new System.Drawing.Point(340 + 18 * i, 410);
                botuni_boja[i].Visible = true;
                botuni_boja[i].Size = new Size(18, 30);
                botuni_boja[i].BackColor = colors[i];
                botuni_boja[i].Click += BotuniBoja_Click;
                this.Controls.Add(botuni_boja[i]);
                this.Controls.SetChildIndex(botuni_boja[i], 0);
            }
        }

        private void inicijalizacija_labela()
        {
            labele = new Label[broj_labela];
            for (int i = 0; i < broj_labela; i++)
            {
                labele[i] = new Label();
                labele[i].Text = "X" + i;
                labele[i].Location = new System.Drawing.Point(0, (i + 1) * 20 + i * 50);
                labele[i].Visible = false;
                labele[i].Font = new System.Drawing.Font(labele[i].Font.FontFamily, 10, System.Drawing.FontStyle.Bold);
                labele[i].Size = new Size(50, 50);
                labele[i].TextAlign = ContentAlignment.MiddleCenter;
                labele[i].BackColor = Color.LightBlue;
                labele[i].BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(labele[i]);
            }
            labele[0].Visible = true;
        }

        private void CheckLabelLocation(Label selectedLabel)
        {
            // Check the location of the draggable label
            MessageBox.Show($"Label Location: {selectedLabel.Location}");
            // You can perform additional logic based on the label's location
        }

        private void postavljanje_NOR()
        {
            nor = new DraggableLabel[broj_NOR];

            for (int i = 0; i < broj_NOR; i++)
            {
                nor[i] = new DraggableLabel();
                nor[i].Visible = false;
                nor[i].Location = new Point(350, 150);
                nor[i].Tag = "nor" + i;

                try
                {
                    Image img = Resource1.NOR5;
                    nor[i].Image = img;
                    nor[i].AutoSize = false;
                    nor[i].Size = img.Size;
                    this.Controls.Add(nor[i]);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void postavljanje_NAND()
        {
            nand = new DraggableLabel[broj_NAND];

            for (int i = 0; i < broj_NAND; i++)
            {
                nand[i] = new DraggableLabel();
                nand[i].Visible = false;
                nand[i].Location = new Point(350, 150);
                nand[i].Tag = "nand" + i;

                try
                {
                    Image img = Resource1.NAND6;
                    nand[i].Image = img;
                    nand[i].AutoSize = false;
                    nand[i].Size = img.Size;
                    this.Controls.Add(nand[i]);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void botuni_ON_click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int i = Array.IndexOf(botuni_ON, clickedButton);
            
            if (lights[i].BackColor == Color.Green)
                lights[i].BackColor = Color.Red;
            else if (lights[i].BackColor == Color.Red)
                lights[i].BackColor = Color.Green;

            string binary = "00000";
            for(int j = 0; j < number_of_lights; j++)
            {
                if (lights[j].BackColor == Color.Green)
                    binary = binary.Substring(0, number_of_lights - 1 - j) + '1' + binary.Substring(number_of_lights - j);
            }

            cp_counter = Convert.ToInt32(binary, 2);
        }

        private void inkrement_Click(object sender, EventArgs e)
        {
            if (trenutni_br < 5)
                trenutni_br++;
            broj_varijabli.Text = trenutni_br.ToString();
            for (int i = 0; i < trenutni_br; i++)
            {
                labele[i].Visible = true;
                botuni_X[i * 2].Visible = true;
                botuni_X[i * 2 + 1].Visible = true;
            }
        }

        private void dekrement_Click(object sender, EventArgs e)
        {
            if (trenutni_br > 1)
                trenutni_br--;
            broj_varijabli.Text = trenutni_br.ToString();
            for (int i = trenutni_br; i < 5; i++)
            {
                labele[i].Visible = false;
                botuni_X[i * 2].Visible = false;
                botuni_X[i * 2 + 1].Visible = false;
            }
        }

        private void inkrement_nili_Click(object sender, EventArgs e)
        {
            if (trenutni_br_nili < 100)
                trenutni_br_nili++;
            nor[trenutni_br_nili - 1].Visible = true;

        }

        private void inkrement_ni_Click(object sender, EventArgs e)
        {
            if (trenutni_br_ni < 100)
                trenutni_br_ni++;
            nand[trenutni_br_ni - 1].Visible = true;
        }

        private void BotuniBoja_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Color selectedColor = clickedButton.BackColor;
            linePen.Color = selectedColor;
        }

        private void LabelMouseDown(object sender, MouseEventArgs e)
        {
            Label selectedLabel = (Label)sender;
            offset = e.Location;
            selectedLabel.BringToFront();
        }

        private void LabelMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label selectedLabel = (Label)sender;
                // Calculate the new position based on the mouse offset
                int newX = selectedLabel.Left + e.X - offset.X;
                int newY = selectedLabel.Top + e.Y - offset.Y;

                // Update the label's position
                selectedLabel.Location = new Point(newX, newY);
            }
        }

        private void reset_lights_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < number_of_lights; i++)
                lights[i].BackColor = Color.Red;
            cp_counter = 0;
        }

        private void counting_point_Click(object sender, EventArgs e)
        {
            cp_counter++;
            string binaryi = Convert.ToString(cp_counter, 2);
            binaryi = binaryi.PadLeft(5, '0');
            for (int i = 0; i < number_of_lights; i++)
            {
                if (binaryi[binaryi.Length-i-1] == '1')
                    lights[i].BackColor = Color.Green;
                else
                    lights[i].BackColor = Color.Red;
            }
            if (cp_counter == 32)
                cp_counter = 0;
        }

        private void add_cabel_Click(object sender, EventArgs e)
        {
            isDrawing = true;
            currentLine.Clear();
            linePen.Color = GetNextLineColor();
        }

        private Color GetNextLineColor()
        {
            // If there are existing lines, return the color of the last line
            if (lineColors.Count > 0)
            {
                return lineColors.Last();
            }
            else
            {
                // Return the default color if no lines have been drawn yet
                return linePen.Color;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Check if right-click occurred on a line
                CheckDeleteLine(e.Location);
            }
            else if (isDrawing && e.Button == MouseButtons.Left)
            {
                currentLine.Add(e.Location);
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Continue drawing while the left mouse button is held down.
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                currentLine.Add(e.Location);
                this.Invalidate(); // Force the form to redraw.
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                // Save the current line to the list of all lines.
                allLines.Add(new List<Point>(currentLine));
                // Save the color of the current line to the list of line colors.
                lineColors.Add(linePen.Color);
                currentLine.Clear();

                broj_vrata++;
            }
        }

        private bool LineIntersectsRectangle(LineSegment line, Control control)
        {
            Rectangle rect = control.Bounds;

            // Check intersection with top side of the rectangle
            if (LineIntersectsLine(line, new LineSegment(rect.Location, new Point(rect.Right, rect.Top))))
                return true;

            // Check intersection with right side of the rectangle
            if (LineIntersectsLine(line, new LineSegment(new Point(rect.Right, rect.Top), new Point(rect.Right, rect.Bottom))))
                return true;

            // Check intersection with bottom side of the rectangle
            if (LineIntersectsLine(line, new LineSegment(new Point(rect.Right, rect.Bottom), new Point(rect.Left, rect.Bottom))))
                return true;

            // Check intersection with left side of the rectangle
            if (LineIntersectsLine(line, new LineSegment(new Point(rect.Left, rect.Bottom), rect.Location)))
                return true;

            return false;
        }

        private bool LineIntersectsLine(LineSegment line1, LineSegment line2)
        {
            double denominator = ((line2.End.Y - line2.Start.Y) * (line1.End.X - line1.Start.X)) - ((line2.End.X - line2.Start.X) * (line1.End.Y - line1.Start.Y));
            double numerator1 = ((line2.End.X - line2.Start.X) * (line1.Start.Y - line2.Start.Y)) - ((line2.End.Y - line2.Start.Y) * (line1.Start.X - line2.Start.X));
            double numerator2 = ((line1.End.X - line1.Start.X) * (line1.Start.Y - line2.Start.Y)) - ((line1.End.Y - line1.Start.Y) * (line1.Start.X - line2.Start.X));

            // Detect coincident lines
            if (denominator == 0) return numerator1 == 0 && numerator2 == 0;

            double r = numerator1 / denominator;
            double s = numerator2 / denominator;

            return (r >= 0 && r <= 1) && (s >= 0 && s <= 1);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < allLines.Count; i++)
            {
                if (allLines[i].Count > 1)
                {
                    // Use the corresponding color from lineColors
                    using (Pen currentLinePen = new Pen(lineColors[i], 3))
                    {
                        e.Graphics.DrawLines(currentLinePen, allLines[i].ToArray());
                    }
                }
            }

            // Draw the current line as well.
            if (currentLine.Count > 1)
            {
                // Use the current color from linePen
                e.Graphics.DrawLines(linePen, currentLine.ToArray());
            }
        }

        private int Value_X(int i)
        {
            if (lights[i / 2].BackColor == Color.Green && i % 2 == 0)
                return 1;
            else if (lights[i / 2].BackColor == Color.Red && i % 2 == 0)
                return 0;
            else if (lights[i / 2].BackColor == Color.Green && i % 2 != 0)
                return 0;
            else if (lights[i / 2].BackColor == Color.Red && i % 2 != 0)
                return 1;
            return 0;
        }

        private int CalculateNOT(int result)
        {
            if (result == 1)
                return 0;
            else
                return 1;
        }

        private int CalculateOR(LineSegment line)
        {
            for(int i = 0; i < int.Parse(broj_varijabli.Text) * 2; i++)
            {
                if(LineIntersectsRectangle(line, botuni_X[i]) == true)
                {
                    if (Value_X(i) == 1)
                        return 1;
                }
            }
            return 0;
        }

        private int CalculateAND(LineSegment line)
        {
            for (int i = 0; i < int.Parse(broj_varijabli.Text) * 2; i++)
            {
                if (LineIntersectsRectangle(line, botuni_X[i]) == true)
                {
                    if (Value_X(i) == 0)
                        return 0;
                }
            }
            return 1;
        }

        private void CheckDeleteLine(Point clickPoint)
        {
            for (int i = 0; i < allLines.Count; i++)
            {
                if (allLines[i].Count > 1 && LineContainsPoint(allLines[i], clickPoint))
                {
                    // Show a context menu to delete the line
                    ShowDeleteLineContextMenu(clickPoint, i);
                    return;
                }
            }
        }

        private bool LineContainsPoint(List<Point> line, Point point)
        {
            for (int i = 1; i < line.Count; i++)
            {
                Point p1 = line[i - 1];
                Point p2 = line[i];
                if (DistanceFromPointToLine(point, p1, p2) < 5) // You can adjust the threshold for proximity
                {
                    return true;
                }
            }
            return false;
        }

        private double DistanceFromPointToLine(Point point, Point lineStart, Point lineEnd)
        {
            double A = point.X - lineStart.X;
            double B = point.Y - lineStart.Y;
            double C = lineEnd.X - lineStart.X;
            double D = lineEnd.Y - lineStart.Y;

            double dot = A * C + B * D;
            double len_sq = C * C + D * D;
            double param = dot / len_sq;

            double xx, yy;

            if (param < 0)
            {
                xx = lineStart.X;
                yy = lineStart.Y;
            }
            else if (param > 1)
            {
                xx = lineEnd.X;
                yy = lineEnd.Y;
            }
            else
            {
                xx = lineStart.X + param * C;
                yy = lineStart.Y + param * D;
            }

            double dx = point.X - xx;
            double dy = point.Y - yy;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        private void ShowDeleteLineContextMenu(Point location, int lineIndex)
        {
            ContextMenu deleteMenu = new ContextMenu();
            MenuItem deleteItem = new MenuItem("Delete Line");
            deleteItem.Click += (sender, e) => DeleteLine(lineIndex);
            deleteMenu.MenuItems.Add(deleteItem);

            Point clientLocation = PointToClient(location); // Convert to client coordinates
            clientLocation.Y += 180; // Adjust the Y-coordinate to move the menu lower
            deleteMenu.Show(this, clientLocation);
        }

        private void DeleteLine(int lineIndex)
        {
            // Remove the selected line and its color from the lists
            allLines.RemoveAt(lineIndex);
            lineColors.RemoveAt(lineIndex);

            // Redraw the form
            Invalidate();
        }

    }

    public class DraggableLabel : Label
    {
        private Point offset;
        private ContextMenuStrip contextMenu;

        public DraggableLabel()
        {
            InitializeContextMenu();
        }

        private void InitializeContextMenu()
        {
            contextMenu = new ContextMenuStrip();
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Remove");
            deleteItem.Click += DeleteItem_Click;
            contextMenu.Items.Add(deleteItem);

            this.ContextMenuStrip = contextMenu;
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            // Cast the sender to ToolStripMenuItem
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;

            // Get the parent context menu strip
            ContextMenuStrip parentMenu = clickedItem.Owner as ContextMenuStrip;

            // Get the owner control (DraggableLabel)
            DraggableLabel labelToRemove = parentMenu.SourceControl as DraggableLabel;

            // Remove the label from its parent
            if (labelToRemove != null)
            {
                labelToRemove.Parent.Controls.Remove(labelToRemove);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            offset = e.Location;
            BringToFront();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                int newX = Left + e.X - offset.X;
                int newY = Top + e.Y - offset.Y;

                //restricting movement area for draggable labels
                newX = Math.Max(Math.Min(newX, 630 - Width), 100);
                newY = Math.Max(Math.Min(newY, 370 - Height), 0);

                Location = new Point(newX, newY);
            }
        }


    }

    public class LineSegment
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public LineSegment(Point start, Point end)
        {
            Start = start;
            End = end;
        }
    }

    public class CircularLabel : Label
    {
        public CircularLabel()
        {
            this.AutoSize = false;
            this.Size = new Size(10, 10);
            this.BackColor = Color.Blue;
            SetCircularRegion();
        }

        private void SetCircularRegion()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }

}
