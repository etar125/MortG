// Created by etar125 in SharpDevelop 5.1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;

namespace MortG
{
	public partial class MainForm : Form
	{
		public Dictionary<int, string> cmn = new Dictionary<int, string>
		{
			{ 0, "null" },
			{ 1, "Mort" },
			{ 2, "InDevelop" },
			{ 3, "" }, // Command
			{ 4, "" }, // Argument
			{ 5, "" }, // Argument
			{ 6, "" }, // Argument
			{ 7, "" }, // Argument
			{ 8, "" }, // Argument
			{ 9, "SuperDuperDeluxe Edition" },
			{ 10, "C#" },
			{ 11, "1.0" },
			{ 12, "dotNET FrameWork 4.0" },
			{ 13, "Pixel Telfer" },
			{ 14, "Virtel" },
			{ 15, "Vrtl" },
			{ 16, "Etar125" },
			{ 17, "InnieSharpSoftware" },
			{ 18, "ISS" },
			{ 19, "ISSU" },
			{ 20, "mv" },
			{ 21, "cp" },
			{ 22, "nc" }, // +1
			{ 23, "dc" }, // -1
			{ 24, "ad" },
			{ 25, "" },
			{ 26, "" },
			{ 27, "" },
			{ 28, "" },
			{ 29, "As Text" },
			{ 30, "0"}, // Draw
			{ 31, ""},
			{ 32, ""},
			{ 33, ""},
			{ 34, "0"}, // Apply
			{ 35, "1"}, // Show warnings and errors
			{ 36, "0"}, // Clear
			{ 37, ""}, // If
			{ 38, ""},
			{ 39, ""},
			{ 40, ""},
			{ 41, ""},
			{ 42, ""},
			{ 43, ""},
			{ 44, ""},
			{ 45, ""},
			{ 46, ""},
			{ 47, ""},
			{ 48, ""},
			{ 49, ""},
			{ 50, ""},
			#region Memory
			{ 51, ""},
			{ 52, ""},
			{ 53, ""},
			{ 54, ""},
			{ 55, ""},
			{ 56, ""},
			{ 57, ""},
			{ 58, ""},
			{ 59, ""},
			{ 60, ""},
			{ 61, ""},
			{ 62, ""},
			{ 63, ""},
			{ 64, ""},
			{ 65, ""},
			{ 66, ""},
			{ 67, ""},
			{ 68, ""},
			{ 69, ""},
			{ 70, ""},
			{ 71, ""},
			{ 72, ""},
			{ 73, ""},
			{ 74, ""},
			{ 75, ""},
			{ 76, ""},
			{ 77, ""},
			{ 78, ""},
			{ 79, ""},
			{ 80, ""},
			{ 81, ""},
			{ 82, ""},
			{ 83, ""},
			{ 84, ""},
			{ 85, ""},
			{ 86, ""},
			{ 87, ""},
			{ 88, ""},
			{ 89, ""},
			{ 90, ""},
			{ 91, ""},
			{ 92, ""},
			{ 93, ""},
			{ 94, ""},
			{ 95, ""},
			{ 96, ""},
			{ 97, ""},
			{ 98, ""},
			{ 99, ""},
			{ 100, ""},
			{ 101, ""},
			{ 102, ""},
			{ 103, ""},
			{ 104, ""},
			{ 105, ""},
			{ 106, ""},
			{ 107, ""},
			{ 108, ""},
			{ 109, ""},
			{ 110, ""},
			{ 111, ""},
			{ 112, ""},
			{ 113, ""},
			{ 114, ""},
			{ 115, ""},
			{ 116, ""},
			{ 117, ""},
			{ 118, ""},
			{ 119, ""},
			{ 120, ""},
			{ 121, ""},
			{ 122, ""},
			{ 123, ""},
			{ 124, ""},
			{ 125, ""},
			{ 126, ""},
			{ 127, ""},
			{ 128, ""},
			{ 129, ""},
			{ 130, ""},
			{ 131, ""},
			{ 132, ""},
			{ 133, ""},
			{ 134, ""},
			{ 135, ""},
			{ 136, ""},
			{ 137, ""},
			{ 138, ""},
			{ 139, ""},
			{ 140, ""},
			{ 141, ""},
			{ 142, ""},
			{ 143, ""},
			{ 144, ""},
			{ 145, ""},
			{ 146, ""},
			{ 147, ""},
			{ 148, ""},
			{ 149, ""},
			{ 150, ""},
			{ 151, ""},
			{ 152, ""},
			{ 153, ""},
			{ 154, ""},
			{ 155, ""},
			{ 156, ""},
			{ 157, ""},
			{ 158, ""},
			{ 159, ""},
			{ 160, ""},
			{ 161, ""},
			{ 162, ""},
			{ 163, ""},
			{ 164, ""},
			{ 165, ""},
			{ 166, ""},
			{ 167, ""},
			{ 168, ""},
			{ 169, ""},
			{ 170, ""},
			{ 171, ""},
			{ 172, ""},
			{ 173, ""},
			{ 174, ""},
			{ 175, ""},
			{ 176, ""},
			{ 177, ""},
			{ 178, ""},
			{ 179, ""},
			{ 180, ""},
			{ 181, ""},
			{ 182, ""},
			{ 183, ""},
			{ 184, ""},
			{ 185, ""},
			{ 186, ""},
			{ 187, ""},
			{ 188, ""},
			{ 189, ""},
			{ 190, ""},
			{ 191, ""},
			{ 192, ""},
			{ 193, ""},
			{ 194, ""},
			{ 195, ""},
			{ 196, ""},
			{ 197, ""},
			{ 198, ""},
			{ 199, ""},
			{ 200, ""},
			{ 201, ""},
			{ 202, ""},
			{ 203, ""},
			{ 204, ""},
			{ 205, ""},
			{ 206, ""},
			{ 207, ""},
			{ 208, ""},
			{ 209, ""},
			{ 210, ""},
			{ 211, ""},
			{ 212, ""},
			{ 213, ""},
			{ 214, ""},
			{ 215, ""},
			{ 216, ""},
			{ 217, ""},
			{ 218, ""},
			{ 219, ""},
			{ 220, ""},
			{ 221, ""},
			{ 222, ""},
			{ 223, ""},
			{ 224, ""},
			{ 225, ""},
			{ 226, ""},
			{ 227, ""},
			{ 228, ""},
			{ 229, ""},
			{ 230, ""},
			{ 231, ""},
			{ 232, ""},
			{ 233, ""},
			{ 234, ""},
			{ 235, ""},
			{ 236, ""},
			{ 237, ""},
			{ 238, ""},
			{ 239, ""},
			{ 240, ""},
			{ 241, ""},
			{ 242, ""},
			{ 243, ""},
			{ 244, ""},
			{ 245, ""},
			{ 246, ""},
			{ 247, ""},
			{ 248, ""},
			{ 249, ""},
			{ 250, ""},
			{ 251, ""},
			{ 252, ""},
			{ 253, ""},
			{ 254, ""},
			{ 255, ""},
			{ 256, ""},
			{ 257, ""},
			{ 258, ""},
			{ 259, ""},
			{ 260, ""},
			{ 261, ""},
			{ 262, ""},
			{ 263, ""},
			{ 264, ""},
			{ 265, ""},
			{ 266, ""},
			{ 267, ""},
			{ 268, ""},
			{ 269, ""},
			{ 270, ""},
			{ 271, ""},
			{ 272, ""},
			{ 273, ""},
			{ 274, ""},
			{ 275, ""},
			{ 276, ""},
			{ 277, ""},
			{ 278, ""},
			{ 279, ""},
			{ 280, ""},
			{ 281, ""},
			{ 282, ""},
			{ 283, ""},
			{ 284, ""},
			{ 285, ""},
			{ 286, ""},
			{ 287, ""},
			{ 288, ""},
			{ 289, ""},
			{ 290, ""},
			{ 291, ""},
			{ 292, ""},
			{ 293, ""},
			{ 294, ""},
			{ 295, ""},
			{ 296, ""},
			{ 297, ""},
			{ 298, ""},
			{ 299, ""},
			{ 300, ""},
			{ 301, ""},
			{ 302, ""},
			{ 303, ""},
			{ 304, ""},
			{ 305, ""},
			#endregion
		};
		
