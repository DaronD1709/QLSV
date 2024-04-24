using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAndEditForm1.Score
{
    public partial class avgScoreByCourseForm : Form
    {
        public avgScoreByCourseForm()
        {
            InitializeComponent();
        }

        private void avgScoreByCourseForm_Load(object sender, EventArgs e)
        {
            SCORE score = new SCORE();
            dataGridView1.DataSource = score.avgScoreByCourse();
        }
    }
}
