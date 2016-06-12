using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Evaluator : MonoBehaviour {

    public InputField myInputField;

    private int points = 0;

	public void GetWord(string word)
    {
        Destroy(GameObject.Find(word));
        points++;
    }

    void OnUpdate()
    {
        //if (myInputField.IsActive == false)
        //myInputField.Select();
    }
}
