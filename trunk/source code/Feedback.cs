/*
 * Copyright © 2004 NullFX Software
 * By: Steve Whitley
 *
 * 
 * */

namespace CZBindMaker {
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web;
    using System.Windows.Forms;
	public class Feedback : System.Windows.Forms.Form {
		private System.Windows.Forms.Label _nameLabel;
		private System.Windows.Forms.Label _emailLabel;
		private System.Windows.Forms.Label _commentsLabel;
		private System.Windows.Forms.TextBox _name;
		private System.Windows.Forms.TextBox _email;
		private System.Windows.Forms.RichTextBox _comments;
		private System.Windows.Forms.Button _submit;
		private System.Windows.Forms.Button _cancel; 
        private Account _account;
		private System.ComponentModel.Container components = null;
        private const string EMAIL_VALIDATION = @"^((?>[a-zA-Z\d!#$%&'*+\-/=?^_`{|}~]+\x20*|\x22((?=[\x01-\x7f])[^\x22\\]|\\[\x01-\x7f])*\x22\x20*)*(?<angle><))?((?!\.)(?>\.?[a-zA-Z\d!#$%&'*+\-/=?^_`{|}~]+)+|\x22((?=[\x01-\x7f])[^\x22\\]|\\[\x01-\x7f])*\x22)@(((?!-)[a-zA-Z\d\-]+(?<!-)\.)+[a-zA-Z]{2,}|\[(((?(?<!\[)\.)(25[0-5]|2[0-4]\d|[01]?\d?\d)){4}|[a-zA-Z\d\-]*[a-zA-Z\d]:((?=[\x01-\x7f])[^\\\[\]]|\\[\x01-\x7f])+)\])(?(angle)>)$";
        private System.Windows.Forms.LinkLabel _disclaimerLink;
        private const string SUCCESS_PATTERN = @".+Your Message has been sent!.+";

		internal Feedback(Account account) {
            _account = account;
			InitializeComponent();
        }
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private void InitializeComponent() {
            this._nameLabel = new System.Windows.Forms.Label();
            this._emailLabel = new System.Windows.Forms.Label();
            this._commentsLabel = new System.Windows.Forms.Label();
            this._name = new System.Windows.Forms.TextBox();
            this._email = new System.Windows.Forms.TextBox();
            this._comments = new System.Windows.Forms.RichTextBox();
            this._submit = new System.Windows.Forms.Button();
            this._cancel = new System.Windows.Forms.Button();
            this._disclaimerLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // _nameLabel
            // 
            this._nameLabel.BackColor = System.Drawing.SystemColors.Control;
            this._nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._nameLabel.Location = new System.Drawing.Point(8, 8);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(104, 23);
            this._nameLabel.TabIndex = 0;
            this._nameLabel.Text = "Your Name";
            this._nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _emailLabel
            // 
            this._emailLabel.BackColor = System.Drawing.SystemColors.Control;
            this._emailLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._emailLabel.Location = new System.Drawing.Point(8, 40);
            this._emailLabel.Name = "_emailLabel";
            this._emailLabel.Size = new System.Drawing.Size(104, 23);
            this._emailLabel.TabIndex = 1;
            this._emailLabel.Text = "Your Email Address";
            this._emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _commentsLabel
            // 
            this._commentsLabel.BackColor = System.Drawing.SystemColors.Control;
            this._commentsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._commentsLabel.Location = new System.Drawing.Point(8, 72);
            this._commentsLabel.Name = "_commentsLabel";
            this._commentsLabel.Size = new System.Drawing.Size(104, 16);
            this._commentsLabel.TabIndex = 2;
            this._commentsLabel.Text = "Your Comments";
            this._commentsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // _name
            // 
            this._name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
            this._name.Location = new System.Drawing.Point(120, 9);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(312, 20);
            this._name.TabIndex = 4;
            this._name.Text = "";
            // 
            // _email
            // 
            this._email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
            this._email.Location = new System.Drawing.Point(120, 41);
            this._email.Name = "_email";
            this._email.Size = new System.Drawing.Size(312, 20);
            this._email.TabIndex = 5;
            this._email.Text = "";
            // 
            // _comments
            // 
            this._comments.AcceptsTab = true;
            this._comments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
            this._comments.Location = new System.Drawing.Point(8, 88);
            this._comments.Name = "_comments";
            this._comments.Size = new System.Drawing.Size(424, 272);
            this._comments.TabIndex = 6;
            this._comments.Text = "";
            this._comments.WordWrap = false;
            // 
            // _submit
            // 
            this._submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._submit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._submit.Location = new System.Drawing.Point(352, 366);
            this._submit.Name = "_submit";
            this._submit.TabIndex = 7;
            this._submit.Text = "Submit";
            this._submit.Click += new System.EventHandler(this._submit_Click);
            // 
            // _cancel
            // 
            this._cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._cancel.Location = new System.Drawing.Point(264, 366);
            this._cancel.Name = "_cancel";
            this._cancel.TabIndex = 8;
            this._cancel.Text = "Cancel";
            this._cancel.Click += new System.EventHandler(this._cancel_Click);
            // 
            // _disclaimerLink
            // 
            this._disclaimerLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._disclaimerLink.Location = new System.Drawing.Point(8, 368);
            this._disclaimerLink.Name = "_disclaimerLink";
            this._disclaimerLink.Size = new System.Drawing.Size(152, 16);
            this._disclaimerLink.TabIndex = 9;
            this._disclaimerLink.TabStop = true;
            this._disclaimerLink.Text = "Security / Privacy Information";
            this._disclaimerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._disclaimerLink_LinkClicked);
            // 
            // Feedback
            // 
            this.AcceptButton = this._submit;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this._cancel;
            this.ClientSize = new System.Drawing.Size(442, 398);
            this.Controls.Add(this._disclaimerLink);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._submit);
            this.Controls.Add(this._comments);
            this.Controls.Add(this._email);
            this.Controls.Add(this._name);
            this.Controls.Add(this._commentsLabel);
            this.Controls.Add(this._emailLabel);
            this.Controls.Add(this._nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(416, 344);
            this.Name = "Feedback";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Send Feedback";
            this.ResumeLayout(false);

        }

