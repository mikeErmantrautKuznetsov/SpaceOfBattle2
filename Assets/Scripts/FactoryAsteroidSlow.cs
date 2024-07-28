using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryAsteroidSlow : AbstractionFactory
{
    private Transform _pointSpawn;

    public FactoryAsteroidSlow(Transform pointSpawn)
    {
        _pointSpawn = pointSpawn;
    }

    public override GameObject CreatefastAsteroid()
    {
        var _sherePrefabStandert = Resources.Load<GameObject>("Prefabs/Asteroid_1");
        var _shereStandert = Instantiate(_sherePrefabStandert, _pointSpawn.position, Quaternion.identity);
        return _shereStandert;
    }

    public override GameObject CreateSmallAsteroid()
    {
        var _prefabStandert = Resources.Load<GameObject>("Prefabs/Asteroid_2");
        var _prefabWalkererStandert = Instantiate(_prefabStandert, _pointSpawn.position, Quaternion.identity);
        return _prefabWalkererStandert;
    }
}
