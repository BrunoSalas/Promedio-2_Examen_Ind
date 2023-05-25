using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Boton :  Interfaz
{
    protected int suma;
    public Boton (int suma)
    {
        this.suma = suma;
    }
    public override int SumaPunto()
    {
        return suma;
    }
}
