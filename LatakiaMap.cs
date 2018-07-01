using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace maps_sy
{
    public partial class LatakiaMap : Form
    {
        Point cor1, cor2;
        int xxx = 0;
        //======================================= position xy the map
        public Double main_left = 35.5, main_right = 36.3, main_top = 36.00, main_buttom = 35.2;
        public Double original_map_x_size, original_map_y_size;
        public Double real_xmap, real_ymap;
        public int mouse_map_x, mouse_map_y;
        //int init_image_x = 1792, init_image_y = 1280; //initail image size   
        int init_image_x = 256*(Convert.ToInt16(Screen.PrimaryScreen.Bounds.Size.Width/256)) +256, init_image_y = 256*(Convert.ToInt16(Screen.PrimaryScreen.Bounds.Size.Height/256)) + 256; //initail image size   
        //Double zoom_x, zoom_y, zoom_to_point_x, zoom_to_point_y;
        int zoom_level = 8, end_zoom = 10, z_stop = 1; // zoom variabls
        //=========================================== detect x y display ziro corner
        Double corner_x_0, corner_y_0;
        int corner_location_x, corner_location_y;
        Double zoom_x, zoom_y, zoom_to_point_x, zoom_to_point_y;
        //=============================================== fill images
        int next_pic_x = 0, next_pic_y = 0, next_place_x = 0, next_place_y = 0, img_ctr_x, img_ctr_y, one_time = 1;
        int offset_x = 0, offset_y = 0;
        int img_ctr_x_tmp = 0, img_ctr_y_tmp = 0;
        //Bitmap img_combine = new Bitmap(1792, 1280);
        //Bitmap img_combine10 = new Bitmap(1792, 1280);
        Bitmap img_combine = new Bitmap(256 * (Convert.ToInt16(Screen.PrimaryScreen.Bounds.Size.Width / 256)) + 256, 256 * (Convert.ToInt16(Screen.PrimaryScreen.Bounds.Size.Height / 256)) + 256);
        Bitmap img_combine10 = new Bitmap(256 * (Convert.ToInt16(Screen.PrimaryScreen.Bounds.Size.Width / 256)) + 256, 256 * (Convert.ToInt16(Screen.PrimaryScreen.Bounds.Size.Height / 256)) + 256);
        //=============================================
        Font fnt = new Font("arial", 12, FontStyle.Bold);
        Font fnt1 = new Font("arial", 16, FontStyle.Bold);
        Pen p = new Pen(Color.Red, 16);
        //+++++++++++++++++++++++++++++++
        Pen pp = new Pen(Color.Lime, 2);
        //============================================================
        String decimal_memo, hddlocation = "d:\\";
        //============================================
        TextBox ggd = new TextBox();
        //============================================
        public LinkedList<PictureBox> PBAList = new LinkedList<PictureBox>();
        LinkedList<PictureBox> PBAListModify = new LinkedList<PictureBox>();

        private void mapviewer_DoubleClick(object sender, EventArgs e)
        {
            zoom_level++;
            if (zoom_level>10) { zoom_level = 8; }
            TextBox1.Text = zoom_level.ToString();
            TrackBar1.Value = zoom_level;
            mapselect.Stop();
            mapselect.Start();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            zoom_level=TrackBar1.Value;
            TextBox1.Text = zoom_level.ToString();
            mapselect.Stop();
            mapselect.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (zoom_level <10) { zoom_level++; }
            TextBox1.Text = zoom_level.ToString();
            TrackBar1.Value = zoom_level;
            mapselect.Stop();
            mapselect.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (zoom_level >8) { zoom_level--; }
            TextBox1.Text = zoom_level.ToString();
            TrackBar1.Value = zoom_level;
            mapselect.Stop();
            mapselect.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (xxx == 0)
            {
                Panel1.Hide();
                LinkLabel1.Text = "إظهار القائمة";
                xxx++;
            }
            else
            {
                Panel1.Show();
                LinkLabel1.Text = "إخفاء القائمة";
                xxx = 0;
            }
        }

        String StrInfo;
        Boolean  PBImageChanged = false;
        public LatakiaMap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox1.Text = zoom_level.ToString();
            //mapviewer.Image = Image.FromFile(@"D:\DB\main.jzr", true);
            img_ctr_y = 3216;
            img_ctr_x = 4903; 
            mapselect.Start();
            mapviewer.Size = new Size(init_image_x, init_image_y);
            mapviewer.Location = new Point((Panel2.Width - mapviewer.Width) / 2, (Panel2.Height - mapviewer.Height) / 2);
            deg_label.Location = new Point(Panel2.Width / 2, 0);
                    }

        private void closeb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void mapviewer_MouseMove(object sender, MouseEventArgs e)
        {
            //=============real long and lat detect
            original_map_x_size = (main_right - main_left) / (mapviewer.Width);
            original_map_y_size = (main_top - main_buttom) / (mapviewer.Height);
            mouse_map_x = MousePosition.X - mapviewer.Location.X;
            mouse_map_y = MousePosition.Y - mapviewer.Location.Y;
            //======================== x y corection
            if (mapviewer.Location.X < 0)
            {
                mouse_map_x = mouse_map_x + 1;
            }

            if (this.mapviewer.Location.Y < 0)
            {
                mouse_map_y = mouse_map_y + 1;
            }
            //==========================================================================
            real_xmap = main_left + (original_map_x_size * mouse_map_x);
            real_ymap = main_top - (original_map_y_size * mouse_map_y);
            corner_x_0 = main_left + (original_map_x_size * (-mapviewer.Location.X + 1));
            corner_y_0 = main_top - (original_map_y_size * (-mapviewer.Location.Y + 1));
            corner_location_x = -this.mapviewer.Location.X / 256;
            corner_location_y = -this.mapviewer.Location.Y / 256;
            decimal_memo = "LAT : " + real_ymap + " N    LONG : " + real_xmap + " E";
            mapviewer.Focus();
            deg_label.Text = decimal_memo;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point ControlPosition = this.PointToClient(MousePosition);
                ControlPosition.Offset(cor1.X, cor1.Y);
                PictureBox ss = sender as PictureBox;
                if (ControlPosition.X > 0) corner_location_x = corner_location_x - 1;
                if (ControlPosition.Y > 0) corner_location_y = corner_location_y - 1;
                ss.Location = ControlPosition;

            }
            TextBox1.Text = zoom_level.ToString();

        }

        private void mapviewer_MouseDown(object sender, MouseEventArgs e)
        {
            cor1 = new Point(-e.X, -e.Y);
            cor2 = new Point(mapviewer.Location.X, mapviewer.Location.Y);
        }


        private void mapviewer_MouseUp(object sender, MouseEventArgs e)
        {
            offset_x = - mapviewer.Location.X / 256;
            if (offset_x < 0 || mapviewer.Location.X > 0) offset_x--;
            offset_y = - mapviewer.Location.Y / 256;
            if (offset_y < 0 || mapviewer.Location.Y > 0) offset_y--;
            mapselect.Start();
        }

               
        private void mapselect_Tick(object sender, EventArgs e)
        {
            
            if (zoom_level == 8)
            {
                Bitmap image;
                
                 if (one_time == 1)
                {
                  
                    img_ctr_y += offset_y;
                    img_ctr_x += offset_x;
                    img_ctr_x_tmp = img_ctr_x;
                    img_ctr_y_tmp = img_ctr_y;
                    next_place_x = -1;
                    one_time = 0;
                     TrackBar1.Value = 8;
                 }
                Graphics g1 = Graphics.FromImage(img_combine);
                image = new Bitmap( @"E:\DB\13\gs_" + img_ctr_x++ + "_" + img_ctr_y + "_13.jpg");
                next_place_x = (next_place_x + 1);
                g1.DrawImage(image, (next_place_x) * 256, (next_place_y) * 256, 256, 256);
                if (next_place_x == (img_combine.Size.Width / 256 - 1))
                {
                    next_place_x = -1;
                    next_pic_x = next_pic_x - img_combine.Size.Width / 256;
                    next_pic_y++;
                    next_place_y = next_place_y + 1;
                    img_ctr_x = img_ctr_x_tmp;
                    img_ctr_y++;
                }
                if (next_place_y == img_combine.Size.Height / 256)
                {
                    
                        //main_right = Convert.ToDouble(right_Edge_Longitude9Label1.Text);
                        //main_buttom = Convert.ToDouble(bottom_Edge_Latitude9Label1.Text);
                    
                    next_place_x = 0;
                    next_place_y = 0;
                    one_time = 1;
                    mapviewer.Size = img_combine.Size;
                    mapviewer.Location = new Point(mapviewer.Location.X + (offset_x * 256), mapviewer.Location.Y + (offset_y * 256));
                    mapviewer.Image = img_combine;
                    mapselect.Stop();
                    z_stop = 1;
                    //if (mapviewer.Location.X > 0) mapviewer.Location = new Point(0, mapviewer.Location.Y);
                    //if (mapviewer.Location.Y > 0) mapviewer.Location = new Point(mapviewer.Location.X, 0);
                    //if (mapviewer.Location.X > 0) mapviewer.Location = new Point(mapviewer.Location.X - 256, mapviewer.Location.Y);
                    //if (mapviewer.Location.Y > 0) mapviewer.Location = new Point(mapviewer.Location.X, mapviewer.Location.Y - 256);

                    img_ctr_x = img_ctr_x_tmp;
                    img_ctr_y = img_ctr_y_tmp;
                }
            } else if (zoom_level == 9)
            {
                Bitmap image;

                if (one_time == 1)
                {
                    img_ctr_x = img_ctr_x * 2;
                    img_ctr_y = img_ctr_y * 2;
                    img_ctr_y += offset_y+1;
                    img_ctr_x += offset_x+1;
                    img_ctr_x_tmp = img_ctr_x;
                    img_ctr_y_tmp = img_ctr_y;
                    next_place_x = -1;
                    one_time = 0;
                    TrackBar1.Value = 9;
                }
                Graphics g1 = Graphics.FromImage(img_combine);
                image = new Bitmap(@"E:\DB\14\gs_" + img_ctr_x++ + "_" + img_ctr_y + "_14.jpg");
                next_place_x = (next_place_x + 1);
                g1.DrawImage(image, (next_place_x) * 256, (next_place_y) * 256, 256, 256);
                if (next_place_x == (img_combine.Size.Width / 256 - 1))
                {
                    next_place_x = -1;
                    next_pic_x = next_pic_x - img_combine.Size.Width / 256;
                    next_pic_y++;
                    next_place_y = next_place_y + 1;
                    img_ctr_x = img_ctr_x_tmp;
                    img_ctr_y++;
                }
                if (next_place_y == img_combine.Size.Height / 256)
                {

                    //main_right = Convert.ToDouble(right_Edge_Longitude9Label1.Text);
                    //main_buttom = Convert.ToDouble(bottom_Edge_Latitude9Label1.Text);

                    next_place_x = 0;
                    next_place_y = 0;
                    one_time = 1;
                    mapviewer.Size = img_combine.Size;
                    mapviewer.Location = new Point(mapviewer.Location.X + (offset_x * 256), mapviewer.Location.Y + (offset_y * 256));
                    mapviewer.Image = img_combine;
                    mapselect.Stop();
                    z_stop = 1;
                    //if (mapviewer.Location.X > 0) mapviewer.Location = new Point(0, mapviewer.Location.Y);
                    //if (mapviewer.Location.Y > 0) mapviewer.Location = new Point(mapviewer.Location.X, 0);
                    //if (mapviewer.Location.X > 0) mapviewer.Location = new Point(mapviewer.Location.X - 256, mapviewer.Location.Y);
                    //if (mapviewer.Location.Y > 0) mapviewer.Location = new Point(mapviewer.Location.X, mapviewer.Location.Y - 256);

                    img_ctr_x = img_ctr_x_tmp;
                    img_ctr_y = img_ctr_y_tmp;
                }
            }
            else if (zoom_level == 10)
            {
                Bitmap image;

                if (one_time == 1)
                {
                    img_ctr_y += offset_y;
                    img_ctr_x += offset_x;
                    img_ctr_x_tmp = img_ctr_x;
                    img_ctr_y_tmp = img_ctr_y;
                    next_place_x = -1;
                    one_time = 0;
                    TrackBar1.Value = 8;
                }
                Graphics g1 = Graphics.FromImage(img_combine);
                image = new Bitmap( @"E:\DB\15\gs_" + img_ctr_x++ + "_" + img_ctr_y + "_15.jpg");
                next_place_x = (next_place_x + 1);
                g1.DrawImage(image, (next_place_x) * 256, (next_place_y) * 256, 256, 256);
                if (next_place_x == (img_combine.Size.Width / 256 - 1))
                {
                    next_place_x = -1;
                    next_pic_x = next_pic_x - img_combine.Size.Width / 256;
                    next_pic_y++;
                    next_place_y = next_place_y + 1;
                    img_ctr_x = img_ctr_x_tmp;
                    img_ctr_y++;
                }
                if (next_place_y == img_combine.Size.Height / 256)
                {

                    //main_right = Convert.ToDouble(right_Edge_Longitude9Label1.Text);
                    //main_buttom = Convert.ToDouble(bottom_Edge_Latitude9Label1.Text);

                    next_place_x = 0;
                    next_place_y = 0;
                    one_time = 1;
                    mapviewer.Size = img_combine.Size;
                    mapviewer.Location = new Point(mapviewer.Location.X + (offset_x * 256), mapviewer.Location.Y + (offset_y * 256));
                    mapviewer.Image = img_combine;
                    mapselect.Stop();
                    z_stop = 1;
                    //if (mapviewer.Location.X > 0) mapviewer.Location = new Point(0, mapviewer.Location.Y);
                    //if (mapviewer.Location.Y > 0) mapviewer.Location = new Point(mapviewer.Location.X, 0);
                    //if (mapviewer.Location.X > 0) mapviewer.Location = new Point(mapviewer.Location.X - 256, mapviewer.Location.Y);
                    //if (mapviewer.Location.Y > 0) mapviewer.Location = new Point(mapviewer.Location.X, mapviewer.Location.Y - 256);

                    img_ctr_x = img_ctr_x_tmp;
                    img_ctr_y = img_ctr_y_tmp;
                }
            }
                
        }

        
       
             
        private void mapviewer_MouseLeave(object sender, EventArgs e)
        {
            Panel1.Focus();
        }

       
        private void closeb_MouseDown(object sender, MouseEventArgs e)
        {
             closeb.Size = new Size(30, 30);
        }

        private void closeb_MouseUp(object sender, MouseEventArgs e)
        {
            closeb.Size = new Size(35, 35);
        }

        
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (xxx==0) {
                Panel1.Hide();
                LinkLabel1.Text = "إظهار القائمة";
                xxx++; }
            else {
                Panel1.Show();
                LinkLabel1.Text = "إخفاء القائمة";
                xxx = 0;
            }
        }

        private void homeb_MouseDown(object sender, MouseEventArgs e)
        {
            homeb.Size = new Size(30, 30);
        }

        private void homeb_MouseUp(object sender, MouseEventArgs e)
        {
             homeb.Size = new Size(35, 35);
        }

        private void homeb_Click(object sender, EventArgs e)
        {
            img_ctr_y = 3216;
            img_ctr_x = 4903;
            offset_y = 0;
            offset_x = 0;
            mapselect.Start();
            mapviewer.Size = new Size(init_image_x, init_image_y);
            mapviewer.Location = new Point((Panel2.Width - mapviewer.Width) / 2, (Panel2.Height - mapviewer.Height) / 2);
            deg_label.Location = new Point(Panel2.Width / 2, 0);
             /*mapviewer.Image = Image.FromFile(hddlocation + @"DB\main.jzr");
        //mapviewer.Size = new Size(1792, 1280);
             mapviewer.Size = img_combine.Size;
            main_left = 33.75;
            main_right = 43.59375;
            main_top = 37.71859032231005;
            main_buttom = 31.952162235114969;
            zoom_level = 8;
            TrackBar1.Value = 10;
            z_stop = 1;
            TextBox1.Text = "8";
            mapselect.Stop();*/
        }

        
        private void deg_label_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        private void mapviewer_Click(object sender, EventArgs e)
        {
                     
            

        }

        private void mapviewer_MouseWheel(object sender, MouseEventArgs e)
        {
            if (z_stop == 1)
            {
                init_image_x = mapviewer.Width;
                init_image_y = mapviewer.Height;
                if (e.Delta > 1)
                {
                    timer1.Start();
                }
                if (e.Delta < 1)
                {
                    timer2.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TextBox1.Text = this.zoom_level.ToString();
            z_stop = 0;

            if (one_time == 1)
            {
                zoom_x = init_image_x / 10;
                zoom_y = init_image_y / 10;
                zoom_to_point_x = mouse_map_x / 10;
                zoom_to_point_y = mouse_map_y / 10;
                zoom_level = zoom_level + 1;
                if (zoom_level > 10) zoom_level = 10;
                one_time = 0;
            }

            mapviewer.Size = new Size(mapviewer.Width + Convert.ToInt32(zoom_x), mapviewer.Height + Convert.ToInt32(zoom_y));
            mapviewer.Location = new Point(mapviewer.Location.X - Convert.ToInt32(zoom_to_point_x), mapviewer.Location.Y - Convert.ToInt32(zoom_to_point_y));
            end_zoom = end_zoom - 1;
            if (end_zoom == 0)
            {

                end_zoom = 10;
                init_image_x = mapviewer.Width;
                init_image_y = mapviewer.Height;
                //img_ctr_y = 3216;
                //img_ctr_y = 6433;
                img_ctr_y *= 2;
                img_ctr_y+=2;
                offset_y = 0;
                //img_ctr_x = 4903;
                //img_ctr_x = 9807;
                img_ctr_x *= 2;
                img_ctr_x+=2;
                offset_x = 0;
                mapselect.Start();
                mapviewer.Location = new Point((Panel2.Width + Convert.ToInt32(zoom_x) * 10 - mapviewer.Width) / 2, (Panel2.Height + Convert.ToInt32(zoom_y) * 10 - mapviewer.Height) / 2);
                //mapviewer.Location = new Point(mapviewer.Location.X + Convert.ToInt32(zoom_to_point_x)*10, mapviewer.Location.Y + Convert.ToInt32(zoom_to_point_y)*10);
                one_time = 1;
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            z_stop = 0;
            if (one_time == 1)
            {
                zoom_level = zoom_level - 1;
                zoom_x = (init_image_x / 2) / 10;
                zoom_y = (init_image_y / 2) / 10;
                zoom_to_point_x = (mouse_map_x / 2) / 10;
                zoom_to_point_y = (mouse_map_y / 2) / 10;
                TextBox1.Text = zoom_level.ToString();
                one_time = 0;
            }
            mapviewer.Size = new Size(mapviewer.Width - Convert.ToInt32(zoom_x), mapviewer.Height - Convert.ToInt32(zoom_y));
            mapviewer.Location = new Point(Convert.ToInt32(zoom_to_point_x) + mapviewer.Location.X, Convert.ToInt32(zoom_to_point_y) + mapviewer.Location.Y);
            end_zoom = end_zoom - 1;
            if (end_zoom == 0)
            {
                end_zoom = 10;
                init_image_x = mapviewer.Width;
                init_image_y = mapviewer.Height;
                img_ctr_y /= 2;
                img_ctr_y -= 1;
                offset_y = 0;
                img_ctr_x /= 2;
                img_ctr_x -= 1;
                offset_x = 0;
                mapselect.Start();
                mapviewer.Location = new Point((Panel2.Width - Convert.ToInt32(zoom_x) * 10 - mapviewer.Width) / 2, (Panel2.Height - Convert.ToInt32(zoom_y) * 10 - mapviewer.Height) / 2);
                one_time = 1;
                timer2.Stop();
            }
        }
        
        private void mapviewer_Resize(object sender, EventArgs e)
        {

        }

        private void mapviewer_Move(object sender, EventArgs e)
        {

        }

        private void state_tableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

     


    }
}
