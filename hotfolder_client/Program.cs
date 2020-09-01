using System;
using System.Windows.Forms;
using System.Net.Sockets;

namespace _hotfolder_client {
	static class Program {
		public static TcpClient clt;
		public static NetworkStream ns;
		public static Form1 main_form;

		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			main_form = new Form1();
			Application.Run(main_form);
		}

		public static bool connect(string host, int port, out string ex_msg) {
			ex_msg = null;
			try {
				Program.clt = new TcpClient(host, port);
			} catch(Exception ex) {
				ex_msg = ex.Message;
				return false;
			}
			Program.ns = Program.clt.GetStream();
			return true;
		}

		public static bool read_message(out string msg) {
			char c;
			
			msg = "";
			while(clt.Connected) {
				try {
					 c = (char)ns.ReadByte();
				} catch {
					return false;
				}

				if(c == -1) continue;
				if(c == 4) return true;
				else msg += c;	
			}
			return false;
		}
	}
}
