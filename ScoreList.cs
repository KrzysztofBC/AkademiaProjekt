using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreList : MonoBehaviour {

    public enum TitlePlayer { Baby, Gimb, Nerd, Advnaced, Pro, Boss = 10 };

    public GameObject evaluator;
    public Text bestScoreText;

    public class Player
    {
        public string name = "player";
        public string title;
        public int score;
        
        public int Score
        {
            get
            {
                return score;
            }

            set
            {
                if (value > 0)
                    score = value;
            }
        }

        public void SetBossTitle()
        {
            if(score >= (int)TitlePlayer.Boss)
            {
                title = "Boss";
            }
        }

        public virtual void Debugger()
        {
            Debug.Log("Player Name:" + name + ", Score: " + score.ToString());
        }
    }

    public class BestPlayer : Player
    {
        public int bestScore = 0;

        public int BestScore
        {
            get
            {
                return bestScore;
            }

            set
            {
                if (value > bestScore)
                    bestScore = value;
            }
        }

        public override void Debugger()
        {
            Debug.Log("Best Player Name: " + name + ", Score: " + score.ToString());
        }

    }

    Player player = new Player();
    BestPlayer bestPlayer = new BestPlayer();

    void Start ()
    {
        //Player player = new Player();
        player.name = "Stasiek";
        player.Score = 0;

        //BestPlayer bestPlayer = new BestPlayer();
	}
	
	void Update () {
        player.Score = evaluator.GetComponent<Evaluator>().points;
        bestPlayer.BestScore = player.Score;
        bestScoreText.text = bestPlayer.Score.ToString();
	}
}