		private void _cancel_Click(object sender, System.EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
		}

		private void _submit_Click(object sender, System.EventArgs e) {			
            DoSubmit();
		}
        private void DoSubmit() {
            if(ValidateFields()) {
                string response = "";                  
                bool success = false;
                string message = ""; 
                string post = string.Format("sender_name={0}&sender_email={1}&message={2}&opi=ds&submit=Send", HttpUtility.UrlEncode(this._name.Text), HttpUtility.UrlEncode(this._email.Text), HttpUtility.UrlEncode(this._comments.Text));
                int contentLength = ((byte[])Encoding.UTF8.GetBytes(post)).Length;                 
                #region string htttPost = "...";
                string httpPost = @"POST /modules.php?name=Feedback HTTP/1.1
Host: bindmaker.org
User-Agent: czbm/1.1.5 (embedded feedback utility) {2}
Accept: text/html;
Accept-Language: en-us,en;q=0.5
Accept-Charset: ISO-8859-1,utf-8;
Accept-Encoding: identity
Content-Type: application/x-www-form-urlencoded
Content-Length: {0}

{1}";
                #endregion 
                byte[] postData = Encoding.UTF8.GetBytes(String.Format(httpPost, contentLength, post, ((_account!=null && _account.AccountName.Length>0)?_account.AccountName:"__UNKNOWN__")));

                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPHostEntry entry = Dns.GetHostEntry("bindmaker.org");
                IPAddress czbm = IPAddress.None;
                foreach(IPAddress addr in entry.AddressList) {
                    if(addr.AddressFamily == AddressFamily.InterNetwork) {
                        czbm = addr;
                        break;
                    }
                }
                IPEndPoint dest = new IPEndPoint(czbm, 80);
                try {
                    s.Connect(dest);
                }catch (Exception e) {
                    e.ToString();
                    message = "We failed to establish a connection to\t\nthe bindmaker webservices to send this feedback.\t\nThis message was not sent.  Please try again later.\t\n\n--[CZ] Qw4z0";
                    MessageBox.Show(this, message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                NetworkStream ns = new NetworkStream(s, FileAccess.ReadWrite, true);
                ns.Write(postData, 0, postData.Length);
                ns.Flush();
                bool firstRead = false;
                int bufferSize = 1024;
                byte[] buffer = new byte[bufferSize];
                while(!firstRead) {
                    while(ns.DataAvailable) {
                        firstRead = true;
                        ns.Read(buffer, 0, buffer.Length);
                        response += Encoding.UTF8.GetString(buffer).Replace("\0", "");
                        if(response.IndexOf("\r\n\r\n") != -1) {
                            // get hex chunk size ad continue reading for that chunk
                            // until chunk size == 0.
                        }
                    }
                }
                ns.Close();
                s.Close();
                if(response.Substring(0, 12).Split(' ')[1] == "200") {
                    //if(Regex.IsMatch(response, SUCCESS_PATTERN)) {
                        success = true;
                        message = "Thank You!  Your response has been recieved.\t\nWe will try to respond to your comments in a timely manner.\t";
//                    }else {
//                        message = "Something went wrong.\t\nPlease revise your message and try again.";
//                    }
                }else if(response.Substring(0, 12).Split(' ')[1] == "403"){
                    message = "Sorry, you have been banned from bindmaker.org.\t\nIf you feel there has been some misunderstanding\t\nfeel free to contact us at qwazo@hotmail.com";
                }else {
                    message = "Sorry, your comments could not be sent at this time.\t\n";
                }
                MessageBox.Show(this, message, "Submission Results", MessageBoxButtons.OK, success?MessageBoxIcon.Information:MessageBoxIcon.Error );
                if(success) {
                    this.DialogResult = DialogResult.OK;
                }
            }else {
                string message = "Please check to see that all fields are filled out correctly.";
                MessageBox.Show(this, message, "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
		private bool ValidateFields() {
			// check name
            if(_name.Text.Length < 1) {
                return false;
            }
			// check email
            if(!Regex.IsMatch(_email.Text, EMAIL_VALIDATION, RegexOptions.IgnoreCase)) {
                return false;
            }
			// check message
            if(_comments.Text.Length < 1) {
                return false;
            }
			return true;
		}

		private string SubmissionEncoding(string text) {
			//text = HttpUtility.HtmlEncode(text);
			text = HttpUtility.UrlEncode(text);
			return text;
		}

        private void _disclaimerLink_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
            string message = @"    For security reasons all IP's are logged when using this form 
to submit any comments, suggestions, bug reports, feature                             
requests, or any other pertinent information.

    A valid (working) email address is required so that we may 
respond to you in the instance further information is needed to 
help quantify things.

    This information is only used for correspondence between us an 
you (no information is ever shared with anyone). It is not stored nor
retained in any manner at all.

    Abuse of this utility will result in a permanent denial of our 
website and services.

Thanks,
[CZ] Qw4z0";
            MessageBox.Show(this, message, "Disclosure Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
	}
}
