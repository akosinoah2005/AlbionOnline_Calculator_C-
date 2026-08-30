using ScottPlot;
using ScottPlot.Reporting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Xml.Serialization;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms.VisualStyles;
using System.Numerics;
using ScottPlot.Plottables;
using ScottPlot.DataSources;
using System.Diagnostics;
namespace Albion_Calcu_C3
{
    public partial class Refine_Charts : UserControl
    {
        private static HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("https://east.albion-online-data.com")
        };

        Form2 _parentform;

        private class data_class
        {
            public int item_count { get; set; }
            public int avg_price { get; set; }
            public DateTime timestamp { get; set; }
        }

        private record class History
        {
            public string? location { get; set; }
            public string? item_id { get; set; }
            public int? quality { get; set; }
            public List<data_class>? data { get; set; }

        };


        private void Load_default()
        {
            cmbLocation.SelectedIndex = 0;
            cmbTscale.SelectedIndex = 0;
            cmbResource.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;


            var axis = plotRefine.Plot.Axes.DateTimeTicksBottom();
            plotRefine.Plot.XLabel($"Time-Scale: {cmbTscale.Text}");
            plotRefine.Plot.YLabel("Price in Silver");
            plotRefine.Refresh();
        }


        private string Get_Type()
        {
            if (cmbType.Text == "Raw")
            {
                switch (cmbResource.SelectedIndex)
                {
                    case 0:
                        return "ORE";
                    case 1:
                        return "HIDE";
                    case 2:
                        return "FIBER";
                    case 3:
                        return "WOOD";
                    case 4:
                        return "ROCK";

                }
            }

            if (cmbType.Text == "Refined")
            {
                switch (cmbResource.SelectedIndex)
                {
                    case 0:
                        return "METALBAR";
                    case 1:
                        return "LEATHER";
                    case 2:
                        return "CLOTH";
                    case 3:
                        return "PLANKS";
                    case 4:
                        return "STONEBLOCK";
                }
            }
            return "";

        }

        private void Plot_data(List<History> fetched_data)
        {

            List<Scatter> scatters = new List<Scatter>();

            plotRefine.Plot.Clear();



            foreach (var item in fetched_data)
            {
                List<DateTime> dates_x = new List<DateTime>();
                List<int> price_y = new List<int>();
                List<int> amount_y = new List<int>();

                foreach (var datas in item.data!)
                {
                    dates_x.Add(datas.timestamp);
                    price_y.Add(datas.avg_price);
                    amount_y.Add(datas.item_count);


                }
                Scatter plotter = plotRefine.Plot.Add.Scatter(dates_x, price_y);
                plotter.LegendText = $"{item.item_id}";
                plotter.LineWidth = 2;
                plotter.MarkerSize = 13;

                plotter.Axes.YAxis = plotRefine.Plot.Axes.Right;

                plotRefine.Plot.XLabel($"Time-Scale: {cmbTscale.Text}");
                plotRefine.Plot.Grid.YAxis = plotRefine.Plot.Axes.Right;
                plotRefine.Plot.Axes.Left.RemoveTickGenerator();


            }

            //Scatter test_plotter = plotRefine.Plot.Add.Scatter(xs, ys);

            var axis = plotRefine.Plot.Axes.DateTimeTicksBottom();
            plotRefine.Plot.Legend.Alignment = Alignment.UpperRight;

            plotRefine.Refresh();

        }
        private async void Get_Api(DateTime now, DateTime past, string checked_ids)
        {
            ///API: api/v2/stats/history/{item_ids}.json?date=2-5-2020&end_date=2-12-2020&locations=Caerleon&qualities=2&time-scale=6

            try
            {
                
                List<History>? fetched_data;
                string url = $"/api/v2/stats/history/{checked_ids}.json?date={past.ToString("M-d-yyyy")}&end_date={now.ToString("M-d-yyyy")}&locations={cmbLocation.Text}&qualities=1&time-scale={cmbTscale.Text} ";
                fetched_data = await sharedClient.GetFromJsonAsync<List<History>>(url);

               
                if (fetched_data != null)
                {
                    MessageBox.Show("Success");

                    Plot_data(fetched_data);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        //EVENTS
        public Refine_Charts(Form2 _parent)
        {
            InitializeComponent();

            _parentform = _parent;
        }

        private void Refine_Charts_Load(object sender, EventArgs e)
        {
            Load_default();


        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (checkTier.CheckedItems.Count == 0)
            {
                MessageBox.Show("Choose a Tier", "No Tier Detected");
                return;
            }

            string ids = "";
            DateTime date_now = DateTime.UtcNow;
            DateTime date_7_ago = DateTime.UtcNow.AddDays(-7);

            foreach (var item in checkTier.CheckedItems)
            {




                if (item.ToString() != null)
                {
                    string[] split_id = (item.ToString())!.Split(".");
                    ids += $"T{split_id[0]}_{Get_Type()}";

                    if (Convert.ToInt16(split_id[1]) > 0)
                    {
                        ids += $"_LEVEL{split_id[1]}@{split_id[1]},";
                    }
                    else
                    {
                        ids += ",";
                    }



                }

            }
            ids = ids.Remove(ids.Length - 1);


            Get_Api(date_now, date_7_ago, ids);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
