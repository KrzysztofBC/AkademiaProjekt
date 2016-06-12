using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EarthHit : MonoBehaviour {

    public Text livesText;

    private int lives = 3;

    void OnStart()
    {
        livesText.text = lives.ToString();
    }

    void OnTriggerEnter(Collider col)
    {
        lives--;
        livesText.text = lives.ToString();

        Destroy(col.gameObject);
    }
}
