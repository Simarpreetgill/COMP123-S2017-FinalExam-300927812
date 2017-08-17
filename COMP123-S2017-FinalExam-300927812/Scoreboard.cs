using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name:Simarpreet Kaur
 * Date: August 17,2017
 * StudentID: 300927812
 * Description: Scoreboard class completed
 * Version: 0.1
 */
namespace COMP123_S2017_FinalExam_300927812
{
    class Scoreboard
    {
        //PRIVATE INSTANCE VARIABLES

        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        // PUBLIC PROPERTIES

        public TextBox FinalScoreTextBox
        {
            get
            {
                return _finalScoreTextBox;
            }
            set
            {
                _finalScoreTextBox = value;
            }
        }
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return _scoreTextBox;
            }
            set
            {
                _scoreTextBox = value;
            }
        }
        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return _timeTextBox;
            }
            set
            {
                _timeTextBox = value;
            }
        }

        // CONSTRUCTORS

        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }

        // PUBLIC METHODS

        public void UpdateTime()
        {
            Time = Convert.ToInt32(Time);
            Time -= 1;
            TimeTextBox.Text = Convert.ToString(Time);
        }
    }
}
}
