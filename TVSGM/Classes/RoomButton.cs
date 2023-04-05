namespace TVSGM.Classes
{
    public partial class RoomButton : System.Windows.Forms.Button
    {
        #region khởi tạo
        public RoomButton()
        {
            //this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "button1";
            this.Size = new System.Drawing.Size(158, 26);
            this.TabIndex = 2;
            this.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UseVisualStyleBackColor = false;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        #endregion

        #region Thiết lập chung
        #region IDStatus
        int fIDStatus = 0;
        public int StatusRoom
        {
            get
            {
                return fIDStatus;
            }
            set
            {
                fIDStatus = value;
            }
        }
        #endregion

        #region IDRoom
        string sIDRoom = string.Empty;
        public string IDRoom
        {
            get
            {
                return sIDRoom;
            }
            set
            {
                sIDRoom = value;
            }
        }
        #endregion

        #region NameRoom
        string sNameRoom = string.Empty;
        public string NameRoom
        {
            get
            {
                return sNameRoom;
            }
            set
            {
                sNameRoom = value;
            }
        }
        #endregion

        #region NameGroup
        string sNameGroup = string.Empty;
        public string NameGroup
        {
            get
            {
                return sNameGroup;
            }
            set
            {
                sNameGroup = value;
            }
        }
        #endregion
        #endregion


    }
}
