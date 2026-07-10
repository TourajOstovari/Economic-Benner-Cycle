namespace Benner_Cycle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] MirrorYears = new byte[6] { 2,5,4,7,3,6 };byte[] MajorYears = new byte[3] { 18,20,16 };
            
            #region MirrorCycleEconomic
            {
                byte literation = 0;
                int year = int.Parse(txtYear.Text);
                string txtMirror = "";
                for (int i = 0; i < 50; i++)
                {
                    year += MirrorYears[literation++];
                    txtMirror += "Rising: " + year + "\n";
                    year += MirrorYears[literation++];
                    txtMirror += "Falling: " + year+"\n";
                    if (literation >= 5) literation = 0;
                }
                richTextBox1.Text = txtMirror;
            }
            #endregion
            #region MajorCycleEconomic
            {
                byte literation2 = 0;
                int year = int.Parse(txtYear.Text);
                string txtmajor = "";
                for (int i = 0; i < 50; i++)
                {
                    
                    year += MajorYears[literation2++];
                    txtmajor += " >>> : " + year + "\n";
                    if (literation2 >= 3) literation2 = 0;
                }
                richTextBox2.Text = txtmajor;
            }
            #endregion
        }
    }
}
