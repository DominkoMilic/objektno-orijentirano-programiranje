using System;
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
        private CircularLabel[] lights;
        int broj_svijetala = 5;
        int trenutni_br = 1;
        int trenutni_br_nili = 0;
        int trenutni_br_ni = 0;
        private Point offset;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

            broj_varijabli.Text = trenutni_br.ToString();
            inicijalizacija_labela();
            inicijalizacija_botuna_X();
            inicijalizacija_botuna_ON();
            postavljanje_NOR();
            postavljanje_NAND();
            labela_svijetlo(broj_svijetala);
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
                lights[i].Location = new Point(478 + i * 30, 405);
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
                botuni_ON[i].Location = new System.Drawing.Point(470 + i * 30, 420);
                botuni_ON[i].Visible = true;
                botuni_ON[i].Font = new System.Drawing.Font(botuni_ON[i].Font.FontFamily, 8, System.Drawing.FontStyle.Bold);
                botuni_ON[i].Size = new Size(25, 20);
                botuni_ON[i].TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(botuni_ON[i]);
                this.Controls.SetChildIndex(botuni_ON[i], 0);
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

            if (i >= 0 && i < lights.Length)
            {
                if (lights[i].BackColor == Color.Green)
                    lights[i].BackColor = Color.Red;
                else if (lights[i].BackColor == Color.Red)
                    lights[i].BackColor = Color.Green;
            }
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

        private void LabelMouseDown(object sender, MouseEventArgs e)
        {
            Label selectedLabel = (Label)sender;
            offset = e.Location;
            selectedLabel.BringToFront();
        }

        private Rectangle draggableArea = new Rectangle(50, 50, 450, 370);

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
            ToolStripMenuItem hideItem = new ToolStripMenuItem("Remove");
            hideItem.Click += HideItem_Click;
            contextMenu.Items.Add(hideItem);

            this.ContextMenuStrip = contextMenu;
        }

        private void HideItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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
