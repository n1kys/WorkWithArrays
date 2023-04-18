using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TechProg_Lab3_Lebed
{
    public class ArrayOperations
    {
        public static int[] GenerateArray(int n, int max, int min)
        {
            int[] arr = new int[n];
            if(min < max) { int a = min; min = max; max = a; }
            if (min == max) { min = 0; max = 100; }
            Random rand = new Random(DateTime.Now.Millisecond);
            for(int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(min, max);
            }
            return arr;
        }

        public static string ArrayToString(int[] arr)
        {
            return string.Join(" ", arr.Select(i => i.ToString()));
        }

        public static double MathExp(int[] arr)
        {
            return arr.Aggregate((acc, x) => acc + x) / arr.Length;
        }

        public static double VarianceCalc(int[] arr)
        {
            double average = arr.Average();
            return arr.Select(x => Math.Pow(x - average, 2)).Average();
        }

        public static double FindMedian(int[] arr)
        {
            int arr_length = arr.Length;
            var arrSort = arr.OrderBy(x => x).ToArray();

            if (arr_length % 2 == 0)  
                return (arrSort[(arr_length / 2) - 1] + arrSort[arr_length / 2]) / 2; 
            else
                return arrSort[arr_length / 2];
        }

        public async static void SaveArrayToJson(string fname, int[] arr)
        {
            using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Write))
            {
                await JsonSerializer.SerializeAsync<int[]>(fs, arr);
            }
        }

        public async static void OpenArrayFromJson(string fname, int[] arr)
        {
            using (FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read))
            {
                arr = await JsonSerializer.DeserializeAsync<int[]>(fs);
            }
        }

        public async static void SaveResultsToJson(string fname, ArrayResults arr_res)
        {
            using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<ArrayResults>(fs, arr_res);
            }
        }

        public static void AddInfoToDataGrid(ref DataGridView dgv, int[] arr)
        {
            dgv.Rows.Clear();
            dgv.ReadOnly = true;
            dgv.ColumnCount = 2;
            dgv.RowCount = (int)arr.Length;

            dgv.Columns[0].Width = 30;
            dgv.Columns[1].Width = 65;
            dgv.Columns[0].HeaderText = "i";
            dgv.Columns[1].HeaderText = "Array[i]";

            dgv.RowHeadersVisible = false;
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            for(int i = 0; i < arr.Length; ++i)
            {
                dgv[0, i].Value = i;
                dgv[1, i].Value = arr[i];
            }
        }
    }
}
