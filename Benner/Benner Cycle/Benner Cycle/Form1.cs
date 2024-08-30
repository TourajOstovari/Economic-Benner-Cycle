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
                    if (literation >= 3) literation = 0;
                    year += MirrorYears[literation++];
                    txtMirror += "Rising: " + year + "\n";
                    if (literation >= 3) literation = 0;
                    year += MirrorYears[literation++];
                    txtMirror += "Falling: " + year+"\n";
                    if (literation >= 6) literation = 0;
                }
                richTextBox1.Text = txtMirror;
            }
            #endregion
            #region MajorCycleEconomic
            {
                byte literation = 0;
                int year = int.Parse(txtYear.Text);
                string txtmajor = "";
                for (int i = 0; i < 50; i++)
                {
                    if (literation >= 3) literation = 0;
                    year += MajorYears[literation++];
                    txtmajor += "Rising: " + year + "\n";
                    if (literation >= 3) literation = 0;
                    year += MajorYears[literation++];
                    txtmajor += "Falling: " + year + "\n";
                    if (literation >= 3) literation = 0;
                }
                richTextBox2.Text = txtmajor;
            }
            #endregion
        }
    }
}
