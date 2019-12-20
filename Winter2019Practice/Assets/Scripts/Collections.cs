using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collections : ScriptableObject
{
    public List<Object> objectList;

    public List<FloatData> floatDataList;

    public List<GameObject> gameObjectList;
    
    public GameAction action;
    

    public void FindObjectType(Object obj)
    {
        foreach (var currentObj in objectList)
        {
            if (currentObj == obj)
            { 
                action.Raise();
            }
        }
    }

    public void AddToList(Object obj)
    {
        objectList.Add(obj);
    }

    public void RemoveFromList(Object obj)
    {
        foreach (var currentObj in objectList)
        {
            if (currentObj == obj)
            {
                objectList.Remove(obj);
            }
        }
    }
}
