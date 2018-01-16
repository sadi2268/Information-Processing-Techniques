using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); //LogHelper.GetLogger(); 

        List<string> matrixSizes = new List<string>() { "100 x 100", "500 x 500", "1000 x 1000" };
        List<string> matrixTypes = new List<string>() { "Integer", "Double", "Decimal" };
        List<string> threadingTypes = new List<string>() { "Single Thread", "10 Threads", "Task Parallel Library", "Asynchronous Tasks" };
        BindingSource matrixSizeSource = new BindingSource();
        BindingSource matrixTypeSource = new BindingSource();
        BindingSource threadingTypeSource = new BindingSource();

        List<int> progressNumbers = new List<int>();

        static int SEED = 2268;
        static int steps;
        static int count;
        static Random random = new Random(SEED);
        Stopwatch watch = new Stopwatch();


        public MainForm()
        {
            InitializeComponent();

            matrixSizeSource.DataSource = matrixSizes;
            MatrixSizeComboBox.DataSource = matrixSizeSource;

            matrixTypeSource.DataSource = matrixTypes;
            StorageComboBox.DataSource = matrixTypeSource;

            threadingTypeSource.DataSource = threadingTypes;
            ThreadingComboBox.DataSource = threadingTypeSource;
        }

        private void GenerateIntegerMatrix(int[,] matrix, int size)
        {
            int MINNUM = 10;
            int MAXNUM = 99999;

            for (int rowIndex = 0; rowIndex < size; ++rowIndex)
                for (int colIndex = 0; colIndex < size; ++colIndex)
                    matrix[rowIndex, colIndex] = random.Next(MINNUM, MAXNUM);
        }

        private void GenerateDoubleMatrix(double[,] matrix, int size)
        {
            double MINNUM = 0.10;
            double MAXNUM = 999.99;
            /*
            List<double> doublerange = new List<double>();
            double doublestep = 0.01;
            for (double index = MINNUM; index < MAXNUM; index += doublestep)
            {
                doublerange.Add(Math.Round(index, 2));
            }
            List<decimal> decimalrange = new List<decimal>();
            decimal decimalstep = 0.01M;
            for (decimal index = (decimal)MINNUM; index < (decimal)MAXNUM; index += decimalstep)
            {
                decimalrange.Add(index);
            }
            */
            for (int rowIndex = 0; rowIndex < size; ++rowIndex)
            {
                for (int colIndex = 0; colIndex < size; ++colIndex)
                {
                    Double value = random.NextDouble() * (MAXNUM - MINNUM) + MINNUM;
                    matrix[rowIndex, colIndex] = Math.Round(value, 2);
                }

            }
        }

        private void GenerateDecimalMatrix(decimal[,] matrix, int size)
        {
            decimal MINNUM = 0.10M;
            decimal MAXNUM = 999.99M;
            for (int rowIndex = 0; rowIndex < size; ++rowIndex)
            {
                for (int colIndex = 0; colIndex < size; ++colIndex)
                {
                    decimal value = (decimal)random.NextDouble() * (MAXNUM - MINNUM) + MINNUM;
                    matrix[rowIndex, colIndex] = Math.Round(value, 2);
                }
            }
        }

        private static Task<int> getPrimesAsync(int min, int count)
        {
            return Task.Run(() => min*count);
            //return Task.Run(() => Enumerable.Range(min, count).Where(n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));
        }

        private static async Task MatrixMultiplicationAsync(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix, int firstRowSize, int firstColSize, int secondColSize)
        {
            for (int rowIndex = 0; rowIndex < firstRowSize; ++rowIndex)
                for (int colIndex = 0; colIndex < secondColSize; ++colIndex)
                {
                    int sum = 0;
                    for (int multIndex = 0; multIndex < firstColSize; ++multIndex)
                    {
                        int firstValue = firstMatrix[rowIndex, multIndex];
                        int secondValue = secondMatrix[multIndex, colIndex];
                        var result = await getPrimesAsync(firstValue, secondValue);
                        sum += result;

                        //sum+=result
                    }
                    resultMatrix[rowIndex, colIndex] = sum;
                }
        }

        private void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix, int firstRowSize, int firstColSize, int secondColSize)
        {
            for (int rowIndex = 0; rowIndex < firstRowSize; ++rowIndex)
            {
                for (int colIndex = 0; colIndex < secondColSize; ++colIndex)
                {
                    int sum = 0;
                    for (int multIndex = 0; multIndex < firstColSize; ++multIndex)
                    {
                        sum += firstMatrix[rowIndex, multIndex] * secondMatrix[multIndex, colIndex];
                    }
                    resultMatrix[rowIndex, colIndex] = sum;
                    count++;
                    double val = (count * 100) / steps ;
                    backgroundWorker1.ReportProgress((int)val);
                    //progressNumbers.Add((int)val);
                }
            }
        }

        private void MultiplyMatrixDouble(double[,] firstMatrix, double[,] secondMatrix, double[,] resultMatrix, int firstRowSize, int firstColSize, int secondColSize)
        {
            for (int rowIndex = 0; rowIndex < firstRowSize; ++rowIndex)
            {
                for (int colIndex = 0; colIndex < secondColSize; ++colIndex)
                {
                    double sum = 0.0;
                    for (int multIndex = 0; multIndex < firstColSize; ++multIndex)
                    {
                        sum += firstMatrix[rowIndex, multIndex] * secondMatrix[multIndex, colIndex];
                    }
                    resultMatrix[rowIndex, colIndex] = sum;
                    count++;
                    double val = (count * 100) / steps;
                    backgroundWorker1.ReportProgress((int)val);
                    //progressNumbers.Add((int)val);
                }
            }
        }

        private void MultiplyMatrixDecimal(decimal[,] firstMatrix, decimal[,] secondMatrix, decimal[,] resultMatrix, int firstRowSize, int firstColSize, int secondColSize)
        {
            for (int rowIndex = 0; rowIndex < firstRowSize; ++rowIndex)
            {
                for (int colIndex = 0; colIndex < secondColSize; ++colIndex)
                {
                    decimal sum = 0.0M;
                    for (int multIndex = 0; multIndex < firstColSize; ++multIndex)
                    {
                        sum += firstMatrix[rowIndex, multIndex] * secondMatrix[multIndex, colIndex];
                    }
                    resultMatrix[rowIndex, colIndex] = sum;
                    count++;
                    double val = (count * 100) / steps;
                    backgroundWorker1.ReportProgress((int)val);
                    //progressNumbers.Add((int)val);
                }
            }
        }

        private void MultiplyMatrixParallel(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix, int firstRowSize, int firstColSize, int secondColSize)
        {
            Parallel.For(0, firstRowSize, rowIndex =>
            {
                for (int colIndex = 0; colIndex < secondColSize; ++colIndex)
                {
                    int sum = 0;
                    for (int multIndex = 0; multIndex < firstColSize; ++multIndex)
                    {
                        sum += firstMatrix[rowIndex, multIndex] * secondMatrix[multIndex, colIndex];
                    }
                    resultMatrix[rowIndex, colIndex] = sum;
                    count++;
                    double val = (count * 100) / steps;
                    backgroundWorker1.ReportProgress((int)val);
                }
            });
        }

        private void MultiplyMatrixParallelDouble(double[,] firstMatrix, double[,] secondMatrix, double[,] resultMatrix, int firstRowSize, int firstColSize, int secondColSize)
        {
            Parallel.For(0, firstRowSize, rowIndex =>
            {
                for (int colIndex = 0; colIndex < secondColSize; ++colIndex)
                {
                    double sum = 0;
                    for (int multIndex = 0; multIndex < firstColSize; ++multIndex)
                    {
                        sum += firstMatrix[rowIndex, multIndex] * secondMatrix[multIndex, colIndex];
                    }
                    resultMatrix[rowIndex, colIndex] = sum;
                    count++;
                    double val = (count * 100) / steps;
                    backgroundWorker1.ReportProgress((int)val);
                }
            });
        }

        private void MultiplyMatrixParallelDecimal(decimal[,] firstMatrix, decimal[,] secondMatrix, decimal[,] resultMatrix, int firstRowSize, int firstColSize, int secondColSize)
        {
            Parallel.For(0, firstRowSize, rowIndex =>
            {
                for (int colIndex = 0; colIndex < secondColSize; ++colIndex)
                {
                    decimal sum = 0;
                    for (int multIndex = 0; multIndex < firstColSize; ++multIndex)
                    {
                        sum += firstMatrix[rowIndex, multIndex] * secondMatrix[multIndex, colIndex];
                    }
                    resultMatrix[rowIndex, colIndex] = sum;
                    count++;
                    double val = (count * 100) / steps;
                    backgroundWorker1.ReportProgress((int)val);
                }
            });
        }

        private List<int> ParseSize(string size)
        {
            int rows = 0;
            int columns = 0;
            List<int> dimensions = new List<int>();
            switch (size)
            {
                case "100 x 100":
                    rows = 100;
                    columns = 100;
                    break;
                case "500 x 500":
                    rows = 500;
                    columns = 500;
                    break;
                case "1000 x 1000":
                    rows = 1000;
                    columns = 1000;
                    break;

            }
            dimensions.Add(rows);
            dimensions.Add(columns);
            return dimensions;

        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageLabel.Text = "Busy processing, please wait";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string size = MatrixSizeComboBox.Text;
            log.Info("Matrix Size: " + size);
            //string size = "500 x 500";
            List<int> dimensions = ParseSize(size);
            int rows = dimensions[0];
            int columns = dimensions[1];
            string dataType = StorageComboBox.Text;
            log.Info("Data type: " + dataType);
            //string dataType = "Double";
            string threadType = ThreadingComboBox.Text;
            log.Info("Threading type: " + threadType);
            //string threadType = "Single Thread";
            List<long> time_taken = new List<long>();
            Task[] tasks = new Task[5];
            steps = rows * columns * 5;
            log.Info("Total number of multiplications: " + steps);
            count = 0;
            for (int index = 0; index < 5; index++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }

                switch (dataType)
                {
                    case "Integer":
                        {
                            int[,] FirstMatrix = new int[rows, columns];
                            GenerateIntegerMatrix(FirstMatrix, rows);
                            int[,] SecondMatrix = new int[rows, columns];
                            GenerateIntegerMatrix(SecondMatrix, rows);
                            int[,] resultMatrix = new int[rows, columns];

                            watch.Reset();
                            watch.Start();
                            if (threadType == "Single Thread")
                            {
                                MultiplyMatrix(FirstMatrix, SecondMatrix, resultMatrix, rows, rows, rows);
                            }
                            else if (threadType == "Task Parallel Library")
                            {
                                MultiplyMatrixParallel(FirstMatrix, SecondMatrix, resultMatrix, rows, rows, rows);
                            }
                            /*
                            else if (threadType == "Asynchronous Tasks")
                            {
                                Task res = MatrixMultiplicationAsync(FirstMatrix, SecondMatrix, resultMatrix, rows, rows, rows);
                                tasks[index] = res;
                            }

                            if (threadType == "Asynchronous Tasks")
                                Task.WaitAll(tasks);
                            */
                            watch.Stop();
                            long time = watch.ElapsedMilliseconds;
                            //MessageBox.Show(time.ToString());
                            time_taken.Add(time);

                        }
                        break;
                    case "Double":
                        {
                            double[,] FirstMatrix = new double[rows, columns];
                            GenerateDoubleMatrix(FirstMatrix, rows);
                            double[,] SecondMatrix = new double[rows, columns];
                            GenerateDoubleMatrix(SecondMatrix, rows);
                            double[,] resultMatrix = new double[rows, columns];

                            watch.Reset();
                            watch.Start();
                            if (threadType == "Single Thread")
                            {
                                MultiplyMatrixDouble(FirstMatrix, SecondMatrix, resultMatrix, rows, rows, rows);
                            }
                            else if (threadType == "Task Parallel Library")
                            {
                                MultiplyMatrixParallelDouble(FirstMatrix, SecondMatrix, resultMatrix, rows, rows, rows);
                            }
                            watch.Stop();
                            long time = watch.ElapsedMilliseconds;
                            time_taken.Add(time);
                            //MessageBox.Show(time.ToString());

                        }
                        break;
                    case "Decimal":
                        {
                            decimal[,] FirstMatrix = new decimal[rows, columns];
                            GenerateDecimalMatrix(FirstMatrix, rows);

                            decimal[,] SecondMatrix = new decimal[rows, columns];
                            GenerateDecimalMatrix(SecondMatrix, rows);
                            decimal[,] resultMatrix = new decimal[rows, columns];

                            watch.Reset();
                            watch.Start();
                            if (threadType == "Single Thread")
                            {
                                MultiplyMatrixDecimal(FirstMatrix, SecondMatrix, resultMatrix, rows, rows, rows);
                            }
                            else if (threadType == "Task Parallel Library")
                            {
                                MultiplyMatrixParallelDecimal(FirstMatrix, SecondMatrix, resultMatrix, rows, rows, rows);
                            }
                            watch.Stop();
                            long time = watch.ElapsedMilliseconds;
                            time_taken.Add(time);
                            //MessageBox.Show(time.ToString());

                        }
                        break;
                }
            }

            //ProgressTextBox.Text = threadType;

            Run1TextBox.Text = time_taken[0].ToString();
            Run2TextBox.Text = time_taken[1].ToString();
            Run3TextBox.Text = time_taken[2].ToString();
            Run4TextBox.Text = time_taken[3].ToString();
            Run5TextBox.Text = time_taken[4].ToString();
            double avg = time_taken.Average();
            RunAverageTextBox.Text = avg.ToString();

            log.Info("Time taken for Run # 01: " + time_taken[0]);
            log.Info("Time taken for Run # 02: " + time_taken[1]);
            log.Info("Time taken for Run # 03: " + time_taken[2]);
            log.Info("Time taken for Run # 04: " + time_taken[3]);
            log.Info("Time taken for Run # 05: " + time_taken[4]);
            log.Info("Average Time taken: " + avg);

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int val = e.ProgressPercentage;
            ProgressBar.Value = val;
            ProgressLabel.Text = val.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                ProgressLabel.Text = "Processing cancelled";
            }
            else if(e.Error != null)
            {
                ProgressLabel.Text = e.Error.Message;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                ProgressLabel.Text = "No operation in progress";
            }
        }
    }
}
