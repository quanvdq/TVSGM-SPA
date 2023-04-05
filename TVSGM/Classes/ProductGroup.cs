namespace TVSGM.Classes
{
    public partial class ProductGroup : System.Windows.Forms.Button
    {
        public ProductGroup()
        {
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.Location = new System.Drawing.Point(12, 12);
            this.Name = "btnRooGroup";
            //this.Size = new System.Drawing.Size(158, 26);
            this.TabIndex = 2;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Text = "Nhóm hàng hóa";
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UseVisualStyleBackColor = false;
        }

        #region IDProductGroup
        string sIDProductGroup = string.Empty;
        public string IDProductGroup
        {
            get
            {
                return sIDProductGroup;
            }
            set
            {
                sIDProductGroup = value;
            }
        }
        #endregion

        
    }
}
