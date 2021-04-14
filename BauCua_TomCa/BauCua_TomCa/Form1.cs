using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BauCua_TomCa
{
    public partial class Form1 : Form
    {
        public List<ConDat> DSCD = new List<ConDat>();//tạo các con đặt lưu vào DSCD
        public List<ConDat> DSKQ = new List<ConDat>();//lưu kết quả random condat vào DSKQ
        public float tienchoi = 500000;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_choigame_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int ma1 = r.Next() % 6;//random ma cho 3 thằng xí ngầu
            int ma2 = r.Next() % 6;
            int ma3 = r.Next() % 6;
            DSKQ.Clear();//xóa kết quả cũ trước khi add thằng mới
            foreach (ConDat a in DSCD)
            {
                if (a.Ma == ma1)
                {
                    pic_kq_1.Image = Image.FromFile("HinhAnh/" + a.Hinhanh);//gán hình cho picture xí ngầu 1 là hình của a -- lưu ý file hình ảnh để trong debug
                    DSKQ.Add(a);
                }
                if (a.Ma == ma2)
                {
                    pic_kq_2.Image = Image.FromFile("HinhAnh/" + a.Hinhanh);
                    DSKQ.Add(a);
                }
                if (a.Ma == ma3)
                {
                    pic_kq_3.Image = Image.FromFile("HinhAnh/" + a.Hinhanh);
                    DSKQ.Add(a);
                }
            }
            kTraTrung(txt_0);
            kTraTrung(txt_1);
            kTraTrung(txt_2);
            kTraTrung(txt_3);
            kTraTrung(txt_4);
            kTraTrung(txt_5);
            clear();
            txt_tienchoi.Text = tienchoi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConDat a = new ConDat() { Ma = 0, Hinhanh = "nai.PNG" };
            ConDat b = new ConDat() { Ma = 1, Hinhanh = "bau.PNG" };
            ConDat c = new ConDat() { Ma = 2, Hinhanh = "ga.PNG" };
            ConDat d = new ConDat() { Ma = 3, Hinhanh = "ca.PNG" };
            ConDat f = new ConDat() { Ma = 4, Hinhanh = "cua.PNG" };
            ConDat g = new ConDat() { Ma = 5, Hinhanh = "tom.PNG" };
            DSCD.Add(a);
            DSCD.Add(b);
            DSCD.Add(c);
            DSCD.Add(d);
            DSCD.Add(f);
            DSCD.Add(g);

        }
        public void kTraTrung(TextBox a)// kiểm tra xem mình có chọn đúng con cược ra hay không
        {
            if (a.Text.Length != 0)
            {
                foreach (ConDat b in DSKQ)
                {
                    if (b.Ma.ToString() == a.Name.Substring(a.Name.Length - 1, 1))
                    {
                        tienchoi = tienchoi + float.Parse(a.Text) * 2;
                        MessageBox.Show("Bạn đã đánh trúng con cược " + tenConCuoc(b) + " với tiền thưởng là: " + (float.Parse(a.Text) * 2).ToString());
                    }
                }
            }
        }
        public void clear()
        {
            txt_0.Clear();
            txt_1.Clear();
            txt_2.Clear();
            txt_3.Clear();
            txt_4.Clear();
            txt_5.Clear();
        }
        public string tenConCuoc(ConDat a)
        {
            string ten = "";
            if (a.Ma == 0)
                ten = "Nai";
            if (a.Ma == 1)
                ten = "Bầu";
            if (a.Ma == 2)
                ten = "Gà";
            if (a.Ma == 3)
                ten = "Cá";
            if (a.Ma == 4)
                ten = "Cua";
            if (a.Ma == 5)
                ten = "Tôm";
            return ten;
        }
        private void txt_1_Leave(object sender, EventArgs e)
        {
            float tiendat;
            Control ctr = (Control)sender;
            if (ctr.GetType() == typeof(TextBox))
            {
                TextBox a = (TextBox)ctr;
                if (a.Text.Length == 0)
                {
                    tiendat = 0;
                }
                else
                {
                    if (kiemTra_textboxChiNhapSo(a.Text) == true)
                    {
                        tiendat = float.Parse(a.Text);
                        if (kiemTra_tienDatCuoc_lonHon_tienHienCo(tienchoi, tiendat) == true)
                        {
                            tienchoi = tienchoi - tiendat;
                        }
                        else
                        {
                            MessageBox.Show("Bạn không đủ tiền để đặt quá tiền chơi còn lại -- số tiền chơi còn lại: " + tienchoi.ToString());
                            a.Clear();
                        }
                    }


                }
                txt_tienchoi.Text = tienchoi.ToString();
            }
        }













        /// <summary>
        /// //KIỂM TRA TEXT BOX CHỈ CHO NHẬP SỐ
        /// </summary>
        /// <param name="pText"></param>
        /// <returns></returns>
        public static bool kiemTra_textboxChiNhapSo(string pText)
        {
            if (pText == null)
            {
                return false;
            }
            else
            {
                foreach (char item in pText)
                {
                    if (char.IsLetter(item))
                    {
                        return false;
                        break;
                    }
                }
            }

            return true;
        }



        private void txt_0_TextChanged(object sender, EventArgs e)
        {
            if (kiemTra_textboxChiNhapSo(txt_0.Text) == false)
            {
                MessageBox.Show("Chỉ Nhập Số Thôi Bạn Ơi");
            }
        }

        private void txt_1_TextChanged(object sender, EventArgs e)
        {
            if (kiemTra_textboxChiNhapSo(txt_1.Text) == false)
            {
                MessageBox.Show("Chỉ Nhập Số Thôi Bạn Ơi");
            }
        }

        private void txt_2_TextChanged(object sender, EventArgs e)
        {

            if (kiemTra_textboxChiNhapSo(txt_2.Text) == false)
            {
                MessageBox.Show("Chỉ Nhập Số Thôi Bạn Ơi");
            }
        }

        private void txt_3_TextChanged(object sender, EventArgs e)
        {
            if (kiemTra_textboxChiNhapSo(txt_3.Text) == false)
            {
                MessageBox.Show("Chỉ Nhập Số Thôi Bạn Ơi");
            }
        }

        private void txt_4_TextChanged(object sender, EventArgs e)
        {
            if (kiemTra_textboxChiNhapSo(txt_4.Text) == false)
            {
                MessageBox.Show("Chỉ Nhập Số Thôi Bạn Ơi");
            }
        }

        private void txt_5_TextChanged(object sender, EventArgs e)
        {
            if (kiemTra_textboxChiNhapSo(txt_5.Text) == false)
            {
                MessageBox.Show("Chỉ Nhập Số Thôi Bạn Ơi");
            }
        }


        ///////////////KIỂM TRA TIỀN CƯỢC HIỆN CÓ
        public static bool kiemTra_tienHienCo(double tienCuoc)
        {

            if (tienCuoc < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txt_tienchoi_TextChanged(object sender, EventArgs e)
        {
            if (kiemTra_tienHienCo(double.Parse(txt_tienchoi.Text)) == false)
            {
                MessageBox.Show("Tiền Cược Phải Có");
            }
        }



        ///////////////KIỂM TRA TIỀN ĐẶT CƯỢC PHẢI LỚN HƠN TIỀN HIỆN CÓ

        public static bool kiemTra_tienDatCuoc_lonHon_tienHienCo(float tienChoi, float tienDat)
        {
            if (tienChoi >= tienDat)
            {
                return true;
            }
            else if (tienChoi == 0 || tienDat == 0)
            {
                return false;
            }
            else if (tienChoi==0 && tienDat==0)
            {
                return false;
            }

            return false;
        }
    }
}
