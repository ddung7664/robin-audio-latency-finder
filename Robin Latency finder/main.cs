using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robin_Latency_finder
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private MMDeviceEnumerator AudioDeviceEnumerator = new MMDeviceEnumerator();

        private MMDevice Device;

        private bool inputStatus = false;

        private void MainScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R && inputStatus == false)
            {
             waitInput();
             inputStatus = true;
            }
        }
        private Stopwatch stopwatch = new Stopwatch();
        private Stopwatch tester = new Stopwatch();

        private ISampleProvider Beep = new SignalGenerator()
        {
            Gain = 1,
            Frequency = 440,
            Type = SignalGeneratorType.Sin
        }.Take(TimeSpan.FromMilliseconds(50));

        private WasapiOut BeepEvent;

        private void main_Load(object sender, EventArgs e)
        {
            foreach (var endpoint in AudioDeviceEnumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active))
            {
                cb_deviceList.Items.Add(endpoint.FriendlyName);
            }

            if (cb_deviceList.Items.Count > 0)
            {
                cb_deviceList.SelectedIndex = 0;
            }


            Device = AudioDeviceEnumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).First(o => o.FriendlyName == cb_deviceList.Text);
        }

        private ISampleProvider GetBeep()
        {
            return Beep;
        }

        public long seungsoo = 0;

        private async void bt_runTest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++) { 
                runTest();
                inputStatus = false;
                await Task.Delay(1000);
                if (stopwatch.ElapsedMilliseconds > 980)
                {
                    missed();
                }
            }
            seungsoo = seungsoo / 15;
            lb_latency.Text = seungsoo + "ms";
            stopwatch.Reset();
        }

        private async void runTest()
        {
            await Task.Delay(1000);

            BeepEvent = new WasapiOut(Device, AudioClientShareMode.Shared, true, 50);

            BeepEvent.Init(Beep);

            BeepEvent.Play();

            stopwatch.Start();
        }

        private void waitInput ()
        {
            //tester.Start();
            stopwatch.Stop();
            
            Beep = new SignalGenerator()
            {
                Gain = 1,
                Frequency = 440,
                Type = SignalGeneratorType.Sin
            }.Take(TimeSpan.FromMilliseconds(50));

            if (stopwatch.ElapsedMilliseconds > 800)
            {
                lb_nowDelay.Text = "Too Slow!";
            }
            else
            {
                seungsoo = seungsoo + stopwatch.ElapsedMilliseconds;
                lb_nowDelay.Text = stopwatch.ElapsedMilliseconds + "ms";
            }

            stopwatch.Reset();
            //tester.Stop();
            //lb_voidRun.Text = tester.ElapsedMilliseconds.ToString();
        }

        private void missed()
        {
            stopwatch.Stop();
            Beep = new SignalGenerator()
            {
                Gain = 1,
                Frequency = 440,
                Type = SignalGeneratorType.Sin
            }.Take(TimeSpan.FromMilliseconds(50));
            stopwatch.Reset();
            lb_nowDelay.Text = "missed!";
        }

        private void lb_license_Click(object sender, EventArgs e)
        {
            license license = new license();
            license.Owner = this;
            license.Show();
        }
    }
}

