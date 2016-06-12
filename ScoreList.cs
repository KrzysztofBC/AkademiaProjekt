using UnityEngine;
using System.Collections;

public class ScoreList : MonoBehaviour {

    public class Player
    {
        public string name = "player";
        public int score = 0;

        public virtual void Debugger()
        {
            Debug.Log("Player Name:" + name + ", Score: " + score.ToString());
        }
    }

    public class BestPlayer : Player
    {
        public int bestScore = 0;

        public override void Debugger()
        {
            Debug.Log("Best Player Name: " + name + ", Score: " + score.ToString());
        }

        private void CalculateBest()
        {
            if (score > bestScore)
                bestScore = score;
        }
    }
    
	void Start ()
    {
        Player player = new Player;
        player.name = "Stasiek";
        player.score = 0;

        BestPlayer bestPlayer = new BestPlayer;
	}
	
	void Update () {
	
	}
}
