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
        bool genAndOperationStatus = false;

        private void generationButton_Click(object sender, EventArgs e)
        {
            genAndOperationStatus = false;

            array_res.array = ArrayOperations.GenerateArray((int)numericUpDown1.Value,
                                                            (int)numericUpDown2.Value,
                                                            (int)numericUpDown3.Value);
            if (array_res.array.Length <= 20)
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
                int c = (int)numericUpDown1.Value;
                array_res.math_exp = ArrayOperations.MathExp(array_res.array);
                array_res.dispersion = ArrayOperations.VarianceCalc(array_res.array);
                array_res.median = ArrayOperations.FindMedian(array_res.array);
                array_res.countOdd = ArrayOperations.FindOddNumbersSumAndCount(array_res.array, c);
                array_res.primeNumbers = ArrayOperations.FindNumberOfPrimeNumbers(array_res.array);
                genAndOperationStatus = true;
                saveOper_button.Enabled = true;
            }

            if (evds_rbutton.Checked) { textBox1.Text = $"EV: {Math.Round(array_res.math_exp, 3).ToString("G5")} Dispersion: {Math.Round(array_res.dispersion, 3).ToString("G5")}"; }

            if (median_rbutton.Checked) { textBox1.Text = $"Median: {Math.Round(array_res.median, 3).ToString("G5")}"; }

            if (CountOddNum.Checked) { textBox1.Text = $"Sum of Odd numbers: {array_res.countOdd[0].ToString("G5")} Counter of Odd numbers: {array_res.countOdd[1].ToString("G5")}"; }

            if (PrimeNum.Checked) { textBox1.Text = $"Number of prime numbers is: {array_res.primeNumbers.ToString("G5")}"; }


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

        private void saveOper_button_Click(object sender, EventArgs e)
        {
            string fname = "saved_operation.json";
            if (array_res != null)
            {
                ArrayOperations.SaveResultsToJson(fname, array_res); textBox1.Text = $"The results is saved to {fname} file";
            }
            else textBox1.Text = "Something went wrong... :(";
        }

        private async void openArray_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofiled = new OpenFileDialog();
            ofiled.Title = "Choose the .json file";
            ofiled.Filter = "Files JSON (*.json)|*.json|All files (*.*)|*.*\"";
            ofiled.Multiselect = false;

            if (ofiled.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofiled.FileName;
                textBox1.Text = $"Selected path: {filePath.ToString()}";
            }

            try
            {
                array_res.array = await ArrayOperations.OpenArrayFromJson(ofiled.FileName, array_res.array);
                runButton.Enabled = true;
                saveArrayToJson_button.Enabled = true;
                saveOper_button.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Something went wrong...", "File error", MessageBoxButtons.OK);
            }
        }

    }
}