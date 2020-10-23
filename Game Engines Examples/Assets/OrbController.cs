using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbController : MonoBehaviour
{

    public TankController tankController;
    public FpsController fpsController;
    public EnemyTankController enemyTankController;
    public RotateMe rotateMe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter()
    {
        if (col.gameObject.tag == "Main Camera")
        {
            !tankController.enabled = tankController.enabled;
            fpsController.enabled = !fpsController.enabled;
            enemyTankController.enabled = !enemyTankController.enabled;
            rotateMe.enabled = !rotateMe.enabled;
        }
    }

    void OnTriggerStay()
    {

    }
}
