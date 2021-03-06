﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CheckBomInTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //v1.0 -- 只check analog部分,IC testjet部分暂时不check，小电阻在Jumper部分不check


        #region 参数


        const string BOARD = "board";
        const string BOARD_XY = "board_xy";
        const string TESTORDER = "testorder";
        const string TESTPLAN = "testplan";


        bool bPanel = false; //board is panel?if it is,must select the board name
        string sDefaultFilePath = "";

       




        List<string> analogInBoard = new List<string>();   //从board里面找到的在analog部分测试的(res,cap,pin lib),包含需要从testorder去掉的电容部分
        List<string> jumperInBoard = new List<string>();   //jumper open close
        List<string> testjetInBoard = new List<string>();  //
        List<string> ntInBoard = new List<string>();


        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {

        }






        /// <summary>
        /// open folder
        /// </summary>
        /// <param name="textbox"></param>
        private void openfolder(TextBox textbox)
        {
            FolderBrowserDialog op = new FolderBrowserDialog();

            if (sDefaultFilePath != "")
                op.SelectedPath = sDefaultFilePath;

            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textbox.Text = op.SelectedPath;
                sDefaultFilePath = op.SelectedPath;
            }
        }

        /// <summary>
        /// open file
        /// </summary>
        /// <param name="textbox"></param>
        private void openfile(TextBox textbox)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textbox.Text = op.FileName;                
            }
        }

        private void txtProgramFolder_DoubleClick(object sender, EventArgs e)
        {
            openfolder(txtProgramFolder);
            if (!string.IsNullOrEmpty (txtProgramFolder.Text .Trim ()))
               checkProgramFile(txtProgramFolder.Text, chkTestorder, chkTestplan, chkBoard, chkBoardxy);
        }

        private void txtBOmFolder_DoubleClick(object sender, EventArgs e)
        {
            openfolder(txtBOmFolder);
        }

        private void txtSingleBom_DoubleClick(object sender, EventArgs e)
        {
            openfile(txtSingleBom);
        }



        /// <summary>
        /// check 3070 board file exists
        /// </summary>
        private void checkProgramFile(string programfolder, CheckBox chktestorder,
            CheckBox chktestplan,CheckBox chkboard,CheckBox chkboardxy)
        {
            if (!Directory.Exists(programfolder))
            {
                chktestorder.Checked = false;
                chktestplan.Checked = false;
                chkboard.Checked = false;
                chkboardxy .Checked = false;
                return;
            }

            DirectoryInfo di = new DirectoryInfo(programfolder);
            FileInfo[] fi = di.GetFiles();
            foreach (var item in fi )
            {
                if (item.Name.ToLower() == "testplan")
                    chktestplan.Checked = true;
                if (item.Name.ToLower() == "testorder")
                    chktestorder.Checked = true;
                if (item.Name.ToLower() == "board")
                    chkboard.Checked = true;
                if (item.Name.ToLower() == "board_xy")
                    chkboardxy.Checked = true;
            }

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (txtProgramFolder.Text.Trim ()))
            {
                MessageBox.Show ("u must select a 3070 program...","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error );
                txtProgramFolder.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSingleBom.Text.Trim()))
            {
                MessageBox.Show("u must select a bom...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSingleBom.Focus();
                return;
            }

            checkProgramFile(txtProgramFolder.Text, chkTestorder, chkTestplan, chkBoard, chkBoardxy);
            if (chkTestplan.Checked && chkTestorder.Checked && chkBoard.Checked && chkBoardxy.Checked)
            {

            }
            else  //
            {
                MessageBox.Show("The program u select may miss some file,eg:'testplan''testorder''board''board_xy',pls check and retry...", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtProgramFolder.SelectAll();
                txtProgramFolder.Focus();
                return;
            }

        }

        private void btnBatchCompare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProgramFolder.Text.Trim()))
            {
                MessageBox.Show("u must select a 3070 program...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProgramFolder.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSingleBom.Text.Trim()))
            {
                MessageBox.Show("u must select a bom...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSingleBom.Focus();
                return;
            }

            checkProgramFile(txtProgramFolder.Text, chkTestorder, chkTestplan, chkBoard, chkBoardxy);
            if (chkTestplan.Checked && chkTestorder.Checked && chkBoard.Checked && chkBoardxy.Checked)
            {

            }
            else  //
            {
                MessageBox.Show("The program u select may miss some file,eg:'testplan''testorder''board''board_xy',pls check and retry...", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtProgramFolder.SelectAll();
                txtProgramFolder.Focus();
                return;
            }
        }

        private void btnLoadboard_Click(object sender, EventArgs e)
        {

           
            if (string.IsNullOrEmpty(txtProgramFolder.Text.Trim()))
            {
                MessageBox.Show("u must select a 3070 program...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProgramFolder.Focus();
                return;
            }

            checkProgramFile(txtProgramFolder.Text, chkTestorder, chkTestplan, chkBoard, chkBoardxy);
            if (chkTestplan.Checked && chkTestorder.Checked && chkBoard.Checked && chkBoardxy.Checked)
            {

            }
            else  //
            {
                MessageBox.Show("The program u select may miss some file,eg:'testplan''testorder''board''board_xy',pls check and retry...", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtProgramFolder.SelectAll();
                txtProgramFolder.Focus();
                return;
            }


            lstBoards.Items.Clear();
            foreach (var item in CheckBoards(txtProgramFolder.Text .Trim ()))
            {
                lstBoards.Items.Add(item);
            }


            if (lstBoards.Items.Count > 0)
                lstBoards.SelectedIndex = 0;

        }




        /// <summary>
        /// read board file ,check board panel or not ,if panle ,return board list
        /// </summary>
        /// <param name="programfolder"></param>
        /// <returns>panel,board list</returns>
        private List<string> CheckBoards(string programfolder)
        {

            bPanel = false;
            bool bBoards = false;
            bool bHeading = false;
            string sHeading = string.Empty;
            string sLine = string.Empty;

            List<string> boards = new List<string>();
            string boardfile = GetFileFrom3070Program(programfolder, BOARD);
           
            StreamReader sr = new StreamReader(boardfile);
            while (!sr.EndOfStream )
            {
                sLine = sr.ReadLine();
                if (!string.IsNullOrEmpty(sLine)) //不能为空
                {

                    //get heading 
                    if (sLine.ToUpper().Trim() == "HEADING")
                        bHeading = true;
                    if (sLine.EndsWith(";") && bHeading)
                    {
                        sHeading = sLine.Replace("\"", "").Replace(";", "");
                        bHeading = false;
                    }
                    //check if panel 

                    if (sLine.ToUpper().Trim() == "BOARDS")
                    {
                        bPanel = true;
                        bBoards = true;
                    }
                    if (bBoards && sLine.ToUpper().Trim().Substring(0, 6).Trim() == "BOARD")
                        bBoards = false;
                    if (bBoards && sLine.EndsWith(";"))
                    {
                        //MessageBox.Show(GetBoardFromLineString(sLine));
                        boards.Add(GetBoardFromLineString(sLine));
                    }

                }
            }
           
            sr.Close();
            return boards;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="linestring"></param>
        /// <returns></returns>
        private string GetBoardFromLineString(string linestring)
        {
            //  1    "13269-1"    "MB";
            string board = string.Empty;
            foreach (string temp in linestring.Trim().Split(' '))
            {
                if (temp.Trim().Contains("\""))
                {
                    board = board +"_"+ temp.Trim().Replace("\"", "").Replace(";", "");
                }
            }
            return board.Remove(0, 1);
        }



        /// <summary>
        /// 从3070程式中获取特定的文件路径
        /// </summary>
        /// <param name="programfolder">3070 program folder</param>
        /// <param name="keyvalue">testplan testorder board or board_xy/param>
        /// <returns></returns>
        private string GetFileFrom3070Program(string programfolder,string keyvalue)
        {
            string filepath = string.Empty;

            if (string.IsNullOrEmpty(programfolder))
                return filepath;
            if (programfolder.EndsWith(@"\"))
                filepath = programfolder + keyvalue;
            else
                filepath = programfolder + @"\" + keyvalue;

            return filepath;
        }


   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="boardfile"></param>
        /// <param name="boardname"></param>
        private void ReadBoard(string boardfile,string boardname)
        {
            //clear data
            analogInBoard = new List<string>();   //从board里面找到的在analog部分测试的(res,cap,pin lib),包含需要从testorder去掉的电容部分
            jumperInBoard = new List<string>();   //jumper open close
            testjetInBoard = new List<string>();  //
            ntInBoard = new List<string>();
            //
            string sLine = string.Empty;

 
            StreamReader sr = new StreamReader(boardfile);
            while (!sr.EndOfStream )
            {
                if (!string.IsNullOrEmpty(sLine))
                {

                }
            }
            sr.Close ();

        }

    }
}
