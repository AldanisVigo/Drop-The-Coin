using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDropCoin : MonoBehaviour
{
    [SerializeField] Transform spawnCenter;
    [SerializeField] GameObject coin;
    [SerializeField] new Camera camera;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePosition = Input.mousePosition;
            var mouseX = mousePosition.x / gameObject.GetComponent<RectTransform>().rect.width * 34;
            var mousePositionSpawnPoint = new Vector3(mouseX - 17, spawnCenter.position.y, spawnCenter.position.z);

            
            Instantiate(coin, mousePositionSpawnPoint, spawnCenter.rotation);
        }
    }
}
