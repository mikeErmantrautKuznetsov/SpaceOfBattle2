using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroidFactoryController : MonoBehaviour
{
    [SerializeField] private Transform m_Transform;
    [SerializeField] private Transform g_Transform;
    [SerializeField] private Transform k_Transform;
    [SerializeField] private Transform j_Transform;

    private AbstractionFactory factory;

    private void Start()
    {
        InvokeRepeating("SpawnRock", 3, 2);
    }

    void SpawnRock()
    {
        factory = new FactoryAsteroidSlow(m_Transform);
        factory.CreatefastAsteroid();

        factory = new FactoryAsteroidSlow(k_Transform);
        factory.CreateSmallAsteroid();

        factory = new FactoryAsteroidFast(j_Transform);
        factory.CreatefastAsteroid();

        factory = new FactoryAsteroidFast(g_Transform);
        factory.CreateSmallAsteroid();
    }


}
