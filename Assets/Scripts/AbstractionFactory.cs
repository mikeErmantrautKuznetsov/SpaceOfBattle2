using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractionFactory : MonoBehaviour
{
    public abstract GameObject CreateSmallAsteroid();
    public abstract GameObject CreatefastAsteroid();
}
