using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Initial Script from Tutorial
    
    private GameObject pathObj;
    private Transform targetPathNode;
    private int pathNodeIndex = 0;
    private float speed = 5;
    public int health = 1;
    private void Start()
    {
        pathObj = GameObject.Find("Path");
    }

    private void GetNextPathNode()
    {
        targetPathNode = pathObj.transform.GetChild(pathNodeIndex);
        pathNodeIndex++;
    }

    private void Update()
    {
        if (targetPathNode == null)
        {
            GetNextPathNode();
            if (targetPathNode == null)
            {
                ReachedGoal();
            }
        }

        Vector3 direction = targetPathNode.position - this.transform.localPosition;
        float distThisFrame = speed * Time.deltaTime;

        if (direction.magnitude <=distThisFrame)
        {
            // We reached the node
            targetPathNode = null;
        }
        else
        {
            //Move towards node
            transform.Translate(direction.normalized * distThisFrame, Space.World);
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime*5);
        }
    }

    private void ReachedGoal()
    {
        Destroy(gameObject);
    }
}
