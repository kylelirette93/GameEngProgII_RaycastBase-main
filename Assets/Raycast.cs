using UnityEngine;

public class Raycast : MonoBehaviour
{
    public Camera mainCamera;
    public LayerMask targetLayer;
    public LayerMask ignoreLayer;
    bool didHit = false;
    public void Update()
    {

            RaycastHit hit;
            if (!didHit && Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, targetLayer))
            {
                Material material = hit.collider.GetComponent<Renderer>().material;
                material.color = Random.ColorHSV();
                Debug.Log("hit object at: " + hit.collider.gameObject.name + hit.distance);
                Debug.DrawRay(mainCamera.transform.position, mainCamera.transform.forward * 10f, Color.green);
                didHit = true;
            }
            else
            {
                Debug.DrawRay(mainCamera.transform.position, mainCamera.transform.forward * 10f, Color.red);
                Debug.Log("Did not hit.");
            }
        }
    
}
