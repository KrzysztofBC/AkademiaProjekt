using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Evaluator : MonoBehaviour {

    //public InputField myInputField;
    public Text pointsText;

    private int points = 0;

	public void GetWord(string word)
    {
        Destroy(GameObject.Find(word));
        points++;
        pointsText.text = points.ToString();
    }

    void OnStart()
    {
        pointsText.text = points.ToString();
    }

    void OnUpdate()
    {
        //if (myInputField.IsActive == false)
        //myInputField.Select();
    }
}
