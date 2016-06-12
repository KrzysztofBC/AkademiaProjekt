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
    public float timeToGenerate = 3.0f;
    public float timeCurrent = 0;

    private Vector3 zeroCoordinates;
    private int asteroidNum = 0;

    private string word;
    private StreamReader FileReader = new StreamReader(@"E:\Dokumenty\Graphics_programming\unity_projects\Academy2DGame\TXT\words.txt");

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeCurrent += Time.deltaTime;

        if( timeCurrent >= timeToGenerate )
        {
            word = FileReader.ReadLine();
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
}
