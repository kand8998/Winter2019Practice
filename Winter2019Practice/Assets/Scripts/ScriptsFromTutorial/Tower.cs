using UnityEngine;

public class Tower : MonoBehaviour
{
    // Script based on Tutorial
    
    public Transform turretTransform;
    private float range = 10f;
    public GameObject bulletPrefab;
    private float fireCoolDown = 0.5f;
    private float fireCoolDownLeft = 0;
    private void Start()
    {
        turretTransform = transform.Find("Turret");
    }


    private void Update()
    {
        Enemy[] enemies = GameObject.FindObjectsOfType<Enemy>();

        Enemy nearestEnemy = null;
        float distance = Mathf.Infinity;

        foreach (Enemy e in enemies)
        {
            float d = Vector3.Distance(this.transform.position, e.transform.position);
            if (nearestEnemy == null || d < distance)
            {
                nearestEnemy = e;
                distance = d;
            }
        }

        if (nearestEnemy == null)
        {
            Debug.Log("No enemies?");
            return;
        }

        Vector3 direction = nearestEnemy.transform.position - this.transform.position;
        Quaternion aimRotation = Quaternion.LookRotation(direction);
        turretTransform.rotation = Quaternion.Euler(0, aimRotation.eulerAngles.y, 0);

        fireCoolDownLeft -= Time.deltaTime;
        if (fireCoolDownLeft <= 0)
        {
            fireCoolDownLeft = fireCoolDown;
            ShootAt(nearestEnemy);
        }
    }
    private void ShootAt(Enemy e)
    {
        GameObject bulletGameObject = 
            (GameObject) Instantiate(bulletPrefab, this.transform.position, this.transform.rotation);
        
        Bullet b = bulletGameObject.GetComponent<Bullet>();
        b.target = e.transform;
    }
}
