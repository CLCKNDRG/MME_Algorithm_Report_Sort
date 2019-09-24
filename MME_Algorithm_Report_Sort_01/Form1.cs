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
        // 빗질정렬 함수 (미구현)
        public object CombSort(int[] inputArray)
        {
            int temp, i, gap, swap;

            var outputArray = new int[inputArray.Length];
            for (i = 0; i < outputArray.Length; i++)
            {
                outputArray[i] = inputArray[i];
            }

            OutputPrint(textBox_Comb, outputArray);
            return null;
        }
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

        // 정렬 실행 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            // 하단 진행 표시 바 초기화
            progress.Maximum = 100;

            //선택된 항목들에 대한 정렬 수행
            if (checkBox_Insertion.Checked == true)
                InsertionSort(mainArray);
            progress.Value += 10;

            if (checkBox_Shell.Checked == true)
                ShellSort(mainArray);
            progress.Value += 10;

            /*
            if (checkBox_Comb.Checked == true)
                CombSort(mainArray);
            progress.Value += 10;
             */

            if (checkBox_Bubble.Checked == true)
                BubbleSort(mainArray);
            progress.Value += 10;

            /*
            if (checkBox_Quick.Checked == true)
                QuickSort(mainArray);
            progress.Value += 10;
             */

            /*
            if (checkBox_2Merge.Checked == true)
                MergeSort(mainArray);
            progress.Value += 10;
             */

            if (checkBox_Selection.Checked == true)
                SelectionSort(mainArray);
            progress.Value += 10;

            /*
            if (checkBox_Heap.Checked == true)
                HeapSort(mainArray);
            progress.Value += 10;
             */

            /*
            if (checkBox_Radix.Checked == true)
                RadixSort(mainArray);
            progress.Value += 10;
             */

            // 하단 진행 표시 바 채우고 메세지 출력
            progress.Value = 100;
            if (progress.Value == 100)
            {
                MessageBox.Show("정렬 작업이 모두 완료되었습니다.");
            }
            progress.Maximum = 0;
        }

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
