using UnityEngine;

public class CollectCapacity : MonoBehaviour
{
    public Collections collection;
    
    public void CollectionCapacity()
    {
        var b = collection.objectList.Capacity == Random.Range(0,10);
    }
}
