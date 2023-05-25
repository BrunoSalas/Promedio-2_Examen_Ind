using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour, iObserver
{
    [SerializeField] private TMP_Text scoreText;

    public void Execute(ISubject subject)
    {
        if (subject is Mente)
        {
            scoreText.text = "Score: " + ((Mente)subject).Score;
        }
    }

    void Start()
    {
        Mente.GetInstance().uiController = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
