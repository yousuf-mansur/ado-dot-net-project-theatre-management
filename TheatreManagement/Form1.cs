using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheatreManagement
{
    public partial class Form1 : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        int intArtistId = 0;
        string strPreviousImage = "";
        bool defaultImage = true;
        OpenFileDialog ofd = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCatagoryCmb();
            LoaddgvArtistList();
            Clear();

        }

        private void Clear()
        {
            txtArtistCode.Text = "";
            txtArtistName.Text = "";
            cmbArtistCatagory.SelectedIndex = 0;
            dtpDOB.Value = DateTime.Now;
            rbtnMale.Checked = true;
            chkStatus.Checked = true;
            intArtistId = 0;
            btnDelete.Enabled = false;
            btnSave.Text = "Save";
            pictureBoxArtist.Image = Image.FromFile(Application.StartupPath + "\\images\\noimage.png");
            defaultImage = true;
            if (dgvExperiences.DataSource == null)
            {
                dgvExperiences.Rows.Clear();
            }
            else
            {
                dgvExperiences.DataSource = (dgvExperiences.DataSource as DataTable).Clone();
            }

        }

        private void LoaddgvArtistList()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("spViewAllArtists", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dt.Columns.Add("Image", Type.GetType("System.Byte[]"));
                foreach (DataRow dr in dt.Rows)
                {
                    string imagePath = Application.StartupPath + "\\images\\" + dr["ImagePath"].ToString();
                    if (File.Exists(imagePath))
                    {
                        dr["Image"] = File.ReadAllBytes(imagePath);
                    }
                    else
                    {
                       
                        dr["Image"] = File.ReadAllBytes(Application.StartupPath + "\\images\\default.jpg");
                        
                        Console.WriteLine("Image file not found: " + imagePath);
                    }
                }

                dgvArtistList.RowTemplate.Height = 80;
                dgvArtistList.DataSource = dt;

                ((DataGridViewImageColumn)dgvArtistList.Columns[dgvArtistList.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                dgvArtistList.AllowUserToAddRows = false;
                sda.Dispose();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateMasterDetailForm())
            {
                int artistId = 0;
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("spArtistAddOrEdit", con, transaction);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ArtistId", intArtistId);
                        cmd.Parameters.AddWithValue("@ArtistCode", txtArtistCode.Text.Trim());
                        cmd.Parameters.AddWithValue("@ArtistName", txtArtistName.Text.Trim());
                        cmd.Parameters.AddWithValue("@CatagoryId", Convert.ToInt16(cmbArtistCatagory.SelectedValue));
                        cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                        cmd.Parameters.AddWithValue("@IsPermanent", chkStatus.Checked ? "True" : "False");
                        cmd.Parameters.AddWithValue("@Gender", rbtnMale.Checked ? "Male" : "Female");
                        if (defaultImage)
                        {
                            cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                        }
                        else if (intArtistId > 0 && strPreviousImage != "")
                        {
                            cmd.Parameters.AddWithValue("@ImagePath", strPreviousImage);
                            if (ofd.FileName != strPreviousImage)
                            {
                                var filename = Application.StartupPath + "\\images\\" + strPreviousImage;
                                if (pictureBoxArtist.Image != null)
                                {
                                    pictureBoxArtist.Image.Dispose();
                                    pictureBoxArtist.Image = null;
                                    System.IO.File.Delete(filename);
                                }
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ImagePath", SaveImage(ofd.FileName));
                        }
                        artistId = Convert.ToInt16(cmd.ExecuteScalar());

                        foreach (DataGridViewRow item in dgvExperiences.Rows)
                        {
                            if (item.IsNewRow) break;
                            else
                            {
                                SqlCommand cmd2 = new SqlCommand("spArtistExperienceAddAndEdit", con, transaction);
                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Parameters.AddWithValue("@ExperienceId", Convert.ToInt32(item.Cells["dgvExperienceId"].Value == DBNull.Value ? "0" : item.Cells["dgvExperienceId"].Value));
                                cmd2.Parameters.AddWithValue("@ArtistId", artistId);
                                cmd2.Parameters.AddWithValue("@GroupName", item.Cells["dgvGroupName"].Value);
                                cmd2.Parameters.AddWithValue("@YearsWorked", item.Cells["dgvYearsWorked"].Value);
                                cmd2.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit(); 
                        LoaddgvArtistList();
                        Clear();
                        MessageBox.Show("Submitted Successfully");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); 
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }





        private void LoadCatagoryCmb()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ArtistCatagory", con);
                    sda.SelectCommand.Transaction = transaction;
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    DataRow topRow = dt.NewRow();
                    topRow[0] = 0;
                    topRow[1] = "--Select--";
                    dt.Rows.InsertAt(topRow, 0);
                    cmbArtistCatagory.ValueMember = "CatagoryId";
                    cmbArtistCatagory.DisplayMember = "CatagoryTitle";
                    cmbArtistCatagory.DataSource = dt;

                    transaction.Commit(); 
                }
                catch (Exception ex)
                {

                    transaction.Rollback(); 
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }




        private void dgvArtistList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvArtistList.CurrentRow.Index != -1)
            {
                DataGridViewRow dgvRow = dgvArtistList.CurrentRow;
                int intArtistId = Convert.ToInt32(dgvRow.Cells[0].Value);
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter("spViewArtistByArtistId", con);
                        sda.SelectCommand.Transaction = transaction;
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.AddWithValue("@ArtistId", intArtistId);
                        DataSet ds = new DataSet();
                        sda.Fill(ds);

                        //--Master---
                        DataRow dr = ds.Tables[0].Rows[0];
                        txtArtistCode.Text = dr["ArtistCode"].ToString();
                        txtArtistName.Text = dr["ArtistName"].ToString();
                        cmbArtistCatagory.SelectedValue = Convert.ToInt32(dr["CatagoryId"].ToString());
                        dtpDOB.Value = Convert.ToDateTime(dr["DateOfBirth"].ToString());
                        chkStatus.Checked = Convert.ToBoolean(dr["IsPermanent"]);
                        rbtnMale.Checked = dr["Gender"].ToString().Trim() == "Male";
                        rbtnFemale.Checked = dr["Gender"].ToString().Trim() == "Female";

                        
                        if (dr["ImagePath"] == DBNull.Value)
                        {
                            pictureBoxArtist.Image = new Bitmap(Application.StartupPath + "\\images\\noimage.png");
                        }
                        else
                        {
                            string imagePath = dr["ImagePath"].ToString();
                            try
                            {
                                if (!string.IsNullOrEmpty(imagePath) && File.Exists(Application.StartupPath + "\\images\\" + imagePath))
                                {
                                    pictureBoxArtist.Image = new Bitmap(Application.StartupPath + "\\images\\" + imagePath);
                                    strPreviousImage = imagePath;
                                    defaultImage = false;
                                }
                                else
                                {
                                    pictureBoxArtist.Image = new Bitmap(Application.StartupPath + "\\images\\noimage.png");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error loading image: " + ex.Message);
                                pictureBoxArtist.Image = new Bitmap(Application.StartupPath + "\\images\\noimage.png");
                            }
                        }

                        //--Details---
                        dgvExperiences.AutoGenerateColumns = false;
                        dgvExperiences.DataSource = ds.Tables[1];
                        btnDelete.Enabled = true;
                        btnSave.Text = "Update";
                        tabControl1.SelectedIndex = 0;

                        transaction.Commit(); 
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); 
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "Master Details", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        string image = "";
                        SqlDataAdapter sda = new SqlDataAdapter("spViewArtistByArtistId", con);
                        sda.SelectCommand.Transaction = transaction;
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.AddWithValue("@ArtistId", intArtistId);
                        DataSet ds = new DataSet();
                        sda.Fill(ds);

                        
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow dr = ds.Tables[0].Rows[0];
                            if (dr["ImagePath"] != DBNull.Value)
                            {
                                image = dr["ImagePath"].ToString();
                                var filename = Application.StartupPath + "\\images\\" + image;
                                if (pictureBoxArtist.Image != null)
                                {
                                    pictureBoxArtist.Image.Dispose();
                                    pictureBoxArtist.Image = null;
                                    System.IO.File.Delete(filename);
                                }
                            }

                            SqlCommand cmd = new SqlCommand("spArtistExperienceDelete", con, transaction);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ArtistId", intArtistId);
                            cmd.ExecuteNonQuery();
                            transaction.Commit(); 

                            LoaddgvArtistList();
                            Clear();
                            MessageBox.Show("Deleted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No data found for the specified ArtistId.");
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }






        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Images(.jpg,.png,.png)|*.png;*.jpg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxArtist.Image = new Bitmap(ofd.FileName);
                if (intArtistId == 0)
                {
                    defaultImage = false;
                    strPreviousImage = "";
                }

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureBoxArtist.Image = new Bitmap(Application.StartupPath + "\\images\\noimage.png");
            defaultImage = true;
            strPreviousImage = "";
        }
        bool ValidateMasterDetailForm()
        {
            bool isValid = true;
            if (txtArtistName.Text.Trim() == "")
            {
                MessageBox.Show("Employee name is required");
                isValid = false;
            }
            return isValid;
        }
        string SaveImage(string imgPath)
        {
            string fileName = Path.GetFileNameWithoutExtension(imgPath);
            string ext = Path.GetExtension(imgPath);
            fileName = fileName.Length <= 15 ? fileName : fileName.Substring(0, 15);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + ext;
            pictureBoxArtist.Image.Save(Application.StartupPath + "\\images\\" + fileName);
            return fileName;
        }

        private void dgvExperiences_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow dgvRow = dgvExperiences.CurrentRow;
            if (dgvRow.Cells["dgvExperienceId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure to delete this record?", "Master Details", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("spExperienceDelete", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ExperienceId", dgvRow.Cells["dgvExperienceId"].Value);
                        cmd.ExecuteNonQuery();
                    }

                }
                else
                {
                    e.Cancel = true;
                }
            }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("spViewAllArtists", con);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    List<ArtistViewModel> list = new List<ArtistViewModel>();

                    foreach (DataRow row in dt.Rows)
                    {
                        try
                        {
                            ArtistViewModel artistVm = new ArtistViewModel();
                            artistVm.ArtistId = Convert.ToInt32(row["ArtistId"]);
                            artistVm.ArtistCode = row["ArtistCode"].ToString();
                            artistVm.ArtistName = row["ArtistName"].ToString();

                            
                            if (row["DateOfBirth"] != DBNull.Value)
                                artistVm.DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
                            else
                                artistVm.DateOfBirth = DateTime.MinValue; // or any default value

                            artistVm.Gender = row["Gender"].ToString();
                            artistVm.IsPermanent = Convert.ToBoolean(row["IsPermanent"]);
                            artistVm.TotalExperience = Convert.ToInt32(row["TotalExperience"]);
                            artistVm.CatagoryTitle = row["CatagoryTitle"].ToString();

                           
                            if (row["ImagePath"] != DBNull.Value)
                                artistVm.ImagePath = Application.StartupPath + "\\images\\" + row["ImagePath"].ToString();
                            else
                                artistVm.ImagePath = ""; 

                            list.Add(artistVm);
                        }
                        catch (Exception ex)
                        {
                            
                            Console.WriteLine($"Error processing row {row} - {ex.Message}");
                        }
                    }

                    if (list.Count > 0)
                    {
                        using (ArtistInformation report = new ArtistInformation(list))
                        {
                            report.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data available to generate report.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}");
            }
        }


    }
}


