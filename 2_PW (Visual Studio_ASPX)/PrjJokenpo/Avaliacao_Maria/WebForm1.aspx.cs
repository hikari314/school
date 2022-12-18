using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Avaliacao_Maria
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ImgBtnPaper_Click(object sender, ImageClickEventArgs e)
        {
            ImgPlayerChoice.ImageUrl = "~/images/paper.png";

            Random random = new Random();
            int img = random.Next(1, 4);

            if (img == 1)
            {
                ImgCPUChoice.ImageUrl = "~/images/rock.png";
                LblResult.Text = "You won!";

                Double po = int.Parse(LblPlayerPoints.Text);
                LblPlayerPoints.Text = (po + 1).ToString();
            }

            if (img == 2)
            {
                ImgCPUChoice.ImageUrl = "~/images/paper.png";
                LblResult.Text = "Tie";
            }

            if (img == 3)
            {
                ImgCPUChoice.ImageUrl = "~/images/scissors.png";
                LblResult.Text = "Defeat";

                Double p = int.Parse(LblPointsCPU.Text);
                LblPointsCPU.Text = (p + 1).ToString();
            }
        }

        protected void ImgBtnRock_Click(object sender, ImageClickEventArgs e)
        {
            ImgPlayerChoice.ImageUrl = "~/images/rock.png";

            Random random = new Random();
            int img = random.Next(1, 4);

            if (img == 1)
            {
                ImgCPUChoice.ImageUrl = "~/images/scissors.png";
                LblResult.Text = "You won!";

                Double pointsplayer = int.Parse(LblPlayerPoints.Text);
                LblPlayerPoints.Text = (pointsplayer + 1).ToString();
            }

            if (img == 2)
            {
                ImgCPUChoice.ImageUrl = "~/images/rock.png";
                LblResult.Text = "Tie";
            }

            if (img == 3)
            {
                ImgCPUChoice.ImageUrl = "~/images/paper.png";
                LblResult.Text = "Defeat";
                Double pointscpu = int.Parse(LblPointsCPU.Text);
                LblPointsCPU.Text = (pointscpu + 1).ToString();
            }
        }

        protected void ImgBtnScissors_Click(object sender, ImageClickEventArgs e)
        {
            ImgPlayerChoice.ImageUrl = "~/images/scissors.png";

            Random random = new Random();
            int img = random.Next(1, 4);

            if (img == 1)
            {
                ImgCPUChoice.ImageUrl = "~/images/paper.png";
                LblResult.Text = "You won!";

                Double pointsplaye = int.Parse(LblPlayerPoints.Text);
                LblPlayerPoints.Text = (pointsplaye + 1).ToString();
            }

            if (img == 2)
            {
                ImgCPUChoice.ImageUrl = "~/images/scissors.png";
                LblResult.Text = "Tie";
            }

            if (img == 3)
            {
                ImgCPUChoice.ImageUrl = "~/images/rock.png";
                LblResult.Text = "Defeat";
                Double pointscp = int.Parse(LblPointsCPU.Text);
                LblPointsCPU.Text = (pointscp + 1).ToString();
            }
        }
    }
}