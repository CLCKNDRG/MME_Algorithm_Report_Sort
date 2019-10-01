using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MME_Algorithm_Report_Sort_01
{
    public partial class Form1 : Form
    {
        public int[] mainArray = new int[0];

        // 텍스트박스에 입출력을 담당하는 함수
        public object InputPrint(TextBox txtbox, int[] inputArray)
        {
            txtbox.Clear();
            txtbox.Text += "입력받은 배열:" + "\r\n[ " + string.Join(",", inputArray) + " ]";
            return null;
        }
        public object OutputPrint(TextBox txtbox, int[] inputArray)
        {
            txtbox.Clear();
            txtbox.Text += "정렬 후의 배열:" + "\r\n[ " + string.Join(",", inputArray) + " ]";
            return null;
        }
        //

        // 삽입정렬 함수
        public object InsertionSort(int[] inputArray)
        {
            int temp, i, j;

            var outputArray = new int[inputArray.Length];
            for (i = 0; i < outputArray.Length; i++)
            {
                outputArray[i] = inputArray[i];
            }

            // 오름차순 정렬
            if (ascend.Checked == true)
            {
                // 삽입정렬 알고리즘
                for (i = 1; i < outputArray.Length; i++)
                {
                    temp = outputArray[i];
                    for (j = i; j >= 1; j += -1)
                    {
                        if (outputArray[j - 1] > temp)
                            outputArray[j] = outputArray[j - 1];
                        else
                            break;
                    }
                    outputArray[j] = temp;
                }
            }
            // 내림차순 정렬
            else if (descend.Checked == true)
            {
                // 삽입정렬 알고리즘
                for (i = 1; i < outputArray.Length; i++)
                {
                    temp = outputArray[i];
                    for (j = i; j >= 1; j += -1)
                    {
                        if (outputArray[j - 1] < temp)
                            outputArray[j] = outputArray[j - 1];
                        else
                            break;
                    }
                    outputArray[j] = temp;
                }
            }

            OutputPrint(textBox_Insertion, outputArray);
            return null;
        }
        //

        // 셸정렬 함수
        public object ShellSort(int[] inputArray)
        {
            int temp, i, j, gap;

            var outputArray = new int[inputArray.Length];
            for (i = 0; i < outputArray.Length; i++)
            {
                outputArray[i] = inputArray[i];
            }

            gap = 3;

            // 정렬 알고리즘
            while (gap > 0)
            {
                for (i = 0; i < outputArray.Length; i++)
                {
                    j = i;
                    temp = outputArray[i];
                    // 오름차순 정렬
                    if (ascend.Checked == true)
                    {
                        while ((j >= gap) && (outputArray[j - gap] > temp))
                        {
                            outputArray[j] = outputArray[j - gap];
                            j = j - gap;
                        }
                    }
                    // 내림차순 정렬
                    else if(descend.Checked == true)
                    {
                        while ((j >= gap) && (outputArray[j - gap] < temp))
                        {
                            outputArray[j] = outputArray[j - gap];
                            j = j - gap;
                        }
                    }
                    outputArray[j] = temp;
                }
                if (gap / 2 != 0)
                {
                    gap = gap / 2;
                }
                else if (gap == 1)
                {
                    gap = 0;
                }
                else
                {
                    gap = 1;
                }
            }

            OutputPrint(textBox_Shell, outputArray);
            return null;
        }
        //

        // 빗질정렬 함수
        public object CombSort(int[] inputArray)
        {
            int i;

            var outputArray = new int[inputArray.Length];
            for (i = 0; i < outputArray.Length; i++)
            {
                outputArray[i] = inputArray[i];
            }

            double gap = outputArray.Length;
            bool swaps = true;

            // 정렬 알고리즘
            while (gap > 1 || swaps)
            {
                gap = gap / 1.3;

                if (gap < 1)
                {
                    gap = 1;
                }

                int j = 0;
                swaps = false;

                while (j + gap < outputArray.Length)
                {
                    // 오름차순 정렬
                    if (ascend.Checked == true)
                    {
                        if (outputArray[j] > outputArray[j + (int)gap])
                        {
                            int swap = outputArray[j];
                            outputArray[j] = outputArray[j + (int)gap];
                            outputArray[j + (int)gap] = swap;
                            swaps = true;
                        }
                    }
                    // 내림차순 정렬
                    else if (descend.Checked == true)
                    {
                        if (outputArray[j] < outputArray[j + (int)gap])
                        {
                            int swap = outputArray[j];
                            outputArray[j] = outputArray[j + (int)gap];
                            outputArray[j + (int)gap] = swap;
                            swaps = true;
                        }
                    }
                    j++;
                }
            }
            OutputPrint(textBox_Comb, outputArray);
            return null;
        }
        //

        // 버블정렬 함수
        public object BubbleSort(int[] inputArray)
        {
            int temp, i, j;

            var outputArray = new int[inputArray.Length];
            for (i = 0; i < outputArray.Length; i++)
                outputArray[i] = inputArray[i];

            for (i = outputArray.Length - 1; i >= 1; i += -1)
            {
                var loopTo1 = i - 1;
                for (j = 0; j <= loopTo1; j++)
                {
                    // 오름차순 정렬
                    if (ascend.Checked == true)
                    {
                        if (outputArray[j] > outputArray[j + 1])
                        {
                            temp = outputArray[j];
                            outputArray[j] = outputArray[j + 1];
                            outputArray[j + 1] = temp;
                        }
                    }
                    // 내림차순 정렬
                    else if(descend.Checked == true)
                    {
                        if (outputArray[j] < outputArray[j + 1])
                        {
                            temp = outputArray[j];
                            outputArray[j] = outputArray[j + 1];
                            outputArray[j + 1] = temp;
                        }
                    }
                }
            }

            OutputPrint(textBox_Bubble, outputArray);
            return null;
        }
        //

        // 퀵정렬 함수
        public object QuickSort(int[] inputArray)
        {
            int i, left, right;

            var outputArray = new int[inputArray.Length];
            for (i = 0; i < outputArray.Length; i++)
                outputArray[i] = inputArray[i];

            left = 0;
            right = outputArray.Length - 1;
            
            if (ascend.Checked == true)
            {
                QuickSort_Sort(outputArray, left, right);
            }
            else if (descend.Checked == true)
            {
                QuickSort_Sort_D(outputArray, left, right);
            }

            OutputPrint(textBox_Quick, outputArray);
            return null;
        }
        public int QuickSort_Partition(int[] outputArray, int left, int right)
        {
            int temp;
            int pivot = outputArray[left];

            while (true)
            {
                while (outputArray[left] < pivot)
                {
                    left++;
                }
                while (outputArray[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    temp = outputArray[right];
                    outputArray[right] = outputArray[left];
                    outputArray[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        public object QuickSort_Sort(int[] outputArray, int left, int right)
        {
            int pivot;

            if (left < right)
            {
                pivot = QuickSort_Partition(outputArray, left, right);

                if (pivot > 1)
                {
                    QuickSort_Sort(outputArray, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort_Sort(outputArray, pivot + 1, right);
                }
            }
            return null;
        }
        public int QuickSort_Partition_D(int[] outputArray, int left, int right)
        {
            int temp;
            int pivot = outputArray[left];

            while (true)
            {
                while (outputArray[left] > pivot)
                {
                    left++;
                }
                while (outputArray[right] < pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    temp = outputArray[right];
                    outputArray[right] = outputArray[left];
                    outputArray[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        public object QuickSort_Sort_D(int[] outputArray, int left, int right)
        {
            int pivot;

            if (left < right)
            {
                pivot = QuickSort_Partition_D(outputArray, left, right);

                if (pivot > 1)
                {
                    QuickSort_Sort_D(outputArray, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort_Sort_D(outputArray, pivot + 1, right);
                }
            }
            return null;
        }
        //

        // 병합정렬 함수
        public object MergeSort(int[] inputArray)
        {
            int i;

            var outputArray = new int[inputArray.Length];
            for (i = 0; i < outputArray.Length; i++)
                outputArray[i] = inputArray[i];

            var sortArray = new int[outputArray.Length];

            MergeSort_Sort(outputArray, sortArray, 0, outputArray.Length - 1);

            OutputPrint(textBox_2Merge, outputArray);
            return null;
        }
        public object MergeSort_Sort(int[] outputArray, int[] sortArray, int left, int right)
        {
            int mid;

            if (left < right)
            {
                mid = (left + right) / 2;
                MergeSort_Sort(outputArray, sortArray, left, mid);
                MergeSort_Sort(outputArray, sortArray, mid + 1, right);
                MergeSort_Merge(outputArray, sortArray, left, mid, right);
            }

            return null;
        }
        public object MergeSort_Merge(int[] outputArray, int[] sortArray, int left, int mid, int right)
        {
            int i, j, k;
            i = left;
            j = mid + 1;
            k = left;

            // 분할 된 배열을 합병한다
            while (i<=mid && j<=right)
            {
                // 오름차순 정렬
                if (ascend.Checked == true)
                {
                    if (outputArray[i] <= outputArray[j])
                    {
                        sortArray[k++] = outputArray[i++];
                    }
                    else
                    {
                        sortArray[k++] = outputArray[j++];
                    }
                }
                // 내림차순 정렬
                else if (descend.Checked == true)
                {
                    if (outputArray[i] >= outputArray[j])
                    {
                        sortArray[k++] = outputArray[i++];
                    }
                    else
                    {
                        sortArray[k++] = outputArray[j++];
                    }
                }

            }

            // 값들을 일괄적으로 복사한다
            while (i <= mid)
            {
                sortArray[k++] = outputArray[i++];
            }
            while (j <= right)
            {
                sortArray[k++] = outputArray[j++];
            }
            for (i=left; i<=right; i++)
            {
                outputArray[i] = sortArray[i];
            }

            return null;
        }
        //

        // 선택정렬 함수
        public object SelectionSort(int[] inputArray)
        {
            int temp, position, i, j;

            var outputArray = new int[inputArray.Length];
            for (i = 0; i < outputArray.Length; i++)
                outputArray[i] = inputArray[i];

            for (i = 0; i <= outputArray.Length - 1; i++)
            {
                position = i;
                for (j = i + 1; j < outputArray.Length; j++)
                {
                    // 오름차순 정렬
                    if (ascend.Checked == true)
                    {
                        if (outputArray[j] < outputArray[position])
                        {
                            position = j;
                        }
                    }
                    // 내림차순 정렬
                    else if (descend.Checked == true)
                    {
                        if (outputArray[j] > outputArray[position])
                        {
                            position = j;
                        }
                    }
                }
                if (position != i)
                {
                    temp = outputArray[position];
                    outputArray[position] = outputArray[i];
                    outputArray[i] = temp;
                }
            }

            OutputPrint(textBox_Selection, outputArray);
            return null;
        }
        //

        // 힙정렬 함수
        public object HeapSort(int[] inputArray)
        {
            var outputArray = new int[inputArray.Length];
            for (int i = 0; i < outputArray.Length; i++)
                outputArray[i] = inputArray[i];

            if (ascend.Checked == true)
            {
                HeapSort_Sort(outputArray);
            }
            else if (descend.Checked == true)
            {
                HeapSort_Sort_D(outputArray);
            }

            OutputPrint(textBox_Heap, outputArray);
            return null;
        }
        public object HeapSort_Heap(int[] outputArray, int n, int i)
        {
            int key, left, right, temp;
            key = i;
            left = i * 2 + 1;
            right = i * 2 + 2;

            if (left < n && outputArray[key] < outputArray[left])
            {
                key = left;
            }
            if (right < n && outputArray[key] < outputArray[right])
            {
                key = right;
            }
            if (i != key)
            {
                temp = outputArray[key];
                outputArray[key] = outputArray[i];
                outputArray[i] = temp;

                HeapSort_Heap(outputArray, n, key);
            }
            return null;
        }
        public object HeapSort_Sort(int[] outputArray)
        {
            int temp;

            for (int i = outputArray.Length / 2 - 1; i >= 0; i--)
            {
                HeapSort_Heap(outputArray, outputArray.Length, i);
            }
            for (int i = outputArray.Length - 1; i > 0; i--)
            {
                temp = outputArray[0];
                outputArray[0] = outputArray[i];
                outputArray[i] = temp;
                HeapSort_Heap(outputArray, i, 0);
            }
            return null;
        }
        public object HeapSort_Heap_D(int[] outputArray, int n, int i)
        {
            int key, left, right, temp;
            key = i;
            left = i * 2 + 1;
            right = i * 2 + 2;

            if (left < n && outputArray[key] > outputArray[left])
            {
                key = left;
            }
            if (right < n && outputArray[key] > outputArray[right])
            {
                key = right;
            }
            if (i != key)
            {
                temp = outputArray[key];
                outputArray[key] = outputArray[i];
                outputArray[i] = temp;

                HeapSort_Heap_D(outputArray, n, key);
            }
            return null;
        }
        public object HeapSort_Sort_D(int[] outputArray)
        {
            int temp;

            for (int i = outputArray.Length / 2 - 1; i >= 0; i--)
            {
                HeapSort_Heap_D(outputArray, outputArray.Length, i);
            }
            for (int i = outputArray.Length - 1; i > 0; i--)
            {
                temp = outputArray[0];
                outputArray[0] = outputArray[i];
                outputArray[i] = temp;
                HeapSort_Heap_D(outputArray, i, 0);
            }
            return null;
        }
        //

        // 기수정렬 함수
        public object RadixSort(int[] inputArray)
        {
            int i, j;

            var outputArray = new int[inputArray.Length];
            for (i = 0; i < outputArray.Length; i++)
                outputArray[i] = inputArray[i];


            OutputPrint(textBox_Radix, outputArray);
            return null;
        }

        // 수집정렬 함수
        public object CountingSort(int[] inputArray)
        {
            //https://exceptionnotfound.net/radix-sort-csharp-the-sorting-algorithm-family-reunion/
            int i, j;

            var outputArray = new int[inputArray.Length];
            for (i = 0; i < outputArray.Length; i++)
                outputArray[i] = inputArray[i];


            OutputPrint(textBox_Radix, outputArray);
            return null;

        }

        // 정렬 실행 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            // 하단 진행 표시 바 초기화
            progress.Maximum = 100;
            // 스톱워치 생성
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            long time = stopwatch.ElapsedMilliseconds;
            // 소요 시간 출력 초기화
            textBox_TimeComplex.Clear();
            progress.Value += 5;
            // 출력 초기화
            textBox_Bubble.Clear();
            textBox_Comb.Clear();
            textBox_Insertion.Clear();
            textBox_Quick.Clear();
            textBox_Radix.Clear();
            textBox_Selection.Clear();
            textBox_Shell.Clear();
            textBox_2Merge.Clear();
            textBox_Heap.Clear();
            progress.Value += 5;

            // 선택된 항목들에 대한 정렬 수행
            if (checkBox_Insertion.Checked == true)
            {
                stopwatch.Start();
                InsertionSort(mainArray);
                stopwatch.Stop();
                time = stopwatch.ElapsedMilliseconds;
                textBox_TimeComplex.Text += "삽입 정렬: " + string.Format("{0:0.000}", (double)time / 1000) + "(s/초)" + "\r\n";
                stopwatch.Reset();
                progress.Value += 10;
            }

            if (checkBox_Shell.Checked == true)
            {
                stopwatch.Start();
                ShellSort(mainArray);
                stopwatch.Stop();
                time = stopwatch.ElapsedMilliseconds;
                textBox_TimeComplex.Text += "셸 정렬: " + string.Format("{0:0.000}", (double)time / 1000) + "(s/초)" + "\r\n";
                stopwatch.Reset();
                progress.Value += 10;
            }

            if (checkBox_Comb.Checked == true)
            {
                stopwatch.Start();
                CombSort(mainArray);
                stopwatch.Stop();
                time = stopwatch.ElapsedMilliseconds;
                textBox_TimeComplex.Text += "빗질 정렬: " + string.Format("{0:0.000}", (double)time / 1000) + "(s/초)" + "\r\n";
                stopwatch.Reset();
                progress.Value += 10;
            }

            if (checkBox_Bubble.Checked == true)
            {
                stopwatch.Start();
                BubbleSort(mainArray);
                stopwatch.Stop();
                time = stopwatch.ElapsedMilliseconds;
                textBox_TimeComplex.Text += "버블 정렬: " + string.Format("{0:0.000}", (double)time / 1000) + "(s/초)" + "\r\n";
                stopwatch.Reset();
                progress.Value += 10;
            }

            if (checkBox_Quick.Checked == true)
            {
                stopwatch.Start();
                QuickSort(mainArray);
                stopwatch.Stop();
                time = stopwatch.ElapsedMilliseconds;
                textBox_TimeComplex.Text += "퀵 정렬: " + string.Format("{0:0.000}", (double)time / 1000) + "(s/초)" + "\r\n";
                stopwatch.Reset();
                progress.Value += 10;
            }

            if (checkBox_2Merge.Checked == true)
            {
                stopwatch.Start();
                MergeSort(mainArray);
                stopwatch.Stop();
                time = stopwatch.ElapsedMilliseconds;
                textBox_TimeComplex.Text += "병합 정렬: " + string.Format("{0:0.000}", (double)time / 1000) + "(s/초)" + "\r\n";
                stopwatch.Reset();
                progress.Value += 10;
            }

            if (checkBox_Selection.Checked == true)
            {
                stopwatch.Start();
                SelectionSort(mainArray);
                stopwatch.Stop();
                time = stopwatch.ElapsedMilliseconds;
                textBox_TimeComplex.Text += "선택 정렬: " + string.Format("{0:0.000}", (double)time/1000) + "(s/초)" + "\r\n";
                stopwatch.Reset();
                progress.Value += 10;
            }

            if (checkBox_Heap.Checked == true)
            {
                stopwatch.Start();
                HeapSort(mainArray);
                stopwatch.Stop();
                time = stopwatch.ElapsedMilliseconds;
                textBox_TimeComplex.Text += "힙 정렬: " + string.Format("{0:0.000}", (double)time / 1000) + "(s/초)" + "\r\n";
                stopwatch.Reset();
                progress.Value += 10;
            }

            if (checkBox_Radix.Checked == true)
            {
                stopwatch.Start();
                RadixSort(mainArray);
                stopwatch.Stop();
                time = stopwatch.ElapsedMilliseconds;
                textBox_TimeComplex.Text += "기수 정렬: " + string.Format("{0:0.000}", (double)time / 1000) + "(s/초)" + "\r\n";
                stopwatch.Reset();
                progress.Value += 10;
            }

            // 하단 진행 표시 바 채우고 메세지 출력
            progress.Value = 100;
            if (progress.Value == 100)
            {
                MessageBox.Show("정렬 작업이 모두 완료되었습니다.");
            }
            progress.Maximum = 0;
        }
        //

        // 수동 '입력'
        private void button2_Click(object sender, EventArgs e)
        {
            if (inputBox_manual.Text == "각 인자의 구분은 띄어쓰기로 구분합니다.")
                MessageBox.Show("값을 입력하지 않았습니다!");
            else
            {
                // 변수 선언
                string inputString;
                var inputArray = new int[2];

                // 입력받은 수들을 분할
                inputString = inputBox_manual.Text;
                var splitString = inputString.Split('\x020');

                // 배열의 내용들을 정수형으로 변환하여 삽입
                inputArray = new int[splitString.Length - 1 + 1];
                for (int i = 0; i <= splitString.Length - 1; i++)
                {
                    inputArray[i] = Convert.ToInt32(splitString[i]);
                }

                mainArray = inputArray;

                // 입력받은 배열을 출력
                InputPrint(textBox_inputBox, inputArray);
            }
        }
        // 자동 '생성'
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (inputBox_max.TextLength == 0 || inputBox_min.TextLength == 0 || inputBox_num.TextLength == 0)
                MessageBox.Show("입력되지 않은 값이 존재합니다!");
            else if (Convert.ToInt32(inputBox_min.Text) > Convert.ToInt32(inputBox_max.Text))
                MessageBox.Show("최소값은 최대값보다 작아야 합니다!");
            else
            {
                // 변수 선언
                int max = Convert.ToInt32(inputBox_max.Text);
                int min = Convert.ToInt32(inputBox_min.Text);
                int num = Convert.ToInt32(inputBox_num.Text);

                // 배열과 랜덤 인스턴스 생성
                var inputArray = new int[num];
                Random r = new Random();
                for (int i = 0; i < inputArray.Length; i++)
                {
                    inputArray[i] = r.Next(min, max);
                }

                mainArray = inputArray;

                // 생성된 배열을 출력
                InputPrint(textBox_inputBox, inputArray);
            }
        }
        // 자동 생성 값을 입력하기 위해 마우스를 클릭했을 시 수동 입력을 초기화
        private void inputBox_min_Enter(object sender, EventArgs e)
        {
            inputBox_manual.Text = "각 인자의 구분은 띄어쓰기로 구분합니다.";
        }
        // 수동으로 값을 입력하기 위해 마우스를 클릭했을 시 자동 입력을 초기화
        private void inputBox_manual_Enter(object sender, EventArgs e)
        {
            inputBox_min.Clear();
            inputBox_max.Clear();
            inputBox_num.Clear();
        }
        private void inputBox_manual_Click(object sender, EventArgs e)
        {
            inputBox_manual.SelectAll();
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
