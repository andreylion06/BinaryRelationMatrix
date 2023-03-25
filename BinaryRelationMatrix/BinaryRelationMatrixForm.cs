namespace BinaryRelationMatrix
{
    public partial class BinaryRelationMatrixForm : Form
    {
        public BinaryRelationMatrixForm()
        {
            InitializeComponent();
        }

        private int[] TryConvertToArray(TextBox withArray)
        {
            int[] arr = null;
            try
            {
                arr = Array.ConvertAll(withArray.Text.Split(", "), int.Parse);
            }
            catch
            {
                MessageBox.Show(
                    $"Invalid input in {withArray.Name}",
                    "Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            return arr!;
        }

        private void button_Count_Click(object sender, EventArgs e)
        {
            int[] arrA = TryConvertToArray(textBox_A);
            int[] arrB = TryConvertToArray(textBox_B);

            if (arrA != null && arrB != null)
            {
                BinaryRelationMatrix matrix = new BinaryRelationMatrix(arrA, arrB);
                textBox_Result.Text = matrix.GetString();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            textBox_Result.Text = "";
        }
    }
}