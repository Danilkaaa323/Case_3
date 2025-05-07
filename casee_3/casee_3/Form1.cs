using BestDelivery;

namespace casee_3
{
    public partial class Form1 : Form
    {
        public BestDelivery.Point depot = new BestDelivery.Point { X = 0, Y = 0 };
        public List<BestDelivery.Point> points = new List<BestDelivery.Point>();
        public bool depotSet = false;
        public bool addingDepot = false;
        public bool addingPoint = false;
        public List<int> currentRoute = new List<int>();
        public Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            drawingPanel.BorderStyle = BorderStyle.FixedSingle;
            drawingPanel.MouseClick += DrawingPanel_MouseClick;
        }

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            if (!depotSet)
            {
                MessageBox.Show("Пожалуйста, установите склад.");
                return;
            }

            if (points.Count < 1)
            {
                MessageBox.Show("Пожалуйста, добавьте хотя бы одну точку.");
                return;
            }

            Order[] orders = points.Select((p, i) => new Order { ID = i, Destination = p }).ToArray();
            List<int> route = new List<int>();
            route.Add(-1); 

            List<BestDelivery.Point> remainingPoints = new List<BestDelivery.Point>(points);
            BestDelivery.Point currentPoint = depot;

            while (remainingPoints.Count > 0)
            {
                int nearestPointIndex = FindNearestPoint(currentPoint, remainingPoints);
                route.Add(points.IndexOf(remainingPoints[nearestPointIndex]));
                currentPoint = remainingPoints[nearestPointIndex];
                remainingPoints.RemoveAt(nearestPointIndex);
            }
            route.Add(-1); 

            if (!RoutingTestLogic.IsValidRoute(route, orders.ToList(), depot))
            {
                richTextBoxOutput.Text = "Маршрут не валиден!";
                return;
            }
            currentRoute = route;

            double totalDistance = RoutingTestLogic.CalculateRouteCost(route, orders.ToList(), depot);
            totalDistance = Math.Round(totalDistance, 2);

            if (totalDistance == -1.0)
            {
                richTextBoxOutput.Text = "Ошибка при расчете стоимости маршрута.";
                return;
            }

            richTextBoxOutput.Text = $"Маршрут (ID): {string.Join(" -> ", route)}\n";
            richTextBoxOutput.Text += $"Стоимость: {totalDistance} руб.";
            drawingPanel.Invalidate();
        }

        private void ButtonAddDepot_Click(object sender, EventArgs e)
        {
            addingDepot = true;
            addingPoint = false;
        }

        private void ButtonAddPoint_Click(object sender, EventArgs e)
        {
            addingPoint = true;
            addingDepot = false;
        }
        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (addingDepot)
            {
                depot = new BestDelivery.Point { X = e.X, Y = e.Y };
                depotSet = true;
                addingDepot = false;
                drawingPanel.Invalidate();
            }
            else if (addingPoint)
            {
                points.Add(new BestDelivery.Point { X = e.X, Y = e.Y });
                addingPoint = false;
                drawingPanel.Invalidate();
            }
        }
        public int FindNearestPoint(BestDelivery.Point currentPoint, List<BestDelivery.Point> points)
        {
            double minDistance = double.MaxValue;
            int nearestPointIndex = -1;

            for (int i = 0; i < points.Count; i++)
            {
                double distance = RoutingTestLogic.CalculateDistance(currentPoint, points[i]); 
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestPointIndex = i;
                }
            }

            return nearestPointIndex;
        }
        public void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pointPen = new Pen(Color.DarkOrange, 3);
            Pen depotPen = new Pen(Color.Red, 5);
            Pen routePen = new Pen(Color.Black, 2);
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            if (depotSet)
            {
                g.DrawEllipse(depotPen, (float)depot.X - 5, (float)depot.Y - 5, 10, 10);
            }

            if (currentRoute.Count > 0 && points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    g.DrawEllipse(pointPen, (float)points[i].X - 3, (float)points[i].Y - 3, 6, 6);
                    int routeIndex = currentRoute.IndexOf(i);
                    if (routeIndex != -1)
                    {
                        g.DrawString(routeIndex.ToString(), drawFont, drawBrush, (float)points[i].X + 5, (float)points[i].Y - 8);
                    }
                }

                BestDelivery.Point? prevPoint = null;
                foreach (int index in currentRoute)
                {
                    BestDelivery.Point currentPoint;
                    if (index == -1)
                    {
                        currentPoint = depot;
                    }
                    else if (index >= 0 && index < points.Count) 
                    {
                        currentPoint = points[index];
                    }
                    else
                    {
                        continue; 
                    }

                    if (prevPoint != null)
                    {
                        g.DrawLine(routePen, (float)prevPoint.Value.X, (float)prevPoint.Value.Y, (float)currentPoint.X, (float)currentPoint.Y);
                    }
                    prevPoint = currentPoint;
                }
            }
            else
            {
                foreach (var point in points)
                {
                    g.DrawEllipse(pointPen, (float)point.X - 3, (float)point.Y - 3, 6, 6);
                }
            }
        }

        private void ButtonRemoveDepot_Click(object sender, EventArgs e)
        {
            depotSet = false;
            currentRoute.Clear();
            drawingPanel.Invalidate();
        }

        private void ButtonRemovePoint_Click(object sender, EventArgs e)
        {
            if (points.Count > 0)
            {
                points.RemoveAt(points.Count - 1);
                currentRoute.Clear();
                drawingPanel.Invalidate();
            }
        }

        private void ButtonGetOrder_Click(object sender, EventArgs e)
        {
            int x = random.Next(0, drawingPanel.Width);
            int y = random.Next(0, drawingPanel.Height);

            BestDelivery.Point newPoint = new BestDelivery.Point { X = x, Y = y };
            points.Add(newPoint);
            drawingPanel.Invalidate();
        }
    }
}
