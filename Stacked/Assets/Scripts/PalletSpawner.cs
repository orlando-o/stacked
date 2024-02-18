using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalletSpawner : MonoBehaviour
{
    public List<GameObject> allPallets;
    public float seconds = 3;
    private System.Random rng = new System.Random();
    private float elapsedSeconds = 20;
    private int previousPallet;

    protected void Update()
    {
        elapsedSeconds += Time.deltaTime;
        if (elapsedSeconds >= seconds && !gameObject.GetComponent<Conveyor>().objectOnConveyor)
        {
            int randomPallet = rng.Next(0, allPallets.Count);
            while (randomPallet == previousPallet)
            {
                randomPallet = rng.Next(0, allPallets.Count);
            }
            GameObject toSpawn = allPallets[randomPallet];
            Vector3 palletRotation = gameObject.GetComponent<Conveyor>().transform.localRotation.eulerAngles + Vector3.up * 90;
            Instantiate(toSpawn, gameObject.GetComponent<Transform>().position + Vector3.up * 0.45f, Quaternion.Euler(palletRotation.x, palletRotation.y, palletRotation.z));
            previousPallet = randomPallet;
            elapsedSeconds = 0;
        }
        else if (gameObject.GetComponent<Conveyor>().objectOnConveyor)
        {
            elapsedSeconds = 0;
        }
    }

}