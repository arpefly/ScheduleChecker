using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScheduleChecker
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void DataGridViewScedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 0)
                monthCalendar.BringToFront();
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 1)
                dateTimePicker.BringToFront();
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 2)
                dateTimePicker.BringToFront();
        }
        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            monthCalendar.SendToBack();
            SetDateValue();
        }
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SetTimeValue();
        }


        private void ПроверитьРасписанинеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ScheduleStructure> Structure = new List<ScheduleStructure>();  // List со всем расписанием
            foreach (DataGridViewRow row in dataGridViewScedule.Rows)   // Проходимся по всем строкам
            {
                #region Если в строке есть хотя бы одна не заполненая ячейка, то эту строку не берём
                bool isCoolRow = true;
                foreach (DataGridViewCell cell in row.Cells)
                    if (cell.Value == null)
                    {
                        isCoolRow = false;
                        break;
                    }
                #endregion

                #region Если строка запонена полностью добовляем в Structure
                if (isCoolRow)
                {
                    Structure.Add(new ScheduleStructure
                    {
                        Date = DateTime.ParseExact(row.Cells[0].Value.ToString(), "d", null, System.Globalization.DateTimeStyles.None),
                        Start = DateTime.ParseExact(row.Cells[1].Value.ToString(), "HH:mm:ss", null, System.Globalization.DateTimeStyles.None),
                        End = DateTime.ParseExact(row.Cells[2].Value.ToString(), "HH:mm:ss", null, System.Globalization.DateTimeStyles.None),
                        RoomNumber = int.Parse(row.Cells[3].Value.ToString()),
                        SubjectName = row.Cells[4].Value.ToString()
                    });
                }
                #endregion
            }


            bool isCoolSchedule = true; // true 0 - если рассписание составлено без ошибок, false - если в расписании есть ошибки
            // Проверка каждой строки по времени (если урок заканчивется прежде чем начинается, значит что то не так) [первый блок проверки]
            for (int i = 0; i < Structure.Count; i++)
                if (Structure[i].End.Ticks - Structure[i].Start.Ticks < 0)
                {
                    isCoolSchedule = false;
                    break;
                }

            // Проверка с групировкой по дням аудиториям и веремени
            // Основная идея проверки заключается в следющем
            // В один день в одной одной аудитории не может идти перекрёстых занятий (занятие должно сначала завершится, а уже затем начинается следущее)
            // GroupBy группирует данные по критерию (в нашем случае группируем по датам затем по аудиториям и смотрим, чтобы занятие сначала завершилось, а уже затем начиналось следущее
            foreach (var date in Structure.GroupBy(x => x.Date).ToList())
            {
                foreach (var num in date.GroupBy(q => q.RoomNumber))
                {
                    bool isFirstLesson = true;
                    DateTime end = new DateTime();
                    DateTime start = new DateTime();
                    foreach (var item in num.OrderBy(w => w.Start))
                    {
                        if (isFirstLesson)
                        {
                            end = item.End;
                            start = item.Start;
                            isFirstLesson = false;
                            continue;
                        }

                        if (end > item.Start)
                        {
                            isCoolSchedule = false;
                            break;
                        }
                        else
                            end = item.End;
                    }
                }
            }


            if (isCoolSchedule)
                MessageBox.Show("Всё cool.", "Отчёт");
            else
                MessageBox.Show("Что-то пошло не так. Проверьте расписание!", "Отчёт");
        }


        // Метод для подстановки времени в DataGridView
        private void SetTimeValue()
        {
            int x = dataGridViewScedule.SelectedCells[0].ColumnIndex;
            int y = dataGridViewScedule.SelectedCells[0].RowIndex;
            dataGridViewScedule.Rows[y].Cells[x].Value = dateTimePicker.Text;
        }
        // Метод для подстановки даты в DataGridView
        private void SetDateValue()
        {
            int x = dataGridViewScedule.SelectedCells[0].ColumnIndex;
            int y = dataGridViewScedule.SelectedCells[0].RowIndex;
            dataGridViewScedule.Rows[y].Cells[x].Value = monthCalendar.SelectionStart.ToString("d");
        }
        // Прячет monthCalendar и dateTimePicker за DataGridView
        private void DataGridViewScedule_Click(object sender, EventArgs e)
        {
            monthCalendar.SendToBack();
            dateTimePicker.SendToBack();
        }
    }
}
