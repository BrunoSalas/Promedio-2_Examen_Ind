using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Puntuaje : MonoBehaviour
{
    public int i;
    public void Press()
    {
        Boton boton = new Boton(i);
        Func<int> puntuaje = boton.SumaPunto;
        Mente.GetInstance().UpdateScore(puntuaje());
    }
}