		#region MFS
		
		Drive sys = new Drive();
		
		#endregion
		
		public Bitmap display = new Bitmap(80, 60);
		public Bitmap buffer = new Bitmap(80, 60);
		public bool wait = false;
		
		public string check(bool check)
		{
			if(check)
				return "1";
			return "0";
		}
		
		public void AdressCheck()
		{
			if(cmn[3] == "1") // Math
			{
				cmn[3] = "0";
				if(cmn[6] == "1")
					cmn[7] = (double.Parse(cmn[4]) + double.Parse(cmn[5])).ToString();
				else if(cmn[6] == "2")
					cmn[7] = (double.Parse(cmn[4]) - double.Parse(cmn[5])).ToString();
				else if(cmn[6] == "3")
					cmn[7] = (double.Parse(cmn[4]) * double.Parse(cmn[5])).ToString();
				else if(cmn[6] == "4")
					cmn[7] = (double.Parse(cmn[4]) / double.Parse(cmn[5])).ToString();
				else if(cmn[6] == "5")
					cmn[7] = (double.Parse(cmn[4]) % double.Parse(cmn[5])).ToString();
			}
			else if(cmn[3] == "2") // If
			{
				cmn[3] = "0";
				if(cmn[6] == "1")
					cmn[7] = check(cmn[4] == cmn[5]);
				else if(cmn[6] == "2")
					cmn[7] = check(cmn[4] != cmn[5]);
				else if(cmn[6] == "3")
					cmn[7] = check(double.Parse(cmn[4]) > double.Parse(cmn[5]));
				else if(cmn[6] == "4")
					cmn[7] = check(double.Parse(cmn[4]) >= double.Parse(cmn[5]));
				else if(cmn[6] == "5")
					cmn[7] = check(double.Parse(cmn[4]) < double.Parse(cmn[5]));
				else if(cmn[6] == "6")
					cmn[7] = check(double.Parse(cmn[4]) <= double.Parse(cmn[5]));
				else if(cmn[6] == "7")
					cmn[7] = check(cmn[4].StartsWith(cmn[5]));
				else if(cmn[6] == "8")
					cmn[7] = check(cmn[4].EndsWith(cmn[5]));
			}
			else if(cmn[3] == "3") // Draw
			{
				cmn[3] = "0";
				try { buffer.SetPixel(int.Parse(cmn[4]), int.Parse(cmn[5]), prs(cmn[6])); }
				catch
				{
					if(cmn[35] == "1")
						MessageBox.Show("При переводе из строкового типа произошла ошибка,\nвозможно строка имела неправильный формат.", "Mort -> AdressCheck", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if(cmn[3] == "4") // Apply
			{
				cmn[3] = "0";
				display = buffer;
				this.BackgroundImage = Zoom(display, this.Size);
			}
			else if(cmn[3] == "5") // Clear
			{
				cmn[3] = "0";
				buffer = new Bitmap(80, 60);
			}
			else if(cmn[3] == "6") // Message
			{
				if(cmn[6] == "1")
					MessageBox.Show(cmn[4], cmn[5], MessageBoxButtons.OK, MessageBoxIcon.None);
				else if(cmn[6] == "2")
					MessageBox.Show(cmn[4], cmn[5], MessageBoxButtons.OK, MessageBoxIcon.Information);
				else if(cmn[6] == "3")
					MessageBox.Show(cmn[4], cmn[5], MessageBoxButtons.OK, MessageBoxIcon.Error);
				else if(cmn[6] == "4")
					MessageBox.Show(cmn[4], cmn[5], MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if(cmn[3] == "7") // Create directory
			{
				cmn[3] = "0";
				sys.data.Add(new Directory(cmn[4], new List<File> {}));
			}
			else if(cmn[3] == "8") // Delete directory
			{
				cmn[3] = "0";
				sys.RemoveByName(cmn[4]);
			}
			else if(cmn[3] == "9") // Create file
			{
				cmn[3] = "0";
				sys.GetByName(cmn[4]).data.Add(new File(cmn[5], new List<string> {}));
			}
			else if(cmn[3] == "11") // Clear file
			{
				cmn[3] = "0";
				sys.GetByName(cmn[4]).GetByName(cmn[5]).data.Clear();
			}
			else if(cmn[3] == "12") // Length file
			{
				cmn[3] = "0";
				cmn[6] = sys.GetByName(cmn[4]).GetByName(cmn[5]).data.Count.ToString();
			}
			else if(cmn[3] == "12") // Longlength file
			{
				cmn[3] = "0";
				cmn[6] = sys.GetByName(cmn[4]).GetByName(cmn[5]).data.ToArray().LongLength.ToString();
			}
			else if(cmn[3] == "13") // Add text to file
			{
				cmn[3] = "0";
				sys.GetByName(cmn[4]).GetByName(cmn[5]).data.Add(cmn[6]);
			}
			else if(cmn[3] == "14") // Insert text to file
			{
				cmn[3] = "0";
				sys.GetByName(cmn[4]).GetByName(cmn[5]).data.Insert(int.Parse(cmn[7]), cmn[6]);
			}
			else if(cmn[3] == "15") // Remove line from file
			{
				cmn[3] = "0";
				sys.GetByName(cmn[4]).GetByName(cmn[5]).data.RemoveAt(int.Parse(cmn[6]));
			}
			else if(cmn[3] == "16") // Get part
			{
				cmn[3] = "0";
				cmn[7] = cmn[4].Substring(int.Parse(cmn[5]), int.Parse(cmn[6]));
			}
			else if(cmn[3] == "17") // Get length
			{
				cmn[3] = "0";
				cmn[5] = cmn[4].Length.ToString();
			}
			else if(cmn[3] == "18") // Save drive
			{
				cmn[3] = "0";
				sys.Save(cmn[4]);
			}
			else if(cmn[3] == "19") // Load drive
			{
				cmn[3] = "0";
				sys.Load(cmn[4]);
			}
			else if(cmn[3] == "20") // Run
			{
				cmn[3] = "0";
				Do(sys.GetByName(cmn[4]).GetByName(cmn[5]).data.ToArray());
			}
			else if(cmn[3] == "21") // Run async
			{
				cmn[3] = "0";
				BackgroundWorker main = new BackgroundWorker();
	            main.DoWork += (object sender3, DoWorkEventArgs ex) =>
	            {
	                Do(sys.GetByName(cmn[4]).GetByName(cmn[5]).data.ToArray());
	            };
	            main.RunWorkerAsync();
			}
			else if(cmn[3] == "22") // Exists file
			{
				cmn[3] = "0";
				if (sys.GetByName(cmn[4]).GetByName(cmn[5]) != null)
					cmn[6] = "1";
				else
					cmn[6] = "0";
			}
			else if(cmn[3] == "23") // Exists directory
			{
				cmn[3] = "0";
				if (sys.GetByName(cmn[4]) != null)
					cmn[5] = "1";
				else
					cmn[5] = "0";
			}
			else if(cmn[3] == "24") // Wait
			{
				cmn[3] = "0";
				Thread.Sleep(int.Parse(cmn[4]));
			}
			else if(cmn[3] == "25") // Get char
			{
				cmn[3] = "0";
				wait = true;
				while(wait) {}
			}
			else if(cmn[3] == "26") // Get char n wait
			{
				cmn[3] = "0";
				wait = true;
				Thread.Sleep(int.Parse(cmn[8]));
				if(wait)
				{
					wait = false;
					cmn[4] = "no";
				}
			}
		}
		
		public Color prs(string k)
        {
            string[] s = k.Split(";".ToCharArray(), StringSplitOptions.None);
            return Color.FromArgb(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]), int.Parse(s[3]));
        }
		
		char get(string numa)
        {
            byte num = 0;
            if (numa.StartsWith("0"))
                num = byte.Parse(numa.Remove(0, 1));
            else
                num = byte.Parse(numa);
            if (num == 0)
                return ' ';
            if (num == 1)
                return '\n';
            return "**qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNMйцукенгшщзхъфывапролджэячсмитьбюёЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮЁ1234567890!@#$%^&*()_+-={}[];:'\"\\|/,.<>?`~"[num];
        }
		
		public string[] GetAdresses()
		{
			List<string> a = new List<string>{};
			for(int i = 0; i < 30; i++)
				a.Add(cmn.ElementAt(i).Key + ": " + cmn.ElementAt(i).Value);
			return a.ToArray();
		}
		
		public void Do(string text)
		{
			if(text != String.Empty)
			{
				string[] kal = text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				int command = Convert.ToInt32(kal[0]);
				if(command <= 24 && command >= 20)
				{
					if (cmn[command] == "mv")
					{
						int to = Convert.ToInt32(kal[1]);
						if(kal[2].StartsWith("$"))
						{
							if(to >= 50)
							{
								cmn[to] = text.Substring(kal[0].Length + kal[1].Length + 3);
							}
							else
							{
								cmn[to] = text.Substring(kal[0].Length + kal[1].Length + 3);
								if(cmn[35] == "1")
									MessageBox.Show("Адрес " + kal[1] + " или " + kal[2] + " является постоянным\nМогут быть вызваны ошибки.", "Mort -> Do", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
						else
						{
							int fm = Convert.ToInt32(kal[2]);
							if(to >= 50 && fm >= 50)
							{
								cmn[to] = cmn[fm];
								cmn[fm] = "";
							}
							else
							{
								cmn[to] = cmn[fm];
								cmn[fm] = "";
								if(cmn[35] == "1")
									MessageBox.Show("Адрес " + kal[1] + " или " + kal[2] + " является постоянным\nМогут быть вызваны ошибки.", "Mort -> Do", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
					}
					else if (cmn[command] == "cp")
					{
						int to = Convert.ToInt32(kal[1]);
						if(kal[2].StartsWith("$"))
						{
							if(to >= 50)
							{
								cmn[to] = text.Substring(kal[0].Length + kal[1].Length + 3);
							}
							else
							{
								cmn[to] = text.Substring(kal[0].Length + kal[1].Length + 3);
								if(cmn[35] == "1")
									MessageBox.Show("Адрес " + kal[1] + " или " + kal[2] + " является постоянным\nМогут быть вызваны ошибки.", "Mort -> Do", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
						else
						{
							int fm = Convert.ToInt32(kal[2]);
							if(to >= 50 && fm >= 50)
							{
								cmn[to] = cmn[fm];
							}
							else
							{
								cmn[to] = cmn[fm];
								if(cmn[35] == "1")
									MessageBox.Show("Адрес " + kal[1] + " или " + kal[2] + " является постоянным\nМогут быть вызваны ошибки.", "Mort -> Do", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
					}
					else if (cmn[command] == "ad")
					{
						int to = Convert.ToInt32(kal[1]);
						if(kal[2].StartsWith("$"))
						{
							if(to >= 50)
							{
								cmn[to] += text.Substring(kal[0].Length + kal[1].Length + 3);
							}
							else
							{
								cmn[to] += text.Substring(kal[0].Length + kal[1].Length + 3);
								if(cmn[35] == "1")
									MessageBox.Show("Адрес " + kal[1] + " или " + kal[2] + " является постоянным\nМогут быть вызваны ошибки.", "Mort -> Do", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
						else
						{
							int fm = Convert.ToInt32(kal[2]);
							if(to >= 50 && fm >= 50)
							{
								cmn[to] += cmn[fm];
							}
							else
							{
								cmn[to] += cmn[fm];
								if(cmn[35] == "1")
									MessageBox.Show("Адрес " + kal[1] + " или " + kal[2] + " является постоянным\nМогут быть вызваны ошибки.", "Mort -> Do", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
					}
					else if (cmn[command] == "nc")
					{
						int to = Convert.ToInt32(kal[1]);
						if(to >= 50)
							cmn[to] = (int.Parse(cmn[to]) + 1).ToString();
						else
						{
							cmn[to] = (int.Parse(cmn[to]) + 1).ToString();
							if(cmn[35] == "1")
								MessageBox.Show("Адрес " + kal[1] + " является постоянным\nМогут быть вызваны ошибки.", "Mort -> Do", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
					else if (cmn[command] == "dc")
					{
						int to = Convert.ToInt32(kal[1]);
						if(to >= 50)
							cmn[to] = (int.Parse(cmn[to]) - 1).ToString();
						else
						{
							cmn[to] = (int.Parse(cmn[to]) - 1).ToString();
							if(cmn[35] == "1")
								MessageBox.Show("Адрес " + kal[1] + " является постоянным\nМогут быть вызваны ошибки.", "Mort -> Do", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
					AdressCheck();
				}
				else
				{
					if(cmn[35] == "1")
						MessageBox.Show("Адрес " + kal[0] + " не является постоянным", "Mort -> Do", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		/*
		 * 52 label
		 * 53 goto
		 * 54 if
		 * 55 end
		 * 56 stop
		*/
		
		public void Do(string[] code)
		{
			for(int i = 0; i < code.Length; i++)
			{
				if(code[i].StartsWith("53 "))
				{
					int kk = 0;
					for(int a = 0; a < code.Length; a++)
					{
						if(code[a] == "52 " + code[i].Substring(2))
						{
							kk = a + 1;
							break;
						}
					}
					i = kk;
				}
				else if(code[i].StartsWith("54 "))
				{
					int kk = 0;
					int count = 0;
					if(cmn[Convert.ToInt32(code[i].Substring(2))] == "1")
						continue;
					for(int a = 0; a < code.Length; a++)
					{
						if(code[a] == "55" && count != 0)
							count--;
						else if(code[a].StartsWith("54 "))
							count++;
						else if(code[a] == "55" && count == 0)
						{
							kk = a + 1;
							break;
						}
					}
					i = kk;
				}
				else if(code[i] == "56")
					break;
				else if(!code[i].StartsWith("52 ") && code[i] != "55")
					Do(code[i]);
			}
		}
		
		public Bitmap Zoom(Image bmp, Size size)
        {
            var result = new Bitmap(size.Width, size.Height);
            using(var gr = Graphics.FromImage(result))
            {
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                gr.DrawImage(bmp, 0, 0, size.Width, size.Height);
            }
 
            return result;
        }
		
		public MainForm()
		{
			InitializeComponent();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			//backgroundWorker1.RunWorkerAsync();
			sys.Load("disk1.txt");
			BackgroundWorker main = new BackgroundWorker();
            main.DoWork += (object sender3, DoWorkEventArgs ex) =>
            {
                Do(sys.GetByName("mbs").GetByName("main").data.ToArray());
            };
            main.RunWorkerAsync();
			//backgroundWorker1.CancelAsync();
		}
		void BackgroundWorker1DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			
		}
		void AdressesToolStripMenuItemClick(object sender, EventArgs e)
		{
			List<string> adr = new List<string> {};
			for(int i = 0; i < cmn.Count; i++)
				adr.Add(cmn.ElementAt(i).Key + ": " + cmn.ElementAt(i).Value);
			MessageBox.Show(string.Join("\n", adr.ToArray()), "Mort -> Adresses", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (wait)
            {
				cmn[4] = e.KeyCode.ToString();
                if (e.Shift)
                	cmn[5] = "1";
                else
                    cmn[5] = "0";
                if (e.Alt)
                	cmn[6] = "1";
                else
                    cmn[6] = "0";
                if (e.Control)
                    cmn[7] = "1";
                else
                    cmn[7] = "0";
                wait = false;
            }
		}
	}
	public class Drive
	{
		public string name;
		public List<Directory> data = new List<Directory> {};
		
		public Drive() { }
		
		public Drive(string name, List<Directory> data)
		{
			this.name = name;
			this.data = data;
		}
		
		public void RemoveByName(string name)
		{
			foreach(Directory a in data)
			{
				if(a.name == name)
				{
					data.Remove(a);
					break;
				}
			}
		}
		
		public Directory GetByName(string name)
		{
			foreach(Directory a in data)
				if(a.name == name)
					return a;
			return null;
		}
		
		public void Save(string file)
		{
			List<string> result = new List<string>
			{
				name,
				"#"
			};
			foreach(Directory a in data)
			{
				result.Add("&" + a.name);
				foreach(File b in a.data)
				{
					result.Add("?" + b.name);
					foreach(string c in b.data)
						result.Add(c);
					result.Add("end");
				}
				result.Add("end");
			}
			System.IO.File.WriteAllLines(file, result.ToArray());
		}
		
		public void Load(string file)
		{
			try
			{
			List<string> logs = new List<string>{};
			this.name = "";
			this.data = new List<Directory> {};
			string[] cn = System.IO.File.ReadAllLines(file);
			this.name = cn[0];
			logs.Add("Drive name: " + name);
			for(int a = 2; a < cn.Length; a++)
			{
				if(cn[a].StartsWith("&"))
				{
					Directory dir = new Directory();
					dir.name = cn[a].Remove(0, 1);
					logs.Add("Directory create: " + dir.name);
					for(int b = a + 1; b < cn.Length; b++)
					{
						if(cn[b].StartsWith("?"))
						{
							File fil = new File();
							fil.name = cn[b].Remove(0, 1);
							logs.Add("File create: " + fil.name);
							for(int c = b + 1; c < cn.Length; c++)
							{
								if(cn[c] != "end")
									fil.data.Add(cn[c]);
								else
								{
									dir.data.Add(fil);
									logs.Add("File end");
									b = c;
									break;
								}
							}
							logs.Add("File first line: " + fil.data[0]);
						}
						else if(cn[b] == "end")
						{
							this.data.Add(dir);
							logs.Add("Directory end");
							a = b;
							break;
						}
					}
				}
			}
			System.IO.File.WriteAllLines("logs.txt", logs.ToArray());
			}
			catch(Exception e)
			{
				MessageBox.Show("Message: " + e.Message + "\nFull: " + e.StackTrace);
			}
		}
	}
	public class Directory
	{
		public string name;
		public List<File> data = new List<File> {};
		
		public Directory() { }
		
		public void RemoveByName(string name)
		{
			foreach(File a in data)
			{
				if(a.name == name)
				{
					data.Remove(a);
					break;
				}
			}
		}
		
		public File GetByName(string name)
		{
			foreach(File a in data)
				if(a.name == name)
					return a;
			return null;
		}
		
		public Directory(string name, List<File> data)
		{
			this.name = name;
			this.data = data;
		}
	}
	public class File
	{
		public string name;
		public List<string> data = new List<string> {};
		
		public File() { }
		
		public File(string name, List<string> data)
		{
			this.name = name;
			this.data = data;
		}
	}
}
