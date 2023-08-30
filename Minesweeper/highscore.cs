using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class highscore
    {
        private static int[] array = new int[2] {int.MaxValue, int.MaxValue};

        private string createPath(string checkForm)
        {
            string netWindows = Path.GetDirectoryName(Application.ExecutablePath);
            string Debug = Directory.GetParent(netWindows).FullName;
            string bin = Directory.GetParent(Debug).FullName;
            string Minesweeper = Directory.GetParent(bin).FullName;
            string txt = "";
            if (checkForm == "Form1")
            {
                txt = "HighScore_Form1.txt";
            }
            else if (checkForm == "Form3")
            {
                txt = "HighScore_Form3.txt";
            }
            else if (checkForm == "Form4")
            {
                txt = "HighScore_Form4.txt";
            }
            string path = Path.Combine(Minesweeper, "Resources", txt);
            
            return path;
        }
        private void readData(string checkForm)
        {
            string path = createPath(checkForm);
            //Nếu file đã tồn tại
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        string[] test = reader.ReadToEnd().Split(":");
                        for (int i = 0; i < test.Length; i++)
                        {
                            array[i] = int.Parse(test[i]);
                        }
                    }
                }
            }
        }
        public void saveHighScore(string checkForm, time timer)
        {
            array[0] = int.MaxValue;
            array[1] = int.MaxValue;
            string path = createPath(checkForm);

            readData(checkForm);

            if (array[0] > timer.phut)
            {
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(timer.phut.ToString() + ":" + timer.giay.ToString());
                    }
                }
            }
            else if (array[0] == timer.phut && array[1] > timer.giay)
            {
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(timer.phut.ToString() + ":" + timer.giay.ToString());
                    }
                }
            }
        }

        public string highScore_Show(string checkForm)
        {
            array[0] = int.MaxValue;
            array[1] = int.MaxValue;
            readData(checkForm);    
            if (array[0] != int.MaxValue && array[1] != int.MaxValue)
            {
                return $"{array[0]:D2}:{array[1]:D2}";
            }
            else
            {
                return $"HighScore";
            }
        }

    }
}
