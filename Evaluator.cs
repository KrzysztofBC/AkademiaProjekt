using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Evaluator : MonoBehaviour {
    
    public Text pointsText;
    public Text pointsOverText;
    
    public int points = 0;

	public void GetWord(string word)
    {
        Destroy(GameObject.Find(word));
        points++;
        pointsText.text = points.ToString();
        pointsOverText.text = points.ToString();
    }

    void Start()
    {
        pointsText.text = points.ToString();
        pointsOverText.text = points.ToString();
    }

    void Update()
    {
        pointsText.text = points.ToString();
    }
}
