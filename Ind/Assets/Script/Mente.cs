using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mente : MonoBehaviour, ISubject
{
    public List<iObserver> boton = new List<iObserver>();
    public float Score { get { return score; } }
    private int score;
    private static Mente instance;
    public UIController uiController;
    public void Attach(iObserver observer)
    {
        boton.Add(observer);
    }

    public void Remove(iObserver observer)
    {
        boton.Remove(observer);
    }
    private void Awake()
    {
        instance = this;
    }
    public static Mente GetInstance()
    {
        return instance;
    }
    public void UpdateScore(int i)
    {
        score += i;
        Notify();
    }
    public void Notify()
    {
        uiController.Execute(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
