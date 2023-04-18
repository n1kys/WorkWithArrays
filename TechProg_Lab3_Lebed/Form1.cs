namespace TechProg_Lab3_Lebed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            runButton.Enabled = false;
            saveArray_button.Enabled = false;
            saveOper_button.Enabled = false;
        }

        ArrayResults array_res = new ArrayResults();
        bool genAndOperationStatus = false;

        private void generationButton_Click(object sender, EventArgs e)
        {
            genAndOperationStatus = false;

            array_res.array = ArrayOperations.GenerateArray((int)numericUpDown1.Value,
                                                            (int)numericUpDown3.Value,
                                                            (int)numericUpDown2.Value);
            if (array_res.array.Length <= 17)
            {
                textBox1.Text = ArrayOperations.ArrayToString(array_res.array);
                ArrayOperations.AddInfoToDataGrid(ref dataGridView1, array_res.array);
            }
            else { dataGridView1.Rows.Clear(); dataGridView1.Columns.Clear(); }

            runButton.Enabled = true;
            saveArray_button.Enabled = true;
        }


    }
}