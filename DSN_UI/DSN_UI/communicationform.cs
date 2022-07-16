using DSN_UI.ServiceReference1;
using DSN_UI.ServiceReference2;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;

namespace DSN_UI
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Single,
        UseSynchronizationContext = false)]
    public partial class communicationform : Form, ILaunchVehicleServiceCallback, IPayloadServiceCallback
    {
        private LaunchVehicleServiceClient lvClient;
        private PayloadServiceClient pClient;
        private SynchronizationContext _uiSyncContext = null;
        private string currentVehicleSelected;
        private string currentPayloadSelected;

        public communicationform()
        {
            InitializeComponent();
            InstanceContext instanceContext = new InstanceContext(this);
            _uiSyncContext = SynchronizationContext.Current;
            lvClient = new LaunchVehicleServiceClient(instanceContext, "NetTcpBinding_ILaunchVehicleService");
            pClient = new PayloadServiceClient(instanceContext, "NetTcpBinding_IPayloadService");
            lvClient.Open();
            pClient.Open();
            ShowDashboardData();
            LoadData();
            HideSpaceCraftBtns();
            HidePayloadBtns();
        }

        private void LoadData()
        {
            this.SelectLaunchVehicleComboBox.Items.Clear();
            this.LaunchVehicleComboBox.Items.Clear();
            this.PayloadComboBox.Items.Clear();
            LaunchVehicleDto[] list = lvClient.GetVehicles();
            PayloadDto[] payLoadlist = pClient.GetPayloads();

            foreach (LaunchVehicleDto item in list)
            {
                if (item.IsActive)
                {
                    this.SelectLaunchVehicleComboBox.Items.Add(item.Name);
                }
                else
                {
                    this.LaunchVehicleComboBox.Items.Add(item.Name);
                }
            }
            this.SelectLaunchVehicleComboBox.SelectedItem = this.currentVehicleSelected ?? String.Empty;
            foreach (PayloadDto payload in payLoadlist)
            {
                if (payload.IsActive)
                {
                    this.PayloadComboBox.Items.Add(payload.Name);
                }
            }
            this.PayloadComboBox.SelectedItem = this.currentPayloadSelected ?? String.Empty;
            ShowDashboardData();
        }

        public void ShowDashboardData()
        {
            LaunchVehicleDto[] list = lvClient.GetVehicles();
            int activeCount = 0;
            int waitingCount = 0;
            foreach (LaunchVehicleDto vehicle in list)
            {
                if (vehicle.IsActive)
                {
                    activeCount++;
                }
                else
                {
                    waitingCount++;
                }
            }
            this.label3.Text = activeCount.ToString();
            this.label4.Text = waitingCount.ToString();
        }

        #region launchvehicle
        private void Upload_Click(object sender, EventArgs e)
        {
            DialogResult t = this.openFileDialog1.ShowDialog();
            if (t == DialogResult.OK)
            {
                string filePath = this.openFileDialog1.FileName;
                try
                {
                    lvClient.AddVehicle(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                LoadData();
            }
        }

        private void LaunchVehicle_Click_1(object sender, EventArgs e)
        {
            string item = this.LaunchVehicleComboBox?.SelectedItem?.ToString();

            if (item == null)
            {
                MessageBox.Show("Please Select a vehicle");
                return;
            }
            else
            {
                this.LaunchVehicleComboBox.SelectedItem = "";
                try
                {
                    lvClient.StartVehicle(item);
                    LoadData();
                    MessageBox.Show("Vehicle Launched");

                }
                catch (FaultException<ServiceReference2.ServiceFault> fault)
                {

                    MessageBox.Show(fault.Detail.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = GetSelectedLaunchVehicleItem();
            if (item == null)
            {
                MessageBox.Show("Please Select a vehicle");
                return;
            }
            try
            {
                lvClient.DeployPayload(item);
                LoadData();
                MessageBox.Show("Payload Deployed!!");
            }
            catch (FaultException<ServiceReference2.ServiceFault> fault)
            {
                MessageBox.Show(fault.Detail.Message);
            }
        }

        private void Deorbit_Click(object sender, EventArgs e)
        {
            var item = GetSelectedLaunchVehicleItem();
            if (item == null)
            {
                MessageBox.Show("Please Select a vehicle");
                return;
            }
            try
            {
                lvClient.DeorbitLaunchVehicle(item);
                this.LauchVehcileTelemetryRichTextBox.Clear();
                this.currentVehicleSelected = String.Empty;
                LoadData();
                HideSpaceCraftBtns();
                MessageBox.Show("Deorbited!!");
            }
            catch (FaultException<ServiceReference2.ServiceFault> fault)
            {
                MessageBox.Show(fault.Detail.Message);
            }
        }

        private void StartTelemetry_Click(object sender, EventArgs e)
        {
            var item = GetSelectedLaunchVehicleItem();
            if (item == null)
            {
                MessageBox.Show("Please Select a vehicle");
                return;
            }
            lvClient.SendTelemetryRequest(item, true);
        }

        private void StopTelemetry_Click(object sender, EventArgs e)
        {
            var item = GetSelectedLaunchVehicleItem();
            if (item == null)
            {
                MessageBox.Show("Please Select a vehicle");
                return;
            }
            lvClient.SendTelemetryRequest(item, false);
        }

        private void LaunchVehicleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SelectLaunchVehicleComboBox.SelectedItem.ToString() == this.currentVehicleSelected)
            {
                return;
            }
            if (!string.IsNullOrEmpty(this.SelectLaunchVehicleComboBox.SelectedItem?.ToString()))
            {
                var item = string.IsNullOrEmpty(currentVehicleSelected) ? GetSelectedLaunchVehicleItem() : currentVehicleSelected;
                if (item == null)
                {
                    MessageBox.Show("Something went wrong, please try again");
                    return;
                }
                lvClient.SendTelemetryRequest(item, false);
                this.currentVehicleSelected = this.SelectLaunchVehicleComboBox.SelectedItem.ToString();
                this.Deorbit.Visible = true;
                this.DeployPayload.Visible = true;
                this.StartTelemetry.Visible = true;
                this.StopTelemetry.Visible = true;
                this.LauchVehcileTelemetryRichTextBox.Clear();
            }
            else
            {
                HideSpaceCraftBtns();
            }
        }

        private void HideSpaceCraftBtns()
        {
            this.Deorbit.Visible = false;
            this.DeployPayload.Visible = false;
            this.StartTelemetry.Visible = false;
            this.StopTelemetry.Visible = false;
        }

        public void NotifyDeployStatus(string name, bool status)
        {
            SendOrPostCallback callback =
                delegate (object state)
                { MessageBox.Show("Spacecraft - " + name + " is ready to deploy"); };
            _uiSyncContext.Post(callback, name);
        }

        public void NotifyTelemetryData(ServiceReference2.TelemetryDto telemetry)
        {
            SendOrPostCallback callback =
                delegate (object state)
                { this.LauchVehcileTelemetryRichTextBox.AppendText(JsonConvert.SerializeObject(telemetry) + "\n"); };

            _uiSyncContext.Post(callback, telemetry.ToString());
        }

        private string GetSelectedLaunchVehicleItem()
        {
            return this.SelectLaunchVehicleComboBox?.SelectedItem?.ToString();
        }
        #endregion

        #region payload methods
        private void button9_Click(object sender, EventArgs e)
        {
            var item = GetSelectedPayload();
            if (item == null)
            {
                MessageBox.Show("Please Select a payload");
                return;
            }
            try
            {
                pClient.SendDataRequest(item, true);
            }
            catch (FaultException<ServiceReference1.ServiceFault> fault)
            {
                MessageBox.Show(fault.Detail.Message);
            }
        }

        private void StopData_Click(object sender, EventArgs e)
        {
            var item = GetSelectedPayload();
            if (item == null)
            {
                MessageBox.Show("Please Select a payload");
                return;
            }
            try
            {
                pClient.SendDataRequest(item, false);
            }
            catch (FaultException<ServiceReference1.ServiceFault> fault)
            {
                MessageBox.Show(fault.Detail.Message);
            }

            if (this.pictureBox1.Visible)
            {
                SendOrPostCallback callback =
                delegate (object state)
                { this.pictureBox1.Visible = false; };

                _uiSyncContext.Post(callback, null);
            }
        }

        private void StartTelemetryPayload_Click(object sender, EventArgs e)
        {
            var item = GetSelectedPayload();
            if (item == null)
            {
                MessageBox.Show("Please Select a payload");
                return;
            }
            try
            {
                pClient.SendTelemetryRequest(item, true);
            }
            catch (FaultException<ServiceReference1.ServiceFault> fault)
            {
                MessageBox.Show(fault.Detail.Message);
            }
        }

        private void StopTelemetryPayload_Click(object sender, EventArgs e)
        {
            var item = GetSelectedPayload();
            if (item == null)
            {
                MessageBox.Show("Please Select a payload");
                return;
            }
            try
            {
                pClient.SendTelemetryRequest(item, false);
            }
            catch (FaultException<ServiceReference1.ServiceFault> fault)
            {
                MessageBox.Show(fault.Detail.Message);
            }
        }

        private void Decommission_Click(object sender, EventArgs e)
        {
            var item = GetSelectedPayload();
            if (item == null)
            {
                MessageBox.Show("Please Select a payload");
                return;
            }
            try
            {
                pClient.DecommissionPayload(item);
                LoadData();
            }
            catch (FaultException<ServiceReference1.ServiceFault> fault)
            {
                MessageBox.Show(fault.Detail.Message);
            }
            this.PayloadTelemetryRichTextBox.Clear();
            this.PayloadDataRichTextBox.Clear();
            this.pictureBox1.Visible = false;
            this.currentPayloadSelected = String.Empty;
            HidePayloadBtns();
            MessageBox.Show("Decommissioned!!");
        }

        private void PayloadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.PayloadComboBox.SelectedItem.ToString() == this.currentPayloadSelected)
            {
                return;
            }
            if (this.PayloadComboBox.SelectedItem != null)
            {
                var item = string.IsNullOrEmpty(currentPayloadSelected) ? GetSelectedPayload() : currentPayloadSelected;
                if (item == null)
                {
                    MessageBox.Show("Something went wrong, please try again");
                    return;
                }
                try
                {
                    pClient.SendTelemetryRequest(item, false);
                    pClient.SendDataRequest(item, false);
                }
                catch (FaultException<ServiceReference1.ServiceFault> fault)
                {
                    MessageBox.Show(fault.Detail.Message);
                }
                this.currentPayloadSelected = this.PayloadComboBox.SelectedItem.ToString();
                ShowPayloadBtns();
                this.PayloadTelemetryRichTextBox.Clear();
                this.PayloadDataRichTextBox.Clear();
                this.PayloadDataRichTextBox.Visible = false;
                this.pictureBox1.Visible = false;
            }
            else
            {
                HidePayloadBtns();
            }
        }

        private string GetSelectedPayload()
        {
            return this.PayloadComboBox?.SelectedItem?.ToString();
        }

        private void ShowPayloadBtns()
        {
            this.Decommission.Visible = true;
            this.StartData.Visible = true;
            this.StartTelemetryPayload.Visible = true;
            this.StopData.Visible = true;
            this.StopTelemetryPayload.Visible = true;
        }

        private void HidePayloadBtns()
        {
            this.Decommission.Visible = false;
            this.StartData.Visible = false;
            this.StartTelemetryPayload.Visible = false;
            this.StopData.Visible = false;
            this.StopTelemetryPayload.Visible = false;
        }

        public void NotifyData(string data)
        {
            SendOrPostCallback callback =
                delegate (object state)
                {
                    this.PayloadDataRichTextBox.Visible = true;
                    this.PayloadDataRichTextBox.AppendText(data + "\n");
                };

            _uiSyncContext.Post(callback, data.ToString());
        }

        public void NotifyImage(Stream data)
        {
            this.pictureBox1.Image = Image.FromStream(data);
            SendOrPostCallback callback =
                delegate (object state)
                { this.pictureBox1.Visible = true; };

            _uiSyncContext.Post(callback, data);
        }

        public void NotifyPayloadTelemetryData(ServiceReference1.TelemetryDto telemetry)
        {
            SendOrPostCallback callback =
                delegate (object state)
                { this.PayloadTelemetryRichTextBox.AppendText(JsonConvert.SerializeObject(telemetry) + "\n"); };

            _uiSyncContext.Post(callback, telemetry.ToString());
        }
        #endregion
        private void communicationform_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}