namespace TVSGM.Classes
{
    public partial class RoomGroupButton : System.Windows.Forms.Button
    {
        public RoomGroupButton()
        {
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "button1";
            //this.Size = new System.Drawing.Size(158, 26);
            this.TabIndex = 2;
            this.Text = "Nhóm hàng hóa";
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UseVisualStyleBackColor = false;
        }
    }
}
