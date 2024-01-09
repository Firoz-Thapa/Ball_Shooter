using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    private float time = 0.0f;
    public float interpolationPeriod = 1.0f;
    public GameObject Ball_R;
    public GameObject Ball_G;
    public GameObject Ball_B;
    private List<GameObject> bullets = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            this.Shoot(Ball_R);
        }
        if (Input.GetMouseButtonDown(1)) {
            this.Shoot(Ball_G);
        }
        if (Input.GetMouseButtonDown(2)) {
            this.Shoot(Ball_B);
        }
        this.time += Time.deltaTime;
        if (this.time >= this.interpolationPeriod) {
            this.time = 0.0f;
            for (int i = 0; i < bullets.Count; i++) {
                if ( bullets[i].transform.position.y < -10) {
                    Destroy(bullets[i]);
                    bullets.RemoveAt(i);
                }
            }
        }
        
    }

    void Shoot(GameObject ball) {
        GameObject bullet = Instantiate(ball, this.transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
        this.bullets.Add(bullet);
    }
}
