using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using System;
using System.Diagnostics;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AsteroidGenerator : MonoBehaviour {

    public GameObject asteroid;
    public GameObject GameOverWindow;
    public GameObject evaluator;
    public GameObject EarthHit;

    public float timeToGenerate = 3.0f;
    public float timeCurrent = 0;

    private Vector3 zeroCoordinates;
    private int asteroidNum = 0;

    private string word;
    private StreamReader FileReader;

    private bool gameStart = false;

	void Update ()
    {
        if(gameStart)
            timeCurrent += Time.deltaTime;

        if( timeCurrent >= timeToGenerate )
        {
            try
            {
                word = FileReader.ReadLine();
            }
            catch (FileNotFoundException)
            {
                UnityEngine.Debug.Log("File doesn't exist");
            }
            catch (Exception e)
            {
                string logText = "Exception: " + e.Message + ",\nDetails: " + e;
                UnityEngine.Debug.Log(logText);
            }
            
            if (word != null)
            {
                asteroidNum++;
                zeroCoordinates = new Vector3(-23, UnityEngine.Random.Range(-1.2f, 1.2f), -2);

                UnityEngine.Object newone = Instantiate(asteroid, zeroCoordinates, Quaternion.identity);
                newone.name = word; //"asteroid." + asteroidNum.ToString() + "." + 
            }
            else
                FileReader.Close();

            timeCurrent = 0;
        }
	}

    public void StartGame()
    {
        FileReader = new StreamReader(@"E:\Dokumenty\Graphics_programming\unity_projects\Academy2DGame\TXT\words.txt");
        gameStart = true;
        GameOverWindow.SetActive(false);
        evaluator.GetComponent<Evaluator>().points = 0;
        EarthHit.GetComponent<EarthHit>().lives = 3;
        timeCurrent = 0;
    }

    public void EndGame()
    {
        gameStart = false;
        FileReader.Close();
        timeCurrent = 0;
    }
}
