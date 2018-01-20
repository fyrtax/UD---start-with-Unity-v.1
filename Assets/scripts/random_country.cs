using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    public int interval = 3;
    private DateTime lastTime;
    public List<string> countries;
    private System.Random random;
    public TextMesh textMesh;

	// Use this for initialization
	void Start()
    {
        lastTime = DateTime.Now;
        random = new System.Random();
	}
	
	// Update is called once per frame
	void Update()
    {
        string country;
		if (DateTime.Now > lastTime.AddSeconds(interval))
        {
            lastTime = DateTime.Now;
            country = countries[random.Next(countries.Count)];
            textMesh.text = country;
        }
	}
}
