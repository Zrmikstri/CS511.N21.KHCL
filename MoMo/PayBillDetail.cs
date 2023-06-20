using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoMo
{
    public partial class PayBillDetail : Form
    {
        private string[] service = { "Điện lực toàn quốc|Áp dụng các tỉnh thành Việt Nam",
                                       "Nước Hồ Chí Minh|Tất cả các quận, huyện của TPHCM",
                                        "Internet Viettel|Áp dụng toàn quốc"};

        private string[] imageService = { @"../../../Images/dien.jpg",
                                    @"../../../Images/nuoc.png",
                                    @"../../../Images/mang.png"};

        private string[] ElectricityCustomer = { "PE1200475946|Nguyễn Văn A|TPHCM|300.000",
                                                "PE1200521946|Trần Thị C|Hà Nội|450.000",
                                                "PE1200147256|Đào Trần Anh Tuấn|Bình Dương|500.000" };

        private string[] WaterCustomer = { "WA1200475946|Nguyễn Thị Xuân|Bình Thạnh|30.000",
                                                "WA1200521946|Trần Thị Hương|Tân Bình|20.000",
                                                "WA1200147256|Đào Văn Việt|Thủ Đức|25.000" };

        private string[] InternetCustomer = { "IT1200475946|Nguyễn Văn A|TPHCM|100.000",
                                                "IT1200521946|Trần Thị C|Hà Nội|120.000",
                                                "IT1200147256|Đào Trần Anh Tuấn|Bình Dương|150.000" };

        string typeService = null!;

        public PayBillDetail()
        {
            InitializeComponent();
        }

        public PayBillDetail(string typeService)
        {
            InitializeComponent();
            this.typeService = typeService;
            show();
        }

        public void show()
        {
            if (this.typeService == "Electricity")
            {
                pictureBox1.Image = Image.FromFile(imageService[0]);
                label3.Text = service[0].Split('|')[0];
                label4.Text = service[0].Split('|')[1];
            }
            else if (this.typeService == "Water")
            {
                pictureBox1.Image = Image.FromFile(imageService[1]);
                label3.Text = service[1].Split('|')[0];
                label4.Text = service[1].Split('|')[1];
            }
            else if (this.typeService == "Internet")
            {
                pictureBox1.Image = Image.FromFile(imageService[2]);
                label3.Text = service[2].Split('|')[0];
                label4.Text = service[2].Split('|')[1];
            }
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }

        public bool check()
        {
            bool isPresent = false;
            if (this.typeService == "Electricity")
                isPresent = Array.Exists(ElectricityCustomer, element => element.StartsWith(textBox1.Text));
            else if (this.typeService == "Water")
                isPresent = Array.Exists(WaterCustomer, element => element.StartsWith(textBox1.Text));
            else
                isPresent = Array.Exists(InternetCustomer, element => element.StartsWith(textBox1.Text));

            return isPresent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 12)
            {
                if (check())
                {
                    pictureBox5.Image = Image.FromFile(@"../../../Images/paybill.png");
                    pictureBox5.Enabled = true;
                    panel5.Visible = true;
                    int index = -1;
                    string searchValue = textBox1.Text;

                    if (this.typeService == "Electricity")
                    {
                        for (int i = 0; i < ElectricityCustomer.Length; i++)
                        {
                            if (ElectricityCustomer[i].StartsWith(searchValue))
                            {
                                index = i;
                                break;
                            }
                        }
                        label10.Text = ElectricityCustomer[index].Split('|')[1];
                        label11.Text = ElectricityCustomer[index].Split('|')[2];
                        label12.Text = ElectricityCustomer[index].Split("|")[3];
                    }
                    else if (this.typeService == "Water")
                    {
                        for (int i = 0; i < WaterCustomer.Length; i++)
                        {
                            if (WaterCustomer[i].StartsWith(searchValue))
                            {
                                index = i;
                                break;
                            }
                        }
                        label10.Text = WaterCustomer[index].Split('|')[1];
                        label11.Text = WaterCustomer[index].Split('|')[2];
                        label12.Text = WaterCustomer[index].Split("|")[3];
                    }
                    else
                    {
                        for (int i = 0; i < InternetCustomer.Length; i++)
                        {
                            if (InternetCustomer[i].StartsWith(searchValue))
                            {
                                index = i;
                                break;
                            }
                        }
                        label10.Text = InternetCustomer[index].Split('|')[1];
                        label11.Text = InternetCustomer[index].Split('|')[2];
                        label12.Text = InternetCustomer[index].Split("|")[3];
                    }

                }
                else
                {
                    label13.Visible = true;
                    label13.Text = "Không có thông tin mã KH!";
                }
            }
            else
            {
                pictureBox5.Image = Image.FromFile(@"../../../Images/paybillgray.png");
                pictureBox5.Enabled = false;
                panel5.Visible = false;
                label13.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán hoá đơn thành công", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
