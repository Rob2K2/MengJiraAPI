﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiraAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var client = new RestClient("https://meng-mod-04.atlassian.net/rest/auth/1/session");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n    \"username\": \"" + username + "\",\r\n    \"password\": \"" + password + "\"\r\n}", ParameterType.RequestBody);
            var response = client.Execute(request);

            txtResponse.Text = response.Content;

            //Guardamos el token generado en el login
            lblName.Text = response.Cookies[1].Name;
            lblValue.Text = response.Cookies[1].Value;
        }

        private void btnVerifySession_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://meng-mod-04.atlassian.net/rest/auth/1/session");
            var request = new RestRequest(Method.GET);
            request.AddCookie(lblName.Text, lblValue.Text);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);

            txtResponse.Text = response.Content;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://meng-mod-04.atlassian.net/rest/auth/1/session");
            var request = new RestRequest(Method.DELETE);
            request.AddCookie(lblName.Text, lblValue.Text);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);

            txtResponse.Text = response.Content;
        }

        private void btnGetProjects_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://meng-mod-04.atlassian.net/rest/api/2/project");
            var request = new RestRequest(Method.GET);
            request.AddCookie(lblName.Text, lblValue.Text);
            request.AddHeader("Content-Type", "application/json");
            var response = client.Execute<List<RootObject>>(request);

            txtResponse.Text = response.Content;
            cboProjects.DataSource = response.Data;
            cboProjects.DisplayMember = "name";
            cboProjects.ValueMember = "key";
        }

        //private void btnGetIssue_Click(object sender, EventArgs e)
        //{
        //    var client = new RestClient("https://meng-mod-04.atlassian.net/rest/api/2/issue/" + txtIssueKey.Text);
        //    var request = new RestRequest(Method.GET);
        //    request.AddCookie(lblName.Text, txtValue.Text);
        //    request.AddHeader("Content-Type", "application/json");
        //    var response = client.Execute(request);

        //    txtResponse.Text = response.Content;
        //}

        //private void getWorklog_Click(object sender, EventArgs e)
        //{
        //    var client = new RestClient("https://meng-mod-04.atlassian.net/rest/api/2/issue/" + txtIssueID.Text + "/worklog/" + txtWorklogID.Text);
        //    var request = new RestRequest(Method.GET);
        //    request.AddCookie(lblName.Text, txtValue.Text);
        //    request.AddHeader("Content-Type", "application/json");
        //    IRestResponse response = client.Execute(request);

        //    txtResponse.Text = response.Content;
        //}

        private void txtAddWorklog_Click(object sender, EventArgs e)
        {
            string issueKey = lvIssues.SelectedItems[0].Text;

            long timeSpent;
            bool res = false;

            res = long.TryParse(lvIssues.SelectedItems[0].SubItems[1].Text, out timeSpent);
            if (!res)
            {
                timeSpent = 0;
            }

            long timeOriginalEstimate = long.Parse(lvIssues.SelectedItems[0].SubItems[2].Text);
            long segundos = long.Parse(txtTime.Text);

            if (segundos + timeSpent >= timeOriginalEstimate + timeOriginalEstimate * 0.1)
            {
                MessageBox.Show("El tiempo agregado supera el 10% del tiempo originalmente estimado");
            }

            string fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff-0400");

            var client = new RestClient("https://meng-mod-04.atlassian.net/rest/api/2/issue/" + issueKey + "/worklog");
            var request = new RestRequest(Method.POST);
            request.AddCookie(lblName.Text, lblValue.Text);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n\"comment\": {\r\n    \"type\": \"doc\",\r\n    \"version\": 1,\r\n    \"content\": [\r\n      {\r\n        \"type\": \"paragraph\",\r\n        \"content\": [\r\n          {\r\n            \"type\": \"text\",\r\n            \"text\": \"Increasing time\"\r\n          }\r\n        ]\r\n      }\r\n    ]\r\n  },\r\n  \"started\": \"" + fecha + "\",\r\n  \"timeSpentSeconds\": " + segundos + "\r\n}",
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            txtResponse.Text = response.Content;
        }

        private void btnSelectProject_Click(object sender, EventArgs e)
        {
            lvIssues.Items.Clear();
            var client = new RestClient("https://meng-mod-04.atlassian.net/rest/api/2/search?jql=project=" + cboProjects.SelectedValue);
            var request = new RestRequest(Method.GET);
            request.AddCookie(lblName.Text, lblValue.Text);
            request.AddHeader("Content-Type", "application/json");
            var response = client.Execute<List<IssuesList>>(request);

            txtResponse.Text = response.Content;

            foreach (var issue in response.Data[0].Issues)
            {
                ListViewItem item = new ListViewItem();
                item.Text = issue.Key;
                item.SubItems.Add(issue.Fields.Timespent.ToString());
                item.SubItems.Add(issue.Fields.Timeoriginalestimate.ToString());
                item.SubItems.Add(issue.Fields.Summary.ToString());
                lvIssues.Items.Add(item);
            }
        }

        private void rbHora_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHora.Checked == true)
            {
                txtTime.Text = "3600";
            }
        }

        private void rbMediaHora_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMediaHora.Checked == true)
            {
                txtTime.Text = "1800";
            }
        }
    }
}
