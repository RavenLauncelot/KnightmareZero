using UnityEngine;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEditor.ShaderGraph.Internal;
using Unity.Mathematics;

public class Unit : MonoBehaviour
{
    [SerializeField] private UnitManager.TeamId teamId;
    public UnitManager.TeamId TeamId
    {
        get { return teamId; }
    }

    [SerializeField] private MeshRenderer meshRend;

    //Basic unit stats
    public float health;
    public float speed;
    public float maxHealth;
    public float detectionRange;
    public Transform observingPos;
    public Transform detectionPos;
    public int objId;

    public UnitManager unitManager;
 
    public void MeshRendEnabled(bool enabled)
    {
        meshRend.enabled = enabled;
    }

    public void awakeInit()
    {
        meshRend = GetComponentInChildren<MeshRenderer>();

        objId = gameObject.GetInstanceID();

        if (observingPos == null)
        {
            observingPos = this.transform;
        }

        if (detectionPos == null)
        {
            detectionPos = this.transform;
        }
    }
}


