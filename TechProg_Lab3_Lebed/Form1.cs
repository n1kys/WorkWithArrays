namespace TechProg_Lab3_Lebed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            runButton.Enabled = false;
            saveArrayToJson_button.Enabled = false;
            saveOper_button.Enabled = false;
        }

        ArrayResults array_res = new ArrayResults();
        int genAndOperationStatus = 0;

        private void generationButton_Click(object sender, EventArgs e)
        {
            genAndOperationStatus = 0;

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
            saveArrayToJson_button.Enabled = true;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (evds_rbutton.Checked == true)
            {
                array_res.math_exp = ArrayOperations.MathExp(array_res.array);
                array_res.dispersion = ArrayOperations.VarianceCalc(array_res.array);
                textBox1.Text = $"EV: {Math.Round(array_res.math_exp, 3).ToString("G5")} Dispersion: {Math.Round(array_res.dispersion, 3).ToString("G5")}";
                genAndOperationStatus += 2;
            }
            else if (median_rbutton.Checked == true)
            {
                array_res.median = ArrayOperations.FindMedian(array_res.array);
                textBox1.Text = $"Median: {Math.Round(array_res.median, 3).ToString("G5")}";
                genAndOperationStatus += 1;
            }
            if (genAndOperationStatus == 3)
            {
                saveOper_button.Enabled = true;
            }

        }

        private void saveArrayToJson_button_Click(object sender, EventArgs e)
        {
            string fname = "array.json";
            if (array_res.array != null)
            {
                ArrayOperations.SaveArrayToJson(fname, array_res.array);
                textBox1.Text = $"Array is saved to {fname} file";
            }
            else textBox1.Text = "Array isn't created!";
        }
    }
}