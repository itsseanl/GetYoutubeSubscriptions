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
using System.Net;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private SqlConnection addressConnection = new SqlConnection();
        private SqlDataAdapter addressDataAdapter = new SqlDataAdapter();
        public Form1()
        {
            InitializeComponent();
            loadThumbnails();
        }
            private void loadThumbnails()
            {
                YoutubeLink linkClass1 = new YoutubeLink();
                addressConnection.ConnectionString = "Data Source = LYONSS2N1\\SQLEXPRESS; initial catalog = YoutubeLinksApp; Integrated Security = True;";
                addressConnection.Open();
                SqlCommand sqlcommand1 = new SqlCommand("SELECT * FROM pagelink", addressConnection);
                List<string> results = new List<string>();
                bool loopBool = false;
                //datareader takes each result from sqlcommand1 and puts it into a single list
                using (SqlDataReader reader = sqlcommand1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string pageLink = (string)reader["pageLink"];
                        results.Add(pageLink);
                    }
                }
                //list to put results of each getTopVideos method
                List<string> videoIDs = new List<string>();
                List<PictureBox> pictureBoxes = new List<PictureBox>();
                List<Label> channelLabels = new List<Label>();
                int y = 10;
                for (int i = 0; i < results.Count; i++)                   
                {
                    String[] linkResults = linkClass1.getTopVideos(results[i]);
                    int x = 6;
                    

                    SqlCommand labelCommand = new SqlCommand("SELECT channelName FROM pagelink WHERE pagelink = @pagelink", addressConnection);
                    labelCommand.Parameters.AddWithValue("@pageLink", results[i]);
                    string txtChannelLabel = (labelCommand.ExecuteScalar()).ToString();
                    channelLabels.Add(
                            new Label()
                            {
                                Name = "label" + i
                            });
                    channelLabels[i].Text = txtChannelLabel;
                    channelLabels[i].Location = new Point(x, y);
                    channelLabels[i].Size = new Size(90, 15);
                    tabPage1.Controls.Add(channelLabels[i]);
                    y = y + 80;

                    SecondaryLoop(linkResults, videoIDs, pictureBoxes, loopBool);
                    loopBool = true;
                }
                addressConnection.Close();
            }
    
            public void SecondaryLoop(string[] linkResults, List<string> videoIDs, List<PictureBox> pictureBoxes, bool loopBool)
            {

                int z = 0;
                int x = 70;
                //prints all links from .getTopVideos method into the output textbox
                if (loopBool == false)
                {
                    for (z = 0; z < linkResults.Length; z++)
                    {
                        if (linkResults.Length > 3)
                        {
                            z = linkResults.Length - ((linkResults.Length / 3) * 3);
                            x = pictureBoxes[pictureBoxes.Count].Location.X;
                        }

                        
                        //gets video ID from full link to retrieve thumbnail, stores into list
                        videoIDs.Add(linkResults[z].Substring(24, 11));
                        pictureBoxes.Add(
                            new PictureBox()
                            {
                                Name = "img" + z.ToString(),
                            });
                        pictureBoxes[0].Location = new Point(imgOne.Location.X, imgOne.Location.Y);
                        if (z > 0)
                        {
                            pictureBoxes[z].Location = new Point(pictureBoxes[z - 1].Location.X + x, pictureBoxes[z - 1].Location.Y);
                        }
                        pictureBoxes[z].ImageLocation = (@"http://img.youtube.com/vi/" + videoIDs[z] + "/0.jpg");
                        pictureBoxes[z].Size = imgOne.Size;
                        pictureBoxes[z].BringToFront();
                        pictureBoxes[z].BorderStyle = imgOne.BorderStyle;
                        pictureBoxes[z].SizeMode = imgOne.SizeMode;
                        pictureBoxes[z].Click += new EventHandler(pictureClick);
                        tabPage1.Controls.Add(pictureBoxes[z]);

                    }
                }
                else if (loopBool == true)
                {
                    int yValue = pictureBoxes[pictureBoxes.Count-1].Location.Y + 80;
                    z = videoIDs.Count;
                    x = 70;
                    int newz = 0;
                    foreach (string item in linkResults)
                    {
                        txtOutput.AppendText("reached");

                        videoIDs.Add(item.Substring(24, 11));
                        pictureBoxes.Add(
                            new PictureBox()
                            {
                                Name = item,
                            });
                        if (newz > 0)
                        {
                            pictureBoxes[z].Location = new Point(pictureBoxes[newz - 1].Location.X + x, yValue);
                        }
                        else
                        {
                            pictureBoxes[z].Location = new Point(imgOne.Location.X, yValue);
                        }
                        pictureBoxes[z].ImageLocation = (@"http://img.youtube.com/vi/" + videoIDs[z] + "/0.jpg");
                        pictureBoxes[z].Size = imgOne.Size;
                        pictureBoxes[z].BringToFront();
                        pictureBoxes[z].BorderStyle = imgOne.BorderStyle;
                        pictureBoxes[z].SizeMode = imgOne.SizeMode;
                        pictureBoxes[z].Click += new EventHandler(pictureClick);
                        tabPage1.Controls.Add(pictureBoxes[z]);
                        z++;
                        newz++;
                    }

                }
                return;
            }
        
        private void pictureClick(object sender, EventArgs e)
        {
            //gets ImageLocation property of sending object in order to extract the video ID, and turn it into a link you can open 
            string videoID = Convert.ToString(sender.GetType().GetProperty("ImageLocation").GetValue(sender, null));
            videoID = videoID.Substring(26, 11);
            string link = @"https://www.youtube.com/watch?v=" + videoID;
            System.Diagnostics.Process.Start(link);
            //MessageBox.Show(videoID);
            //System.Diagnostics.Process.Start();
        }
        private void btnGetLinks_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO pagelink (pageLink, channelName) VALUES(@pageLink, @channelName)", addressConnection);
                sqlCommand.Parameters.AddWithValue("@pageLink", txtInput.Text);
                sqlCommand.Parameters.AddWithValue("@channelName", txtChannelName.Text);
                addressConnection.Open();
                sqlCommand.ExecuteNonQuery();
                addressConnection.Close();
                txtAddPageOutput.AppendText("User page added successfully" + Environment.NewLine);
            }
            catch
            {
                txtAddPageOutput.AppendText("Oops! Something went wrong. User page not added.");
            }
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //this.Refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void imgOne_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            //{
            //    if (this.Controls[ix] is PictureBox)
            //        this.Controls[ix].Dispose();
            //}
            //List<PictureBox> itemsToRemove = new List<PictureBox>();
            //foreach (PictureBox picBox in Controls.OfType<PictureBox>())
            //{
                
            //   itemsToRemove.Add(picBox);
                
            //}

            //foreach (PictureBox picBox in itemsToRemove)
            //{
            //    Controls.Remove(picBox);
            //    picBox.Dispose();
            //}
            //loadThumbnails();
            Application.Restart();
        }

        private void btnRemovePage_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM pagelink WHERE pagelink = @pageLink", addressConnection);
                sqlCommand.Parameters.AddWithValue("@pageLink", txtInput.Text);
                addressConnection.Open();
                sqlCommand.ExecuteNonQuery();
                addressConnection.Close();
                loadThumbnails();
            }
            catch
            {
                txtAddPageOutput.AppendText("Oops! Something went wrong. User page not removed.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
