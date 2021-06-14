using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using Discord;
using Discord.WebSocket;
using System.Collections.Specialized;

namespace Tunned
{
    public partial class Form1 : Form
    {
        // Some definitions
        List<string> generate_codes = new List<string>();
        private DiscordSocketClient client;
        bool webhook_state = false;
        bool claim_state = false;
        string valid;
        string line_two;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        



        // Principal Code
        private void Generate(object sender, EventArgs e)
        {
            // Generate
            string amount = codes.Text;

            if (!Int32.TryParse(amount, out int number))
            {
                MessageBox.Show("Invalid amount");
            }

            else
            {
                int parsed_amount = Int32.Parse(amount);

                for (int i = 0; i < parsed_amount; i++)
                {
                    generate_codes.Add(random_code(16));
                }

                // Save codes
                System.IO.File.WriteAllLines("NitroCodes.txt", generate_codes);
                MessageBox.Show("Sucefully saved codes, please don't change the name of the file");

                // Output
                foreach (string f_codes_output in generate_codes)
                {
                    results_output.Text = File.ReadAllText("NitroCodes.txt");
                }
            }
        }

        // Random function
        private static Random random = new Random();
        public static string random_code(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; // List of characters used
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }





        // Checker
        private void button2_Click(object sender, EventArgs e)
        {
            // Delete output
            results_output.Text = null;

            // Open File
            string pathFile = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathFile = openFileDialog.FileName;
            }

            // Output Path
            txtPathFile.Text = pathFile;


            // Checker
            async Task mainchecker()
            {
                // Check system
                string readlines = File.ReadAllText("NitroCodes.txt");
                string[] lines = readlines.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in lines) // Open file with Nitro Codes
                {
                    line_two = line;

                    // Base
                    HttpClient client = new HttpClient();
                    string api = "https://discord.com/api/v8/entitlements/gift-codes/" + generate_codes + "?with_application=true&with_subscription_plan=true"; ;
                    HttpResponseMessage response = await client.GetAsync(api);
                    var status = response.StatusCode.ToString();


                    // Empty File
                    if (new FileInfo("NitroCodes.txt").Length == 0)
                    {
                        MessageBox.Show("The file is empty!");
                    }

                    // Valid Code
                    if (response.IsSuccessStatusCode) 
                    {
                        string vcheck = $"[Valid] " + line + Environment.NewLine;
                        results_output.Text += vcheck;
                        MessageBox.Show("Valid Nitro found!");
                        valid = "true";

                        if (webhook_state == true)
                        {
                            SaveWH_Click(sender, e);
                        }

                        if(claim_state == true)
                        {
                            SaveToken_Click(sender, e);
                        }
                    }

                    else
                    {
                        // Rate Limit
                        if (status == "TooManyRequests") 
                        {
                            string fcheck = $"[Too many requests] " + line + Environment.NewLine;
                            results_output.Text += fcheck;
                            valid = "tmr";

                            if (webhook_state == true)
                            {
                                SaveWH_Click(sender, e);
                            }
                        }

                        // Invalid Code
                        else 
                        {
                            string fcheck = $"[Invalid] " + line + Environment.NewLine;
                            results_output.Text += fcheck;
                            valid = "false";

                            if (webhook_state == true)
                            {
                                SaveWH_Click(sender, e);
                            }
                        }
                    }
                }
            }
            mainchecker();
        }




        // Auto Claim
        public void SaveToken_Click(object sender, EventArgs e) //=> new Program().RunAccount();
        {
            claim_state = true;

            if (claim_state == true)
            {
                string token = TokenInput.Text;

                if (valid == "true")
                {
                    // Add API and create request
                    var api = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/entitlements/gift-codes/{line_two}/redeem");
                    api.Accept = "application/json, text/javascript, */*; q=0.01";

                    var postData = "";
                    var data = Encoding.ASCII.GetBytes(postData);
                    api.Headers["authorization"] = token;
                    api.Method = "POST";
                    api.ContentType = "application/json";
                    api.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.75 Safari/537.36";
                    api.ContentLength = data.Length;

                    using (var stream = api.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }

                    var response = (HttpWebResponse)api.GetResponse();
                    string responsestring = new StreamReader(response.GetResponseStream()).ReadToEnd();

                    // Sucefully claimed
                    if ((int)response.StatusCode == 200)
                    {
                        MessageBox.Show("Nitro Claimed!");
                    }

                    else
                    {
                        MessageBox.Show($"Failed to redeem code {line_two}");
                    }
                }
            }
        }



        // Webhook
        private void SaveWH_Click(object sender, EventArgs e)
        {
            webhook_state = true;

            if (webhook_state == true)
            {
                string webhook = WHInput.Text;
                
                static void sWh(string URL, string msg, string nn)
                {
                    Http.Post(URL, new NameValueCollection()
                    {
                        { "username", "Tunned" },
                        { "content", msg }
                    });
                }

                // Send Nitro Codes
                if (valid == "true")
                {
                    sWh(webhook, string.Concat(new string[] { $"@everyone [Valid Nitro Code]! : `https://discord.gift/{line_two}`" }), "Tunned"); // Valid
                }

                if (valid == "false")
                {
                    sWh(webhook, string.Concat(new string[] { $"[Invalid Nitro Code] : `https://discord.gift/{line_two}`" }), "Tunned"); // Invalid
                }

                if (valid == "tmr")
                {
                    sWh(webhook, string.Concat(new string[] { $"[Too many requests] : `https://discord.gift/{line_two}`" }), "Tunned"); // Too many requests
                }
            }
        }



        // Close
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize
        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        // Move window
        int m, mx, my;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }




        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void results_output_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
