﻿using ListAndEditForm1.Admin;
using ListAndEditForm1.CourseNScore;
using ListAndEditForm1.Result;
using ListAndEditForm1.Score;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAndEditForm1
{
    public partial class MainForm01 : Form
    {
        public MainForm01()
        {
            InitializeComponent();
        }

        private void addNewStudentCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdf = new AddStudentForm();
            addStdf.Show(this);
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, args) =>
            {
                studentsListForm StdList = new studentsListForm();
                StdList.Show();
                timer.Stop();
            };
            timer.Start();
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticForm StdSF = new StatisticForm();
            StdSF.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print print = new Print();
            print.Show();
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Managestudentform mnsdf = new Managestudentform();
            mnsdf.Show();
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm manageCourseForm = new ManageCourseForm();
            manageCourseForm.Show( );
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintForm printForm = new PrintForm();
            printForm.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addScoreForm = new AddScoreForm();
            addScoreForm.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm removeCourseForm = new RemoveCourseForm();
            removeCourseForm.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm editCourseForm = new EditCourseForm();
            editCourseForm.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           RemoveScore removescore = new RemoveScore();
            removescore.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm manageScoreForm = new ManageScoreForm();
            manageScoreForm.Show(this);
        }

        private void avgScoreByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgScoreByCourseForm avgScoreBy = new avgScoreByCourseForm();   
            avgScoreBy.Show(this);  
        }

        private void aVGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AVGResult aVGResult = new AVGResult();
            aVGResult.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStudentForm = new UpdateDeleteStudentForm();
            updateDeleteStudentForm.Show(this);
        }

        private void rESULTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountManage accountManage = new AccountManage();  
            accountManage.Show(this);
        }

        private void staticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticResult staticResult = new StaticResult(); 
            staticResult.Show(this);
        }

        private void cOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void resultToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
