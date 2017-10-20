using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace GMap.NETChacher
{
    public partial class Form1 : Form
    {

        private void gMapControl1_Load(object sender, EventArgs e)
        {

            gMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            GMap.NET.MapProviders.OpenStreetMapProvider.UserAgent = "IE";

            gMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            GMaps.Instance.OptimizeMapDb(null);
            //TODO:Define Your Own location to store the cache file
            gMapControl1.CacheLocation = @"C:\Users\Inno3\Desktop\";
            //
            gMapControl1.Zoom = 14;
            gMapControl1.Size = new Size(this.Width, this.Height);
            gMapControl1.ShowCenter = false;
            gMapControl1.Position = new GMap.NET.PointLatLng(45.385, -74.08);

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader file;
            //TODO: Choose your own csv file!
            file = new System.IO.StreamReader(@"C:\Git\GMap.NETChacher\GMap.NETChacher\waypoints.csv");
            Stopwatch sw = new Stopwatch(); // sw cotructor

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] values = line.Split(',');
                gMapControl1.Position = new GMap.NET.PointLatLng(Convert.ToDouble(values[1]), Convert.ToDouble(values[2]));
                gMapControl1.Zoom = 14;
                sw.Start(); // starts the stopwatch
                for (int i = 0; ; i++)
                {
                    if (i % 100000 == 0) // if in 100000th iteration (could be any other large number
                                         // depending on how often you want the time to be checked) 
                    {
                        sw.Stop(); // stop the time measurement
                        if (sw.ElapsedMilliseconds > 1000) // check if desired period of time has elapsed
                        {
                            sw.Reset();
                            break; // if more than 5000 milliseconds have passed, stop looping and return
                                   // to the existing code
                        }
                        else
                        {
                            sw.Start(); // if less than 5000 milliseconds have elapsed, continue looping
                                        // and resume time measurement
                        }
                    }
                }
                gMapControl1.Zoom = 13;
                sw.Start(); // starts the stopwatch
                for (int i = 0; ; i++)
                {
                    if (i % 100000 == 0) // if in 100000th iteration (could be any other large number
                                         // depending on how often you want the time to be checked) 
                    {
                        sw.Stop(); // stop the time measurement
                        if (sw.ElapsedMilliseconds > 1000) // check if desired period of time has elapsed
                        {
                            sw.Reset();
                            break; // if more than 5000 milliseconds have passed, stop looping and return
                                   // to the existing code
                        }
                        else
                        {
                            sw.Start(); // if less than 5000 milliseconds have elapsed, continue looping
                                        // and resume time measurement
                        }
                    }
                }
                gMapControl1.Zoom = 12;
                sw.Start(); // starts the stopwatch
                for (int i = 0; ; i++)
                {
                    if (i % 100000 == 0) // if in 100000th iteration (could be any other large number
                                         // depending on how often you want the time to be checked) 
                    {
                        sw.Stop(); // stop the time measurement
                        if (sw.ElapsedMilliseconds > 1000) // check if desired period of time has elapsed
                        {
                            sw.Reset();
                            break; // if more than 5000 milliseconds have passed, stop looping and return
                                   // to the existing code
                        }
                        else
                        {
                            sw.Start(); // if less than 5000 milliseconds have elapsed, continue looping
                                        // and resume time measurement
                        }
                    }
                }
                gMapControl1.Zoom = 11;
                sw.Start(); // starts the stopwatch
                for (int i = 0; ; i++)
                {
                    if (i % 100000 == 0) // if in 100000th iteration (could be any other large number
                                         // depending on how often you want the time to be checked) 
                    {
                        sw.Stop(); // stop the time measurement
                        if (sw.ElapsedMilliseconds > 1000) // check if desired period of time has elapsed
                        {
                            sw.Reset();
                            break; // if more than 5000 milliseconds have passed, stop looping and return
                                   // to the existing code
                        }
                        else
                        {
                            sw.Start(); // if less than 5000 milliseconds have elapsed, continue looping
                                        // and resume time measurement
                        }
                    }
                }
                gMapControl1.Zoom = 10;
                sw.Start(); // starts the stopwatch
                for (int i = 0; ; i++)
                {
                    if (i % 100000 == 0) // if in 100000th iteration (could be any other large number
                                         // depending on how often you want the time to be checked) 
                    {
                        sw.Stop(); // stop the time measurement
                        if (sw.ElapsedMilliseconds > 1000) // check if desired period of time has elapsed
                        {
                            sw.Reset();
                            break; // if more than 5000 milliseconds have passed, stop looping and return
                                   // to the existing code
                        }
                        else
                        {
                            sw.Start(); // if less than 5000 milliseconds have elapsed, continue looping
                                        // and resume time measurement
                        }
                    }
                }
                gMapControl1.Zoom = 15;
                sw.Start(); // starts the stopwatch
                for (int i = 0; ; i++)
                {
                    if (i % 100000 == 0) // if in 100000th iteration (could be any other large number
                                         // depending on how often you want the time to be checked) 
                    {
                        sw.Stop(); // stop the time measurement
                        if (sw.ElapsedMilliseconds > 1000) // check if desired period of time has elapsed
                        {
                            sw.Reset();
                            break; // if more than 5000 milliseconds have passed, stop looping and return
                                   // to the existing code
                        }
                        else
                        {
                            sw.Start(); // if less than 5000 milliseconds have elapsed, continue looping
                                        // and resume time measurement
                        }
                    }
                }
            }
        }
    }
}
